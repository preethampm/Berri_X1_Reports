ALTER PROCEDURE psp_BRANCH_SUMMARY_TOP10ITEMS
(
    @branchids  dbo.tp_BrnIds READONLY,
    @fromdate   DATE = NULL,
    @todate     DATE = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 10
        II.InvI_ItemID                  AS ItemCode,
        II.InvI_ItemName                AS ItemName,
        SUM(II.InvI_Quantity)           AS TotalQtySold,
        SUM(II.InvI_NetAmount)          AS TotalRevenue,
        ROUND(AVG(II.InvI_Price), 3)    AS AvgSellingPrice
    FROM Invoice I
    JOIN @branchids B     ON B.BrnId = I.BRNID
    JOIN Invoice_Items II ON II.InvI_InvID = I.Inv_ID
    WHERE CAST(I.Inv_Date AS DATE) BETWEEN @fromdate AND @todate
      AND ISNULL(I.Inv_Cancelled, 0) = 0
      AND ISNULL(I.Inv_Approve, 1) = 1
    GROUP BY
        II.InvI_ItemID,
        II.InvI_ItemName
    ORDER BY TotalRevenue DESC;
END