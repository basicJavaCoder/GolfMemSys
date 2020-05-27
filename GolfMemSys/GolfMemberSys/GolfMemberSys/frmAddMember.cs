using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace GolfMemberSys
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu goBack = new frmMainMenu();
            this.Hide();
            goBack.Show();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            //determine next ClientID
            txtMemId.Text = Members.getNextMemberID().ToString();

            //Get county list from table + fill in combobox
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //SQL Query
            String strSQL = "SELECT * FROM COUNTYLIST";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cboCounty.Items.Add(dr["COUNTY"].ToString());
            }

            conn.Close();


            //GET MEMBER TYPES + FILL IN COMBOBOX
            OracleConnection connType = new OracleConnection(DBConnect.oradb);
            connType.Open();

            //SQL Query
            String query = "SELECT * FROM MEMBERTYPES";

            OracleCommand cmdType = new OracleCommand(query, connType);
            OracleDataReader drType = cmdType.ExecuteReader();

            while (drType.Read())
            {
                cboMemberType.Items.Add(drType["TYPEID"].ToString());
            }

            connType.Close();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || !Members.validateTextBox(txtFirstName.Text))
            {
                MessageBox.Show("Please enter valid First name.", "Invalid Infomation");
                txtFirstName.Focus();

            } else if(txtLastName.Text == "" || !Members.validateTextBox(txtLastName.Text))
            {
                MessageBox.Show("Please enter valid Last name.", "Invalid Infomation");
                txtLastName.Focus();

            } else if(txtStreet.Text == "")
            {
                MessageBox.Show("Please enter a street name.", "Invalid Infomation");
                txtStreet.Focus();

            } else if(txtTown.Text == "" || !Members.validateTextBox(txtTown.Text))
            {
                MessageBox.Show("Please enter a valid town name.", "Invalid Infomation");
                txtTown.Focus();

            } else if(cboCounty.SelectedItem == null)
            {
                MessageBox.Show("Please select a county.", "Invalid Infomation");
                cboCounty.Focus();

            } else if(txtMobile.Text == "" || txtMobile.Text[0] != '0')
            {
                MessageBox.Show("Please enter a valid phone number. Phone numbers begin with 0.", "Invalid Infomation");
                txtMobile.Focus();

            } else if(txtEmail.Text == "" || !Members.validateEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Infomation");
                txtEmail.Focus();

            } else if(cboMemberType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Member Type.", "Invalid Infomation");
                cboMemberType.Focus();
            }
            else
            {
                //Set Data
                Members addMember = new Members();

                addMember.setMemberID(Convert.ToInt32(txtMemId.Text));
                addMember.setMemberFirstName(txtFirstName.Text);
                addMember.setMemberLastName(txtLastName.Text);
                addMember.setStreet(txtStreet.Text);
                addMember.setTown(txtTown.Text);
                addMember.setCounty(cboCounty.SelectedItem.ToString());
                addMember.setMobile(txtMobile.Text);
                addMember.setEmail(txtEmail.Text);
                addMember.setMemberStatus("Active");
                addMember.setTypeID(cboMemberType.SelectedItem.ToString());

                //SAVE DATA
                addMember.addMember();

                MessageBox.Show("Newly added members given unpaid status by default. If the member has already paid for this year's membership then confirm their payment in the Record Payment section.", "Information");

                //ASK USER IF THEY WANT TO VIEW MEMBERS AFTER ADDING A NEW MEMBER
                if (MessageBox.Show("Member Added! Would you like to view all members?", "View Members?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    frmAddMember refresh = new frmAddMember();
                    this.Hide();
                    refresh.Show();
                }
                else
                {
                    frmViewMembers viewMembers = new frmViewMembers();
                    this.Hide();
                    viewMembers.Show();
                }

            }

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

    }
}
