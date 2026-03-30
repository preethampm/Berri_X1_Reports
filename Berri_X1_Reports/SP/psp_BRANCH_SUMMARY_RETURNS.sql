ALTER PROCEDURE psp_BRANCH_SUMMARY_RETURNS
(
    @branchids  dbo.tp_BrnIds READONLY,
    @fromdate   DATE = NULL,
    @todate     DATE = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    -- Summary row
    SELECT
        'SUMMARY'                               AS RecordType,
        NULL                                    AS ItemCode,
        NULL                                    AS ItemName,
        NULL                                    AS PaymentMode,
        SUM(IR.IR_GrandTotal)                   AS ReturnValue,
        NULL                                    AS ReturnQty,
        ROUND(
            SUM(IR.IR_GrandTotal) * 100.0
            / NULLIF((
                SELECT SUM(I.Inv_GrandTotal)
                FROM Invoice I
                JOIN @branchids B2 ON B2.BrnID = I.BRNID
                WHERE CAST(I.Inv_Date AS DATE) BETWEEN @fromdate AND @todate
                  AND ISNULL(I.Inv_Cancelled, 0) = 0
                  AND ISNULL(I.Inv_Approve, 1) = 1
            ), 0)
        , 2)                                    AS ReturnRatePct
    FROM InvoiceReturn IR
    JOIN @branchids B ON B.BrnID = IR.BRNID
    WHERE CAST(IR.IR_Date AS DATE) BETWEEN @fromdate AND @todate
      AND ISNULL(IR.IR_Cancelled, 0) = 0

    UNION ALL

    -- Top 5 returned items
    SELECT
        RecordType, ItemCode, ItemName, PaymentMode, ReturnValue, ReturnQty, ReturnRatePct
    FROM (
        SELECT TOP 5
            'TOP_ITEM'              AS RecordType,
            IRI.IRI_ItemCode        AS ItemCode,
            IRI.IRI_ItemName        AS ItemName,
            NULL                    AS PaymentMode,
            SUM(IRI.IRI_NetAmount)  AS ReturnValue,
            SUM(IRI.IRI_Quantity)   AS ReturnQty,
            NULL                    AS ReturnRatePct
        FROM InvoiceReturn IR
        JOIN @branchids B            ON B.BrnID = IR.BRNID
        JOIN InvoiceReturn_Items IRI ON IRI.IRI_IRID = IR.IR_ID
        WHERE CAST(IR.IR_Date AS DATE) BETWEEN @fromdate AND @todate
          AND ISNULL(IR.IR_Cancelled, 0) = 0
        GROUP BY
            IRI.IRI_ItemCode,
            IRI.IRI_ItemName
        ORDER BY SUM(IRI.IRI_NetAmount) DESC
    ) TopItems

    UNION ALL

    -- Returns by payment mode
    SELECT
        'BY_PAYMENT',
        NULL,
        NULL,
        IR.IR_PayMode,
        SUM(IR.IR_GrandTotal),
        NULL,
        NULL
    FROM InvoiceReturn IR
    JOIN @branchids B ON B.BrnID = IR.BRNID
    WHERE CAST(IR.IR_Date AS DATE) BETWEEN @fromdate AND @todate
      AND ISNULL(IR.IR_Cancelled, 0) = 0
    GROUP BY IR.IR_PayMode;
END