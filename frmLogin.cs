﻿using System;
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
    public partial class frmLogin : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void fillusernType()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(userType) from User_Registration ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbUsertype.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            fillusernType();
            progressBar1.Visible = false;
            cmbUsertype.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (UserID.Text == "")
            {
                MessageBox.Show("Please enter user ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID.Focus();
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT RTRIM(UserID),RTRIM(Password) FROM User_Registration where UserID=@d1 and Password=@d2 union Select RTRIM(UserID),RTRIM(Password) from Client where UserID = @d1 and Password=@d2";
                cmd.Parameters.AddWithValue("@d1", UserID.Text);
                cmd.Parameters.AddWithValue("@d2", Password.Text);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    con = new SqlConnection(cs.DBcon);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT usertype FROM User_Registration where UserID=@d3 and Password=@d4";
                    cmd.Parameters.AddWithValue("@d3", UserID.Text);
                    cmd.Parameters.AddWithValue("@d4", Password.Text);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        cmbUsertype.Text = rdr.GetValue(0).ToString().Trim();
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                    
                    progressBar1.Visible = true;
                    progressBar1.Maximum = 5000;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 4;
                    progressBar1.Step = 1;
                    for (int i = 0; i <= 5000; i++)
                    {
                        progressBar1.PerformStep();
                    }
                   
                    this.Hide();
                   frmMainMenu frm1 = new frmMainMenu();
                   frm1.User.Text = UserID.Text;
                  frm1.Show();
                  st1 = UserID.Text;
                  st2 = "Successfully logged in";
                  cf.LogFunc(st1, System.DateTime.Now, st2);

   }
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UserID.Clear();
                    Password.Clear();
                    UserID.Focus();

                }
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmPasswordRecovery frm = new frmPasswordRecovery();
            frm.txtTo.Focus();
            frm.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmChangePassword frm = new FrmChangePassword();
            frm.Show();
            frm.txtUserID.Text = "";
            frm.txtNewPassword.Text = "";
            frm.txtOldPassword.Text = "";
            frm.txtConfirmPassword.Text = "";
        }
    }
}
