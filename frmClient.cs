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
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net.Sockets;
using System.IO;


namespace CRM
{
    public partial class frmClient : Form
    {
      
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd,cmd1 = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmClient()
        {
            InitializeComponent();
        }

        public void Email()
        {
            try
            {

                if (checkInternetCon())
                {

                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("vaibhavpatidar36@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Your Password Details : You Can Change It From Change Password Icon on Login Page";
                    Msg.Body = label22.Text.ToString();        //"Your Password:"+ Convert.ToString(ds.Tables[0].Rows[0]["Password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new System.Net.NetworkCredential("vaibhavpatidar36@gmail.com", "Enter password");
                    smtp.Send(Msg);
                    MessageBox.Show(("Password Successfully sent on your Email ID " + ("\r\n" + "Please check your mail")), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    MessageBox.Show("You are not connected to internet Write client's password manually");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void auto()
        {
            try
            {
                int Num = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string sql = "SELECT MAX(ID+1) FROM Client";
                cmd = new SqlCommand(sql);
                cmd.Connection = con;
                if (Convert.IsDBNull(cmd.ExecuteScalar()))
                {
                    Num = 1;
                    ID.Text = Convert.ToString(Num);
                    txtuserID.Text = Convert.ToString("CX" + Num);
                }
                else
                {
                    Num = (int)(cmd.ExecuteScalar());
                    ID.Text = Convert.ToString(Num);
                    txtuserID.Text = Convert.ToString("CX" + Num);
                }
                cmd.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            label22.Text = "";
            label22.Visible = false;
            

            txtMobileNo.Text = "";
            txtTelephoneNo.Text = "";
            txtFaxNo.Text = "";
            cmbClientType.SelectedIndex = -1;
           cmbH_State.SelectedIndex = -1;
          cmbW_State.Text = "";
            cmbH_State.Text="";
            cmbW_State.SelectedIndex = -1;
           txtClientOfficer.SelectedIndex = -1;
            txtSecetory.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtIDNo.Text = "";
            txtLastName.Text = "";
           txtH_Street.Text = "";
            txtH_City.Text = "";
           txtW_City.Text = "";
            txtW_Street.Text = "";
         dtpExpiryDate.Text = DateTime.Today.ToString();
           txtW_Zip.Text = "";
            txtH_Zip.Text = "";
            txtSecetory.Text = "";
            txtClientOfficer.Text = "";
            cmbH_Country.SelectedIndex = -1;
            cmbIssuedCountry.SelectedIndex = -1;
           cmbW_Country.SelectedIndex = -1;
            cmbIDType.SelectedIndex = -1;
           txtInterest.SelectedIndex= -1;

      txtDirectors.SelectedIndex = -1;
            txtClientOfficer.SelectedIndex = -1;
          txtCategorization.SelectedIndex = -1;
         txtSecetory.SelectedIndex = -1;
         txtBOwner.SelectedIndex = -1;

            txtEmail.Text = "";
    
           txtmoneycommited.Text = "";
        
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnRemove.Enabled = false;
            dataGridView1.Rows.Clear();
        }

    
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
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
        public void document()
        {
            con = new SqlConnection(cs.DBcon);
            con.Open();

            string cb1 = "insert into Document(ClientID,Photo) VALUES (" + ID.Text + ",@d51)";
            cmd1 = new SqlCommand(cb1);
            cmd1.Connection = con;
            // Add Parameters to Command Parameters collection
            cmd1.Prepare();

            // Data to be inserted
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                MemoryStream ms1 = new MemoryStream();
                Image img = (Image)(row.Cells[0].Value); //explicit conversion

                Bitmap bmpImage1 = new Bitmap(img);

                bmpImage1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data1 = ms1.GetBuffer();
                SqlParameter p1 = new SqlParameter("@d51", SqlDbType.Image);
                p1.Value = data1;
                cmd1.Parameters.Add(p1);
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();
            }



            con.Close();
        }
        public void document1()
        {
            con = new SqlConnection(cs.DBcon);
            con.Open();

            string cb1 = "insert into Document(ClientID,Photo) VALUES (" + ID.Text + ",@d51)";
            cmd1 = new SqlCommand(cb1);
            cmd1.Connection = con;
            // Add Parameters to Command Parameters collection
            cmd1.Prepare();

            // Data to be inserted
        
                MemoryStream ms1 = new MemoryStream();
                Bitmap bmpImage1 = new Bitmap(pictureBox2.Image);

                bmpImage1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data1 = ms1.GetBuffer();
                SqlParameter p1 = new SqlParameter("@d51", SqlDbType.Image);
                p1.Value = data1;
                cmd1.Parameters.Add(p1);
                cmd1.ExecuteNonQuery();
                cmd1.Parameters.Clear();
                con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please enter First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                    return;
                }
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Please Enter Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                    return;
                }
                if (cmbClientType.Text == "")
                {
                    MessageBox.Show("Please Select Client Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbClientType.Focus();
                    return;
                }
                if (txtH_Street.Text == "")
                {
                    MessageBox.Show("Please enter father's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtH_Street.Focus();
                    return;
                }
                if (txtH_City.Text == "")
                {
                    MessageBox.Show("Please enter client's Home City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtH_City.Focus();
                    return;
                }
                if (cmbW_State.Text == "")
                {
                    MessageBox.Show("Please enter client's Work State name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbW_State.Focus();
                    return;
                }
                if (cmbH_Country.Text == "")
                {
                    MessageBox.Show("Please enter Client's Home Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbH_Country.Focus();
                    return;
                }
                if (txtW_City.Text == "")
                {
                    MessageBox.Show("Please client's work City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtW_City.Focus();
                    return;
                }
                if (txtMobileNo.Text == "")
                {
                    MessageBox.Show("Please enter mobile no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMobileNo.Focus();
                    return;
                }

                if (txtW_Zip.Text == "")
                {
                    MessageBox.Show("Please select Client's Work Zip", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtW_Zip.Focus();
                    return;
                }
                if (cmbIssuedCountry.Text == "")
                {
                    MessageBox.Show("Please enter Issued Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbIssuedCountry.Focus();
                    return;
                }
                if (txtSecetory.Text == "")
                {
                    MessageBox.Show("Please enter Secetory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSecetory.Focus();
                    return;
                }
                if (txtCategorization.Text == "")
                {
                    MessageBox.Show("Please enter Categorization", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategorization.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                if (cmbIDType.Text == "")
                {
                    MessageBox.Show("Please Select ID Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbIDType.Focus();
                    return;
                }

                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("Please browse & select photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Focus();
                    return;
                }
                if (txtClientOfficer.Text == "")
                {
                    MessageBox.Show("Please enter client Officer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClientOfficer.Focus();
                    return;
                }

                if (cmbW_Country.Text == null)
                {
                    MessageBox.Show("Please enter client's work country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbW_Country.Focus();
                    return;
                }
                if (cmbW_State.Text == null)
                {
                    MessageBox.Show("Please enter client's work state ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbW_State.Focus();
                    return;
                }

                    Cursor = Cursors.WaitCursor;
                    timer1.Enabled = true;
                    label22.Visible = true;

                    label22.Text = GetUniqueKey(4);
                    con = new SqlConnection(cs.DBcon);
                    con.Open();

                    string cb = "insert into client(ID,UserID,FirstName,LastName,ClientType,HStreet,HCity,Hstate,Hzip,Hcountry,IDtype,IDNo,Expdate,Telephone,mobile,FaxNo,Email,WStreet,WCity,Wstate,Wzip,Wcountry,Password,Clientofficers,interestlevel,MoneyCommited,Secetory,Picture,Icountry,Categorization,Bowner,Directors) VALUES (" + ID.Text + ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23,@d24,@d25,@d26,@d27,@d28,@d29,@d30,@d31)";
                    cmd = new SqlCommand(cb);

                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@d1", txtuserID.Text);
                    cmd.Parameters.AddWithValue("@d2", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@d3", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@d4", cmbClientType.Text);
                    cmd.Parameters.AddWithValue("@d5", txtH_Street.Text);
                    cmd.Parameters.AddWithValue("@d6", txtH_City.Text);
                    cmd.Parameters.AddWithValue("@d7", cmbH_State.Text);
                    cmd.Parameters.AddWithValue("@d8", txtH_Zip.Text);
                    cmd.Parameters.AddWithValue("@d9", cmbH_Country.Text);

                    cmd.Parameters.AddWithValue("@d10", cmbIDType.Text);
                    cmd.Parameters.AddWithValue("@d11", txtIDNo.Text);
                    cmd.Parameters.AddWithValue("@d12", dtpExpiryDate.Value.Date);
                    cmd.Parameters.AddWithValue("@d13", txtTelephoneNo.Text);
                    cmd.Parameters.AddWithValue("@d14", txtMobileNo.Text);
                    cmd.Parameters.AddWithValue("@d15", txtFaxNo.Text);
                    cmd.Parameters.AddWithValue("@d16", txtEmail.Text);

                    cmd.Parameters.AddWithValue("@d17", txtW_Street.Text);
                    cmd.Parameters.AddWithValue("@d18", txtW_City.Text);
                    cmd.Parameters.AddWithValue("@d19", cmbW_State.Text);
                    cmd.Parameters.AddWithValue("@d20", txtW_Zip.Text);
                    cmd.Parameters.AddWithValue("@d21", cmbW_Country.Text);
                    cmd.Parameters.AddWithValue("@d22", label22.Text);
                    cmd.Parameters.AddWithValue("@d23", txtClientOfficer.Text);

                    cmd.Parameters.AddWithValue("@d24", txtInterest.Text);
                    cmd.Parameters.AddWithValue("@d25", txtmoneycommited.Text);
                    cmd.Parameters.AddWithValue("@d26", txtSecetory.Text);
                    cmd.Parameters.AddWithValue("@d28", cmbIssuedCountry.Text);
                    cmd.Parameters.AddWithValue("@d29", txtCategorization.Text);
                    cmd.Parameters.AddWithValue("@d30", txtBOwner.Text);
                    cmd.Parameters.AddWithValue("@d31", txtDirectors.Text);




                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(pictureBox1.Image);

                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d27", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (dataGridView1.Rows.Count > 0)
                    {
                        document();
                    }
                    else if (dataGridView1.Rows.Count == 0)
                    {
                        document1();
                    }

                 MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 st1 = lblUser.Text;
                 st2 = "New Client  is Added Having FirstName='" + txtFirstName.Text + "'and LastName='" + txtLastName.Text + "'";
                 cf.LogFunc(st1, System.DateTime.Now, st2);
                     btnSave.Enabled = false;

                 }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
            auto();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _with1 = openFileDialog1;

            _with1.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.ico");
            _with1.FilterIndex = 4;

            //Clear the file name
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
              
                string cb2 = "update Client set FirstName=@d3,Lastname=@d4,ClientType=@d5,Hstreet=@d6, Hcity=@d7,Hstate=@d8,HZip=@d9,Hcountry=@d10,IDType=@d11,IDNO=@d12,ExpDate=@d13,Telephone=@d14,Mobile=@d15,FaxNo=@d16,Email=@d17,Wstreet=@d19,  Wcity=@d18,Wstate=@d19,WZip=@d20,Wcountry=@d21,ClientOfficers=@d22,InterestLevel=@d23,MoneyCommited=@d24,Secetory=@d25,Picture=@d26,Icountry=@d27,Categorization=@d28,Bowner=@d29,Directors=@d30 where id='"+ID.Text+"'";
                cmd = new SqlCommand(cb2);
                cmd.Connection = con;

               
                // cmd.Parameters["@d2"].Value = txtuserID.Text;
                cmd.Parameters.AddWithValue("@d3",txtFirstName.Text);
                cmd.Parameters.AddWithValue("@d4" ,txtLastName.Text);
                cmd.Parameters.AddWithValue("@d5",  cmbClientType.Text);
                cmd.Parameters.AddWithValue("@d6",txtH_Street.Text);
                cmd.Parameters.AddWithValue("@d7", txtH_City.Text);
                cmd.Parameters.AddWithValue("@d8",cmbH_State.Text);
                cmd.Parameters.AddWithValue("@d9",txtH_Zip.Text);
                cmd.Parameters.AddWithValue("@d10",cmbH_Country.Text);
                cmd.Parameters.AddWithValue("@d11", cmbIDType.Text);
                cmd.Parameters.AddWithValue("@d12",txtIDNo.Text);
                cmd.Parameters.AddWithValue("@d13", dtpExpiryDate.Value.Date);
                cmd.Parameters.AddWithValue("@d14",txtTelephoneNo.Text);
                cmd.Parameters.AddWithValue("@d15",txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@d16", txtFaxNo.Text);
                cmd.Parameters.AddWithValue("@d17",txtEmail.Text);
                cmd.Parameters.AddWithValue("@d18",txtW_Street.Text);
               
                cmd.Parameters.AddWithValue("@d19",txtW_City.Text);
                cmd.Parameters.AddWithValue("@d20",txtW_Zip.Text);
                cmd.Parameters.AddWithValue("@d21",cmbW_Country.Text);
                cmd.Parameters.AddWithValue("@d22" , txtClientOfficer.Text);
                cmd.Parameters.AddWithValue("@d23",txtInterest.Text);
                cmd.Parameters.AddWithValue("@d24", txtmoneycommited.Text);
                cmd.Parameters.AddWithValue("@d25", txtSecetory.Text);
                cmd.Parameters.AddWithValue("@d27", cmbIssuedCountry.Text);
                cmd.Parameters.AddWithValue("@d28" ,txtCategorization.Text);
                cmd.Parameters.AddWithValue("@d29" , txtBOwner.Text);
                cmd.Parameters.AddWithValue("@d30",txtDirectors.Text);

                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d26", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteReader();
                con.Close();
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Document  where ClientID='" + ID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                document();

                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     st1 = lblUser.Text;
                    st2 = "Client is updated  having FirstName='" + txtFirstName.Text + "'and LastName='" + txtLastName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);   
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            lblHeader.Width = this.Width;
            auto();
           
        }

        private void cmbH_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(Hstate),Rtrim(Hcountry) from Client Where Hcountry='" + cmbH_Country.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbH_State.Items.Add(rdr[0]);


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbW_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();
                string ct1 = "select distinct RTRIM(wstate),Rtrim(wcountry) from Client Where wcountry='" + cmbW_Country.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbW_State.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientRecords frm = new frmClientRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.SET1.Text = "CS";
            frm.Show();
        }
        private void delete_records()
        {

            try
            {

                int RowsAffected = 0;

                con = new SqlConnection(cs.DBcon);

                con.Open();
                string cm = "select ClientID from investment where clientID=@find";


                cmd = new SqlCommand(cm);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.Int, 10, "clientID"));


                cmd.Parameters["@find"].Value = ID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from Client  where ID='" + ID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Client is deleted having FirstName='" + txtFirstName.Text + "'and LastName='" + txtLastName.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                //GetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete_records();
        }
        public void getdata()
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                cmd = new SqlCommand("SELECT rtrim(Document.ID), rtrim(document.Photo) from Document,Client where client.ID = Document.ClientID", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1]);
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
            dataGridView1.Rows.Add(pictureBox2.Image);
            
      }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnRemove.Enabled = true;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.Rows.Remove(row);
            }
            btnRemove.Enabled = false;
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            var _with2 = openFileDialog1;

            _with2.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.ico");
            _with2.FilterIndex = 4;

            //Clear the file name
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
    }

