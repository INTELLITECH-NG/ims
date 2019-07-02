using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM
{
    public partial class frmMainMenu : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmContacts frm = new frmContacts();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmClient frm = new frmClient();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;


            frm.Show();
        }

        private void fundManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
           frmFund frm = new frmFund();

           frm.lblUser.Text = User.Text;
           frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void invToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmInvestment frm = new frmInvestment();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActivity frm = new frmActivity();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void complaintAndSuggestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

           this.Hide();
           frmSuggestions frm = new frmSuggestions();
           frm.lblUser.Text = User.Text;
           frm.lblUserType.Text = UserType.Text;
           frm.Show();
        }

        private void companyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCompanyinfo frm = new frmCompanyinfo();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void registrationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserRegistration frm = new frmUserRegistration();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.progressBar1.Visible = false;
            frm.cmbUsertype.Focus();
            this.Hide();
        }
      
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
      
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmUserRegistration frm = new frmUserRegistration();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void contactsProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmContacts frm = new frmContacts();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void clientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmClient frm = new frmClient();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void fundManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmFund frm = new frmFund();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void investmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmInvestment frm = new frmInvestment();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActivity frm = new frmActivity();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void complaintBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmSuggestions frm = new frmSuggestions();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.progressBar1.Visible = false;
            frm.cmbUsertype.Focus();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            timer1.Enabled = false;
            Time.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmSales frm = new frmSales();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSales frm = new frmSales();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;

            frm.Show();
        }

        private void complaintBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuggestions frm = new frmSuggestions();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\CRM_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\CRM_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
               
                MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;
                _with1.Filter = ("DB Backup File|*.bak;");
                _with1.FilterIndex = 4;
                //Clear the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer1.Enabled = true;
                    SqlConnection.ClearAllPools();
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] SET Multi_User ";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            
            AboutBox1 frm = new AboutBox1();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;
            timer2.Enabled = false;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogs frm = new frmLogs();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogs frm = new frmLogs();

            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                if ((!System.IO.Directory.Exists("C:\\DBBackup")))
                {
                    System.IO.Directory.CreateDirectory("C:\\DBBackup");
                }
                string destdir = "C:\\DBBackup\\CRM_DB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "backup database [" + System.Windows.Forms.Application.StartupPath + "\\CRM_DB.mdf] to disk='" + destdir + "'with init,stats=10";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;
                _with1.Filter = ("DB Backup File|*.bak;");
                _with1.FilterIndex = 4;
                //Clear the file name
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Cursor = Cursors.WaitCursor;
                    timer1.Enabled = true;
                    SqlConnection.ClearAllPools();
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    string cb = "USE Master ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] SET Single_User WITH Rollback Immediate Restore database [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] FROM disk='" + openFileDialog1.FileName + "' WITH REPLACE ALTER DATABASE [" + System.Windows.Forms.Application.StartupPath + "\\CRM_db.mdf] SET Multi_User ";
                    cmd = new SqlCommand(cb);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            frmProfit frm = new frmProfit();
           frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
              frm.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
          
            frmProfit frm = new frmProfit();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.lblUser.Text = User.Text;
            frm.lblUserType.Text = UserType.Text;
            frm.Show();
        }

        private void activityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActivitiesRecords frm = new frmActivitiesRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void clientRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientRecords frm = new frmClientRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void complaintsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmComplaintRecords frm = new frmComplaintRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeRecords frm = new frmEmployeeRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void contactRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmContactRecords frm = new frmContactRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void investmentRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmInvestmentRecords frm = new frmInvestmentRecords();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void salesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
                 frmSalesRecord frm = new frmSalesRecord();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeReport frm = new frmEmployeeReport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcontactReport frm = new frmcontactReport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void clientToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmclientReport frm = new frmclientReport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void investmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frminvestmentReport frm = new frminvestmentReport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
          frmsalesReport frm = new frmsalesReport();
          frm.label12.Text = UserType.Text;
          frm.label13.Text = User.Text;
          frm.ShowDialog();
        }

        private void clientsDeclarationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientDeclaration frm = new frmClientDeclaration();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.ShowDialog();
        }

        private void clientFeedBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
          frmFeedbackForm1 frm = new frmFeedbackForm1();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmEmployee frm = new frmEmployee();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void profileEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmEmployee frm = new frmEmployee();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void financialProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
          frmFinancialProfile frm = new frmFinancialProfile();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void investmentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmObjectiveReport frm = new frmObjectiveReport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDashboard frm = new frmDashboard();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void knowlegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmKnowledgereport frm = new frmKnowledgereport();
            frm.lblUserType.Text = UserType.Text;
            frm.lblUser.Text = User.Text;
            frm.Show();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            frm.UserID.Text = "";
            frm.Password.Text = "";
            frm.progressBar1.Visible = false;
            frm.cmbUsertype.Focus();
            this.Hide();
        }

    }
}
