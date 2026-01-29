ALTER PROCEDURE [dbo].[psp_TR_PURCHASE_IW_ALL]
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
            PM_ID,
            MAX(PM_Code)      AS PM_Code,
            MAX(PM_LegalName) AS PM_LegalName,
            MAX(PM_TaxRegNo1) AS PM_TaxRegNo1
        FROM PartyMaster
        GROUP BY PM_ID
    )
    SELECT
        P.PRCH_No                    AS [DOC NO],
        @reporttype                  AS [DOC TYPE],
        P.PRCH_InvDate               AS [INV DATE],
        P.PRCH_InvNo                 AS [INV NO],
        @fromdate                    AS [FROM DATE],
        @todate                      AS [TO DATE],

        B.brnName                    AS [DIVISION],
        'INWARD'                     AS [SOURCE TYPE],

        CASE 
            WHEN ISNULL(P.PRCH_Cancelled,0) = 1 THEN 'CANCELLED'
            ELSE 'ACTIVE'
        END                          AS [PURCHASE STATUS],

        PT.PM_Code                   AS [PARTY CODE],
        PT.PM_LegalName              AS [PARTY NAME],
        PT.PM_TaxRegNo1              AS [VAT NO],

        SUM(CASE 
                WHEN TI.TI_Taxable = 1 AND TI.TI_TaxPer = 0
                THEN TI.TI_TaxableAmount
                ELSE 0
            END)                     AS [TAXABLE 0%],

        SUM(CASE 
                WHEN TI.TI_Taxable = 1 AND TI.TI_TaxPer = 5
                THEN TI.TI_TaxableAmount
                ELSE 0
            END)                     AS [TAXABLE 5%],

        SUM(CASE 
                WHEN TI.TI_Taxable = 1 AND TI.TI_TaxPer = 5
                THEN TI.TI_TaxAmount
                ELSE 0
            END)                     AS [TAX 5%],

        SUM(CASE 
                WHEN TI.TI_Taxable = 1
                THEN TI.TI_TaxableAmount
                ELSE 0
            END)                     AS [NET TAXABLE AMT],

        SUM(CASE 
                WHEN TI.TI_Taxable = 1
                THEN TI.TI_TaxAmount
                ELSE 0
            END)                     AS [NET TAX AMT],

        SUM(CASE 
                WHEN TI.TI_Taxable = 0
                THEN TI.TI_FOCValue
                ELSE 0
            END)                     AS [FOC TAXABLE AMT],

        SUM(CASE 
                WHEN TI.TI_Taxable = 0 AND TI.TI_TaxOnFree = 1
                THEN TI.TI_TaxAmount
                ELSE 0
            END)                     AS [FOC TAX AMT],

        P.PRCH_RoundOff              AS [DISCOUNT / ROUND OFF]

    FROM Purchase P
    INNER JOIN Purchase_Items TI
        ON TI.TI_MasterID = P.PRCH_ID
    INNER JOIN Branch B
        ON B.brnId = P.BRNID
    INNER JOIN @branchids BR
        ON BR.brnId = B.brnId
    LEFT JOIN Party PT
        ON PT.PM_ID = P.PRCH_SupplierID

    WHERE
        CONVERT(DATE, P.PRCH_InvDate) BETWEEN @fromdate AND @todate

    GROUP BY
        P.PRCH_No,
        P.PRCH_InvDate,
        P.PRCH_InvNo,
        B.brnName,
        PT.PM_Code,
        PT.PM_LegalName,
        PT.PM_TaxRegNo1,
        P.PRCH_RoundOff,
        P.PRCH_Cancelled

    ORDER BY
        P.PRCH_InvDate,
        P.PRCH_No;

END
GO
