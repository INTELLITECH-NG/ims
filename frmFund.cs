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
    public partial class frmFund : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
 
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmFund()
        {
            InitializeComponent();
        }

        private void frmFund_Load(object sender, EventArgs e)
        {

        }

        private void frmFund_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFundName.Text == "")
                {
                    MessageBox.Show("Please enter Fund Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFundName.Focus();
                    return;
                }
                if (txtcountry.Text == "")
                {
                    MessageBox.Show("Please Enter Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcountry.Focus();
                    return;
                }
                if (txtValue.Text == "")
                {
                    MessageBox.Show("Please Select City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValue.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into Fund(Fundname,Account,Platform,Value,Country,Status,AssetClass,Date,Notes) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtFundName.Text);
                cmd.Parameters.AddWithValue("@d2", txtAccount.Text);
                cmd.Parameters.AddWithValue("@d3", txtplatform.Text);
                cmd.Parameters.AddWithValue("@d4", txtValue.Text);
                cmd.Parameters.AddWithValue("@d5", txtcountry.Text);
                cmd.Parameters.AddWithValue("@d6", txtStatus.Text);
                cmd.Parameters.AddWithValue("@d7", txtAssetClass.Text);
                cmd.Parameters.AddWithValue("@d8", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d9", txtnotes.Text);
           
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Fund is Added Having FundName='" + txtFundName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmFundRecords frm = new frmFundRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb2 = "update Fund set FundName=@d3,Account=@d4,Platform=@d5,Value=@d6, Country=@d7,Status=@d8,AssetClass=@d9,Date=@d10,Notes=@d11 where id='" +textBox1.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d3", txtFundName.Text);
                cmd.Parameters.AddWithValue("@d4", txtAccount.Text);
                cmd.Parameters.AddWithValue("@d5", txtplatform.Text);
                cmd.Parameters.AddWithValue("@d6", txtValue.Text);
                cmd.Parameters.AddWithValue("@d7", txtcountry.Text);
                cmd.Parameters.AddWithValue("@d8", txtStatus.Text);
                cmd.Parameters.AddWithValue("@d9", txtAssetClass.Text);
                cmd.Parameters.AddWithValue("@d10", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d11", txtnotes.Text);
            
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Fund is Updated Sucessfully Having FundName='" + txtFundName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtcountry.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
           txtAssetClass.SelectedIndex = -1;
         txtplatform.SelectedIndex = -1;
      
            txtFundName.Text = "";
            txtValue.Text = 0.ToString();
            txtnotes.Text = "";
            txtAccount.Text = "";

            txtdate.Text = DateTime.Today.ToString();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Fund  where ID='" +textBox1.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Fund is Deleted Having FundName='" + txtFundName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
