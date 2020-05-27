using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmRemoveMember : Form
    {
        public frmRemoveMember()
        {
            InitializeComponent();
        }

        private void frmRemoveMember_Load(object sender, EventArgs e)
        {
            grdRemoveMember.DataSource = Members.getNonRemovedMembers().Tables["GOLFMEMBERSLOG"];

            //GET MEMBER TYPES + FILL IN COMBOBOX
            OracleConnection connType = new OracleConnection(DBConnect.oradb);
            connType.Open();

            //SQL Query
            String query = "SELECT * FROM MEMBERTYPES";

            OracleCommand cmdType = new OracleCommand(query, connType);
            OracleDataReader drType = cmdType.ExecuteReader();

            while (drType.Read())
            {
                cboRemoveType.Items.Add(drType["TYPEID"].ToString());
            }

            connType.Close();

            //GET COUNTYS + FILL IN COMBOBOX
            OracleConnection connCounty = new OracleConnection(DBConnect.oradb);
            connCounty.Open();

            String queryCounty = "SELECT * FROM COUNTYLIST";

            OracleCommand cmdCounty = new OracleCommand(queryCounty, connCounty);
            OracleDataReader drCounty = cmdCounty.ExecuteReader();

            while (drCounty.Read())
            {
                cboRemoveCounty.Items.Add(drCounty["COUNTY"].ToString());
            }

            connCounty.Close();

            cboRemoveStatus.Items.Add("Active");
            cboRemoveStatus.Items.Add("Inactive");
            cboRemoveStatus.Items.Add("Removed");

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
            this.Hide();
            goBack.Show();
        }

        private void grdRemoveMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get ID from first column of selected rom and store it as variable gridID
            int gridID = Convert.ToInt32(grdRemoveMember.Rows[grdRemoveMember.CurrentCell.RowIndex].Cells[0].Value);

            //Retrieve Widget Details
            Members singleMember = new Members();
            singleMember.getSingleMember(gridID);

            //load Widget details onto form
            txtRemoveId.Text = singleMember.getMemberID().ToString();
            txtRemoveFirstName.Text = singleMember.getFirstName().ToString();
            txtRemoveLastName.Text = singleMember.getLastName().ToString();
            txtRemoveStreet.Text = singleMember.getStreet().ToString();
            txtRemoveTown.Text = singleMember.getTown().ToString();
            cboRemoveCounty.Text = singleMember.getCounty().ToString();
            txtRemoveNumber.Text = singleMember.getMobile().ToString();
            txtRemoveEmail.Text = singleMember.getEmail().ToString();
            cboRemoveStatus.Text = singleMember.getMemberStatus().ToString();
            cboRemoveType.Text = singleMember.getTypeID().ToString();
            txtRemovePaid.Text = singleMember.getPaid().ToString();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {

            if(txtRemoveId.Text == "")
            {
                MessageBox.Show("Please select a Member to remove by clicking their row in the table.", "No Member Selected");

            } else
            {
                //Instantiate Member variables
                Members removeMember = new Members();

                removeMember.setMemberID(Convert.ToInt32(txtRemoveId.Text));
                removeMember.setMemberStatus("Removed");

                //Update database
                removeMember.removeMember();

                //ASK USER IF THEY WANT TO VIEW MEMBERS AFTER UPDATING A MEMBER
                if (MessageBox.Show("Member Removed! Would you like to view all members?", "View Members?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    frmRemoveMember refresh = new frmRemoveMember();
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
    }
}
