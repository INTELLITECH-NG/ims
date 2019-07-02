﻿using System;
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
    public partial class frmLogs : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;

        public frmLogs()
        {
            InitializeComponent();
        }
        public void fillCombo()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("SELECT distinct RTRIM(UserID) FROM User_Registration", con);
                ds = new DataSet("ds");
                da.Fill(ds);
                dtable = ds.Tables[0];
                cmbUserID.Items.Clear();
                foreach (DataRow drow in dtable.Rows)
                {
                    cmbUserID.Items.Add(drow[0].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reset()
        {
            cmbUserID.SelectedIndex = -1;
            dtpDateFrom.Text = System.DateTime.Today.ToString();
            dtpDateTo.Text = System.DateTime.Now.ToString();
            lblUser.Text = "";
            GetData();
            fillCombo();
        }
        private void GetData()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from Logs order by Date", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while ((rdr.Read() == true))
                {
                    dgw.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteRecord()
        {
            try
            {
                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct = "delete from logs";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                if (RowsAffected > 0)
                {
                    st1 = lblUser.Text;
                    st2 = "deleted the all logs till date '" + System.DateTime.Now + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    GetData();
                }
                else
                {
                    MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                con.Close();
                lblUserType.Text = lblUserType.Text;
                lblUser.Text = lblUser.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogs_Load(object sender, EventArgs e)
        {
            fillCombo();
            GetData();
        }

        private void btnDeleteAllLogs_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to delete all logs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    DeleteRecord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from logs where Date between @date1 and @date2 order by Date", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = dtpDateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = dtpDateTo.Value;
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while ((rdr.Read() == true))
                {
                    dgw.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from Logs where UserID='" + cmbUserID.Text + "' order by date", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dgw.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dgw.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgw_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ButtonHighlight;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }
    }
}
