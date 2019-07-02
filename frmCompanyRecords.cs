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
    public partial class frmCompanyRecords : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlDataAdapter adp;
        Connectionstring cs = new Connectionstring();
        public frmCompanyRecords()
        {
            InitializeComponent();
        }
        private void Autocomplete()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(CompanyName) FROM Company", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                CmbCompanyName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    CmbCompanyName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Autocompletecountry()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Country) FROM Company", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                CmbCountry.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    CmbCountry.Items.Add(drow[0].ToString());

                }
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

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        private void frmCompanyRecords_Load(object sender, EventArgs e)
        {
            Autocomplete();
            Autocompletecountry();
         }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCompanyName.Text == "")
                {
                    MessageBox.Show("Please select Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CmbCompanyName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ID), rtrim(Companyname),rtrim(RegNo),rtrim(Role), rtrim(Telephone),rtrim(Fax), rtrim(Mobile),rtrim(City), rtrim(Country) , rtrim(State), rtrim(Objective),rtrim(Date),rtrim(Code),rtrim(Mgr),rtrim(investorType),rtrim(TotalAssets),rtrim(PEratio),rtrim(Fee),rtrim(Staff) FROM dbo.Company where  CompanyName = '" + CmbCompanyName.Text + "' order by CompanyName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbCountry.Text == "")
                {
                    MessageBox.Show("Please select Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CmbCountry.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ID), rtrim(Companyname),rtrim(RegNo),rtrim(Role), rtrim(Telephone),rtrim(Fax), rtrim(Mobile),rtrim(City), rtrim(Country) , rtrim(State), rtrim(Objective),rtrim(Date),rtrim(Code),rtrim(Mgr),rtrim(investorType),rtrim(TotalAssets),rtrim(PEratio),rtrim(Fee),rtrim(Staff) FROM dbo.Company where  Country = '" + CmbCountry.Text + "' order by CompanyName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CmbCompanyName.Text = "";
            dataGridView1.Rows.Clear();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmbCountry.Text = "";

            dataGridView2.Rows.Clear();

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

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ButtonHighlight;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void frmCompanyRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            try
                {
            if (SETS.Text == "CS")
            {

                   DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    this.Hide();
                    frmCompanyinfo frm = new frmCompanyinfo();
                    
                    frm.Show();

                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtcompanyName.Text = dr.Cells[1].Value.ToString();
                    frm.txtRegNo.Text = dr.Cells[2].Value.ToString();

                    frm.txtrole.Text = dr.Cells[3].Value.ToString();
                    frm.txtphone.Text = dr.Cells[4].Value.ToString();
                    frm.txtfax.Text = dr.Cells[5].Value.ToString();
                    frm.txtmob.Text = dr.Cells[6].Value.ToString();

                    frm.txtcity.Text = dr.Cells[7].Value.ToString();
                    frm.txtcountry.Text = dr.Cells[8].Value.ToString();
                    frm.txtState.Text = dr.Cells[9].Value.ToString();

                    frm.txtobjective.Text = dr.Cells[10].Value.ToString();
                    frm.txtdate.Text = dr.Cells[11].Value.ToString();
                    frm.txtpostalcode.Text = dr.Cells[12].Value.ToString();
                    frm.txtRelmgr.Text = dr.Cells[13].Value.ToString();
                    frm.txtinvestorType.Text = dr.Cells[14].Value.ToString();
                    frm.txttotalassets.Text = dr.Cells[15].Value.ToString();
                    frm.txtperatio.Text = dr.Cells[16].Value.ToString();
                    frm.txtmgtfee.Text = dr.Cells[17].Value.ToString();

                    frm.txtstaff.Text = dr.Cells[18].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtcompanyName.Focus();
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { try
                {
                  
            if (SETS.Text == "CS")
            {

                 DataGridViewRow dr = dataGridView2.SelectedRows[0];
                    this.Hide();
                    frmCompanyinfo frm = new frmCompanyinfo();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();

                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtcompanyName.Text = dr.Cells[1].Value.ToString();
                    frm.txtRegNo.Text = dr.Cells[2].Value.ToString();

                    frm.txtrole.Text = dr.Cells[3].Value.ToString();
                    frm.txtphone.Text = dr.Cells[4].Value.ToString();
                    frm.txtfax.Text = dr.Cells[5].Value.ToString();
                    frm.txtmob.Text = dr.Cells[6].Value.ToString();

                    frm.txtcity.Text = dr.Cells[7].Value.ToString();
                    frm.txtcountry.Text = dr.Cells[8].Value.ToString();
                    frm.txtState.Text = dr.Cells[9].Value.ToString();

                    frm.txtobjective.Text = dr.Cells[10].Value.ToString();
                    frm.txtdate.Text = dr.Cells[11].Value.ToString();
                    frm.txtpostalcode.Text = dr.Cells[12].Value.ToString();
                    frm.txtRelmgr.Text = dr.Cells[13].Value.ToString();
                    frm.txtinvestorType.Text = dr.Cells[14].Value.ToString();
                    frm.txttotalassets.Text = dr.Cells[15].Value.ToString();
                    frm.txtperatio.Text = dr.Cells[16].Value.ToString();
                    frm.txtmgtfee.Text = dr.Cells[17].Value.ToString();

                    frm.txtstaff.Text = dr.Cells[18].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtcompanyName.Focus();
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        

        private void ExportExcel_Click(object sender, EventArgs e)
        {

        }

    }
}
    
