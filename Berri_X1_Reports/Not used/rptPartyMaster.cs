using Berri_X1_DLL;
using Berri_X1_UI_Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Berri_X1_Reports.Reports
{
    public partial class rptPartyMaster : Form
    {
        public rptPartyMaster()
        {
            InitializeComponent();
        }

        DataTable dtPartyMaster = new DataTable();
        DataTable dtBrnids = new DataTable();

        private void Getdata()
        {
            grdData.DataSource = null;

            if (dtBrnids.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast One Branch");
                btnBrnLookup_Click(null, null);
                return;
            }

            dtPartyMaster = new DataTable();
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("psp_Report_PartyMaster_Details", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] values =  
                {
                    new SqlParameter("@partytype", cmbPartyType.Text),
                    //new SqlParameter("@branchname", txtBranches.Text),
                    //new SqlParameter("@branchid", txtBranches.Tag),
                    new SqlParameter("@branchids", dtBrnids),
                    new SqlParameter("@party", cmbParty.Text)
                };
                sqlCommand.Parameters.AddRange(values);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtPartyMaster);

                grdData.DataSource = dtPartyMaster;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Getdata();
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

            //if (_objBranch.dtBranches.Rows.Count > 0)
            //{
            //    txtBranches.Text = _objBranch.dtBranches.Rows[0]["BrnName"].ToString();
            //    txtBranches.Tag = _objBranch.dtBranches.Rows[0]["BrnID"].ToString();
            //}

            string branches = "";

            for (int i = 0; i < dtBrnids.Rows.Count; i++)
            {
                branches += ", " + dtBrnids.Rows[i]["BrnName"];
            }

            branches = branches.TrimStart(',');
            branches = branches.Trim();

            txtBranches.Text = branches;

            if (dtBrnids.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Atleast One Branch");
                btnBrnLookup_Click(null, null);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Close?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dtPartyMaster.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
                return;
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Clear();
            DataTable dtrpt = dtPartyMaster.Copy();

            dsReport.Tables.Add(dtrpt);

            Common_View.Reporintg.PrintReport(dsReport, "CRrptPartyMaster", 1, true);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            btnFilter.Text = pnlTop.Visible ? "Hide Filter" : "Show Filter";
        }
    }
}   
