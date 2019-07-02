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

namespace CRM
{
    public partial class frmcontactReport : Form
    {
          Connectionstring cs = new Connectionstring();
        public frmcontactReport()
        {
            InitializeComponent();
        }

        private void frmcontactReport_Load(object sender, EventArgs e)
        {
             try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
               Rptcontact rpt = new Rptcontact();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CRM_DBDataSet myDS = new CRM_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select *  from Contact ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Contact");
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

        private void frmcontactReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
    }
}
