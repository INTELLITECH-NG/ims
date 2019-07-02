using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CRM
{
    public partial class frminvestmentReport : Form
    {
        Connectionstring cs = new Connectionstring();
        public frminvestmentReport()
        {
            InitializeComponent();
        }

        private void frminvestmentReport_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                RptInvestment rpt = new RptInvestment();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select Client.ID, Investment.Inv_ID, UserID,FirstName,LastName,ClientType,HStreet,HCity,Hstate,Hzip,Hcountry,IDtype,IDNo,Expdate,Telephone,mobile,FaxNo,Email,WStreet,WCity,Wstate,Wzip,Wcountry,Password,Clientofficers,interestlevel,MoneyCommited,Secetory,Picture,Icountry,Categorization,Bowner,Directors,Date,investmenttype,AssetType,Goal,Sector,unitprice,Shares,Total,Currency,ClientID,Cusip from investment,client where client.id=investment.clientid";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "investment");
                myDA.Fill(myDS, "client");
                rpt.SetDataSource(myDS);

                crystalReportViewer1.ReportSource = rpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void frminvestmentReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
    }
}
