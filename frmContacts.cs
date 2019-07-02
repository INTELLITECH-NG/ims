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
    public partial class frmContacts : Form
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
        public frmContacts()
        {
            InitializeComponent();
        }

        private void auto()
        {
            txtID.Text = "C-" + GetUniqueKey(2);
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

        private void frmContacts_Load(object sender, EventArgs e)
        {
            FillCombo1();
          
        }
        public void FillCombo1()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "SELECT distinct RTRIM(CompanyName) FROM Company";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   txtcompany.Items.Add(rdr[0]);
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

                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    return;
                }
                if (txtCountry.Text == "")
                {
                    MessageBox.Show("Please Enter Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCountry.Focus();
                    return;
                }
                if (txtCity.Text == "")
                {
                    MessageBox.Show("Please Select City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCity.Focus();
                    return;
                }
                if (txtState.Text == "")
                {
                    MessageBox.Show("Please enter State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtState.Focus();
                    return;
                }
                if (txtmob.Text == "")
                {
                    MessageBox.Show("Please enter State", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmob.Focus();
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into contact(ID,Contactname,mob,Postalcode,City,Country,State,Title,Role,Notes,Company) VALUES ('"+txtID.Text+"',@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtName.Text);
                cmd.Parameters.AddWithValue("@d2", txtmob.Text);
                cmd.Parameters.AddWithValue("@d3", txtpostalcode.Text);
                cmd.Parameters.AddWithValue("@d4", txtCity.Text);
                cmd.Parameters.AddWithValue("@d5", txtCountry.Text);
                cmd.Parameters.AddWithValue("@d6", txtState.Text);
                cmd.Parameters.AddWithValue("@d7", txtTitle.Text);
                cmd.Parameters.AddWithValue("@d8", txtRole.Text);
                cmd.Parameters.AddWithValue("@d9", txtNotes.Text);
                cmd.Parameters.AddWithValue("@d10", txtcompany.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Contact is Added Having ContactName='" + txtName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

                btnSave.Enabled = false;
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
                string cb2 = "Update Contact set Contactname= '" + txtName.Text + "',mob= '" + txtmob.Text + "',Postalcode= '" + txtpostalcode.Text + "',City= '" + txtCity.Text + "',Country= '" + txtCountry.Text + "',State= '" + txtState.Text + "',Title= '" + txtTitle.Text + "',Role= '" + txtRole.Text + "',Notes= '" + txtNotes.Text + "',Company= '" + txtcompany.Text + "' where ID = '" + txtID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "New Contact is Update Having ContactName='" + txtName.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            txtcompany.SelectedIndex = -1;
            txtCountry.Text  = "";
            txtState.SelectedIndex = -1;
            txtRole.SelectedIndex = -1;
            txtTitle.SelectedIndex = -1;
            txtCountry.Text = "";
            txtCity.Text = "";

            txtTitle.Text = "";
         txtRole.Text = "";
            txtmob.Text = "";
            txtName.Text = "";
            txtNotes.Text = "";
            txtpostalcode.Text = "";
            txtmob.Text = "";
            txtID.Text = "";

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
                string cq1 = "delete from Contact  where ID='" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "New Contact is Deleted Having ContactName='" + txtName.Text + "'";
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

        private void frmContacts_FormClosing(object sender, FormClosingEventArgs e)
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
            frmContactRecords frm = new frmContactRecords();
            frm.SET.Text = "CS";
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtcompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
