ALTER PROCEDURE psp_TAX_REPORT_INVOICE_RETURN_IW
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
        IR.IR_No                                   AS [DOC NO],
        @reporttype                                AS [DOC TYPE],
        IR.IR_Date                                 AS [INV DATE],
        IR.IR_No                                   AS [INV NO],
        B.brnName                                  AS [DIVISION],
        'INWARD'                                   AS [SOURCE TYPE],

        P.PM_Code                                  AS [PARTY CODE],
        P.PM_LegalName                             AS [PARTY NAME],
        P.PM_TaxRegNo1                             AS [VAT NO],

        IRI.IRI_ItemID                             AS [ITEM CODE],
        IRI.IRI_ItemName                           AS [ITEM NAME],

        IRI.IRI_TaxableAmount                     AS [NET TAXABLE AMT],
        IRI.IRI_TaxAmount                         AS [NET TAX AMT],

        0                                          AS [FOC TAXABLE AMT],
        0                                          AS [FOC TAX AMT],

        IR.IR_RoundOff                             AS [DISCOUNT / ROUND OFF]

    FROM InvoiceReturn IR
    INNER JOIN InvoiceReturn_Items IRI
        ON IRI.IRI_IRID = IR.IR_ID
    INNER JOIN Branch B
        ON B.brnId = IR.BRNID
    LEFT JOIN Party P
        ON P.PM_AccID = IR.IR_CustAccID

    WHERE
        CONVERT(DATE, IR.IR_Date) BETWEEN @fromdate AND @todate
        AND ISNULL(IR.IR_Cancelled,0) = 0
        AND IR.BRNID IN (SELECT BrnID FROM @branchids)

    ORDER BY
        IR.IR_Date,
        IR.IR_No,
        IRI.IRI_SLNo;

END
