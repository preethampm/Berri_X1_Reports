using Berri_X1_DLL;
using Berri_X1_MODEL;
using Berri_X1_Reports.Not_used;
using Berri_X1_Reports.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Berri_X1_Reports
{
    public partial class MainFrom : Form
    {
        private int childFormNumber = 0;

        public MainFrom()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptPurchaseReports rptprch = new rptPurchaseReports();
            rptprch.MdiParent = this;
            rptprch.rptTag = "PURCHASE";
            rptprch.StartPosition = FormStartPosition.CenterScreen;
            rptprch.Show();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            bool failed = false;
            bool cloudConSettings = false;
            bool branchConSettings = false;
            bool posConSettings = false;
            bool centralConSettings = false;
            //dbCon.Updates();
            //break;

            cloudConSettings = Common_Connection.getConnectionValues("CLOUD");
            branchConSettings = Common_Connection.getConnectionValues("BRANCH");
            posConSettings = Common_Connection.getConnectionValues("POS");
            centralConSettings = Common_Connection.getConnectionValues("CENTRAL");

            setCounterBrnID();

            if (Common_Var.CounterID > 0)
            {
                CounterMaster_MODEL objCounter = new CounterMaster_MODEL();
                objCounter = CounterMaster_PRESENT.Get(Common_Var.CounterID, Common_Var.Branch.brnId);
                if (objCounter.CMPID == 0 || objCounter.BRNID == 0 || objCounter.CMPID == 0)
                {
                    MessageBox.Show("                             Invalid Counter  !                             ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                Common_Var.Company.cmpId = objCounter.CMPID;
                Common_Var.MachineName = objCounter.MachineName;
                Common_Var.CounterCode = objCounter.CounterCode;
                Common_Var.SyncMode = objCounter.SyncMode;

                switch (Common_Var.SyncMode)
                {
                    case "CLOUD":
                        Common_Connection.ConnString_Sync_Remote = Common_Connection.ConnString_Cloud;
                        Common_Connection.ConnString_Sync_Local = Common_Connection.ConnString_Branch;
                        break;
                    case "BRANCH":
                        Common_Connection.ConnString_Sync_Remote = Common_Connection.ConnString_Branch;
                        Common_Connection.ConnString_Sync_Local = Common_Connection.ConnString_POS;
                        break;
                    case "NONE":
                        Common_Connection.ConnString_Sync_Remote = Common_Connection.ConnString_POS;
                        Common_Connection.ConnString_Sync_Local = Common_Connection.ConnString_POS;
                        break;
                    default:
                        Common_Connection.ConnString_Sync_Remote = Common_Connection.ConnString_POS;
                        Common_Connection.ConnString_Sync_Local = Common_Connection.ConnString_POS;
                        break;
                }

                Common_Methods.getCompanyDetails(Common_Var.Company.cmpId);
                Common_Methods.setCounterBrnID();

                setBranchDetails(Common_Var.Branch.brnId);
                setHODetails(Common_Var.Company.cmpId);
                setFinancialYear(Common_Var.Branch.brnId, Common_Var.Company.cmpId);

                Common_Var.isActivated = true;
            }
        }
        public static int setCounterBrnID()
        {
            int cntID = 0;
            try
            {
                using (StreamReader gsSR = new StreamReader(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\erp.config.sys"))
                {
                    Common_Var.CounterID = Convert.ToInt32(gsSR.ReadLine().Trim());
                    Common_Var.Branch.brnId = Convert.ToInt32(gsSR.ReadLine().Trim());
                    Common_Var.loginBRNID = Common_Var.Branch.brnId;
                    gsSR.Dispose();
                }
            }
            catch
            { }
            return cntID;
        }

        public static void setBranchDetails(int BRNID)
        {
            Common_Var.Branch = Branch_PRESENT.Get(BRNID);
            Common_Var.BrnAddress = AllAddress_PRESENT.Get(Common_Var.Branch.brnAddressID);

        }
        public static void setHODetails(int _cmpID)
        {
            int hoID = 0;

            hoID = Branch_PRESENT.GetHOid(Common_Var.Company.cmpId);

            Common_Var.Branch = Branch_PRESENT.Get(hoID);
            Common_Var.BrnAddress = AllAddress_PRESENT.Get(Common_Var.Branch.brnAddressID);

        }
        public static void setFinancialYear(int _brnid, int _cmpid)
        {
            FinancialYear_MODEL _objFin = new FinancialYear_MODEL();
            _objFin = FinancialYear_PRESENT.GetCurrentFinYear(_brnid, _cmpid);

            Common_Connection.FinYearID = _objFin.FY_ID;

            Common_Connection.COFinYearID = _objFin.FY_COFinID;
            Common_Connection.FinYearStartDate = _objFin.FY_StartDate;
            Common_Connection.FinYearEndDate = _objFin.FY_EndDate;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    rptSettings rptset =new rptSettings();
        //    rptset.MdiParent = this;
        //    rptset.StartPosition = FormStartPosition.CenterParent;
        //    rptset.Show();
        //}

        //private void partyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    rptPartyMaster rptpm = new rptPartyMaster();
        //    rptpm.MdiParent = this;
        //    rptpm.StartPosition = FormStartPosition.CenterParent;   
        //    rptpm.Show();
        //}

        //private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    rptDailySales rptdaily = new rptDailySales();
        //    rptdaily.MdiParent = this;
        //    rptdaily.StartPosition = FormStartPosition.CenterParent;
        //    rptdaily.Show();
        //}

        //private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    rptItemDetails rptitemdetails = new rptItemDetails();
        //    rptitemdetails.MdiParent = this;
        //    rptitemdetails.StartPosition = FormStartPosition.CenterParent; 
        //    rptitemdetails.Show();
        //}

        private void supplierProductListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptProductList rptproductlist = new rptProductList();
            rptproductlist.MdiParent = this;
            rptproductlist.StartPosition = FormStartPosition.CenterParent;
            rptproductlist.Show();
        }

        private void purchaseDepartmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptPurchaseDepartmentSummaryReport rptPurchaseDepartmentSummaryReport = new rptPurchaseDepartmentSummaryReport();
            rptPurchaseDepartmentSummaryReport.MdiParent = this;
            rptPurchaseDepartmentSummaryReport.StartPosition = FormStartPosition.CenterParent;
            rptPurchaseDepartmentSummaryReport.Show();
        }

        private void productSalesDivisonWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptProductSalesSummaryReport rptProductSales = new rptProductSalesSummaryReport();
            rptProductSales.MdiParent = this;
            rptProductSales.StartPosition = FormStartPosition.CenterParent;
            rptProductSales.Show();
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptDailySalesReport rptDailySales = new rptDailySalesReport();
            rptDailySales.MdiParent = this;
            rptDailySales.StartPosition = FormStartPosition.CenterParent;
            rptDailySales.Show();
        }

        private void withGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptProductSalesSummaryReport rptProductSales = new rptProductSalesSummaryReport();
            rptProductSales.Tag = "GP";
            rptProductSales.MdiParent = this;
            rptProductSales.StartPosition = FormStartPosition.CenterParent;
            rptProductSales.Show();
        }

        private void withoutGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptProductSalesSummaryReport rptProductSales = new rptProductSalesSummaryReport();
            rptProductSales.Tag = "WOGP";
            rptProductSales.MdiParent = this;
            rptProductSales.StartPosition = FormStartPosition.CenterParent;
            rptProductSales.Show();
        }

        private void periodicSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptPeriodicSalesReport rptPeriodicSales = new rptPeriodicSalesReport();
            rptPeriodicSales.MdiParent = this;
            rptPeriodicSales.StartPosition = FormStartPosition.CenterParent;
            rptPeriodicSales.Show();
        }
    }
}
