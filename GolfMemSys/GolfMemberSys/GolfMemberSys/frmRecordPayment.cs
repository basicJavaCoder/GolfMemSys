using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmRecordPayment : Form
    {
        public frmRecordPayment()
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
            frmMainMenu backtoMain = new frmMainMenu();
            this.Hide();
            backtoMain.Show();
        }

        private void frmRecordPayment_Load(object sender, EventArgs e)
        {
            //determine next RenewalID
            int nextRenewalID = Renewals.getNextRenewalID();

            //Put next RenewalID Into textbox
            txtRecPayRenewalID.Text = nextRenewalID.ToString();

            //Get a view of all tables to provide useful information to make recording new payments easier.
            grdRecPayMembers.DataSource = Members.getMembersWithTypeID().Tables["GOLFMEMBERSLOG"];
            grdRecPayRenewals.DataSource = Renewals.getRenewals().Tables["RENEWALS"];
            grdTypePrice.DataSource = MemberTypes.getTypePrices().Tables["MEMBERTYPES"];

            //GET MEMBER IDs + FILL IN COMBOBOX
            OracleConnection connType = new OracleConnection(DBConnect.oradb);
            connType.Open();

            //SQL Query
            String query = "SELECT MEMBERID FROM GOLFMEMBERSLOG";

            OracleCommand cmdType = new OracleCommand(query, connType);
            OracleDataReader drType = cmdType.ExecuteReader();

            while (drType.Read())
            {
                cboRecPayMemberID.Items.Add(drType["MEMBERID"].ToString());
            }

            connType.Close();


            //Get member type prices + fill in combobox
            //GET MEMBER IDs + FILL IN COMBOBOX
            OracleConnection connPrice = new OracleConnection(DBConnect.oradb);
            connPrice.Open();

            //SQL Query
            String priceQuery = "SELECT TYPEPRICE FROM MEMBERTYPES";

            OracleCommand cmdPrice = new OracleCommand(priceQuery, connPrice);
            OracleDataReader drPrice = cmdPrice.ExecuteReader();

            while (drPrice.Read())
            {
                cboRecPayAmount.Items.Add(drPrice["TYPEPRICE"].ToString());
            }

            connType.Close();

        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {

            if (txtRecPayRenewalID.Text == "")
            {
                MessageBox.Show("Please fill out the other fields before recording payment.", "Invalid Information");

            } else if (cboRecPayMemberID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Member ID", "Invalid Information");
                cboRecPayMemberID.Focus();

            } else if (cboRecPayAmount.SelectedItem == null)
            {
                MessageBox.Show("Please select Amount to Pay.", "Invalid Information");
                cboRecPayAmount.Focus();

            } else
            {
                //MemberTypes newType = new MemberTypes();
                Renewals newRenewal = new Renewals();

                newRenewal.setRenewalID(Convert.ToInt32(txtRecPayRenewalID.Text));
                newRenewal.setMemberID(Convert.ToInt32(cboRecPayMemberID.SelectedItem.ToString()));
                newRenewal.setAmountPaid(Convert.ToDecimal(cboRecPayAmount.SelectedItem.ToString()));

                newRenewal.recordNewPayment();

                //Update the member's paid status to y
                Members updatePaid = new Members();

                updatePaid.setMemberID(Convert.ToInt32(cboRecPayMemberID.SelectedItem.ToString()));

                updatePaid.updatePaidStatus();

                MessageBox.Show("Payment Recorded! The Paid status for this member was set to y also.");
                frmRecordPayment refresh = new frmRecordPayment();
                this.Hide();
                refresh.Show();
            }

            
        }
    }
}
