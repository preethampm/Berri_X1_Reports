using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptRepackingItems : Form
    {
        public rptRepackingItems()
        {
            InitializeComponent();
        }
        DataTable dtRepacking = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void GetData()
        {
            grdData.DataSource = null;

            dtRepacking = new DataTable();

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
            string sp = "";
            if (cmbReportType.Text == "Summary")
            {
                sp = "psp_REPORT_REPACKING_DETAILS_SUMMARY";
            }
            else
            {
                sp = "psp_REPORT_REPACKING_DETAILS_DETAILED";
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sp, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] values =
                {
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@fromdate", dtpFrom.Value.Date),
                    new SqlParameter("@todate", dtpTo.Value.Date),
                    new SqlParameter("@brand", cmbBrand.Text),
                    new SqlParameter("@department", cmbDepartment.Text),
                    new SqlParameter("@division", cmbDivision.Text),
                    new SqlParameter("@category", cmbCategory.Text),
                    new SqlParameter("@barcode", txtBarcodeCode.Text),
                    new SqlParameter("@itemcode", txtItemCode.Text),
                };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtRepacking);

                grdData.DataSource = dtRepacking;

                grdData.Columns["Branch Id"].Visible = false;
                grdData.Columns["Address"].Visible = false;
                grdData.Columns["City"].Visible = false;
                grdData.Columns["Country"].Visible = false;
                grdData.Columns["Place"].Visible = false;
                grdData.Columns["Phone1"].Visible = false;
                grdData.Columns["From Date"].Visible = false;
                grdData.Columns["To Date"].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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

        private void rptRepackingItems_Load(object sender, EventArgs e)
        {
            cmbBrand.DataSource = Masters_PRESENT.GetList("ITEMBRN", "", true, Common_Var.Company.cmpId);
            cmbBrand.DisplayMember = "Description";

            cmbDepartment.DataSource = Masters_PRESENT.GetList("ITEMDEPT", "", true, Common_Var.Company.cmpId);
            cmbDepartment.DisplayMember = "Description";

            cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", "", true, Common_Var.Company.cmpId);
            cmbDivision.DisplayMember = "Description";

            cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", "", true, Common_Var.Company.cmpId);
            cmbCategory.DisplayMember = "Description";

            cmbSubCategory.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", "", true, Common_Var.Company.cmpId);
            cmbSubCategory.DisplayMember = "Description";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSupplierLookup_Click(object sender, EventArgs e)
        {
            frmLookUp frmLkp = new frmLookUp();

            frmLkp.m_table = "PartyMaster P";
            frmLkp.m_fields = "PM_FirstName,PM_Code";
            frmLkp.m_dispname = "Supplier,Code";
            frmLkp.m_condition =
                "PM_FirstName <> '' " +
                "AND ISNULL(PM_Type,'') = 'SUPPLIER' " +
                "AND CMPID = " + Common_Var.Company.cmpId;
            frmLkp.m_fldwidth = "500,120,0";

            frmLkp.ShowDialog();

            if (frmLkp.m_values.Count > 0)
            {
                txtSupplier.Text = frmLkp.m_values[0].ToString(); // Supplier name
            }
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

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            txtSupplier.Text = "";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
        }

        private void btnBarcodeLookup_Click(object sender, EventArgs e)
        {
            frmLookUp frmLkp = new frmLookUp();

            frmLkp.m_table = "ItemMultiUnit I";
            frmLkp.m_fields = "I.IM_BarCode, I.IM_ShortName";
            frmLkp.m_dispname = "Barcode, Item";
            frmLkp.m_condition = "I.IM_BarCode IS NOT NULL AND I.IM_BarCode <> ''";
            frmLkp.m_fldwidth = "200, 300";

            frmLkp.ShowDialog();

            if (frmLkp.m_values.Count > 0)
            {
                txtBarcodeCode.Text = frmLkp.m_values[0].ToString();
            }
        }

        private void btnRemoveBarcode_Click(object sender, EventArgs e)
        {
            txtBarcodeCode.Text = "";
        }
    }
}
