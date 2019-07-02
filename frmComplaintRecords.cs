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
    public partial class frmComplaintRecords : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlDataAdapter adp;
        Connectionstring cs = new Connectionstring();
        public frmComplaintRecords()
        {
            InitializeComponent();
        }
        private void Autocomple()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBcon);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Client.FirstName) FROM Client,complaint where client.ID = Complaint.ClientID", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
               cmbClientName.Items.Clear();

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
        private void frmComplaintRecords_Load(object sender, EventArgs e)
        {
            Autocomple();
            getdata();
        }

        public void getdata()
        {
            try
            {
             con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Complaint.ID), rtrim(Client.userID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(client.Mobile),rtrim(complaint.Date), rtrim(Complaint.Notes) FROM complaint,Client where client.ID = Complaint.ClientID order by FirstName", con);
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

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientName.Text == "")
                {
                    MessageBox.Show("Please select Client Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClientName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Complaint.ID), rtrim(client.UserID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(Mobile),rtrim(complaint.Date), rtrim(Complaint.Notes) FROM complaint,Client where client.ID = Complaint.ClientID and  Firstname = '" + cmbClientName.Text + "' order by FirstName", con);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Complaint.ID), rtrim(client.UserID),rtrim(Client.FirstName),rtrim(Client.LastName), rtrim(Mobile),rtrim(complaint.Date), rtrim(Complaint.Notes) FROM complaint,Client where client.ID = Complaint.ClientID and  Complaint.Date between @date1 and @date2", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = Date_from.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = Date_to.Value.Date;
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmComplaintRecords_FormClosing(object sender, FormClosingEventArgs e)
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
            dataGridView2.DataSource = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            cmbClientName.Text = "";
            dataGridView1.DataSource = null;
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
