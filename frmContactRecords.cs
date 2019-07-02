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

namespace CRM
{
    public partial class frmContactRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmContactRecords()
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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(ContactName) FROM Contact", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
              cmbContactName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbContactName.Items.Add(drow[0].ToString());

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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Country) FROM Contact", CN);
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
        private void frmContactRecords_Load(object sender, EventArgs e)
        {
            Autocomplete();
            Autocompletecountry();
         }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbContactName.Text == "")
                {
                    MessageBox.Show("Please select contact Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbContactName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(ID), rtrim(Contactname),rtrim(Mob),rtrim(PostalCode), rtrim(City),rtrim(country), rtrim(State),rtrim(Title), rtrim(Role) , rtrim(Notes),rtrim(Company) FROM dbo.Contact where  ContactName = '" + cmbContactName.Text + "' order by contactName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);
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
                cmd = new SqlCommand("SELECT rtrim(ID), rtrim(Contactname),rtrim(Mob),rtrim(PostalCode), rtrim(City),rtrim(country), rtrim(State),rtrim(Title), rtrim(Role) , rtrim(Notes),rtrim(Company) FROM dbo.Contact where country = '" + CmbCountry.Text + "' order by contactName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10]);
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
          cmbContactName.Text = "";
          dataGridView1.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           CmbCountry.Text = "";
           dataGridView2.Rows.Clear();
        }

        private void frmContactRecords_FormClosing(object sender, FormClosingEventArgs e)
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
           if (SET.Text == "CS")
            {
         DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmContacts frm = new  frmContacts();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.txtID.Text = dr.Cells[0].Value.ToString();
            frm.txtName.Text = dr.Cells[1].Value.ToString();
            frm.txtmob.Text = dr.Cells[2].Value.ToString();
            frm.txtpostalcode.Text = dr.Cells[3].Value.ToString();
            frm.txtCity.Text = dr.Cells[4].Value.ToString();

            frm.txtCountry.Text = dr.Cells[5].Value.ToString();
            frm.txtState.Text = dr.Cells[6].Value.ToString();
            frm.txtTitle.Text = dr.Cells[7].Value.ToString();
            frm.txtRole.Text = dr.Cells[8].Value.ToString();
            frm.txtNotes.Text = dr.Cells[9].Value.ToString();
            frm.txtcompany.Text = dr.Cells[10].Value.ToString();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;

            frm.btnUpdate.Enabled = true;
            frm.btnDelete.Enabled = true;
            frm.btnNew.Enabled = true;
            frm.btnSave.Enabled = false;
            frm.txtName.Focus();
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
             if (SET.Text == "CS")
            {

            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            this.Hide();
            frmContacts frm = new frmContacts();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.txtID.Text = dr.Cells[0].Value.ToString();
            frm.txtName.Text = dr.Cells[1].Value.ToString();
            frm.txtmob.Text = dr.Cells[2].Value.ToString();
            frm.txtpostalcode.Text = dr.Cells[3].Value.ToString();
            frm.txtCity.Text = dr.Cells[4].Value.ToString();

            frm.txtCountry.Text = dr.Cells[5].Value.ToString();
            frm.txtState.Text = dr.Cells[6].Value.ToString();
            frm.txtTitle.Text = dr.Cells[7].Value.ToString();
            frm.txtRole.Text = dr.Cells[8].Value.ToString();
            frm.txtNotes.Text = dr.Cells[9].Value.ToString();
            frm.txtcompany.Text = dr.Cells[10].Value.ToString();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;

            frm.btnUpdate.Enabled = true;
            frm.btnDelete.Enabled = true;
            frm.btnNew.Enabled = true;
            frm.btnSave.Enabled = false;
            frm.txtName.Focus();
}
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

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = dataGridView1.RowCount;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }
    }
}
