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

namespace Berri_X1_Reports.Not_used
{
    public partial class rptHeader : Form
    {
        public rptHeader()
        {
            InitializeComponent();
        }
        DataTable dtAddress = new DataTable();
        private void GetData()
        {
            grdData.DataSource = null;
            dtAddress = new DataTable();
            
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Common_Connection.ConnString_Cloud);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("psp_REPORT_HEADER", sqlConnection);
                //sqlCommand.Parameters.Add(new SqlParameter("@branchid", ));
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtAddress); 
                grdData.DataSource = dtAddress;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtAddress.Rows.Count <= 0)
            {
                MessageBox.Show("No Data");
                return;
            }

            DataSet dsReport = new DataSet();
            dsReport.Tables.Clear();
            DataTable dtrpt = dtAddress.Copy();
            dtrpt.TableName = "dtAddress";
            dsReport.Tables.Add(dtrpt);
            Common_View.Reporintg.PrintReport(dsReport, "CRrptReportHeader", 1, true);
        }
    }
}
