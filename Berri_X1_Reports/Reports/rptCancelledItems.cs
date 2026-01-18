using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System; 
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptCancelledItems : Form
    {
        public rptCancelledItems()
        {
            InitializeComponent();
        }

        DataTable dtCancelled = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;
            dtCancelled = new DataTable();
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
                SqlCommand sqlCommand = new SqlCommand("psp_REPORT_CANCELLED_ITEMS_SUMMARY", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] values =
                {
                new SqlParameter("@branchids", dtBrnids),
                new SqlParameter("@fromdate", dtpFrom.Value.Date),  
                new SqlParameter("@todate", dtpTo.Value.Date)
            };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtCancelled);

                grdData.DataSource = dtCancelled;

                grdData.Columns["Address1"].Visible = false;
                grdData.Columns["Place"].Visible = false;
                grdData.Columns["Phone1"].Visible = false;
                grdData.Columns["Country"].Visible = false;
                grdData.Columns["State"].Visible = false;
                grdData.Columns["City"].Visible = false;
                grdData.Columns["From Date"].Visible = false;
                grdData.Columns["To Date"].Visible = false;
                grdData.Columns["Email"].Visible = false;
                grdData.Columns["Website"].Visible = false;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtCancelled.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
                return;
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Clear();
            DataTable dtrpt = dtCancelled.Copy();
            dtrpt.TableName = "dtPeriodic";
            dsReport.Tables.Add(dtrpt);
            
            Common_View.Reporintg.PrintReport(dsReport, "CRrptCancelledItemsReport", 1, true);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            btnFilter.Text = pnlTop.Visible ? "Hide Filter" : "Show Filter";
        }
    }
}
