using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptPromotionItems : Form
    {
        public rptPromotionItems()
        {
            InitializeComponent();
        }

        DataTable dtPromotion = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;
            dtPromotion = new DataTable();
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

            if (cmbReportType.Text == "Summary")
            {
                procedureName = "psp_PROMOTION_ITEMS_SUMMARY";
            }
            else if(cmbReportType.Text == "Detailed")
            {
                procedureName = "psp_PROMOTION_ITEMS_DETAILED";
            }
            else if (cmbReportType.Text == "Promotion Summary") 
            {   
                procedureName = "psp_PROMOTION_ITEMS_PROMOTION_SUMMARY";
            }
            else
            {
                MessageBox.Show("Invalid report type selected");
                return;
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
                        new SqlParameter("@todate", dtpTo.Value.Date)
                    };
                    sqlCommand.Parameters.AddRange(values);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtPromotion);

                    grdData.DataSource = dtPromotion;

                    grdData.Columns["Address1"].Visible = false;
                    grdData.Columns["Place"].Visible = false;
                    grdData.Columns["Phone1"].Visible = false;
                    grdData.Columns["Country"].Visible = false;
                    grdData.Columns["State"].Visible = false;
                    grdData.Columns["City"].Visible = false;
                    grdData.Columns["From Date"].Visible = false;
                    grdData.Columns["To Date"].Visible = false;
                    grdData.Columns["Branch"].Visible = false;

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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            btnFilter.Text = pnlTop.Visible ? "Hide Filter" : "Show Filter";
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

        private void rptPromotionItems_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = Masters_PRESENT.GetList("ITEMDEPT", "", true, Common_Var.Company.cmpId);
            cmbDepartment.DisplayMember = "Description";

            cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", "", true, Common_Var.Company.cmpId);
            cmbDivision.DisplayMember = "Description";

            cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", "", true, Common_Var.Company.cmpId);
            cmbCategory.DisplayMember = "Description";

            cmbSubCategory.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", "", true, Common_Var.Company.cmpId);
            cmbSubCategory.DisplayMember = "Description";
        }

        private void btnItemLookup_Click(object sender, EventArgs e)
        {
            ArrayList lkpValues = new ArrayList();
            lkpValues = Common_View.Methods.ItemMasterLookUp();

            if (lkpValues.Count > 0)
            {
                txtItemName.Text = lkpValues[0].ToString(); // Item Name
                txtItemCode.Text = lkpValues[1].ToString(); // Item Code
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPromotion.Rows.Count <= 0)
            {
                MessageBox.Show("No Data. Click View to fetch the data");
                return;
            }

            string reportName = "";

            if (cmbReportType.Text == "Summary")
            {
                reportName = "CRrptPromotionSummary";
            }
            else if (cmbReportType.Text == "Detailed")
            {
                reportName = "CRprtRepackingDetailed";
            }
            else
            {
                MessageBox.Show("Invalid report type selected");
                return;
            }

            DataSet dsReport = new DataSet();
            DataTable dtrpt = dtPromotion.Copy();
            dsReport.Tables.Add(dtrpt);

            Common_View.Reporintg.PrintReport(dsReport, reportName, 1, true);
        }
    }
}
