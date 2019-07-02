using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace CRM
{
    public partial class frmInvestment : Form
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
        public frmInvestment()
        {
            InitializeComponent();
        }
        private void auto()
        {
            ID.Text = "I-" + GetUniqueKey(5);
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
        private void frmInvestment_Load(object sender, EventArgs e)
        {
            Autocompleclient();
            txtClientID.Focus();
        }
        private void Reset()
        {
            txtclientname.Text = "";
           txtClientID.SelectedIndex = -1;
            txtinvestmentType.SelectedIndex = -1;
            txtcurrency.SelectedIndex = -1;
            txtgoal.SelectedIndex = -1;
            txtsector.SelectedIndex = -1;
            txtassettype.SelectedIndex = -1;
            txtprice.Text =0.ToString();
            txtShares.Text =0.ToString();
           txtTotal.Text = 0.ToString();
          txtCUSIPNumber.Text = "";
           txtinvestmentType.Text = "";

            txtdate.Text = DateTime.Today.ToString();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void Autocompleclient()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(userid) from Client ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                  txtClientID.Items.Add(rdr[0]);
             
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
                if (txtClientID.Text == "")
                {
                    MessageBox.Show("Please Select Client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClientID.Focus();
                    return;
                }
                if (txtassettype.Text == "")
                {
                    MessageBox.Show("Please Enter Asset Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtassettype.Focus();
                    return;
                }
                if (txtgoal.Text == "")
                {
                    MessageBox.Show("Please Select Goal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtgoal.Focus();
                    return;
                }
                if (txtsector.Text == "")
                {
                    MessageBox.Show("Please Select Sectors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtsector.Focus();
                    return;
                }
                if (txtShares.Text == "")
                {
                    MessageBox.Show("Please Enter Shares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtShares.Focus();
                    return;
                }
                if (txtprice.Text == "")
                {
                    MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtprice.Focus();
                    return;
                }
                auto();
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into investment(inv_ID,Date,investmenttype,AssetType,Goal,Sector,unitprice,Shares,Total,Currency,ClientID,Cusip) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1",ID.Text);
                cmd.Parameters.AddWithValue("@d2", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d3", txtinvestmentType.Text);
                cmd.Parameters.AddWithValue("@d4", txtassettype.Text);
                cmd.Parameters.AddWithValue("@d5", txtgoal.Text);
                cmd.Parameters.AddWithValue("@d6", txtsector.Text);
                cmd.Parameters.AddWithValue("@d7", txtprice.Text);
                cmd.Parameters.AddWithValue("@d8", txtShares.Text);
                cmd.Parameters.AddWithValue("@d9", txtTotal.Text);
                cmd.Parameters.AddWithValue("@d10", txtcurrency.Text);
                cmd.Parameters.AddWithValue("@d11", textBox1.Text);
                cmd.Parameters.AddWithValue("@d12", txtCUSIPNumber.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = " New Investment is Done by Client='" + txtclientname.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtcurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtClientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Firstname,UserID,ID FROM client where  UserID = '" + txtClientID.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                  txtclientname.Text = rdr.GetString(0).Trim();
                  textBox1.Text = rdr.GetInt32(2).ToString().Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtShares_TextChanged(object sender, EventArgs e)
        {
            decimal val1 = 0;
           decimal val2 = 0;
            decimal val3 = 0;
           decimal.TryParse(txtprice.Text, out val1);
            decimal.TryParse(txtShares.Text, out val2);
            decimal.TryParse(txtTotal.Text, out val3);

            decimal I = (val1 * val2);

            txtTotal.Text =I.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmInvestment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            decimal val1 = 0;
            decimal val2 = 0;
            decimal val3 = 0;
            decimal.TryParse(txtprice.Text, out val1);
            decimal.TryParse(txtShares.Text, out val2);
            decimal.TryParse(txtTotal.Text, out val3);

            decimal I = (val1 * val2);

            txtTotal.Text = I.ToString();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            this.Hide();
          frmInvestmentRecords  frm = new frmInvestmentRecords();
          frm.SET.Text = "CS";
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

                string cb2 = "update Investment set Date=@d3,InvestmentType=@d4,CUSIP=@d5,AssetType=@d6, Goal=@d7,Sector=@d8,UnitPrice=@d9,Shares=@d10,Total=@d11,Currency=@d12,ClientID=@d13 where inv_id='" + ID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d3", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d4", txtinvestmentType.Text);
                cmd.Parameters.AddWithValue("@d5", txtCUSIPNumber.Text);
                cmd.Parameters.AddWithValue("@d6", txtassettype.Text);
                cmd.Parameters.AddWithValue("@d7", txtgoal.Text);
                cmd.Parameters.AddWithValue("@d8", txtsector.Text);
                cmd.Parameters.AddWithValue("@d9", txtprice.Text);
                cmd.Parameters.AddWithValue("@d10", txtShares.Text);
                cmd.Parameters.AddWithValue("@d11", txtTotal.Text);
                cmd.Parameters.AddWithValue("@d12", txtcurrency.Text);
                cmd.Parameters.AddWithValue("@d13", textBox1.Text);

                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated the Investment of Client='" + txtclientname.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from investment  where inv_ID='" + ID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = " Deleted the Investment of Client='" + txtclientname.Text + "'";
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
    }
}
