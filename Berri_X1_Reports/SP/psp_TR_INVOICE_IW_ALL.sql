ALTER PROCEDURE [dbo].[psp_TR_INVOICE_IW_ALL]
(
    @reporttype  VARCHAR(50) = '',
    @branchids   dbo.tp_BrnIds READONLY,
    @fromdate    DATE = NULL,
    @todate      DATE = NULL
)
AS
BEGIN

    SELECT
        I.Inv_No                                                     AS [DOC NO],
        @reporttype                                                  AS [DOC TYPE],
        I.Inv_Date                                                   AS [INV DATE],
        I.Inv_No                                                     AS [INV NO],
        B.brnName                                                    AS [DIVISION],
        'OUTWARD'                                                    AS [SOURCE TYPE],

        CASE 
            WHEN ISNULL(I.Inv_Cancelled,0) = 1 THEN 'CANCELLED'
            WHEN ISNULL(I.Inv_SalesReturnID,0) <> 0 THEN 'RETURNED'
            ELSE 'ACTIVE'
        END                                                          AS [INVOICE STATUS],

        SUM(CASE 
                WHEN II.InvI_TaxPer = 0
                     AND ISNULL(II.InvI_Free,0) = 0
                THEN II.InvI_TaxableAmount 
                ELSE 0 
            END)                                                     AS [TAXABLE 0%],

        SUM(CASE 
                WHEN II.InvI_TaxPer = 5 
                     AND ISNULL(II.InvI_Free,0) = 0
                THEN II.InvI_TaxableAmount 
                ELSE 0 
            END)                                                     AS [TAXABLE 5%],

        SUM(CASE 
                WHEN II.InvI_TaxPer = 5 
                     AND ISNULL(II.InvI_Free,0) = 0
                THEN II.InvI_TaxAmount 
                ELSE 0 
            END)                                                     AS [TAX 5%],

        SUM(CASE 
                WHEN ISNULL(II.InvI_Free,0) = 0
                THEN II.InvI_TaxableAmount 
                ELSE 0 
            END)                                                     AS [NET TAXABLE AMT],

        SUM(CASE 
                WHEN ISNULL(II.InvI_Free,0) = 0
                THEN II.InvI_TaxAmount 
                ELSE 0 
            END)                                                     AS [NET TAX AMT],

        SUM(CASE 
                WHEN ISNULL(II.InvI_Free,0) = 1
                THEN II.InvI_TaxableAmount 
                ELSE 0 
            END)                                                     AS [FOC TAXABLE AMT],

        SUM(CASE 
                WHEN ISNULL(II.InvI_Free,0) = 1
                THEN II.InvI_TaxAmount 
                ELSE 0 
            END)                                                     AS [FOC TAX AMT],

        I.Inv_RoundOff                                               AS [DISCOUNT / ROUND OFF]

    FROM Invoice I
    INNER JOIN Invoice_Items II
        ON II.InvI_InvID = I.Inv_ID
    INNER JOIN Branch B
        ON B.brnId = I.BRNID
    INNER JOIN @branchids BR
        ON BR.brnId = B.brnId

    WHERE
        CONVERT(DATE, I.Inv_Date) BETWEEN @fromdate AND @todate

    GROUP BY
        I.Inv_No,
        I.Inv_Date,
        B.brnName,
        I.Inv_RoundOff,
        I.Inv_Cancelled,
        I.Inv_SalesReturnID

    ORDER BY
        I.Inv_Date,
        I.Inv_No;

END
GO
