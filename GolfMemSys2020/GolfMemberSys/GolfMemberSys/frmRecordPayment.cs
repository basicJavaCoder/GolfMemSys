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
            this.Close();
            backtoMain.Show();
        }

        private void frmRecordPayment_Load(object sender, EventArgs e)
        {
            //determine next RenewalID
            int nextRenewalID = Renewals.getNextRenewalID();

            //Put next RenewalID Into textbox
            txtRecPayRenewalID.Text = nextRenewalID.ToString();

            //Fill grdRecordPayment DataGridView with useful information needed to easily record a payment.
            grdRecordPayment.DataSource = Renewals.getRecordPaymentInformation().Tables[0];

            //GET MEMBER IDs + FILL IN COMBOBOX
            Array comboData = Utility.getMemberIDs();

            foreach (var item in comboData)
            {
                cboRecPayMemberID.Items.Add(item.ToString());
            }

            //Get Member Type Prices + FILL IN COMBOBOX
            Array comboPrice = Utility.getTypePrice();
            
            foreach (var price in comboPrice)
            {
                cboRecPayAmount.Items.Add(price.ToString());
            }

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

                //Convert selected combobox items to string.
            
                Renewals newRenewal = new Renewals();

                newRenewal.setRenewalID(Convert.ToInt32(txtRecPayRenewalID.Text));
                newRenewal.setMemberID(Convert.ToInt32(cboRecPayMemberID.SelectedItem.ToString()));               
                newRenewal.setAmountPaid(Convert.ToDecimal(cboRecPayAmount.SelectedItem.ToString()));

                newRenewal.recordNewPayment();

                //Update the member's paid status to y
                Members updatePaid = new Members();

                updatePaid.setMemberID(Convert.ToInt32(cboRecPayMemberID.SelectedItem.ToString()));

                updatePaid.updatePaidStatus();

                MessageBox.Show("Payment has been recorded!");
                frmRecordPayment refresh = new frmRecordPayment();
                this.Close();
                refresh.Show();
            }

            
        }
    }
}
