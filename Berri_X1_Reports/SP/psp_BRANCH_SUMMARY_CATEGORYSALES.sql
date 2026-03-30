ALTER PROCEDURE psp_BRANCH_SUMMARY_CATEGORYSALES
(
    @branchids  dbo.tp_BrnIds READONLY,
    @fromdate   DATE = NULL,
    @todate     DATE = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        DP.MST_Desc                                             AS DepartmentName,
        DV.MST_Desc                                             AS DivisionName,
        CT.MST_Desc                                             AS CategoryName,
        SUM(II.InvI_NetAmount)                                  AS CategorySales,
        SUM(II.InvI_Quantity)                                   AS CategoryQty,
        ROUND(
            SUM(II.InvI_NetAmount) * 100.0
            / NULLIF(SUM(SUM(II.InvI_NetAmount)) OVER (), 0)
        , 2)                                                    AS SalesSharePct
    FROM Invoice I
    JOIN @branchids B   ON B.BrnId = I.BRNID
    JOIN Invoice_Items II ON II.InvI_InvID = I.Inv_ID
    JOIN ItemMaster IM  ON IM.ItemID = II.InvI_ItemID
    JOIN Masters DP     ON DP.MST_Type = 'ITEMDEPT'
                       AND DP.MST_Code = IM.itemDepartmentCode
    JOIN Masters DV     ON DV.MST_Type = 'ITEMDIVISN'
                       AND DV.MST_Code = IM.itemDivisionCode
    JOIN Masters CT     ON CT.MST_Type = 'ITEMCAT'
                       AND CT.MST_Code = IM.itemCategoryCode
    WHERE CAST(I.Inv_Date AS DATE) BETWEEN @fromdate AND @todate
      AND ISNULL(I.Inv_Cancelled, 0) = 0
      AND ISNULL(I.Inv_Approve, 1) = 1
    GROUP BY
        DP.MST_Desc,
        DV.MST_Desc,
        CT.MST_Desc
    ORDER BY
        DP.MST_Desc,
        DV.MST_Desc,
        CategorySales DESC;
END