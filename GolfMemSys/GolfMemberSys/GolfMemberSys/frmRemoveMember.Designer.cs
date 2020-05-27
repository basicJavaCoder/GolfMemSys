namespace GolfMemberSys
{
    partial class frmRemoveMember
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
            this.mnuRemoveMembers = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.grdRemoveMember = new System.Windows.Forms.DataGridView();
            this.grpUpdateMembers = new System.Windows.Forms.GroupBox();
            this.txtRemovePaid = new System.Windows.Forms.TextBox();
            this.txtRemoveEmail = new System.Windows.Forms.TextBox();
            this.txtRemoveNumber = new System.Windows.Forms.TextBox();
            this.cboRemoveStatus = new System.Windows.Forms.ComboBox();
            this.cboRemoveType = new System.Windows.Forms.ComboBox();
            this.cboRemoveCounty = new System.Windows.Forms.ComboBox();
            this.txtRemoveTown = new System.Windows.Forms.TextBox();
            this.txtRemoveStreet = new System.Windows.Forms.TextBox();
            this.txtRemoveLastName = new System.Windows.Forms.TextBox();
            this.txtRemoveFirstName = new System.Windows.Forms.TextBox();
            this.btnRemoveMember = new System.Windows.Forms.Button();
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemoveId = new System.Windows.Forms.TextBox();
            this.mnuRemoveMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveMember)).BeginInit();
            this.grpUpdateMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRemoveMembers
            // 
            this.mnuRemoveMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuRemoveMembers.Location = new System.Drawing.Point(0, 0);
            this.mnuRemoveMembers.Name = "mnuRemoveMembers";
            this.mnuRemoveMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuRemoveMembers.Size = new System.Drawing.Size(1280, 24);
            this.mnuRemoveMembers.TabIndex = 0;
            this.mnuRemoveMembers.Text = "menuStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(375, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Removing a member changes their status to \"Removed\"";
            // 
            // grdRemoveMember
            // 
            this.grdRemoveMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRemoveMember.Location = new System.Drawing.Point(12, 74);
            this.grdRemoveMember.Name = "grdRemoveMember";
            this.grdRemoveMember.Size = new System.Drawing.Size(1256, 303);
            this.grdRemoveMember.TabIndex = 2;
            this.grdRemoveMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemoveMember_CellClick);
            // 
            // grpUpdateMembers
            // 
            this.grpUpdateMembers.Controls.Add(this.txtRemovePaid);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveEmail);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveNumber);
            this.grpUpdateMembers.Controls.Add(this.cboRemoveStatus);
            this.grpUpdateMembers.Controls.Add(this.cboRemoveType);
            this.grpUpdateMembers.Controls.Add(this.cboRemoveCounty);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveTown);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveStreet);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveLastName);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveFirstName);
            this.grpUpdateMembers.Controls.Add(this.btnRemoveMember);
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
            this.grpUpdateMembers.Controls.Add(this.label12);
            this.grpUpdateMembers.Controls.Add(this.txtRemoveId);
            this.grpUpdateMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpUpdateMembers.Location = new System.Drawing.Point(94, 404);
            this.grpUpdateMembers.Name = "grpUpdateMembers";
            this.grpUpdateMembers.Size = new System.Drawing.Size(1074, 297);
            this.grpUpdateMembers.TabIndex = 5;
            this.grpUpdateMembers.TabStop = false;
            this.grpUpdateMembers.Text = "Member Details";
            // 
            // txtRemovePaid
            // 
            this.txtRemovePaid.Enabled = false;
            this.txtRemovePaid.Location = new System.Drawing.Point(451, 243);
            this.txtRemovePaid.MaxLength = 1;
            this.txtRemovePaid.Name = "txtRemovePaid";
            this.txtRemovePaid.Size = new System.Drawing.Size(209, 23);
            this.txtRemovePaid.TabIndex = 22;
            // 
            // txtRemoveEmail
            // 
            this.txtRemoveEmail.Enabled = false;
            this.txtRemoveEmail.Location = new System.Drawing.Point(451, 171);
            this.txtRemoveEmail.MaxLength = 150;
            this.txtRemoveEmail.Name = "txtRemoveEmail";
            this.txtRemoveEmail.Size = new System.Drawing.Size(209, 23);
            this.txtRemoveEmail.TabIndex = 21;
            // 
            // txtRemoveNumber
            // 
            this.txtRemoveNumber.Enabled = false;
            this.txtRemoveNumber.Location = new System.Drawing.Point(152, 172);
            this.txtRemoveNumber.MaxLength = 10;
            this.txtRemoveNumber.Name = "txtRemoveNumber";
            this.txtRemoveNumber.Size = new System.Drawing.Size(177, 23);
            this.txtRemoveNumber.TabIndex = 20;
            // 
            // cboRemoveStatus
            // 
            this.cboRemoveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemoveStatus.Enabled = false;
            this.cboRemoveStatus.FormattingEnabled = true;
            this.cboRemoveStatus.Location = new System.Drawing.Point(810, 171);
            this.cboRemoveStatus.Name = "cboRemoveStatus";
            this.cboRemoveStatus.Size = new System.Drawing.Size(222, 24);
            this.cboRemoveStatus.TabIndex = 19;
            // 
            // cboRemoveType
            // 
            this.cboRemoveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemoveType.Enabled = false;
            this.cboRemoveType.FormattingEnabled = true;
            this.cboRemoveType.Location = new System.Drawing.Point(152, 242);
            this.cboRemoveType.Name = "cboRemoveType";
            this.cboRemoveType.Size = new System.Drawing.Size(177, 24);
            this.cboRemoveType.TabIndex = 18;
            // 
            // cboRemoveCounty
            // 
            this.cboRemoveCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemoveCounty.Enabled = false;
            this.cboRemoveCounty.FormattingEnabled = true;
            this.cboRemoveCounty.Location = new System.Drawing.Point(810, 111);
            this.cboRemoveCounty.Name = "cboRemoveCounty";
            this.cboRemoveCounty.Size = new System.Drawing.Size(222, 24);
            this.cboRemoveCounty.TabIndex = 17;
            // 
            // txtRemoveTown
            // 
            this.txtRemoveTown.Enabled = false;
            this.txtRemoveTown.Location = new System.Drawing.Point(451, 110);
            this.txtRemoveTown.MaxLength = 30;
            this.txtRemoveTown.Name = "txtRemoveTown";
            this.txtRemoveTown.Size = new System.Drawing.Size(209, 23);
            this.txtRemoveTown.TabIndex = 16;
            // 
            // txtRemoveStreet
            // 
            this.txtRemoveStreet.Enabled = false;
            this.txtRemoveStreet.Location = new System.Drawing.Point(152, 110);
            this.txtRemoveStreet.MaxLength = 30;
            this.txtRemoveStreet.Name = "txtRemoveStreet";
            this.txtRemoveStreet.Size = new System.Drawing.Size(177, 23);
            this.txtRemoveStreet.TabIndex = 15;
            // 
            // txtRemoveLastName
            // 
            this.txtRemoveLastName.Enabled = false;
            this.txtRemoveLastName.Location = new System.Drawing.Point(810, 41);
            this.txtRemoveLastName.MaxLength = 150;
            this.txtRemoveLastName.Name = "txtRemoveLastName";
            this.txtRemoveLastName.Size = new System.Drawing.Size(222, 23);
            this.txtRemoveLastName.TabIndex = 14;
            // 
            // txtRemoveFirstName
            // 
            this.txtRemoveFirstName.Enabled = false;
            this.txtRemoveFirstName.Location = new System.Drawing.Point(451, 41);
            this.txtRemoveFirstName.MaxLength = 50;
            this.txtRemoveFirstName.Name = "txtRemoveFirstName";
            this.txtRemoveFirstName.Size = new System.Drawing.Size(209, 23);
            this.txtRemoveFirstName.TabIndex = 13;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(810, 220);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(158, 61);
            this.btnRemoveMember.TabIndex = 12;
            this.btnRemoveMember.Text = "Remove Selected Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Member ID:";
            // 
            // txtRemoveId
            // 
            this.txtRemoveId.Enabled = false;
            this.txtRemoveId.Location = new System.Drawing.Point(152, 38);
            this.txtRemoveId.Name = "txtRemoveId";
            this.txtRemoveId.Size = new System.Drawing.Size(100, 23);
            this.txtRemoveId.TabIndex = 0;
            // 
            // frmRemoveMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 713);
            this.Controls.Add(this.grpUpdateMembers);
            this.Controls.Add(this.grdRemoveMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuRemoveMembers);
            this.MainMenuStrip = this.mnuRemoveMembers;
            this.Name = "frmRemoveMember";
            this.Text = "Remove Members - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmRemoveMember_Load);
            this.mnuRemoveMembers.ResumeLayout(false);
            this.mnuRemoveMembers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemoveMember)).EndInit();
            this.grpUpdateMembers.ResumeLayout(false);
            this.grpUpdateMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRemoveMembers;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdRemoveMember;
        private System.Windows.Forms.GroupBox grpUpdateMembers;
        private System.Windows.Forms.TextBox txtRemovePaid;
        private System.Windows.Forms.TextBox txtRemoveEmail;
        private System.Windows.Forms.TextBox txtRemoveNumber;
        private System.Windows.Forms.ComboBox cboRemoveStatus;
        private System.Windows.Forms.ComboBox cboRemoveType;
        private System.Windows.Forms.ComboBox cboRemoveCounty;
        private System.Windows.Forms.TextBox txtRemoveTown;
        private System.Windows.Forms.TextBox txtRemoveStreet;
        private System.Windows.Forms.TextBox txtRemoveLastName;
        private System.Windows.Forms.TextBox txtRemoveFirstName;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemoveId;
    }
}