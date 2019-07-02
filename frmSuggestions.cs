using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CRM
{
    public partial class frmSuggestions : Form
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
        public frmSuggestions()
        {
            InitializeComponent();
        }
        private void auto()
        {
            txtID.Text = "C-" + GetUniqueKey(5);
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void frmSuggestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
       

        private void frmSuggestions_Load(object sender, EventArgs e)
        {
            Autocomplete();

            if(lblUserType.Text == "")
            {
               btnSave.Enabled = true;
             }
            else
            {
                btnSave.Enabled = false;
            }
        }
        private void Autocomplete()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(ID) from Client where userID='"+lblUser.Text+"' ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                  txtclientID.Text = rdr.GetValue(0).ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnotes.Text == "")
                {
                    MessageBox.Show("Please Enter Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnotes.Focus();
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into complaint(ID,ClientID,Notes,Date) VALUES (@d1,@d2,@d3,@d4)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtID.Text);
                cmd.Parameters.AddWithValue("@d2", txtclientID.Text);
                cmd.Parameters.AddWithValue("@d3", txtnotes.Text);
                cmd.Parameters.AddWithValue("@d4", txtDate.Value.Date);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Complaint is Registered Sucessfully Having Complaint ID='" + txtID.Text + "'";
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
            frmComplaintRecords frm = new frmComplaintRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.SET.Text = "CS";
            frm.Show();
        }
    }
}
