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
    public partial class frmActivitiesRecords : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlDataAdapter adp;
        Connectionstring cs = new Connectionstring();
        public frmActivitiesRecords()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Autocomple()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Employee.StaffName) FROM Employee,Activity where Employee.staffID = Activity.StaffID", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbEmployeeName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbEmployeeName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void getdata()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Activity.ID),Activity.Dates,rtrim(Activity.ContactID), rtrim(Contact.ContactName),rtrim(contact.Mob), rtrim(Employee.StaffName),rtrim(Activity.ActivityType),rtrim(Activity.Status), rtrim(Activity.Subject),rtrim(contact.Notes), rtrim(Activity.StaffID) FROM contact,Employee,Activity where contact.ID = Activity.ContactID and Employee.StaffID =Activity.StaffID order by Dates", con);
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
        private void frmActivitiesRecords_Load(object sender, EventArgs e)
        {
           
            Autocomple();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployeeName.Text == "")
                {
                    MessageBox.Show("Please select Client Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbEmployeeName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Activity.ID),Activity.Dates,rtrim(Activity.ContactID), rtrim(Contact.ContactName),rtrim(contact.Mob), rtrim(Employee.StaffName),rtrim(Activity.ActivityType),rtrim(Activity.Status), rtrim(Activity.Subject),rtrim(contact.Notes), rtrim(Activity.StaffID) FROM contact,Employee,Activity where contact.ID = Activity.ContactID and Employee.StaffID =Activity.StaffID and Employee.staffname = '" + cmbEmployeeName.Text + "' order by StaffName", con);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           try
           {
             if (SET.Text == "CS")
            {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    this.Hide();
                    frmActivity frm = new frmActivity();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();
                   frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtdate.Text = dr.Cells[1].Value.ToString();
                    frm.txtcontactID.Text = dr.Cells[2].Value.ToString();
                   frm.txtContact.Text = dr.Cells[3].Value.ToString();
                    frm.txtAssignedto.Text = dr.Cells[5].Value.ToString();
                    frm.txtActivityType.Text = dr.Cells[6].Value.ToString();
                    frm.txtstatus.Text = dr.Cells[7].Value.ToString();
                    frm.txtsubject.Text = dr.Cells[8].Value.ToString();
                    frm.txtNotes.Text = dr.Cells[9].Value.ToString();
                    frm.txtstaffID.Text = dr.Cells[10].Value.ToString();
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
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Activity.ID),Activity.Dates,rtrim(Activity.ContactID), rtrim(Contact.ContactName),rtrim(contact.Mob), rtrim(Employee.StaffName),rtrim(Activity.ActivityType),rtrim(Activity.Status), rtrim(Activity.Subject),rtrim(contact.Notes), rtrim(Activity.StaffID) FROM contact,Employee,Activity where contact.ID = Activity.ContactID and Employee.StaffID =Activity.StaffID and Dates between @date1 and @date2 order by Dates", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = Date_to.Value.Date;
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

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

                try
                {

            if (SET.Text == "CS")
            {

                    DataGridViewRow dr = dataGridView2.SelectedRows[0];
                    this.Hide();
                    frmActivity frm = new frmActivity();
                    // or simply use column name instead of index
                    //dr.Cells["id"].Value.ToString();
                    frm.Show();

                    frm.txtID.Text = dr.Cells[0].Value.ToString();
                    frm.txtdate.Text = dr.Cells[1].Value.ToString();
                   
                    frm.txtcontactID.Text = dr.Cells[2].Value.ToString();

                    frm.txtContact.Text = dr.Cells[3].Value.ToString();
                    frm.txtAssignedto.Text = dr.Cells[5].Value.ToString();
                    frm.txtActivityType.Text = dr.Cells[6].Value.ToString();
                    frm.txtstatus.Text = dr.Cells[7].Value.ToString();
                    frm.txtsubject.Text = dr.Cells[8].Value.ToString();
                    frm.txtNotes.Text = dr.Cells[9].Value.ToString();
                    frm.txtstaffID.Text = dr.Cells[10].Value.ToString();

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

        

        private void frmActivitiesRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Date_from.Text = System.DateTime.Today.ToString();
            Date_to.Text = System.DateTime.Today.ToString();
            dataGridView2.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbEmployeeName.Text = "";
            dataGridView1.Rows.Clear();
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

                rowsTotal = dataGridView2.RowCount - 1;
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

        private void button7_Click(object sender, EventArgs e)
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
        }
    }
