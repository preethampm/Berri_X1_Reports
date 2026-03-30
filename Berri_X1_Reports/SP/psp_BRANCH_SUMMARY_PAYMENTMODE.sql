ALTER PROCEDURE psp_BRANCH_SUMMARY_PAYMENTMODE
(
    @branchids  dbo.tp_BrnIds READONLY,
    @fromdate   DATE = NULL,
    @todate     DATE = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    WITH PaymentBase AS
    (
        SELECT
            SUM(I.Inv_CashAmount)   AS CashTotal,
            SUM(I.Inv_CardAmount)   AS CardTotal,
            SUM(I.Inv_CreditAmount) AS CreditTotal,
            SUM(I.Inv_GrandTotal)   AS GrandTotal
        FROM Invoice I
        JOIN @branchids B ON B.BrnId = I.BRNID
        WHERE CAST(I.Inv_Date AS DATE) BETWEEN @fromdate AND @todate
          AND ISNULL(I.Inv_Cancelled, 0) = 0
          AND ISNULL(I.Inv_Approve, 1) = 1
    )
    SELECT
        'Cash'                                                          AS PaymentMode,
        CashTotal                                                       AS Amount,
        ROUND(CASE WHEN GrandTotal = 0 THEN 0
              ELSE (CashTotal / GrandTotal) * 100 END, 2)              AS Percentage
    FROM PaymentBase
    UNION ALL
    SELECT
        'Card',
        CardTotal,
        ROUND(CASE WHEN GrandTotal = 0 THEN 0
              ELSE (CardTotal / GrandTotal) * 100 END, 2)
    FROM PaymentBase
    UNION ALL
    SELECT
        'Credit',
        CreditTotal,
        ROUND(CASE WHEN GrandTotal = 0 THEN 0
              ELSE (CreditTotal / GrandTotal) * 100 END, 2)
    FROM PaymentBase;
END