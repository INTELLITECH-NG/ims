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
    public partial class frmRegisteredUsersRecord : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();

        Connectionstring cs = new Connectionstring();
        public frmRegisteredUsersRecord()
        {
            InitializeComponent();
        }
        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBcon);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }

        public void GetData1()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(userType) as [User Type], id, RTRIM(UserID) [User ID],RTRIM(Password)[Password],RTRIM(Name)[Name],RTRIM(Contact_No)[Contact No.],RTRIM(Email)[Email],Rtrim(date_of_joining) as [Date_of_joining] FROM user_registration where usertype = '" + usertype.Text + "' order by UserID", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Grid()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }
        public void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(userType) as [User Type],id, RTRIM(UserID) [User ID],RTRIM(Password)[Password],RTRIM(Name)[Name],RTRIM(Contact_No)[Contact No.],RTRIM(Email)[Email],Rtrim(date_of_joining) as [Date_of_joining] FROM user_registration order by UserID", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Fill()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct1 = "SELECT distinct RTRIM(UserType) FROM user_Registration ";
                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    usertype.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegisteredUsersRecord_Load(object sender, EventArgs e)
        {
           GetData();
            Fill();
          }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData1();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
           frmUserRegistration frm = new frmUserRegistration();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.cmbUsertype.Text = dr.Cells[0].Value.ToString();
            frm.txtID.Text = dr.Cells[1].Value.ToString();
            frm.UserID.Text = dr.Cells[2].Value.ToString();

            frm.txtPassword.Text = dr.Cells[3].Value.ToString();
            frm.txtUserName.Text = dr.Cells[4].Value.ToString();
            frm.txtContact_no.Text = dr.Cells[5].Value.ToString();
            frm.txtEmail_Address.Text = dr.Cells[6].Value.ToString();


            //frm.lblUser.Text = lblUser.Text;
            //frm.lblUserType.Text = lblUserType.Text;
            frm.btnDelete.Enabled = true;
            frm.button1.Enabled = true;
            frm.btnRegister.Enabled = false;
            frm.UserID.Focus();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void frmRegisteredUsersRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
        }
    }
}
