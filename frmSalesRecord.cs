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
using Excel = Microsoft.Office.Interop.Excel;

namespace CRM
{
    public partial class frmSalesRecord : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();



        public frmSalesRecord()
        {
            InitializeComponent();
        }
        private void Autocompleclient()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(FirstName) from Client,investment,sales where client.ID=investment.ClientID and investment.inv_id=sales.investmentid  ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbClientName.Items.Add(rdr[0]);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSalesRecord_Load(object sender, EventArgs e)
        {
            Autocompleclient();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(sales.S_ID), rtrim(sales.InvestmentID),rtrim(Investment.ClientID),rtrim(Client.UserID),rtrim(client.FirstName),rtrim(client.LastName),rtrim(investment.Shares),rtrim(investment.UnitPrice),rtrim(sales.newPrice),rtrim(investment.total),rtrim(sales.sellingprice),rtrim(sales.Profit), rtrim(sales.Deduction) , rtrim(sales.Due), (sales.Date) , rtrim(sales.Notes), (sales.profit/sales.sellingprice)*100 FROM sales,investment,client where investment.inv_ID=sales.investmentID and client.ID=investment.clientID and sales.Date between @date1 and @date2 order by sales.Date", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = Date_to.Value.Date;
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12],rdr[13],rdr[14],rdr[15],rdr[16]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cmd = new SqlCommand("SELECT rtrim(sales.S_ID), rtrim(sales.InvestmentID),rtrim(Investment.ClientID),rtrim(Client.UserID),rtrim(client.FirstName),rtrim(client.LastName),rtrim(investment.Shares),rtrim(investment.UnitPrice),rtrim(sales.newPrice),rtrim(investment.total),rtrim(sales.sellingprice),rtrim(sales.Profit), rtrim(sales.Deduction) , rtrim(sales.Due), (sales.Date) , rtrim(sales.Notes), (sales.profit/sales.sellingprice)*100 FROM sales,investment,client where investment.inv_ID=sales.investmentID and client.ID=investment.clientID and FirstName = '" + cmbClientName.Text + "' order by FirstName", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9],rdr[10],rdr[11],rdr[12],rdr[13],rdr[14],rdr[15],rdr[16]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { try
                {
            if (SET.Text == "CS")
            {
                   DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    this.Hide();
                    frmSales frm = new frmSales();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();
                    frm.txtsalesID.Text = dr.Cells[0].Value.ToString();
                    frm.txtinvestmentID.Text = dr.Cells[1].Value.ToString();
                    frm.txtClientID.Text = dr.Cells[2].Value.ToString();
                    frm.txtUserID.Text = dr.Cells[3].Value.ToString();
                   
                    frm.txtClientname.Text = dr.Cells[4].Value.ToString();
                    frm.txtShares.Text = dr.Cells[6].Value.ToString();


                    frm.txtoldprice.Text = dr.Cells[7].Value.ToString();
                    frm.txtnewPrice.Text = dr.Cells[8].Value.ToString();
                  
                    frm.txtOldTotal.Text = dr.Cells[9].Value.ToString();
                    frm.txtsellingprice.Text = dr.Cells[10].Value.ToString();
                    frm.txtProfit.Text = dr.Cells[11].Value.ToString();
                    frm.txtdeduction.Text = dr.Cells[12].Value.ToString();

                    frm.txtdue.Text = dr.Cells[13].Value.ToString();
                    frm.txtdate.Text = dr.Cells[14].Value.ToString();
                    frm.txtnotes.Text = dr.Cells[15].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtClientname.Focus();
                }
        }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            
        

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView2_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {try
                {
                  
            if (SET.Text == "CS")
            {
                  DataGridViewRow dr = dataGridView2.SelectedRows[0];
                    this.Hide();
                    frmSales frm = new frmSales();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();
                    frm.txtsalesID.Text = dr.Cells[0].Value.ToString();
                    frm.txtinvestmentID.Text = dr.Cells[1].Value.ToString();
                    frm.txtClientID.Text = dr.Cells[2].Value.ToString();
                    frm.txtUserID.Text = dr.Cells[3].Value.ToString();

                    frm.txtClientname.Text = dr.Cells[4].Value.ToString();
                    frm.txtShares.Text = dr.Cells[6].Value.ToString();


                    frm.txtoldprice.Text = dr.Cells[7].Value.ToString();
                    frm.txtnewPrice.Text = dr.Cells[8].Value.ToString();

                    frm.txtOldTotal.Text = dr.Cells[9].Value.ToString();
                    frm.txtsellingprice.Text = dr.Cells[10].Value.ToString();
                    frm.txtProfit.Text = dr.Cells[11].Value.ToString();
                    frm.txtdeduction.Text = dr.Cells[12].Value.ToString();

                    frm.txtdue.Text = dr.Cells[13].Value.ToString();
                    frm.txtdate.Text = dr.Cells[14].Value.ToString();
                    frm.txtnotes.Text = dr.Cells[15].Value.ToString();
                    frm.lblUser.Text = lblUser.Text;
                    frm.lblUserType.Text = lblUserType.Text;
                    frm.btnUpdate.Enabled = true;
                    frm.btnDelete.Enabled = true;
                    frm.btnNew.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.txtClientname.Focus();
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void frmSalesRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            cmbClientName.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView2.Rows.Clear();
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
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

