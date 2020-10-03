using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmViewMembers : Form
    {
        public frmViewMembers()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu goBack = new frmMainMenu();
            this.Close();
            goBack.Show();
        }

        private void frmViewMembers_Load(object sender, EventArgs e)
        {
            grdViewMembers.DataSource = Members.getMembers().Tables["GOLFMEMBERSLOG"];
        }

        private void radFirstName_Click(object sender, EventArgs e)
        {
            grdViewMembers.DataSource = Members.getMembers("FIRSTNAME").Tables["GOLFMEMBERSLOG"];
        }

        private void radCounty_Click(object sender, EventArgs e)
        {
            grdViewMembers.DataSource = Members.getMembers("COUNTY").Tables["GOLFMEMBERSLOG"];
        }

        private void radStatus_Click(object sender, EventArgs e)
        {
            grdViewMembers.DataSource = Members.getMembers("MEMBERSTATUS").Tables["GOLFMEMBERSLOG"];
        }

    }
}
