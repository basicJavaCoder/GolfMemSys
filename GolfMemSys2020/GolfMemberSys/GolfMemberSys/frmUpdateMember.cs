using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            grdUpdateMembers.DataSource = Members.getSummaryMembers().Tables["GOLFMEMBERSLOG"];

            //GET MEMBER TYPES + FILL IN COMBOBOX
            Array comboData = Utility.getMemberTypes();

            foreach (var item in comboData)
            {
                cboUpdateType.Items.Add(item.ToString());
            }

            //GET COUNTYS + FILL IN COMBOBOX

            Array countyData = Utility.getCountyList();

            foreach (var item in countyData)
            {
                cboUpdateCounty.Items.Add(item.ToString());
            }
            
            //Fill member statuses into cboUpdateStatus
            Array statusArray = Utility.getMemberStatuses();

            foreach (var status in statusArray)
            {
                cboUpdateStatus.Items.Add(status);
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu goBack = new frmMainMenu();
            this.Close();
            goBack.Show();
        }


        private void grdUpdateMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Get ID from first column of selected rom and store it as variable gridID
            int gridID = Convert.ToInt32(grdUpdateMembers.Rows[grdUpdateMembers.CurrentCell.RowIndex].Cells[0].Value);

            //Retrieve Member Details
            Members singleMember = new Members();
            singleMember.getSingleMember(gridID);

            //load Member details onto form
            txtUpdateId.Text = singleMember.getMemberID().ToString();
            txtUpdateFirstName.Text = singleMember.getFirstName().ToString();
            txtUpdateLastName.Text = singleMember.getLastName().ToString();
            txtUpdateStreet.Text = singleMember.getStreet().ToString();
            txtUpdateTown.Text = singleMember.getTown().ToString();
            cboUpdateCounty.Text = singleMember.getCounty().ToString();
            txtUpdateNumber.Text = singleMember.getMobile().ToString();
            txtUpdateEmail.Text = singleMember.getEmail().ToString();
            cboUpdateStatus.Text = singleMember.getMemberStatus().ToString();
            cboUpdateType.Text = singleMember.getTypeID().ToString();
            cboUpdatePaid.Text = singleMember.getPaid().ToString();

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

        //RegEx string from https://stackoverflow.com/questions/12776428/how-to-validate-textbox-value-is-string-in-c-sharp-windows-form-application

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (txtUpdateFirstName.Text == "" || !Members.validateTextBox(txtUpdateFirstName.Text))
            {
                MessageBox.Show("Please enter a valid first name.", "Invalid Infomation");
                txtUpdateFirstName.Focus();

            } else if (txtUpdateLastName.Text == "" || !Members.validateTextBox(txtUpdateLastName.Text))
            {
                MessageBox.Show("Please enter a valid last name.", "Invalid Infomation");
                txtUpdateLastName.Focus();

            } else if (txtUpdateStreet.Text == "")
            {
                MessageBox.Show("Please enter a street name.", "Invalid Infomation");
                txtUpdateStreet.Focus();

            } else if (txtUpdateTown.Text == "" || !Members.validateTextBox(txtUpdateTown.Text))
            {
                MessageBox.Show("Please enter a valid town name.", "Invalid Infomation");
                txtUpdateTown.Focus();

            } else if (cboUpdateCounty.SelectedItem == null)
            {
                MessageBox.Show("Please select a county.", "Invalid Infomation");
                cboUpdateCounty.Focus();

            } else if (txtUpdateNumber.Text == "")
            {
                MessageBox.Show("Please enter a valid phone number", "Invalid Infomation");
                txtUpdateNumber.Focus();

            } else if (txtUpdateEmail.Text == "" || !Members.validateEmail(txtUpdateEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Infomation");
                txtUpdateEmail.Focus();

            } else if (cboUpdateStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a Member Status.", "Invalid Infomation");
                cboUpdateStatus.Focus();

            } else if (cboUpdateType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Membership Type", "Invalid Infomation");
                cboUpdateType.Focus();

            } else if (cboUpdatePaid.SelectedItem == null)
            {
                MessageBox.Show("Please enter either y or n to indicate if Member has paid or not", "Invalid Infomation");
                cboUpdatePaid.Focus();
            }
            else
            {
                //Instantiate Member variables
                Members updateMember = new Members();

                updateMember.setMemberID(Convert.ToInt32(txtUpdateId.Text));
                updateMember.setMemberFirstName(txtUpdateFirstName.Text);
                updateMember.setMemberLastName(txtUpdateLastName.Text);
                updateMember.setStreet(txtUpdateStreet.Text);
                updateMember.setTown(txtUpdateTown.Text);
                updateMember.setCounty(cboUpdateCounty.SelectedItem.ToString());
                updateMember.setMobile(txtUpdateNumber.Text);
                updateMember.setEmail(txtUpdateEmail.Text);
                updateMember.setMemberStatus(cboUpdateStatus.SelectedItem.ToString());
                updateMember.setTypeID(cboUpdateType.SelectedItem.ToString());
                updateMember.setPaid(cboUpdatePaid.SelectedItem.ToString());

                //Update database
                updateMember.updateMember();

                //ASK USER IF THEY WANT TO VIEW MEMBERS AFTER UPDATING A MEMBER
                if (MessageBox.Show("Member Details Updated! Would you like to view all members?", "View Members?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    frmUpdateMember refresh = new frmUpdateMember();
                    this.Close();
                    refresh.Show();
                }
                else
                {
                    frmViewMembers viewMembers = new frmViewMembers();
                    this.Close();
                    viewMembers.Show();
                }
            }

        }

    }
}
