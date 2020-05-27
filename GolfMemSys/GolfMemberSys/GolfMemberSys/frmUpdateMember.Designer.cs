namespace GolfMemberSys
{
    partial class frmUpdateMember
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
            this.mnuViewMembers = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdUpdateMembers = new System.Windows.Forms.DataGridView();
            this.grpUpdateMembers = new System.Windows.Forms.GroupBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateNumber = new System.Windows.Forms.TextBox();
            this.cboUpdateStatus = new System.Windows.Forms.ComboBox();
            this.cboUpdateType = new System.Windows.Forms.ComboBox();
            this.cboUpdateCounty = new System.Windows.Forms.ComboBox();
            this.txtUpdateTown = new System.Windows.Forms.TextBox();
            this.txtUpdateStreet = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.cboUpdatePaid = new System.Windows.Forms.ComboBox();
            this.mnuViewMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMembers)).BeginInit();
            this.grpUpdateMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewMembers
            // 
            this.mnuViewMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuViewMembers.Location = new System.Drawing.Point(0, 0);
            this.mnuViewMembers.Name = "mnuViewMembers";
            this.mnuViewMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuViewMembers.Size = new System.Drawing.Size(1098, 24);
            this.mnuViewMembers.TabIndex = 2;
            this.mnuViewMembers.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grdUpdateMembers
            // 
            this.grdUpdateMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUpdateMembers.Location = new System.Drawing.Point(12, 36);
            this.grdUpdateMembers.Name = "grdUpdateMembers";
            this.grdUpdateMembers.Size = new System.Drawing.Size(1074, 236);
            this.grdUpdateMembers.TabIndex = 3;
            this.grdUpdateMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateMembers_CellClick);
            // 
            // grpUpdateMembers
            // 
            this.grpUpdateMembers.Controls.Add(this.cboUpdatePaid);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateEmail);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateNumber);
            this.grpUpdateMembers.Controls.Add(this.cboUpdateStatus);
            this.grpUpdateMembers.Controls.Add(this.cboUpdateType);
            this.grpUpdateMembers.Controls.Add(this.cboUpdateCounty);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateTown);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateStreet);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateLastName);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateFirstName);
            this.grpUpdateMembers.Controls.Add(this.btnUpdateMember);
            this.grpUpdateMembers.Controls.Add(this.label11);
            this.grpUpdateMembers.Controls.Add(this.label10);
            this.grpUpdateMembers.Controls.Add(this.label9);
            this.grpUpdateMembers.Controls.Add(this.label8);
            this.grpUpdateMembers.Controls.Add(this.label7);
            this.grpUpdateMembers.Controls.Add(this.label6);
            this.grpUpdateMembers.Controls.Add(this.label5);
            this.grpUpdateMembers.Controls.Add(this.label4);
            this.grpUpdateMembers.Controls.Add(this.label3);
            this.grpUpdateMembers.Controls.Add(this.label2);
            this.grpUpdateMembers.Controls.Add(this.label1);
            this.grpUpdateMembers.Controls.Add(this.txtUpdateId);
            this.grpUpdateMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpUpdateMembers.Location = new System.Drawing.Point(12, 291);
            this.grpUpdateMembers.Name = "grpUpdateMembers";
            this.grpUpdateMembers.Size = new System.Drawing.Size(1074, 297);
            this.grpUpdateMembers.TabIndex = 4;
            this.grpUpdateMembers.TabStop = false;
            this.grpUpdateMembers.Text = "Member Details";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(451, 171);
            this.txtUpdateEmail.MaxLength = 150;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(209, 23);
            this.txtUpdateEmail.TabIndex = 21;
            // 
            // txtUpdateNumber
            // 
            this.txtUpdateNumber.Location = new System.Drawing.Point(152, 172);
            this.txtUpdateNumber.MaxLength = 10;
            this.txtUpdateNumber.Name = "txtUpdateNumber";
            this.txtUpdateNumber.Size = new System.Drawing.Size(177, 23);
            this.txtUpdateNumber.TabIndex = 20;
            // 
            // cboUpdateStatus
            // 
            this.cboUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateStatus.FormattingEnabled = true;
            this.cboUpdateStatus.Location = new System.Drawing.Point(810, 171);
            this.cboUpdateStatus.Name = "cboUpdateStatus";
            this.cboUpdateStatus.Size = new System.Drawing.Size(222, 24);
            this.cboUpdateStatus.TabIndex = 19;
            // 
            // cboUpdateType
            // 
            this.cboUpdateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateType.FormattingEnabled = true;
            this.cboUpdateType.Location = new System.Drawing.Point(152, 242);
            this.cboUpdateType.Name = "cboUpdateType";
            this.cboUpdateType.Size = new System.Drawing.Size(177, 24);
            this.cboUpdateType.TabIndex = 18;
            // 
            // cboUpdateCounty
            // 
            this.cboUpdateCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateCounty.FormattingEnabled = true;
            this.cboUpdateCounty.Location = new System.Drawing.Point(810, 111);
            this.cboUpdateCounty.Name = "cboUpdateCounty";
            this.cboUpdateCounty.Size = new System.Drawing.Size(222, 24);
            this.cboUpdateCounty.TabIndex = 17;
            // 
            // txtUpdateTown
            // 
            this.txtUpdateTown.Location = new System.Drawing.Point(451, 110);
            this.txtUpdateTown.MaxLength = 30;
            this.txtUpdateTown.Name = "txtUpdateTown";
            this.txtUpdateTown.Size = new System.Drawing.Size(209, 23);
            this.txtUpdateTown.TabIndex = 16;
            // 
            // txtUpdateStreet
            // 
            this.txtUpdateStreet.Location = new System.Drawing.Point(152, 110);
            this.txtUpdateStreet.MaxLength = 30;
            this.txtUpdateStreet.Name = "txtUpdateStreet";
            this.txtUpdateStreet.Size = new System.Drawing.Size(177, 23);
            this.txtUpdateStreet.TabIndex = 15;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(810, 41);
            this.txtUpdateLastName.MaxLength = 150;
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(222, 23);
            this.txtUpdateLastName.TabIndex = 14;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(451, 41);
            this.txtUpdateFirstName.MaxLength = 50;
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(209, 23);
            this.txtUpdateFirstName.TabIndex = 13;
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(810, 220);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(158, 61);
            this.btnUpdateMember.TabIndex = 12;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(354, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Paid?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Member Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Member Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mobile Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "County:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Town:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID:";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Enabled = false;
            this.txtUpdateId.Location = new System.Drawing.Point(152, 38);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(100, 23);
            this.txtUpdateId.TabIndex = 0;
            // 
            // cboUpdatePaid
            // 
            this.cboUpdatePaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdatePaid.FormattingEnabled = true;
            this.cboUpdatePaid.Items.AddRange(new object[] {
            "y",
            "n"});
            this.cboUpdatePaid.Location = new System.Drawing.Point(451, 244);
            this.cboUpdatePaid.Name = "cboUpdatePaid";
            this.cboUpdatePaid.Size = new System.Drawing.Size(121, 24);
            this.cboUpdatePaid.TabIndex = 22;
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 600);
            this.Controls.Add(this.grpUpdateMembers);
            this.Controls.Add(this.grdUpdateMembers);
            this.Controls.Add(this.mnuViewMembers);
            this.Name = "frmUpdateMember";
            this.Text = "Update Members - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.mnuViewMembers.ResumeLayout(false);
            this.mnuViewMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateMembers)).EndInit();
            this.grpUpdateMembers.ResumeLayout(false);
            this.grpUpdateMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewMembers;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdUpdateMembers;
        private System.Windows.Forms.GroupBox grpUpdateMembers;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateNumber;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.ComboBox cboUpdateType;
        private System.Windows.Forms.ComboBox cboUpdateCounty;
        private System.Windows.Forms.TextBox txtUpdateTown;
        private System.Windows.Forms.TextBox txtUpdateStreet;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboUpdatePaid;
    }
}