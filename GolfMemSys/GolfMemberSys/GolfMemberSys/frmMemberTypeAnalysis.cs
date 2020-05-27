﻿using System;
using System.Windows.Forms;

namespace GolfMemberSys
{
    public partial class frmMemberTypeAnalysis : Form
    {
        public frmMemberTypeAnalysis()
        {
            InitializeComponent();
        }

        private void frmMemberTypeAnalysis_Load(object sender, EventArgs e)
        {
            grdMemType.DataSource = MemberTypes.getMemberTypes().Tables["MEMBERTYPES"];
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
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get typeID from selected row in the datagrid and assign it to typeID
            String typeID = grdMemType.Rows[grdMemType.CurrentCell.RowIndex].Cells[0].Value.ToString();

            //Create new MemberType object to call getTypeCount() with the typeID
            MemberTypes singleType = new MemberTypes();
            int typeCount = singleType.getTypeCount(typeID);

            //Display typeCount on the UI as a label.
            lblTypeCount.Text = typeCount.ToString();

            //Fill the second Datagrid with the members of the selected Membership Type.
            grdDisplayMembers.DataSource = Members.getMembersFromType(typeID).Tables["GOLFMEMBERSLOG"];

            //Get the current revenue generated by the member type selected
            MemberTypes typeIncome = new MemberTypes();
            decimal income = typeIncome.getTypeRevenue(typeID);

            decimal currentRevenue = income * typeCount;
            
            lblTypeRevenue.Text = currentRevenue.ToString();

        }
    }
}
