﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace CRM
{
    public partial class frmPasswordRecovery : Form
    {
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }
        public bool checkInternetCon()
        {
            try
            {
                TcpClient Tcp = new TcpClient("WWW.GMAIL.COM", 80);
                Tcp.Close();
                return true;
            }
            catch
            {
                return false;

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                MessageBox.Show("Enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTo.Focus();
                return;
            }
            if (checkInternetCon())
            {
                MessageBox.Show("You are Connected to Internet");

            }
            else
            {
                MessageBox.Show("Please Connect to Internet");
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(cs.DBcon);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM User_Registration Where Email = '"+txtTo.Text+"' union Select Password from Client Where Email = '" + txtTo.Text + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("vaibhavpatidar36@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtTo.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Your Password: " + Convert.ToString(ds.Tables[0].Rows[0]["Password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("vaibhavpatidar36@gmail.com", "Your Password");
                    smtp.Send(Msg);
                    MessageBox.Show(("Password Successfully sent " + ("\r\n" + "Please check your mail")), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();
                    st1 = lblUser.Text;
                    st2 = "Password Is Recovered";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    frmLogin LoginForm1 = new frmLogin();
                    LoginForm1.Show();
                    LoginForm1.UserID.Text = "";
                    LoginForm1.Password.Text = "";
                    LoginForm1.cmbUsertype.Text = "";
                    LoginForm1.progressBar1.Visible = false;

                    LoginForm1.cmbUsertype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPasswordRecovery_Load(object sender, EventArgs e)
        {

        }

        private void frmPasswordRecovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
