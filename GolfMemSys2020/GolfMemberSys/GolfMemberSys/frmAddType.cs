using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmAddType : Form
    {
        public frmAddType()
        {
            InitializeComponent();
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu goBack = new frmMainMenu();
            this.Close();
            goBack.Show();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            decimal tmpDecimal;

            if(txtTypeId.Text == "" || !Members.validateTextBox(txtTypeId.Text))
            {
                MessageBox.Show("Please enter a Type ID. TypeID is two characters in length.", "Invalid Information");
                txtTypeId.Focus();

            } else if(txtTypeName.Text == "" || !Members.validateTextBox(txtTypeName.Text))
            {
                MessageBox.Show("Please enter a valid description.", "Invalid Information");
                txtTypeName.Focus();

            } else if(txtTypePrice.Text == "" || !decimal.TryParse(txtTypePrice.Text, out tmpDecimal))
            {
                MessageBox.Show("Please enter a valid Type Price to 2 decimal places.", "Invalid Information");
            } else
            {
                MemberTypes newType = new MemberTypes();

                newType.setTypeID(txtTypeId.Text);
                newType.setTypeName(txtTypeName.Text);
                newType.setTypePrice(Convert.ToDecimal(txtTypePrice.Text));

                newType.addMemberType();

                MessageBox.Show("Member Type Added!");
                frmAddType refresh = new frmAddType();
                this.Close();
                refresh.Show();
            }
            
        }

    }
}
