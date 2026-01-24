ALTER PROCEDURE [dbo].[psp_TAX_REPORT_PURCHASE_RETURN_ITW]
(
    @reporttype  VARCHAR(50) = '',
    @branchids   dbo.tp_BrnIds READONLY,
    @fromdate    DATE = NULL,
    @todate      DATE = NULL
)
AS
BEGIN
	SELECT * FROM 

END
