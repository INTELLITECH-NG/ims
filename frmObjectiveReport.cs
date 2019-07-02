using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class frmObjectiveReport : Form
    {
        public frmObjectiveReport()
        {
            InitializeComponent();
        }

        private void frmObjectiveReport_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }
    }
}
