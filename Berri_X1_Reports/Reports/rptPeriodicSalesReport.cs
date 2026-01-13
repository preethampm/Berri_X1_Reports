using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptPeriodicSalesReport : Form
    {
        public rptPeriodicSalesReport()
        {
            InitializeComponent();
        }

        DataTable dtPeriodic = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;
            dtPeriodic = new DataTable();
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
            int shiftId = 0;
            //int counterId = 0;
            int.TryParse(txtShift.Text.Trim(), out shiftId);
            //int.TryParse(txtCounter.Text.Trim(), out counterId);

            if (!rbtnSummary.Checked && !rbtnDetailed.Checked)
            {
                MessageBox.Show("Please select either Summary or Detailed report type.");
                return;
            }
            //if (cmbCounter.SelectedIndex < 0)
            //{
            //    MessageBox.Show("Please select a counter.");
            //    cmbCounter.Focus();
            //    return;
            //}
            string procedureName = "";
            if (rbtnSummary.Checked)
            {
                procedureName = "psp_REPORT_PERIODIC_SALES_SUMMARY";
            }
            else
            {
                procedureName = "psp_REPORT_PERIODIC_SALES_DETAILED";
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
                new SqlParameter("@shiftid", shiftId),
                new SqlParameter("@countercode", cmbCounter.Text)
            };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtPeriodic);

                grdData.DataSource = dtPeriodic;

                //grdData.Columns["Address1"].Visible = false;
                //grdData.Columns["Address2"].Visible = false;
                //grdData.Columns["Phone1"].Visible = false;
                //grdData.Columns["Email"].Visible = false;
                //grdData.Columns["Website"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
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

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPeriodic.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
                return;
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Clear();
            DataTable dtrpt = dtPeriodic.Copy();
            dtrpt.TableName = "dtPeriodic";
            dsReport.Tables.Add(dtrpt);
            string reportName = rbtnSummary.Checked ? "CRrptPeriodicSalesSummary" : "CRrptPeriodicSalesDetailed";
            Common_View.Reporintg.PrintReport(dsReport, reportName  , 1, true);
        }
    }
}
