ALTER PROCEDURE psp_TAX_REPORT_INVOIC_IW
(
    @reporttype  VARCHAR(50) = '',
    @branchids   dbo.tp_BrnIds READONLY,
    @fromdate    DATE = NULL,
    @todate      DATE = NULL
)
AS
BEGIN

    ;WITH Party AS
    (
        SELECT
            PM_AccID,
            MAX(PM_Code)      AS PM_Code,
            MAX(PM_LegalName) AS PM_LegalName,
            MAX(PM_TaxRegNo1) AS PM_TaxRegNo1
        FROM PartyMaster
        GROUP BY PM_AccID
    )
    SELECT
        I.Inv_No                                                     AS [DOC NO],
        @reporttype                                                  AS [DOC TYPE],
        I.Inv_Date                                                   AS [INV DATE],
        I.Inv_No                                                     AS [INV NO],
        B.brnName                                                    AS [DIVISION],
        'OUTWARD'                                                    AS [SOURCE TYPE],

        P.PM_Code                                                    AS [PARTY CODE],
        P.PM_LegalName                                               AS [PARTY NAME],
        P.PM_TaxRegNo1                                               AS [VAT NO],

        II.InvI_ItemID                                               AS [ITEM CODE],
        II.InvI_ItemName                                             AS [ITEM NAME],

        CASE 
            WHEN ISNULL(II.InvI_Free,0) = 0 
            THEN II.InvI_TaxableAmount 
            ELSE 0 
        END                                                          AS [NET TAXABLE AMT],

        CASE 
            WHEN ISNULL(II.InvI_Free,0) = 0 
            THEN II.InvI_TaxAmount 
            ELSE 0 
        END                                                          AS [NET TAX AMT],

        CASE 
            WHEN ISNULL(II.InvI_Free,0) = 1 
            THEN II.InvI_TaxableAmount 
            ELSE 0 
        END                                                          AS [FOC TAXABLE AMT],

        CASE 
            WHEN ISNULL(II.InvI_Free,0) = 1 
            THEN II.InvI_TaxAmount 
            ELSE 0 
        END                                                          AS [FOC TAX AMT],

        I.Inv_RoundOff                                               AS [DISCOUNT / ROUND OFF]

    FROM Invoice I
    INNER JOIN Invoice_Items II
        ON II.InvI_InvID = I.Inv_ID
    INNER JOIN Branch B
        ON B.brnId = I.BRNID
    LEFT JOIN Party P
        ON P.PM_AccID = I.Inv_CustAccID

    WHERE
        CONVERT(DATE, I.Inv_Date) BETWEEN @fromdate AND @todate
        AND ISNULL(I.Inv_Cancelled,0) = 0
        AND I.BRNID IN (SELECT BrnID FROM @branchids)

    ORDER BY
        I.Inv_Date,
        I.Inv_No,
        II.InvI_ItemID;

END
