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
    public partial class frmInvestmentRecords : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
     
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        public frmInvestmentRecords()
        {
            InitializeComponent();
        }

        private void frmInvestmentRecords_Load(object sender, EventArgs e)
        {

         
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
              
            con = new SqlConnection(cs.DBcon);
            con.Open();
            cmd = new SqlCommand("select  RTrim(investment.inv_ID),rtrim(Client.userid),rtrim(client.FirstName), RTRIM(Date), RTRIM(InvestmentType), RTRIM(Cusip), RTRIM(AssetType), RTRIM(Goal), RTRIM(Sector), RTRIM(UnitPrice), RTRIM(Shares), RTRIM(Total), RTRIM(Currency) from investment, Client where Client.ID = Investment.ClientID and Date between @date1 and @date2 order by Date", con);
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = Date_from.Value.Date;
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = Date_to.Value.Date;
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView2.Rows.Clear();
            while (rdr.Read() == true)
            {
                dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11],rdr[12]);
            }
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("select  RTrim(investment.inv_ID),rtrim(client.userid),rtrim(client.Firstname), RTRIM(Date), RTRIM(InvestmentType), RTRIM(Cusip), RTRIM(AssetType), RTRIM(Goal), RTRIM(Sector), RTRIM(UnitPrice), RTRIM(Shares), RTRIM(Total), RTRIM(Currency) from investment, Client where Client.ID = Investment.ClientID  order by Date", con);

                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11],rdr[12]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView2.Rows.Clear();
        }

       

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ButtonHighlight ;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        private void frmInvestmentRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { try
                {
                  
            if (SET.Text == "CS")
            {
                 DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    this.Hide();
                    frmInvestment frm = new frmInvestment();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();
                    frm.ID.Text = dr.Cells[0].Value.ToString();
                    frm.txtClientID.Text = dr.Cells[1].Value.ToString();
                    frm.txtclientname.Text = dr.Cells[2].Value.ToString();
                    frm.txtdate.Text = dr.Cells[3].Value.ToString();
                    frm.txtinvestmentType.Text = dr.Cells[4].Value.ToString();

                    frm.txtCUSIPNumber.Text = dr.Cells[5].Value.ToString();
                    frm.txtassettype.Text = dr.Cells[6].Value.ToString();
                    frm.txtgoal.Text = dr.Cells[7].Value.ToString();
                    frm.txtsector.Text = dr.Cells[8].Value.ToString();
                    frm.txtprice.Text = dr.Cells[9].Value.ToString();
                    frm.txtShares.Text = dr.Cells[10].Value.ToString();
                    frm.txtTotal.Text = dr.Cells[11].Value.ToString();
                    frm.txtcurrency.Text = dr.Cells[12].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtdate.Focus();
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {try
                {
            if (SET.Text == "CS")
            {
                
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmInvestment frm = new frmInvestment();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.ID.Text = dr.Cells[0].Value.ToString();
            frm.txtClientID.Text = dr.Cells[1].Value.ToString();
            frm.txtclientname.Text = dr.Cells[2].Value.ToString();
            frm.txtdate.Text = dr.Cells[3].Value.ToString();
            frm.txtinvestmentType.Text = dr.Cells[4].Value.ToString();

            frm.txtCUSIPNumber.Text = dr.Cells[5].Value.ToString();
            frm.txtassettype.Text = dr.Cells[6].Value.ToString();
            frm.txtgoal.Text = dr.Cells[7].Value.ToString();
            frm.txtsector.Text = dr.Cells[8].Value.ToString();
            frm.txtprice.Text = dr.Cells[9].Value.ToString();
            frm.txtShares.Text = dr.Cells[10].Value.ToString();
            frm.txtTotal.Text = dr.Cells[11].Value.ToString();
            frm.txtcurrency.Text = dr.Cells[12].Value.ToString();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;

            frm.btnUpdate.Enabled = true;
            frm.btnDelete.Enabled = true;
            frm.btnNew.Enabled = true;
            frm.btnSave.Enabled = false;
            frm.txtdate.Focus();
        }
        }
         catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

                rowsTotal = dataGridView2.RowCount;
                colsTotal = dataGridView2.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView2.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView2.Rows[I].Cells[j].Value;
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
    }
}
