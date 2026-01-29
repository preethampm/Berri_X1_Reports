CREATE PROCEDURE [dbo].[psp_TR_INVOICE_RETURN_IW_ALL]
(
    @reporttype  VARCHAR(50) = '',
    @branchids   dbo.tp_BrnIds READONLY,
    @fromdate    DATE = NULL,
    @todate      DATE = NULL
)
AS
BEGIN

    SELECT
        IR.IR_ID                                                   AS [IR ID],
        IR.IR_No                                                   AS [DOC NO],
        @reporttype                                                AS [DOC TYPE],
        IR.IR_Date                                                 AS [INV DATE],
        IR.IR_No                                                   AS [INV NO],

        B.brnName                                                  AS [DIVISION],
        'OUTWARD'                                                  AS [SOURCE TYPE],

        CASE 
            WHEN ISNULL(IR.IR_Cancelled,0) = 1 THEN 'CANCELLED'
            ELSE 'ACTIVE'
        END                                                        AS [RETURN STATUS],

        SUM(CASE 
                WHEN IRI.IRI_TaxPer = 0
                     AND ISNULL(IRI.IRI_Quantity,0) > 0
                THEN IRI.IRI_TaxableAmount
                ELSE 0
            END)                                                   AS [TAXABLE 0%],

        SUM(CASE 
                WHEN IRI.IRI_TaxPer = 5
                     AND ISNULL(IRI.IRI_Quantity,0) > 0
                THEN IRI.IRI_TaxableAmount
                ELSE 0
            END)                                                   AS [TAXABLE 5%],

        SUM(CASE 
                WHEN IRI.IRI_TaxPer = 5
                     AND ISNULL(IRI.IRI_Quantity,0) > 0
                THEN IRI.IRI_TaxAmount
                ELSE 0
            END)                                                   AS [TAX 5%],

        SUM(CASE 
                WHEN ISNULL(IRI.IRI_Quantity,0) > 0
                THEN IRI.IRI_TaxableAmount
                ELSE 0
            END)                                                   AS [NET TAXABLE AMT],

        SUM(CASE 
                WHEN ISNULL(IRI.IRI_Quantity,0) > 0
                THEN IRI.IRI_TaxAmount
                ELSE 0
            END)                                                   AS [NET TAX AMT],

        IR.IR_RoundOff                                             AS [DISCOUNT / ROUND OFF]

    FROM InvoiceReturn IR
    INNER JOIN InvoiceReturn_Items IRI
        ON IRI.IRI_IRID = IR.IR_ID
    INNER JOIN Branch B
        ON B.brnId = IR.BRNID
    INNER JOIN @branchids BR
        ON BR.brnId = B.brnId

    WHERE
        CONVERT(DATE, IR.IR_Date) BETWEEN @fromdate AND @todate

    GROUP BY
        IR.IR_ID,
        IR.IR_No,
        IR.IR_Date,
        B.brnName,
        IR.IR_RoundOff,
        IR.IR_Cancelled

    ORDER BY
        IR.IR_Date,
        IR.IR_No;

END
GO
