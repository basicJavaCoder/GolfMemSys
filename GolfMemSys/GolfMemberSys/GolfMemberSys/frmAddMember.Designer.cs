namespace GolfMemberSys
{
    partial class frmAddMember
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
            this.grpAddMember = new System.Windows.Forms.GroupBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.cboMemberType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemId = new System.Windows.Forms.Label();
            this.mnuAddMember = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddMessage = new System.Windows.Forms.Label();
            this.lblAddMessage2 = new System.Windows.Forms.Label();
            this.grpAddMember.SuspendLayout();
            this.mnuAddMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddMember
            // 
            this.grpAddMember.Controls.Add(this.btnAddMember);
            this.grpAddMember.Controls.Add(this.txtTown);
            this.grpAddMember.Controls.Add(this.cboMemberType);
            this.grpAddMember.Controls.Add(this.txtEmail);
            this.grpAddMember.Controls.Add(this.txtMobile);
            this.grpAddMember.Controls.Add(this.cboCounty);
            this.grpAddMember.Controls.Add(this.txtStreet);
            this.grpAddMember.Controls.Add(this.txtLastName);
            this.grpAddMember.Controls.Add(this.txtFirstName);
            this.grpAddMember.Controls.Add(this.txtMemId);
            this.grpAddMember.Controls.Add(this.label9);
            this.grpAddMember.Controls.Add(this.label8);
            this.grpAddMember.Controls.Add(this.label7);
            this.grpAddMember.Controls.Add(this.label6);
            this.grpAddMember.Controls.Add(this.label5);
            this.grpAddMember.Controls.Add(this.label4);
            this.grpAddMember.Controls.Add(this.label3);
            this.grpAddMember.Controls.Add(this.label2);
            this.grpAddMember.Controls.Add(this.lblMemId);
            this.grpAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpAddMember.Location = new System.Drawing.Point(32, 85);
            this.grpAddMember.Name = "grpAddMember";
            this.grpAddMember.Size = new System.Drawing.Size(717, 343);
            this.grpAddMember.TabIndex = 0;
            this.grpAddMember.TabStop = false;
            this.grpAddMember.Text = "Member Details";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddMember.Location = new System.Drawing.Point(249, 269);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(216, 65);
            this.btnAddMember.TabIndex = 18;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(307, 121);
            this.txtTown.MaxLength = 30;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(131, 21);
            this.txtTown.TabIndex = 5;
            // 
            // cboMemberType
            // 
            this.cboMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberType.FormattingEnabled = true;
            this.cboMemberType.Location = new System.Drawing.Point(590, 211);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Size = new System.Drawing.Size(121, 23);
            this.cboMemberType.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(307, 216);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 21);
            this.txtEmail.TabIndex = 8;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(111, 213);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 21);
            this.txtMobile.TabIndex = 7;
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(590, 121);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 23);
            this.cboCounty.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(111, 118);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 21);
            this.txtStreet.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(591, 39);
            this.txtLastName.MaxLength = 150;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(307, 33);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 21);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(111, 33);
            this.txtMemId.MaxLength = 3;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(100, 21);
            this.txtMemId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Member Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mobile:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "County:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Town:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Street:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Location = new System.Drawing.Point(22, 33);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(72, 15);
            this.lblMemId.TabIndex = 0;
            this.lblMemId.Text = "Member ID:";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuAddMember.Location = new System.Drawing.Point(0, 0);
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuAddMember.Size = new System.Drawing.Size(776, 24);
            this.mnuAddMember.TabIndex = 1;
            this.mnuAddMember.Text = "menuStrip1";
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
            // lblAddMessage
            // 
            this.lblAddMessage.AutoSize = true;
            this.lblAddMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddMessage.Location = new System.Drawing.Point(191, 24);
            this.lblAddMessage.Name = "lblAddMessage";
            this.lblAddMessage.Size = new System.Drawing.Size(411, 24);
            this.lblAddMessage.TabIndex = 2;
            this.lblAddMessage.Text = "Members will be given \"Active\" status by default.";
            // 
            // lblAddMessage2
            // 
            this.lblAddMessage2.AutoSize = true;
            this.lblAddMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddMessage2.Location = new System.Drawing.Point(107, 58);
            this.lblAddMessage2.Name = "lblAddMessage2";
            this.lblAddMessage2.Size = new System.Drawing.Size(559, 24);
            this.lblAddMessage2.TabIndex = 3;
            this.lblAddMessage2.Text = "New member\'s sign up date will be the current date of the system.";
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 445);
            this.Controls.Add(this.lblAddMessage2);
            this.Controls.Add(this.lblAddMessage);
            this.Controls.Add(this.grpAddMember);
            this.Controls.Add(this.mnuAddMember);
            this.MainMenuStrip = this.mnuAddMember;
            this.Name = "frmAddMember";
            this.Text = "Add Member - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.grpAddMember.ResumeLayout(false);
            this.grpAddMember.PerformLayout();
            this.mnuAddMember.ResumeLayout(false);
            this.mnuAddMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddMember;
        private System.Windows.Forms.MenuStrip mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.ComboBox cboMemberType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblAddMessage;
        private System.Windows.Forms.Label lblAddMessage2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}