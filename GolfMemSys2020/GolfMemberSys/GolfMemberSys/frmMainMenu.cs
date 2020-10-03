using System;
using System.Data;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

        }


        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember addMember = new frmAddMember();
            this.Hide();
            addMember.Show();
        }

        private void quitAppToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewMembers viewMembers = new frmViewMembers();
            this.Hide();
            viewMembers.Show();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateMember updateMember = new frmUpdateMember();
            this.Hide();
            updateMember.Show();
        }

        private void addMembershipTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddType newType = new frmAddType();
            this.Hide();
            newType.Show();
        }

        private void removeMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveMember removeMember = new frmRemoveMember();
            this.Hide();
            removeMember.Show();
        }


        private void recordPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecordPayment newPayment = new frmRecordPayment();
            this.Hide();
            newPayment.Show();
        }

        private void membershipTypeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberTypeAnalysis showAnalysis = new frmMemberTypeAnalysis();
            this.Hide();
            showAnalysis.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

            DataSet dsn = Members.getExpiredMembers();

            if (dsn.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("There are Members due for renewals, Please record the payments.","Renewal Notice");
            }

        }

    }
}
