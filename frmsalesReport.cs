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
    public partial class frmsalesReport : Form
    {
        Connectionstring cs = new Connectionstring();
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       
        public frmsalesReport()
        {
            InitializeComponent();
        }
        private void Autocompleclient()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(FirstName) from Client,investment,sales where client.ID=investment.ClientID and investment.inv_id=sales.investmentid  ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbclientname.Items.Add(rdr[0]);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Autocomplete()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(UserID) from Client,investment,sales where client.ID=investment.ClientID and investment.inv_id=sales.investmentid  ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbClientID.Items.Add(rdr[0]);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                Rptsales1 rpt = new Rptsales1();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.
              

                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from investment,client,sales where client.id=investment.clientid and investment.inv_ID=sales.investmentid and client.FirstName = '" + cmbclientname.Text + "' ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "investment");
                myDA.Fill(myDS, "client");
                myDA.Fill(myDS, "sales");
                rpt.SetDataSource(myDS);

                crystalReportViewer1.ReportSource = rpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void R1()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                Rptsales rpt = new Rptsales();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from investment,client,sales where client.id=investment.clientid and investment.inv_ID=sales.investmentid";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "investment");
                myDA.Fill(myDS, "client");
                myDA.Fill(myDS, "sales");
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

        private void frmsalesReport_Load(object sender, EventArgs e)
        {
            Autocompleclient();
            Autocomplete();
            R1();

        }
        public void R2()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                Rptsales rpt = new Rptsales();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.
                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from investment,client,sales where client.id=investment.clientid and investment.inv_ID=sales.investmentid and sales.Date between @date1 and @date2 order by sales.Date";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = Date_from.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = Date_to.Value.Date;
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "investment");
                myDA.Fill(myDS, "client");
                myDA.Fill(myDS, "sales");
                rpt.SetDataSource(myDS);
                crystalReportViewer2.ReportSource = rpt;
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            R2();  
        }

        private void frmsalesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = label12.Text;
            frm.UserType.Text = label13.Text;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbclientname.Text = "";
           crystalReportViewer1.ReportSource = null;
           R1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          Date_from.Text = System.DateTime.Today.ToString();
           Date_to.Text = System.DateTime.Today.ToString();
           crystalReportViewer2.ReportSource = null;
          
        }

        private void cmbclientname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                Rptsales1 rpt = new Rptsales1();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                DataSet myDS = new DataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBcon);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from investment,client,sales where client.id=investment.clientid and investment.inv_ID=sales.investmentid and client.UserID = '" + cmbClientID.Text + "' ";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "investment");
                myDA.Fill(myDS, "client");
                myDA.Fill(myDS, "sales");
                rpt.SetDataSource(myDS);
                crystalReportViewer3.ReportSource = rpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
