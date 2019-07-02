using System;
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
    public partial class frmActivity : Form
    {

        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        Connectionstring cs = new Connectionstring();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            txtdate.Focus();
            txtdate.Text = System.DateTime.Today.ToString();
            Autocompletes();
            Autostaff();
        }
        private void Autocompletes()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(ID) from Contact ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtcontactID.Items.Add(rdr[0]);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Autostaff()
        {
            try
            {

                con = new SqlConnection(cs.DBcon);
                con.Open();


                string ct = "select distinct RTRIM(StaffName) from Employee ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtAssignedto.Items.Add(rdr[0]);

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.User.Text = lblUser.Text;
            frm.UserType.Text = lblUserType.Text;
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "insert into Activity(Dates,ContactID,ActivityType,Status,Subject,Notes,staffid) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d2", txtcontactID.Text);
                cmd.Parameters.AddWithValue("@d3", txtActivityType.Text);
                cmd.Parameters.AddWithValue("@d4", txtstatus.Text);
                cmd.Parameters.AddWithValue("@d5", txtsubject.Text);
                cmd.Parameters.AddWithValue("@d6", txtNotes.Text);
                cmd.Parameters.AddWithValue("@d7", txtstaffID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                st1 = lblUser.Text;
                st2 = "New Activity  is Assigned For='" + txtAssignedto.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             try
            {

                int RowsAffected = 0;
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cq1 = "delete from activity  where ID='" + txtID.Text + "'";
                cmd = new SqlCommand(cq1);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    st1 = lblUser.Text;
                    st2 = "Activity is deleted For='" +txtAssignedto.Text + "'";
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
        private void Reset()
        {
          
           txtNotes.Text = "";
            txtsubject.Text = "";

          txtstaffID.Text = "";
            txtAssignedto.Text = "";
           txtActivityType.Text = "";
           txtstatus.Text = "";
            txtNotes.Text = "";
         txtcontactID.Text = "";
            txtdate.Text = System.DateTime.Today.ToString();
           
            txtID.Text = "";

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);
                con.Open();
                string cb = "Update Activity set Dates=@d1,ContactID=@d2,ActivityType=@d3,Status=@d4,Subject=@d5,Notes=@d6,staffid=@d7 where id=@d8";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@d2", txtcontactID.Text);
                cmd.Parameters.AddWithValue("@d3", txtActivityType.Text);
                cmd.Parameters.AddWithValue("@d4", txtstatus.Text);
                cmd.Parameters.AddWithValue("@d5", txtsubject.Text);
                cmd.Parameters.AddWithValue("@d6", txtNotes.Text);
                cmd.Parameters.AddWithValue("@d7", txtstaffID.Text);
                cmd.Parameters.AddWithValue("@d8", txtID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                st1 = lblUser.Text;
                st2 = "New Activity  is Assigned For='" + txtAssignedto.Text + "'";
                cf.LogFunc(st1, System.DateTime.Now, st2);
                MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcontactname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT ContactName,ID FROM contact where  ID = '" +txtcontactID.Text+ "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                  txtContact.Text = rdr.GetString(0).Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAssignedto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBcon);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT staffID,StaffName FROM Employee where  StaffName = '" + txtAssignedto.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                   txtstaffID.Text = rdr.GetString(0).Trim();
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmActivitiesRecords frm = new frmActivitiesRecords();
            frm.lblUser.Text = lblUser.Text;
            frm.lblUserType.Text = lblUserType.Text;
            frm.SET.Text = "CS";
            frm.Show();
        }
    }
}
