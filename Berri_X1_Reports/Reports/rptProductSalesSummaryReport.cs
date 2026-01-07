using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptProductSalesSummaryReport : Form
    {
        public rptProductSalesSummaryReport()
        {
            InitializeComponent();
        }

        DataTable dtSales = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void Getdata()
        {
            grdData.DataSource = null;

            dtSales = new DataTable();

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

            if (cmbReportType.Text == "Division")
            {
                procedureName = "psp_REPORT_PRODUCT_SALES_DIVISION";
            }
            else if (cmbReportType.Text == "Department")
            {
                procedureName = "psp_REPORT_PRODUCT_SALES_DEPARTMENT";
            }
            else if (cmbReportType.Text == "Category")
            {
                procedureName = "psp_REPORT_PRODUCT_SALES_CATEGORY";
            }
            else if (cmbReportType.Text == "Sub Category")
            {
                procedureName = "psp_REPORT_PRODUCT_SALES_SUBCATEGORY";
            }
            else
            {
                MessageBox.Show("Unsupported Report Type.");
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
                    new SqlParameter("@division", cmbDivision.Text),
                    new SqlParameter("@fromdate", dtpFrom.Value.Date),
                    new SqlParameter("@todate", dtpTo.Value.Date),
                    new SqlParameter("@reporttype", cmbReportType.Text),
                    new SqlParameter("@paytype", GetPayType()),
                    new SqlParameter("@department", cmbDepartment.Text),
                    new SqlParameter("@category", cmbCategory.Text)
                };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSales);

                grdData.DataSource = dtSales;

                if (this.Tag != "GP")
                {
                    grdData.Columns["COST OF SALE"].Visible = false;
                    grdData.Columns["PROFIT AMOUNT"].Visible = false;
                    grdData.Columns["PROFIT %"].Visible = false;
                }
                else
                {
                    grdData.Columns["COST OF SALE"].Visible = true;
                    grdData.Columns["PROFIT AMOUNT"].Visible = true;
                    grdData.Columns["PROFIT %"].Visible = true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void rptProductSalesDivisionWise_Load(object sender, EventArgs e)
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btnRemoveBranch_Click(object sender, EventArgs e)
        {
            txtBranches.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtSales.Rows.Count <= 0)
            {
                MessageBox.Show("No Data. Click View to fetch the data");
                return;
            }

            string reportName = "";
            bool isGP = this.Tag == "GP";

            switch (cmbReportType.Text)
            {
                case "Department":
                    reportName = isGP
                        ? "CRrptProductSalesDepartment"
                        : "CRrptProductSalesDepartmentWOGP";
                    break;

                case "Division":
                    reportName = isGP
                        ? "CRrptProductSalesDivision"
                        : "CRrptProductSalesDivisionWOGP";
                    break;

                case "Category":
                    reportName = isGP
                        ? "CRrptProductSalesCategory"
                        : "CRrptProductSalesCategoryWOGP";
                    break;

                case "Sub Category":
                    reportName = isGP
                        ? "CRrptProductSalesSubCategory"
                        : "CRrptProductSalesSubCategoryWOGP";
                    break;

                default:
                    MessageBox.Show("Invalid report type selected");
                    return;
            }

            DataTable dtrpt = dtSales.Copy();

            if (rbtnCash.Checked)
            {
                if (dtrpt.Columns.Contains("CREDIT SALES"))
                    dtrpt.Columns.Remove("CREDIT SALES");
            }
            else if (rbtnCredit.Checked)
            {
                if (dtrpt.Columns.Contains("CASH SALES"))
                    dtrpt.Columns.Remove("CASH SALES");
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Add(dtrpt);

            Common_View.Reporintg.PrintReport(dsReport, reportName, 1, true);
        }

        private string GetPayType()
        {
            if (rbtnCash.Checked) return "Cash";
            if (rbtnCredit.Checked) return "Credit";
            return "Both";
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reportType = cmbReportType.Text;
            cmbDivision.Visible = false;
            cmbCategory.Visible = false;
            lblDivison.Visible = false;
            lblCategory.Visible = false;
            lblDepartment.Visible = false;
            cmbDepartment.Visible = false;
            lblSubCategory.Visible = false;
            cmbSubCategory.Visible = false;

            if (reportType == "Division")
            {
                cmbDivision.Visible = true;
                lblDivison.Visible = true;
                cmbDepartment.Visible = true;
                lblDepartment.Visible = true;
            }
            else if (reportType == "Category")
            {
                cmbDivision.Visible = true;
                cmbCategory.Visible = true;
                lblDivison.Visible = true;
                lblCategory.Visible = true;
                cmbDepartment.Visible = true;
                lblDepartment.Visible = true;
            }
            else if (reportType == "Department")
            {
                cmbDepartment.Visible= true;
                lblDepartment.Visible= true;
            }
            else if (reportType == "Sub Category")
            {
                cmbDivision.Visible = true;
                cmbCategory.Visible = true;
                lblDivison.Visible = true;
                lblCategory.Visible = true;
                cmbDepartment.Visible = true;
                lblDepartment.Visible = true;
                cmbSubCategory.Visible = true;
                lblSubCategory.Visible = true;  
            }
        }
    }
}