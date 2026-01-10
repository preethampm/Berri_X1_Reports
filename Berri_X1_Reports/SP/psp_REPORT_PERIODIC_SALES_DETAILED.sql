ALTER PROCEDURE psp_REPORT_PERIODIC_SALES_DETAILED
(    @fromdate  DATE,
    @todate    DATE,
    @branchids dbo.tp_BrnIds READONLY,
    @counterid INT = 0,
    @shiftid   INT = 0
)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
        I.Inv_No                     AS [Bill No],
        CONVERT(DATE, I.Inv_Date)    AS [Bill Date],
        I.BRNID                      AS [Branch Id],
        I.CounterID                  AS [Counter Id],
        I.ShiftID                    AS [Shift Id],

        ISNULL(I.Inv_TaxableAmount, 0)  AS [Sales Amount],
        ISNULL(I.Inv_TaxAmount, 0)      AS [Tax],
        ISNULL(I.Inv_GrandTotal, 0)     AS [Net Sales Amount],

        ISNULL(I.Inv_CashAmount, 0)     AS [Cash],
        ISNULL(I.Inv_CardAmount, 0)     AS [Card],
        ISNULL(I.Inv_CreditAmount, 0)   AS [Credit],
        (
            ISNULL(I.Inv_GVoucherAmount, 0)
          + ISNULL(I.Inv_BillDiscAmountBTax, 0)
          + ISNULL(I.Inv_BillDiscAmountATax, 0)
        ) AS [Gift / Disc]

    FROM Invoice I
    INNER JOIN @branchids B
        ON B.BrnID = I.BRNID

    WHERE
        CONVERT(DATE, I.Inv_Date) BETWEEN @fromdate AND @todate
        AND ISNULL(I.Inv_Cancelled, 0) = 0
        AND (@counterid = 0 OR I.CounterID = @counterid)
        AND (@shiftid = 0 OR I.ShiftID = @shiftid)

    ORDER BY
        I.Inv_Date,
        I.Inv_No;
END;
GO