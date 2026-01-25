using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptTaxReportItemWise : Form
    {
        public rptTaxReportItemWise()
        {
            InitializeComponent();
        }

        DataTable dtTax = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;

            dtTax = new DataTable();

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

            string procedureName = "";

            if (cmbReportType.Text == "Purchase")
            {
                procedureName = "psp_TAX_REPORT_PURCHASE_ITW";
            }
            else if (cmbReportType.Text == "Purchase Return")
            {
                procedureName = "psp_TAX_REPORT_PURCHASE_RETURN_ITW";
            }
            else if (cmbReportType.Text == "Invoice")
            {
                procedureName = "psp_TAX_REPORT_INVOICE_ITW";
            }
            else if (cmbReportType.Text == "Invoice Return")
            {
                procedureName = "psp_TAX_REPORT_INVOICE_RETURN_ITW";
            }
            else
            {
                MessageBox.Show("Unsupported Report Type.");

            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] values =
                {
                new SqlParameter("@branchids", dtBrnids),
                new SqlParameter("@fromdate", dtpFrom.Value.Date),
                new SqlParameter("@todate", dtpTo.Value.Date),
                new SqlParameter("@reporttype", cmbReportType.Text)

            };
            sqlCommand.Parameters.AddRange(values);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTax);

            grdData.DataSource = dtTax;

                string[] hideCols =
                {
                "ADDRESS1", "PHONE", "CITY", "STATE", "COUNTRY", "PLACE", "DOC TYPE", "DIVISION", "FROM DATE", "TO DATE"
                };

                foreach (string col in hideCols)
                {
                    if (grdData.Columns.Contains(col))
                    {
                        grdData.Columns[col].Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
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

        private void btnRemoveBranch_Click(object sender, EventArgs e)
        {
            txtBranches.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtTax.Rows.Count <= 0)
            {
                MessageBox.Show("No Data. Click View to fetch the data");
                return;
            }

            string reportName = "";

            if (cmbReportType.Text == "Purchase")
            {
                reportName = "CRrptTR_PURCHASE_ITW";
            }
            else if (cmbReportType.Text == "Purchase Return")
            {
                reportName = "psp_TAX_REPORT_PURCHASE_RETURN_ITW";
            }
            else if (cmbReportType.Text == "Invoice")
            {
                reportName = "psp_TAX_REPORT_INVOICE_ITW";
            }
            else if (cmbReportType.Text == "Invoice Return")
            {
                reportName = "psp_TAX_REPORT_INVOICE_RETURN_ITW";
            }
            else
            {
                MessageBox.Show("Invalid report type selected");
                return;
            }

            DataSet dsReport = new DataSet();
            DataTable dtrpt = dtTax.Copy();
            dsReport.Tables.Add(dtrpt);

            Common_View.Reporintg.PrintReport(dsReport, reportName, 1, true);
        }
    }
}
