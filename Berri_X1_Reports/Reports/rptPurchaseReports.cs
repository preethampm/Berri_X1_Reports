using System;
using System.Data;
using System.Windows.Forms;
using Berri_X1_MODEL;
using System.Collections;
using Telerik.WinControls.UI;
using Berri_X1_UI_Common;
using Berri_X1_DLL;

namespace Berri_X1_Reports
{
    public partial class rptPurchaseReports : Form
    {
        DataSet dsReport = new DataSet();
        DataTable dtMasters = new DataTable();
        DataTable dtBrnids = new DataTable();
        public String rptTag = "";
        bool FrmLoaded = false;
        public rptPurchaseReports()
        {
            InitializeComponent();
        }

        private void rptPurchaseReports_Load(object sender, EventArgs e)
        {
           //Common_View.Methods.ApplyThemes(this, pnlHeader, pnlFooter);
            //Common_Var.Methods.setGridStyles(grdData);

            if (Common_Var.Branch.brnType != "HO")
            {
                dtBrnids.Columns.Add("brnID", typeof(Int32));
                dtBrnids.Columns.Add("brnName", typeof(string));

                dtBrnids.Rows.Add(new Object[] { Common_Var.Branch.brnId, Common_Var.Branch.brnName });
                txtBranches.Text = Common_Var.Branch.brnName;
            }

            switch (this.rptTag.ToString())
            {
                case "PURCHASE":
                    lblFormName.Text = "Purchase Invoice Report";
                    break;
                case "RPTPRCHDTL":
                    lblFormName.Text = "Purchase Invoice Report - Detailed";
                    cmbSummaryType.Visible = false;
                    break;
            }

            cmbSummaryType.DisplayMember = "Text";
            cmbSummaryType.ValueMember = "Value";
            if (this.rptTag.ToString() == "RPTPRCHDTL")
            {
                var items = new[] {
                new { Text = "Purchase - Detailed", Value = "PRCH_DTL" } };
                cmbSummaryType.DataSource = items;
                cmbSummaryType.SelectedIndex = 0;
            }
            else
            {
                var items = new[] {
                new { Text = "Branch and Date wise Detailed", Value = "BR_DT_D" },
                new { Text = "Date and Branch wise Detailed", Value = "DT_BR_D" },
                new { Text = "Branch and Date wise Summary", Value = "BR_DT_S" },
                new { Text = "Date and Branch wise Summary", Value = "DT_BR_S" },
                new { Text = "Branch - Supplier and Date wise Summary", Value = "BR_SU_DT_S" },
                new { Text = "Date - Supplier and Branch wise Summary", Value = "DT_SU_BR_S" },
                new { Text = "Branchwise Periodic Summary", Value = "BR_S" }};
                cmbSummaryType.DataSource = items;
            }
            grdData.ShowFilteringRow = false;

            cmbBrand.DataSource = Masters_PRESENT.GetList("ITEMBRN", "", true, Common_Var.Company.cmpId);
            cmbDepartment.DataSource = Masters_PRESENT.GetList("ITEMDEPT", "", true, Common_Var.Company.cmpId);
            cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", "", true, Common_Var.Company.cmpId);
            cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", "", true, Common_Var.Company.cmpId);
            cmbSubCategory.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", "", true, Common_Var.Company.cmpId);

            cmbBrand.DisplayMember = "Description";
            cmbBrand.ValueMember = "Code";

            cmbDepartment.DisplayMember = "Description";
            cmbDepartment.ValueMember = "Code";

            cmbDivision.DisplayMember = "Description";
            cmbDivision.ValueMember = "Code";

            cmbCategory.DisplayMember = "Description";
            cmbCategory.ValueMember = "Code";

            cmbSubCategory.DisplayMember = "Description";
            cmbSubCategory.ValueMember = "Code";

            FrmLoaded = true;
            grdData.DataSource = dtMasters;
            this.Text = lblFormName.Text;
        }
 
       
        private void EnableDisableButtons(bool _enable)
        {
           
            btnExcel.Enabled = _enable;
            btnPrint.Enabled = _enable;
            
        }
        private void getInvoiceData()
        {
            grdData.DataSource = null;
            this.grdData.SummaryRowsBottom.Clear();
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            EnableDisableButtons(false);
            try
            {
                int custID = 0;

                try
                {
                    if (txtSupplier.Text != "")
                        custID = Convert.ToInt32(txtSupplier.Tag.ToString());
                }
                catch { }
                //new
                dtMasters = Purchase_PRESENT.GetMasterDetails(dtpFrom.Value, dtpTo.Value, custID,cmbPurchType.Text, cmbSummaryType.SelectedValue.ToString(), Common_Var.Branch.brnId, Common_Var.Company.cmpId, dtBrnids);
            }
            catch (Exception ex)
            { }

            if (dtMasters.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");

                return;
            }

            #region setOrdinal and Sort Order
            switch (cmbSummaryType.SelectedValue.ToString())
            {
                case "BR_DT_D":
                case "BR_DT_S":
                case "BR_DT_PY_S":
                    dtMasters.Columns["Branch"].SetOrdinal(0);
                    dtMasters.Columns["Purchase Date"].SetOrdinal(1);
                    dtMasters.DefaultView.Sort = "Branch,Purchase Date";
                    break;
                case "DT_BR_D":
                case "DT_BR_S":
                case "DT_BR_PY_S":
                    dtMasters.Columns["Purchase Date"].SetOrdinal(0);
                    dtMasters.Columns["Branch"].SetOrdinal(1);
                    dtMasters.DefaultView.Sort = "Purchase Date,Branch";
                    break;
                case "BR_SU_DT_S":
                    dtMasters.Columns["Branch"].SetOrdinal(0);
                    dtMasters.Columns["Supplier"].SetOrdinal(1);
                    dtMasters.Columns["Purchase Date"].SetOrdinal(2);
                    dtMasters.DefaultView.Sort = "Branch,Supplier,Purchase Date";
                    break;
                case "DT_SU_BR_S":
                    dtMasters.Columns["Purchase Date"].SetOrdinal(0);
                    dtMasters.Columns["Supplier"].SetOrdinal(1);
                    dtMasters.Columns["Branch"].SetOrdinal(2);
                    dtMasters.DefaultView.Sort = "Purchase Date,Supplier,Branch";
                    break;
                case "BR_S":
                    dtMasters.Columns["Branch"].SetOrdinal(0);
                    dtMasters.DefaultView.Sort = "Branch";
                    break;
            }
            #endregion

            grdData.DataSource = dtMasters;

            #region FormatGrid
   

            switch (cmbSummaryType.SelectedValue.ToString())
            {
                

                case "BR_DT_D":
                case "DT_BR_D":
                    
                    grdData.Columns["Prch_ID"].IsVisible = false;
                    grdData.Columns["SupplierID"].IsVisible = false;
                    grdData.Columns["BrnID"].IsVisible = false;

                    grdData.Columns["Branch"].Width = 150;
                    grdData.Columns["Purchase Date"].Width = 80;
                    grdData.Columns["Doc No"].Width = 60;
                    grdData.Columns["Inv No"].Width = 60;
                    grdData.Columns["Inv Date"].Width = 80;
                    grdData.Columns["Supplier"].Width = 200;
                    grdData.Columns["Gross Amount"].Width = 90;
                    grdData.Columns["Tax Amount"].Width = 90;
                    grdData.Columns["Discount"].Width = 90;
                    grdData.Columns["RoundOff"].Width = 90;
                    grdData.Columns["Bill Amount"].Width = 90;

                    grdData.Columns["Branch"].AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells;

                    break;
                case "BR_DT_S":
                case "DT_BR_S":
                    grdData.Columns["BrnID"].IsVisible = false;

                    grdData.Columns["Branch"].Width = 150;
                    grdData.Columns["Purchase Date"].Width = 80;
                    grdData.Columns["Gross Amount"].Width = 90;
                    grdData.Columns["Tax Amount"].Width = 90;
                    grdData.Columns["Discount"].Width = 90;
                    grdData.Columns["RoundOff"].Width = 90;
                    grdData.Columns["Bill Amount"].Width = 90;

                    grdData.Columns["Branch"].AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells;

                    break;
                case "BR_SU_DT_S":
                case "DT_SU_BR_S":
                    grdData.Columns["SupplierID"].IsVisible = false;
                    grdData.Columns["BrnID"].IsVisible = false;

                    grdData.Columns["Branch"].Width = 150;
                    grdData.Columns["Purchase Date"].Width = 80;
                    grdData.Columns["Supplier"].Width = 200;
                    grdData.Columns["Gross Amount"].Width = 90;
                    grdData.Columns["Tax Amount"].Width = 90;
                    grdData.Columns["Discount"].Width = 90;
                    grdData.Columns["RoundOff"].Width = 90;
                    grdData.Columns["Bill Amount"].Width = 90;

                    grdData.Columns["Branch"].AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells;

                    break;
                case "BR_S":

                    grdData.Columns["BrnID"].IsVisible = false;

                    grdData.Columns["Branch"].Width = 150;
                    grdData.Columns["Gross Amount"].Width = 90;
                    grdData.Columns["Tax Amount"].Width = 90;
                    grdData.Columns["Discount"].Width = 90;
                    grdData.Columns["RoundOff"].Width = 90;
                    grdData.Columns["Bill Amount"].Width = 90;

                    grdData.Columns["Branch"].AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells;

                    break;
                case "PRCH_DTL":

                    grdData.Columns["Ratio"].IsVisible = false;
                    grdData.Columns["TI_BDiscPer"].IsVisible = false;
                    grdData.Columns["TI_BDiscAmount"].IsVisible = false;
                    grdData.Columns["TI_BBillDiscAmount"].IsVisible = false;
                    grdData.Columns["TI_ADiscPer"].IsVisible = false;
                    grdData.Columns["TI_ADiscAmount"].IsVisible = false;
                    grdData.Columns["Request Status"].IsVisible = false;
                    grdData.Columns["Entry Date"].IsVisible = false;
                    grdData.Columns["Last Modified"].IsVisible = false;

                    grdData.Columns["Branch"].Width = 150;
                    grdData.Columns["Taxable Amount"].Width = 90;
                    grdData.Columns["Tax Amount"].Width = 90;
                    grdData.Columns["Total"].Width = 90;

                    grdData.Columns["Branch"].AutoSizeMode = Telerik.WinControls.UI.BestFitColumnMode.DisplayedCells;
                    break;
            }
            #endregion
            try
            {
                if (cmbSummaryType.SelectedValue.ToString() == "PRCH_DTL")
                {
                    GridViewSummaryItem sumGross = new GridViewSummaryItem();
                    sumGross.Name = "Taxable Amount";
                    sumGross.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumTax = new GridViewSummaryItem();
                    sumTax.Name = "Tax Amount";
                    sumTax.Aggregate = GridAggregateFunction.Sum;

                    //GridViewSummaryItem sumDisc = new GridViewSummaryItem();
                    //sumDisc.Name = "Discount";
                    //sumDisc.Aggregate = GridAggregateFunction.Sum;

                    //GridViewSummaryItem sumRoff = new GridViewSummaryItem();
                    //sumRoff.Name = "RoundOff";
                    //sumRoff.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumBillAmt = new GridViewSummaryItem();
                    sumBillAmt.Name = "Total";
                    sumBillAmt.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                    summaryRowItem.Add(sumGross);
                    summaryRowItem.Add(sumTax);
                    //summaryRowItem.Add(sumDisc);
                    //summaryRowItem.Add(sumRoff);
                    summaryRowItem.Add(sumBillAmt);
                    this.grdData.SummaryRowsBottom.Add(summaryRowItem);
                }
                else
                {
                    GridViewSummaryItem sumGross = new GridViewSummaryItem();
                    sumGross.Name = "Gross Amount";
                    sumGross.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumTax = new GridViewSummaryItem();
                    sumTax.Name = "Tax Amount";
                    sumTax.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumDisc = new GridViewSummaryItem();
                    sumDisc.Name = "Discount";
                    sumDisc.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumRoff = new GridViewSummaryItem();
                    sumRoff.Name = "RoundOff";
                    sumRoff.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryItem sumBillAmt = new GridViewSummaryItem();
                    sumBillAmt.Name = "Bill Amount";
                    sumBillAmt.Aggregate = GridAggregateFunction.Sum;

                    GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
                    summaryRowItem.Add(sumGross);
                    summaryRowItem.Add(sumTax);
                    summaryRowItem.Add(sumDisc);
                    summaryRowItem.Add(sumRoff);
                    summaryRowItem.Add(sumBillAmt);
                    this.grdData.SummaryRowsBottom.Add(summaryRowItem);
                }
            }
            catch { }
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            EnableDisableButtons(true);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtMasters.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
                return;
            }

            dsReport.Tables.Clear();

            DataTable dtHeader = new DataTable();
            string header = "",filter="";

            if (rptTag == "PURCHASE")
                header = "Purchase Statement"; //header = "Sales Statement";
            else if(rptTag == "RPTPRCHDTL")
                header = "Purchase - Detailed";
            if (txtSupplier.Text != "")
                filter = "Supplier : " + txtSupplier.Text;

            filter = filter.Trim();
            filter = filter.TrimStart('-');
            filter = filter.TrimEnd(',');

            dtHeader =Common_Methods.TableTypes.CreateDTReportHeader(header, txtBranches.Text, dtpFrom.Value.Date, dtpTo.Value.Date, filter);

            dtHeader.TableName = "dtHeader";
            dsReport.Tables.Add(dtHeader);
            dtMasters.TableName = "dtInvoice";
            dsReport.Tables.Add(dtMasters);

            switch (cmbSummaryType.SelectedValue.ToString())
            {
                case "BR_DT_D":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_BR_DT_D", 1, true);        //Completed
                    break;
                case "DT_BR_D":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_DT_BR_D", 1, true);        //Completed
                    break;
                case "BR_DT_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_BR_DT_S", 1, true);       //
                    break;
                case "DT_BR_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_DT_BR_S", 1, true);       //
                    break;
                case "BR_DT_PY_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_BR_DT_PY_S", 1, true);    //
                    break;
                case "DT_BR_PY_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_DT_BR_PY_S", 1, true);    //
                    break;
                case "BR_SU_DT_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_BR_SU_DT_S", 1, true);    //
                    break;
                case "DT_SU_BR_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_DT_SU_BR_S", 1, true);    //
                    break;
                case "BR_S":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_BR_S", 1, true);          //
                    break;
                case "PRCH_DTL":
                    Common_View.Reporintg.PrintReport(dsReport, "CRrptInvoice_Dtl", 1, true);           //
                    break;
            }
        }

        private void btnBrnLookup_Click(object sender, EventArgs e)
        {
            frmLookUp_Branch _objBranch = new frmLookUp_Branch(dtBrnids);
            _objBranch.ShowDialog();
            if (!_objBranch.isEnter)
                return;

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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dtMasters.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
            }

            dsReport.Tables.Clear();
            dtMasters.TableName = "dtMaster";
            dsReport.Tables.Add(dtMasters);

            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.ShowDialog();

            //string filepath = sfd.FileName;

            //if (File.Exists(filepath))
            //    File.Delete(filepath);

           Common_Methods.ExportDataSetToExcel(dsReport, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close() ;
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

        private void cmsMenuInvoiceRcpt_Click(object sender, EventArgs e)
        {
            int invID = 0;
            try
            {
                invID = Convert.ToInt32(grdData.CurrentRow.Cells["Inv_ID"].Value);  // grdData["Inv_ID", grdData.CurrentRow.Index].Value.ToString());                
            }
            catch
            { }

            if (invID == 0)
            {
                MessageBox.Show("Select an Invoice to Cancel");
                return;
            }

            Common_View.Reporintg.BillPrint(false, invID, Common_Var.CounterID, "INVRCPT", 1, true);
        }

        private void btnRowFilter_Click(object sender, EventArgs e)
        {
            if (grdData.ShowFilteringRow == false)
                grdData.ShowFilteringRow = true;
            else
                grdData.ShowFilteringRow = false;
        }

        private void btnHideFilter_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = false;
        }

        private void btnCloseFilter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close ? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            if (CloseValidation())
            {
                this.Dispose();
            }
            else
            {
                return;
            }
        }
        private bool CloseValidation()
        {
            return true;
        }

       

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded)
            {
                cmbDivision.DataSource = Masters_PRESENT.GetList("ITEMDIVISN", cmbDepartment.SelectedValue + "".ToString(), true, Common_Var.Company.cmpId);
            }
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded)
            {
                cmbCategory.DataSource = Masters_PRESENT.GetList("ITEMCAT", cmbDivision.SelectedValue + "".ToString(), true, Common_Var.Company.cmpId);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FrmLoaded)
            {
                cmbSubCategory.DataSource = Masters_PRESENT.GetList("ITEMSUBCAT", cmbCategory.SelectedValue + "".ToString(), true, Common_Var.Company.cmpId);

            }
        }

        private void cmbSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
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

        private void btnRemoveSupplier_Click_1(object sender, EventArgs e)
        {

            txtSupplier.Text = "";
            txtSupplier.Tag = "";
        }

        private void btnproItemSearch_Click(object sender, EventArgs e)
        {
            ArrayList lkpValues = new ArrayList();
            lkpValues =Common_View.Methods.ItemMasterLookUp();
            if (lkpValues.Count > 0)
            {
                txtItemCode.Text = lkpValues[1].ToString();
                txtItemCode.Tag = lkpValues[2].ToString();
                txtItemName.Text = lkpValues[0].ToString();
            }
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            grdData.DataSource = null;

            if (dtBrnids.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast One Branch");
                btnBrnLookup_Click(null, null);
                return;
            }

            if (this.rptTag.ToString() == "PURCHASE" || this.rptTag.ToString() == "RPTPRCHDTL")
            {
                getInvoiceData();
                EnableDisableButtons(true);
            }
            pnlFilter.Visible = false;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = true;
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

