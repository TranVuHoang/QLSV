using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using adao_lib;

namespace QLSV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsersUpdate usu = new UsersUpdate();
            DataTable u = usu.getUserPass(this.txtUsername.Text.Trim(), this.txtPassword.Text.Trim());

            if (u.Rows.Count == 0)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("User name or password is wrong! Please checking again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtUsername.Focus();
            }
            else
            {
                frmGeneral frm = new frmGeneral();
                frm.Show();
                this.Hide();

                frmMain frmm = new frmMain();
                frmm.MdiParent = frm;
                frmm.Show();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
