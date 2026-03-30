ALTER PROCEDURE psp_BRANCH_SUMMARY_DAILYTREND
(
    @branchids  dbo.tp_BrnIds READONLY,
    @fromdate   DATE = NULL,
    @todate     DATE = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        CAST(I.Inv_Date AS DATE)        AS SalesDay,
        SUM(I.Inv_GrandTotal)           AS DailySales,
        COUNT(I.Inv_ID)                 AS DailyTransactions
    FROM Invoice I
    JOIN @branchids B ON B.BrnId = I.BRNID
    WHERE CAST(I.Inv_Date AS DATE) BETWEEN @fromdate AND @todate
      AND ISNULL(I.Inv_Cancelled, 0) = 0
      AND ISNULL(I.Inv_Approve, 1) = 1
    GROUP BY CAST(I.Inv_Date AS DATE)
    ORDER BY SalesDay;
END