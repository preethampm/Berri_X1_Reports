using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptItemDetails : Form
    {
        public rptItemDetails()
        {
            InitializeComponent();
        }

        DataTable dtItemDetails = new DataTable();
        DataTable dtBrnids = new DataTable();
        Boolean FrmLoaded = false;

        private void Getdata()
        {
            grdData.DataSource = null;

            dtItemDetails = new DataTable();

            if (dtBrnids.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast One Branch");
                btnBrnLookup_Click(null, null);
                return;
            }

            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("psp_Report_Item_Details", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] values =
                {
                    //new SqlParameter("@branchname", txtBranches.Text),
                    new SqlParameter("@supplier",  txtSupplier.Text),
                    new SqlParameter("@itemname",  txtItemName.Text),
                    new SqlParameter("@branchidS", dtBrnids),
                    new SqlParameter("@purchasetype", cmbPurchaseType.Text),
                    new SqlParameter("@brand", cmbBrand.Text)
                };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtItemDetails);

                grdData.DataSource = dtItemDetails;
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            btnFilter.Text = pnlTop.Visible ? "Hide Filter" : "Show Filter";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtItemDetails.Rows.Count <= 0)
            {
                MessageBox.Show("No Data. Click View to fetch the data");
                return;
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Clear();
            DataTable dtrpt = dtItemDetails.Copy();

            dsReport.Tables.Add(dtrpt);

            Common_View.Reporintg.PrintReport(dsReport, "CRrptItem", 1, true);
        }

        private void rptItemDetails_Load(object sender, EventArgs e)
        {
            cmbBrand.DataSource = Masters_PRESENT.GetList("ITEMBRN", "", true, Common_Var.Company.cmpId);
            cmbBrand.ValueMember = "Code";
            cmbBrand.DisplayMember = "Description";

            cmbDepartment.DataSource = Masters_PRESENT.GetList("ITEMDEPT", "", true, Common_Var.Company.cmpId);
            cmbDepartment.DisplayMember= "Description";

            cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", "", true, Common_Var.Company.cmpId);
            cmbDivision.DisplayMember= "Description";

            cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", "", true, Common_Var.Company.cmpId);
            cmbCategory.DisplayMember= "Description";

            cmbSubCat.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", "", true, Common_Var.Company.cmpId);
            cmbSubCat.DisplayMember= "Description";

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

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmLookUp frmLkp = new frmLookUp();
            frmLkp.m_table = "(PartyMaster P left join AllAddress A on  P.PM_BIllAddressID = a.AddressId )";
            frmLkp.m_fields = "PM_FirstName,Phone1,PM_CardNo,Place,PM_Code,PM_Id";
            frmLkp.m_dispname = "Supplier,Phone,PCard No,Place,Code,PM_Id";
            frmLkp.m_condition = " PM_FirstName <>'' and isnull(PM_Type,'') = 'SUPPLIER' and CMPID = " + Common_Var.Company.cmpId;
            frmLkp.m_fldwidth = "450,100,100,100,0,0";
            frmLkp.ShowDialog();
            if (frmLkp.m_values.Count > 0)
            {
                txtSupplier.Tag = frmLkp.m_values[5].ToString();
                txtSupplier.Text = frmLkp.m_values[0].ToString();
            }
        }

        //department
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded)
            {
                cmbDepartment.DataSource = Masters_PRESENT.GetList("ITEMDEPT", "", true, Common_Var.Company.cmpId);
            }
        }

        //division
        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded) 
            {
                cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", "", true, Common_Var.Company.cmpId);
            }  
        }

        //category
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded) {
                cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", "", true, Common_Var.Company.cmpId);
            }
           
        }

        private void btnproItemSearch_Click(object sender, EventArgs e)
        {
            ArrayList lkpValues = new ArrayList();
            lkpValues = Common_View.Methods.ItemMasterLookUp();
            if (lkpValues.Count > 0)
            {
                txtItemCode.Text = lkpValues[1].ToString();
                txtItemCode.Tag = lkpValues[2].ToString();
                txtItemName.Text = lkpValues[0].ToString();
            }
        }

        //brand
        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (FrmLoaded)
            {
                cmbBrand.DataSource = Masters_PRESENT.GetList("ITEMBRN", "", true, Common_Var.Company.cmpId);
            }
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {

            txtSupplier.Text = "";
            txtSupplier.Tag = "";
        }

        private void cmbSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded)
            {
                cmbSubCat.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", "", true, Common_Var.Company.cmpId);
            }
        }

        private void btnRemoveItemCode_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtItemName.Text = "";
        }

        private void btnRemoveBranch_Click(object sender, EventArgs e)
        {
            txtBranches.Text = "";
        }
    }
}
