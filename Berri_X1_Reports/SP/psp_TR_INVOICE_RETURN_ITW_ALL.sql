CREATE PROCEDURE [dbo].[psp_TR_INVOICE_RETURN_ITW_ALL]
(
    @reporttype  VARCHAR(50) = '',
    @branchids   dbo.tp_BrnIds READONLY,
    @fromdate    DATE = NULL,
    @todate      DATE = NULL
)
AS
BEGIN

    SELECT
        IR.IR_No                           AS [DOC NO],
        @reporttype                        AS [DOC TYPE],
        IR.IR_Date                         AS [INV DATE],
        IR.IR_No                           AS [INV NO],
        B.brnName                          AS [DIVISION],
        'OUTWARD'                          AS [SOURCE TYPE],

        CASE 
            WHEN ISNULL(IR.IR_Cancelled,0) = 1 THEN 'CANCELLED'
            ELSE 'ACTIVE'
        END                                AS [RETURN STATUS],

        IRI.IRI_ItemCode                   AS [ITEM CODE],
        IRI.IRI_ItemName                   AS [ITEM NAME],

        CASE 
            WHEN IRI.IRI_TaxPer = 0
            THEN IRI.IRI_TaxableAmount
            ELSE 0
        END                                AS [TAXABLE 0%],

        CASE 
            WHEN IRI.IRI_TaxPer = 5
            THEN IRI.IRI_TaxableAmount
            ELSE 0
        END                                AS [TAXABLE 5%],

        CASE 
            WHEN IRI.IRI_TaxPer = 5
            THEN IRI.IRI_TaxAmount
            ELSE 0
        END                                AS [TAX 5%],

        IRI.IRI_TaxableAmount              AS [NET TAXABLE AMT],
        IRI.IRI_TaxAmount                  AS [NET TAX AMT],

        IR.IR_RoundOff                     AS [DISCOUNT / ROUND OFF]

    FROM InvoiceReturn IR
    INNER JOIN InvoiceReturn_Items IRI
        ON IRI.IRI_IRID = IR.IR_ID
    INNER JOIN Branch B
        ON B.brnId = IR.BRNID
    INNER JOIN @branchids BR
        ON BR.brnId = B.brnId

    WHERE
        CONVERT(DATE, IR.IR_Date) BETWEEN @fromdate AND @todate

    ORDER BY
        IR.IR_Date,
        IR.IR_No,
        IRI.IRI_ItemID;

END
GO
