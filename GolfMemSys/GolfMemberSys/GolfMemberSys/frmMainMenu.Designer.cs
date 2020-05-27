namespace GolfMemberSys
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMembershipTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipTypeAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.renewalsToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 0;
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMembersToolStripMenuItem,
            this.addMembershipTypeToolStripMenuItem,
            this.addMemberToolStripMenuItem,
            this.updateMemberToolStripMenuItem,
            this.removeMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.memberToolStripMenuItem.Text = "Members";
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click);
            // 
            // addMembershipTypeToolStripMenuItem
            // 
            this.addMembershipTypeToolStripMenuItem.Name = "addMembershipTypeToolStripMenuItem";
            this.addMembershipTypeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addMembershipTypeToolStripMenuItem.Text = "Add membership Type";
            this.addMembershipTypeToolStripMenuItem.Click += new System.EventHandler(this.addMembershipTypeToolStripMenuItem_Click);
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // updateMemberToolStripMenuItem
            // 
            this.updateMemberToolStripMenuItem.Name = "updateMemberToolStripMenuItem";
            this.updateMemberToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.updateMemberToolStripMenuItem.Text = "Update Member";
            this.updateMemberToolStripMenuItem.Click += new System.EventHandler(this.updateMemberToolStripMenuItem_Click);
            // 
            // removeMemberToolStripMenuItem
            // 
            this.removeMemberToolStripMenuItem.Name = "removeMemberToolStripMenuItem";
            this.removeMemberToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeMemberToolStripMenuItem.Text = "Remove Member";
            this.removeMemberToolStripMenuItem.Click += new System.EventHandler(this.removeMemberToolStripMenuItem_Click);
            // 
            // renewalsToolStripMenuItem
            // 
            this.renewalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordPaymentToolStripMenuItem});
            this.renewalsToolStripMenuItem.Name = "renewalsToolStripMenuItem";
            this.renewalsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.renewalsToolStripMenuItem.Text = "Renewals";
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membershipTypeAnalysisToolStripMenuItem});
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeToolStripMenuItem.Text = "Finance";
            // 
            // membershipTypeAnalysisToolStripMenuItem
            // 
            this.membershipTypeAnalysisToolStripMenuItem.Name = "membershipTypeAnalysisToolStripMenuItem";
            this.membershipTypeAnalysisToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.membershipTypeAnalysisToolStripMenuItem.Text = "Membership Type Analysis";
            this.membershipTypeAnalysisToolStripMenuItem.Click += new System.EventHandler(this.membershipTypeAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitAppToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // quitAppToolStripMenuItem
            // 
            this.quitAppToolStripMenuItem.Name = "quitAppToolStripMenuItem";
            this.quitAppToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.quitAppToolStripMenuItem.Text = "Quit App";
            this.quitAppToolStripMenuItem.Click += new System.EventHandler(this.quitAppToolStripMenuItem_Click);
            // 
            // picMainMenu
            // 
            this.picMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMainMenu.BackgroundImage")));
            this.picMainMenu.Location = new System.Drawing.Point(12, 136);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(776, 302);
            this.picMainMenu.TabIndex = 1;
            this.picMainMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(152, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to the Golf Membership Management System!";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu - GolfMemberSys";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMembershipTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitAppToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membershipTypeAnalysisToolStripMenuItem;
    }
}

