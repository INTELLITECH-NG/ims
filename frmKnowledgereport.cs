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
    public partial class frmKnowledgereport : Form
    {
        public frmKnowledgereport()
        {
            InitializeComponent();
        }

        private void frmKnowledgereport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = lblUserType.Text;
            frm.User.Text = lblUser.Text;
            frm.Show();
        }
    }
}
