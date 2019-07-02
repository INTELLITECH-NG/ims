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
    public partial class frmSales : Form
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
        public frmSales()
        {
            InitializeComponent();
        }


        public void getdata1()
        {
            try
            {
            con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTrim(investment.inv_ID),RTrim(investment.clientID),RTrim(client.userid),RTrim(Client.firstname),RTrim(Unitprice),RTrim(Shares),RTrim(Total) FROM investment,client where client.id = investment.clientID and Inv_ID not in (Select InvestmentID from Sales) ", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        public void due()
        {
            decimal val1 = 0;
            decimal val2 = 0;
          
            decimal.TryParse(txtProfit.Text, out val1);
            decimal.TryParse(txtdeduction.Text, out val2);
       
            decimal I = (val1 - val2);

            txtdue.Text = I.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            saleprice();
            decimal val1 = 0;
            decimal val2 = 0;
            decimal val3 = 0;
            decimal.TryParse(txtShares.Text, out val1);
            decimal.TryParse(txtOldTotal.Text, out val2);
            decimal.TryParse(txtnewPrice.Text, out val3);

            decimal I =(val1 * val3)-val2;

            txtProfit.Text = I.ToString();
            per();
            due();

        }
        private void AutocompleteMargin()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(percents) from ProfitPercent ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

               if (rdr.Read())
                {

                    txtMargin.Text = rdr.GetValue(0).ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSales_Load(object sender, EventArgs e)
        {
            //Autocompleclient();
            AutocompleteMargin();
            getdata1();
        }
        public void per()
        {

        decimal val1 = 0;
        decimal val2 = 0;

        decimal.TryParse(txtProfit.Text, out val1);
        decimal.TryParse(txtMargin.Text, out val2);


        decimal I = (val1 * val2) / 100;

        txtdeduction.Text = I.ToString();

        }

        public void saleprice()
        {

            decimal val1 = 0;
            decimal val2 = 0;

            decimal.TryParse(txtShares.Text, out val1);
            decimal.TryParse(txtnewPrice.Text, out val2);


            decimal I = (val1 * val2);

            txtsellingprice.Text = I.ToString();

        }
        private void txtMargin_TextChanged(object sender, EventArgs e)
        {
            per();
        }

        private void txtProfit_TextChanged(object sender, EventArgs e)
        {
            per();
            due();
        }
      
       

        private void txtdeduction_TextChanged(object sender, EventArgs e)
        {
            due();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientname.Text == "")
                {
                    MessageBox.Show("Please Select Client Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClientname.Focus();
                    return;
                }
                if (txtnewPrice.Text == "")
                {
                    MessageBox.Show("Please Enter New price of Shares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewPrice.Focus();
                    return;
                }
              
                con = new SqlConnection(cs.DBcon);
                con.Open();

                string cb = "insert into sales(InvestmentID,NewPrice,Profit,Deduction,Due,Date,Notes,sellingprice) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)";
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtinvestmentID.Text);
                cmd.Parameters.AddWithValue("@d2", txtnewPrice.Text);
                cmd.Parameters.AddWithValue("@d3", txtProfit.Text);
                cmd.Parameters.AddWithValue("@d4", txtdeduction.Text);
                cmd.Parameters.AddWithValue("@d5", txtdue.Text);
                cmd.Parameters.AddWithValue("@d6", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d7", txtnotes.Text);
                cmd.Parameters.AddWithValue("@d8", txtsellingprice.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Shares Sale out Sucessfully by Client='" + txtClientname.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                btnSave.Enabled = false;
                getdata1();
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

                string cb2 = "update Sales set InvestmentID=@d1,NewPrice=@d2,Profit=@d3,Deduction=@d4, Due=@d5,Date=@d6,Notes=@d7,sellingprice=@d8 where S_id='" + txtsalesID.Text + "'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtinvestmentID.Text);
                cmd.Parameters.AddWithValue("@d2", txtnewPrice.Text);
                cmd.Parameters.AddWithValue("@d3", txtProfit.Text);
                cmd.Parameters.AddWithValue("@d4", txtdeduction.Text);
                cmd.Parameters.AddWithValue("@d5",  txtdue.Text);
                cmd.Parameters.AddWithValue("@d6", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d7", txtnotes.Text);
                cmd.Parameters.AddWithValue("@d8", txtsellingprice.Text);
                   cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                st1 = lblUser.Text;
                st2 = "Updated Sale out Shares of Client='" + txtClientname.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                getdata1();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
          
            txtUserID.Text = "";
           txtClientname.Text = "";
            txtdate.Text = System.DateTime.Now.ToString();
            txtdeduction.Text = "";
          txtdue.Text = "";
           txtnewPrice.Text = "";
       
           txtnotes.Text = "";
           txtoldprice.Text = "";
            txtClientID.Text = "";
            txtOldTotal.Text = "";
            txtProfit.Text = "";
           txtShares.Text = "";
           txtinvestmentID.Text = "";
              txtsalesID.Text="";
            txtUserID.Text = "";
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
                string cq1 = "delete from sales  where ID='" + txtsalesID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Deleted Sale out Shares of Client='" + txtClientname.Text + "'";
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

                getdata1();

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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmSalesRecord frm = new frmSalesRecord();
            frm.SET.Text = "CS";
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];

               txtinvestmentID.Text = dr.Cells[0].Value.ToString();
              txtClientID.Text = dr.Cells[1].Value.ToString();
                txtUserID.Text = dr.Cells[2].Value.ToString();
             txtClientname.Text = dr.Cells[3].Value.ToString();
             txtoldprice.Text = dr.Cells[4].Value.ToString();
             txtShares.Text = dr.Cells[5].Value.ToString();
            txtOldTotal.Text = dr.Cells[6].Value.ToString();
            txtnewPrice.Text = "";
            txtProfit.Text = "";
            txtdue.Text = "";
            txtdeduction.Text = "";
            txtsellingprice.Text = "";

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ButtonHighlight;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void txtShares_TextChanged(object sender, EventArgs e)
        {
            //saleprice();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtsellingprice_TextChanged(object sender, EventArgs e)
        {
            saleprice();
        }

        private void txtoldprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOldTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
    }
}
