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
    public partial class frmCompanyinfo : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmCompanyinfo()
        {
            InitializeComponent();
        }
        private void AutocompleState()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(State),rtrim(role) from Company ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtState.Items.Add(rdr[0]);
                    txtrole.Items.Add(rdr[1]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCompanyinfo_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
          //  AutocompleState();
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcompanyName.Text == "")
                {
                    MessageBox.Show("Please enter Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcompanyName.Focus();
                    return;
                }
                if (txtmob.Text == "")
                {
                    MessageBox.Show("Please Enter Mobile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmob.Focus();
                    return;
                }
                if (txtState.Text == "")
                {
                    MessageBox.Show("Please Enter State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtState.Focus();
                    return;
                }
                if (txtcountry.Text == "")
                {
                    MessageBox.Show("Please enter country Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcountry.Focus();
                    return;
                }
                if (txtRegNo.Text == "")
                {
                    MessageBox.Show("Please enter Registration No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegNo.Focus();
                    return;
                }
                if (txtstaff.Text == "")
                {
                    MessageBox.Show("Please enter No of Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtstaff.Focus();
                    return;
                }
                if (txtturnover.Text == "")
                {
                    MessageBox.Show("Please enter turnover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtturnover.Focus();
                    return;
                }

                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into company(Companyname,Regno,Role,Telephone,Fax,Mobile,city,country,State,objective,date,code,mgr,investortype,TotalAssets,peratio,fee,staff) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d16,@d17,@d18,@d19)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtcompanyName.Text);
                cmd.Parameters.AddWithValue("@d2", txtRegNo.Text);
                cmd.Parameters.AddWithValue("@d3", txtrole.Text);
                cmd.Parameters.AddWithValue("@d4", txtphone.Text);
                cmd.Parameters.AddWithValue("@d5", txtfax.Text);
                cmd.Parameters.AddWithValue("@d6", txtmob.Text);
                cmd.Parameters.AddWithValue("@d7", txtcity.Text);
                cmd.Parameters.AddWithValue("@d8", txtcountry.Text);
                cmd.Parameters.AddWithValue("@d9", txtState.Text);
                cmd.Parameters.AddWithValue("@d10", txtobjective.Text);

                cmd.Parameters.AddWithValue("@d11", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d12",txtpostalcode.Text);
                cmd.Parameters.AddWithValue("@d13", txtRelmgr.Text);
                cmd.Parameters.AddWithValue("@d14", txtinvestorType.Text);
             //  cmd.Parameters.AddWithValue("@d15", cmbSubtype.Text);
              cmd.Parameters.AddWithValue("@d16", txttotalassets.Text);
                cmd.Parameters.AddWithValue("@d17", txtperatio.Text);
               cmd.Parameters.AddWithValue("@d18", txtmgtfee.Text);
                cmd.Parameters.AddWithValue("@d19", txtstaff.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Company is Added Having Name='" + txtcompanyName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            txtcompanyName.Text = "";
          txtcountry.SelectedIndex = -1;
            txtState.SelectedIndex = -1;
            txtrole.SelectedIndex = -1;
          txtRelmgr.SelectedIndex = -1;
            txtphone.Text = "";
           txtRegNo.Text = "";
            txtfax.Text = "";
            txtmob.Text = "";
          txtcity.Text = "";
         txtState.Text= "";
            txtpostalcode.Text = "";
           txtdate.Text =DateTime.Today.ToString();
            txtobjective.Text = "";
            txtobjective.Text = "";
            txtRelmgr.SelectedIndex = -1;
          txtinvestorType.SelectedIndex = -1;
            //cmbSubtype.SelectedIndex = -1;
           txttotalassets.Text = "";
            txtmgtfee.Text = "";
            txtperatio.Text = "";
            txtturnover.Text = "";
            txtstaff.Text= "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Company where ID='" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "New Company is Deleted Having Name='" + txtcompanyName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                //GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb2 = "Update company set Companyname= '" + txtcompanyName.Text + "',regno= '" + txtRegNo.Text + "',role= '" + txtrole.Text + "',Telephone= '" + txtphone.Text + "',fax= '" + txtfax.Text + "',mobile= '" + txtmob.Text + "',city= '" + txtcity.Text + "',country= '" + txtcountry.Text + "',state= '" + txtState.Text + "',objective= '" + txtobjective.Text + "',Date= '" +txtdate.Value.Date+ "',code= '" + txtpostalcode.Text + "',mgr= '" + txtRelmgr.Text + "',investorType= '" + txtinvestorType.Text + "',totalassets= '" + txttotalassets.Text + "',Peratio= '" + txtperatio.Text + "',Fee= '" + txtmgtfee.Text + "',Staff= '" + txtstaff.Text + "' where ID = '" + txtID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Company is Updated Having Name='" + txtcompanyName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }

        private void frmCompanyinfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCompanyRecords frm = new frmCompanyRecords();
            frm.SETS.Text = "CS";
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void txtmgtfee_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
