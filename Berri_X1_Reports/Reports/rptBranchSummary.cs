using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptBranchSummary : Form
    {
        public rptBranchSummary()
        {
            InitializeComponent();
        }

        DataTable dtScalars = new DataTable();
        DataTable dtBrnids = new DataTable();
        DataTable dtPaymentMode = new DataTable();
        DataTable dtDailyTrend = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtTop10 = new DataTable();
        DataTable dtReturns = new DataTable();
        DataTable dtVAT = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;
            dtScalars = new DataTable();
            dtPaymentMode = new DataTable();
            dtDailyTrend = new DataTable();
            dtCategory = new DataTable();
            dtTop10 = new DataTable();
            dtReturns = new DataTable();
            //dtVAT = new DataTable();

            if (dtBrnids.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast One Branch");
                btnBrnLookup_Click(null, null);
                return;
            }
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("From Date cannot be greater than To Date.");
                dtpFrom.Focus();
                return;
            }
            DateTime today = DateTime.Today;
            if (dtpFrom.Value.Date == today && dtpTo.Value.Date == today)
            {
                MessageBox.Show("Please change the date range. No data available for today.");
                dtpFrom.Focus();
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();

                SqlParameter[] values =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                // SP1 - Scalars
                SqlCommand cmd1 = new SqlCommand("psp_BRANCH_SUMMARY_SCALARS", sqlConnection);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddRange(values);
                new SqlDataAdapter(cmd1).Fill(dtScalars);

                // SP2 - Payment Mode
                SqlParameter[] values2 =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                SqlCommand cmd2 = new SqlCommand("psp_BRANCH_SUMMARY_PAYMENTMODE", sqlConnection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddRange(values2);
                new SqlDataAdapter(cmd2).Fill(dtPaymentMode);

                // SP3 - Daily Trend
                SqlParameter[] values3 =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                SqlCommand cmd3 = new SqlCommand("psp_BRANCH_SUMMARY_DAILYTREND", sqlConnection);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddRange(values3);
                new SqlDataAdapter(cmd3).Fill(dtDailyTrend);

                // SP4 - Category Sales
                SqlParameter[] values4 =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                SqlCommand cmd4 = new SqlCommand("psp_BRANCH_SUMMARY_CATEGORYSALES", sqlConnection);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddRange(values4);
                new SqlDataAdapter(cmd4).Fill(dtCategory);

                // SP5 - Top 10 Items
                SqlParameter[] values5 =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                SqlCommand cmd5 = new SqlCommand("psp_BRANCH_SUMMARY_TOP10ITEMS", sqlConnection);
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.Parameters.AddRange(values5);
                new SqlDataAdapter(cmd5).Fill(dtTop10);

                // SP6 - Returns
                SqlParameter[] values6 =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                    new SqlParameter("@todate",    dtpTo.Value.Date)
                };
                SqlCommand cmd6 = new SqlCommand("psp_BRANCH_SUMMARY_RETURNS", sqlConnection);
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.Parameters.AddRange(values6);
                new SqlDataAdapter(cmd6).Fill(dtReturns);

                // SP7 - VAT
                //SqlParameter[] values7 =
                //{
                //    new SqlParameter("@branchids", dtBrnids),
                //    new SqlParameter("@fromdate",  dtpFrom.Value.Date),
                //    new SqlParameter("@todate",    dtpTo.Value.Date)
                //};
                //SqlCommand cmd7 = new SqlCommand("psp_BRANCH_SUMMARY_VAT", sqlConnection);
                //cmd7.CommandType = CommandType.StoredProcedure;
                //cmd7.Parameters.AddRange(values7);
                //new SqlDataAdapter(cmd7).Fill(dtVAT);

                sqlConnection.Close();

                // show scalars for now, swap later for Crystal Reports
                grdData.DataSource = dtScalars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnBrnLookup_Click(object sender, EventArgs e)
        {
            frmLookUp_Branch _objBranch = new frmLookUp_Branch(dtBrnids);
            _objBranch.ShowDialog();

            if (!_objBranch.isEnter)
            {
                return;
            }

            dtBrnids = _objBranch.dtBranches;

            string branches = "";

            for (int i = 0; i < dtBrnids.Rows.Count; i++)
            {
                branches += ", " + dtBrnids.Rows[i]["BrnName"];
            }

            branches = branches.TrimStart(',');
            branches = branches.Trim();

            txtBranches.Text = branches;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            btnFilter.Text = pnlTop.Visible ? "Hide Filter" : "Show Filter";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (dtCancelled.Rows.Count <= 0)
            //{
            //    MessageBox.Show("No Data");
            //    return;
            //}

            //DataSet dsReport = new DataSet();
            //dsReport.Tables.Clear();
            //DataTable dtrpt = dtCancelled.Copy();
            //dtrpt.TableName = "dtPeriodic";
            //dsReport.Tables.Add(dtrpt);

            //Common_View.Reporintg.PrintReport(dsReport, "CRrptCancelledItemsReport", 1, true);
        }
    }
}