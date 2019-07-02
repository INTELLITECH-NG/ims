using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace CRM
{
    public partial class frmClientRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        frmClient frm = new frmClient();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmClientRecords()
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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(FirstName) FROM Client", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                CmbClientID.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                   cmbClientName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteID()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(UserID) FROM Client", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                CmbClientID.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    CmbClientID.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteCountry()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Hcountry) FROM Client", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbCountry.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbCountry.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmClientRecords_Load(object sender, EventArgs e)
        {
            Autocomplete();
            AutocompleteCountry();
            AutocompleteID();
       }
        public void Grid()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientName.Text == "")
                {
                    MessageBox.Show("Please select client Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClientName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Client.ID), rtrim(Client.UserID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(ClientType),rtrim(HStreet), rtrim(HCity),rtrim(HState), rtrim(HZip) , rtrim(HCountry),rtrim(IDType) , rtrim(IDNo), ExpDate, rtrim(Telephone),rtrim(Mobile),rtrim(FaxNo),rtrim(Email), rtrim(Client.WStreet), rtrim(Client.WCity) , rtrim(Client.WState),rtrim(Client.WZip),rtrim(Client.WCountry),rtrim(Client.ClientOfficers),rtrim(Client.Interestlevel), rtrim(Client.MoneyCommited),rtrim (Client.Secetory),Client.picture, rtrim(Client.Icountry),rtrim (Client.Categorization),rtrim(Client.Bowner), rtrim(Client.Directors) FROM dbo.Client where Firstname = '" + cmbClientName.Text + "' order by FirstName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22], rdr[23], rdr[24], rdr[25], rdr[26], rdr[27], rdr[28], rdr[29], rdr[30]);
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
                if (CmbClientID.Text == "")
                {
                    MessageBox.Show("Please select client ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CmbClientID.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Client.ID), rtrim(Client.UserID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(ClientType),rtrim(HStreet), rtrim(HCity),rtrim(HState), rtrim(HZip) , rtrim(HCountry),rtrim(IDType) , rtrim(IDNo), ExpDate, rtrim(Telephone),rtrim(Mobile),rtrim(FaxNo),rtrim(Email), rtrim(Client.WStreet), rtrim(Client.WCity) , rtrim(Client.WState),rtrim(Client.WZip),rtrim(Client.WCountry),rtrim(Client.ClientOfficers),rtrim(Client.Interestlevel), rtrim(Client.MoneyCommited),rtrim (Client.Secetory),Client.picture, rtrim(Client.Icountry),rtrim (Client.Categorization),rtrim(Client.Bowner), rtrim(Client.Directors) FROM dbo.Client where UserID = '" + CmbClientID.Text + "' order by FirstName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22], rdr[23], rdr[24], rdr[25], rdr[26], rdr[27], rdr[28], rdr[29],rdr[30]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGetdata_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCountry.Text == "")
                {
                    MessageBox.Show("Please select Clients Home Country Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   cmbCountry.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Client.ID), rtrim(Client.UserID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(ClientType),rtrim(HStreet), rtrim(HCity),rtrim(HState), rtrim(HZip) , rtrim(HCountry),rtrim(IDType) , rtrim(IDNo), ExpDate, rtrim(Telephone),rtrim(Mobile),rtrim(FaxNo),rtrim(Email), rtrim(Client.WStreet), rtrim(Client.WCity) , rtrim(Client.WState),rtrim(Client.WZip),rtrim(Client.WCountry),rtrim(Client.ClientOfficers),rtrim(Client.Interestlevel), rtrim(Client.MoneyCommited),rtrim (Client.Secetory),Client.picture, rtrim(Client.Icountry),rtrim (Client.Categorization),rtrim(Client.Bowner), rtrim(Client.Directors) FROM dbo.Client where HCountry = '" + cmbCountry.Text + "' order by FirstName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView3.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView3.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13], rdr[14], rdr[15], rdr[16], rdr[17], rdr[18], rdr[19], rdr[20], rdr[21], rdr[22], rdr[23], rdr[24], rdr[25], rdr[26], rdr[27], rdr[28], rdr[29],rdr[30]);
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
            cmbClientName.Text = "";

            dataGridView1.Rows.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmbClientID.Text = "";
            dataGridView2.Rows.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           cmbCountry.Text = "";
           dataGridView3.Rows.Clear();
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
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
        private void GetRecord(int i)
        {
            con = new SqlConnection(cs.DBcon);
            con.Open();
            string sql = "Select photo from client,document where Client.ID=document.ClientID and Client.ID="+ i +"";
            cmd = new SqlCommand(sql);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            frm.dataGridView1.Rows.Clear();
            while (rdr.Read())
            {
                Image img;
                byte[] data = (byte[])rdr[0];
                MemoryStream ms = new MemoryStream(data);
                img= Image.FromStream(ms);
                frm.dataGridView1.Rows.Add(img);

            }
            con.Close();

        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }

        private void frmClientRecords_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
                {

               if (SET1.Text == "CS")
               {

                 DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    this.Hide();
                    frm.Show();
                    frm.ID.Text = dr.Cells[0].Value.ToString();
                    frm.txtuserID.Text = dr.Cells[1].Value.ToString();
                    frm.txtFirstName.Text = dr.Cells[2].Value.ToString();

                    frm.txtLastName.Text = dr.Cells[3].Value.ToString();
                    frm.cmbClientType.Text = dr.Cells[4].Value.ToString();
                    frm.txtH_Street.Text = dr.Cells[5].Value.ToString();
                    frm.txtH_City.Text = dr.Cells[6].Value.ToString();
                    frm.cmbH_State.Text = dr.Cells[7].Value.ToString();
                    frm.txtH_Zip.Text = dr.Cells[8].Value.ToString();
                    frm.cmbH_Country.Text = dr.Cells[9].Value.ToString();
                    frm.cmbIDType.Text = dr.Cells[10].Value.ToString();
                    frm.txtIDNo.Text = dr.Cells[11].Value.ToString();
                    frm.dtpExpiryDate.Text = dr.Cells[12].Value.ToString();
                    frm.txtTelephoneNo.Text = dr.Cells[13].Value.ToString();
                    frm.txtMobileNo.Text = dr.Cells[14].Value.ToString();
                    frm.txtFaxNo.Text = dr.Cells[15].Value.ToString();
                    frm.txtEmail.Text = dr.Cells[16].Value.ToString();
                    frm.txtW_Street.Text = dr.Cells[17].Value.ToString();

                    frm.txtW_City.Text = dr.Cells[18].Value.ToString();
                    frm.cmbW_State.Text = dr.Cells[19].Value.ToString();
                    frm.txtW_Zip.Text = dr.Cells[20].Value.ToString();
                    frm.cmbW_Country.Text = dr.Cells[21].Value.ToString();
                    frm.txtClientOfficer.Text = dr.Cells[22].Value.ToString();
                    frm.txtInterest.Text = dr.Cells[23].Value.ToString();
                    frm.txtmoneycommited.Text = dr.Cells[24].Value.ToString();
                    frm.txtSecetory.Text = dr.Cells[25].Value.ToString();
                    //  frm.pictureBox1.Text = dr.Cells[26].Value.ToString();
                    frm.cmbIssuedCountry.Text = dr.Cells[27].Value.ToString();
                    frm.txtCategorization.Text = dr.Cells[28].Value.ToString();
                    frm.txtBOwner.Text = dr.Cells[29].Value.ToString();
                    frm.txtDirectors.Text = dr.Cells[30].Value.ToString();

                    byte[] data = (byte[])dr.Cells[26].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.pictureBox1.Image = Image.FromStream(ms);
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtuserID.Focus();
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           try
            {
                if (SET1.Text == "CS")
                {
                    DataGridViewRow dr = dataGridView3.SelectedRows[0];
                    this.Hide();
                    frmClient frm = new frmClient();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();
                    frm.ID.Text = dr.Cells[0].Value.ToString();
                    frm.txtuserID.Text = dr.Cells[1].Value.ToString();
                    frm.txtFirstName.Text = dr.Cells[2].Value.ToString();

                    frm.txtLastName.Text = dr.Cells[3].Value.ToString();
                    frm.cmbClientType.Text = dr.Cells[4].Value.ToString();
                    frm.txtH_Street.Text = dr.Cells[5].Value.ToString();
                    frm.txtH_City.Text = dr.Cells[6].Value.ToString();

                    frm.cmbH_State.Text = dr.Cells[7].Value.ToString();
                    frm.txtH_Zip.Text = dr.Cells[8].Value.ToString();
                    frm.cmbH_Country.Text = dr.Cells[9].Value.ToString();

                    frm.cmbIDType.Text = dr.Cells[10].Value.ToString();
                    frm.txtIDNo.Text = dr.Cells[11].Value.ToString();
                    frm.dtpExpiryDate.Text = dr.Cells[12].Value.ToString();
                    frm.txtTelephoneNo.Text = dr.Cells[13].Value.ToString();
                    frm.txtMobileNo.Text = dr.Cells[14].Value.ToString();
                    frm.txtFaxNo.Text = dr.Cells[15].Value.ToString();
                    frm.txtEmail.Text = dr.Cells[16].Value.ToString();
                    frm.txtW_Street.Text = dr.Cells[17].Value.ToString();

                    frm.txtW_City.Text = dr.Cells[18].Value.ToString();
                    frm.cmbW_State.Text = dr.Cells[19].Value.ToString();
                    frm.txtW_Zip.Text = dr.Cells[20].Value.ToString();

                    frm.cmbW_Country.Text = dr.Cells[21].Value.ToString();
                    frm.txtClientOfficer.Text = dr.Cells[22].Value.ToString();
                    frm.txtInterest.Text = dr.Cells[23].Value.ToString();
                    frm.txtmoneycommited.Text = dr.Cells[24].Value.ToString();
                    frm.txtSecetory.Text = dr.Cells[25].Value.ToString();
                    // frm.pictureBox1.Text = dr.Cells[26].Value.ToString();
                    frm.cmbIssuedCountry.Text = dr.Cells[27].Value.ToString();
                    frm.txtCategorization.Text = dr.Cells[28].Value.ToString();
                    frm.txtBOwner.Text = dr.Cells[29].Value.ToString();
                    frm.txtDirectors.Text = dr.Cells[30].Value.ToString();

                    byte[] data = (byte[])dr.Cells[26].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.pictureBox1.Image = Image.FromStream(ms);
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnDelete.Enabled = true;
                    frm.btnUpdate.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtuserID.Focus();
                    GetRecord(Convert.ToInt16(dr.Cells[0].Value));
            }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
               {
                if (SET1.Text == "CS")
                   {
                   DataGridViewRow dr = dataGridView2.SelectedRows[0];
                    this.Hide();
                    frm.Show();
                    frm.ID.Text = dr.Cells[0].Value.ToString();
                    frm.txtuserID.Text = dr.Cells[1].Value.ToString();
                    frm.txtFirstName.Text = dr.Cells[2].Value.ToString();

                    frm.txtLastName.Text = dr.Cells[3].Value.ToString();
                    frm.cmbClientType.Text = dr.Cells[4].Value.ToString();
                    frm.txtH_Street.Text = dr.Cells[5].Value.ToString();
                    frm.txtH_City.Text = dr.Cells[6].Value.ToString();

                    frm.cmbH_State.Text = dr.Cells[7].Value.ToString();
                    frm.txtH_Zip.Text = dr.Cells[8].Value.ToString();
                    frm.cmbH_Country.Text = dr.Cells[9].Value.ToString();

                    frm.cmbIDType.Text = dr.Cells[10].Value.ToString();
                    frm.txtIDNo.Text = dr.Cells[11].Value.ToString();
                    frm.dtpExpiryDate.Text = dr.Cells[12].Value.ToString();
                    frm.txtTelephoneNo.Text = dr.Cells[13].Value.ToString();
                    frm.txtMobileNo.Text = dr.Cells[14].Value.ToString();
                    frm.txtFaxNo.Text = dr.Cells[15].Value.ToString();
                    frm.txtEmail.Text = dr.Cells[16].Value.ToString();
                    frm.txtW_Street.Text = dr.Cells[17].Value.ToString();

                    frm.txtW_City.Text = dr.Cells[18].Value.ToString();
                    frm.cmbW_State.Text = dr.Cells[19].Value.ToString();
                    frm.txtW_Zip.Text = dr.Cells[20].Value.ToString();

                    frm.cmbW_Country.Text = dr.Cells[21].Value.ToString();
                    frm.txtClientOfficer.Text = dr.Cells[22].Value.ToString();
                    frm.txtInterest.Text = dr.Cells[23].Value.ToString();
                    frm.txtmoneycommited.Text = dr.Cells[24].Value.ToString();
                    frm.txtSecetory.Text = dr.Cells[25].Value.ToString();
                    // frm.pictureBox1.Text = dr.Cells[26].Value.ToString();
                    frm.cmbIssuedCountry.Text = dr.Cells[27].Value.ToString();
                    frm.txtCategorization.Text = dr.Cells[28].Value.ToString();
                    frm.txtBOwner.Text = dr.Cells[29].Value.ToString();
                    frm.txtDirectors.Text = dr.Cells[30].Value.ToString();

                    byte[] data = (byte[])dr.Cells[26].Value;
                    MemoryStream ms = new MemoryStream(data);
                    frm.pictureBox1.Image = Image.FromStream(ms);
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnUpdate.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtuserID.Focus();
                    GetRecord(Convert.ToInt16(dr.Cells[0].Value));
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dataGridView2_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
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
        }
                
        }
    

