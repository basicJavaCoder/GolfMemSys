namespace GolfMemberSys
{
    partial class frmMemberTypeAnalysis
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
            this.dtpAnalysis1 = new System.Windows.Forms.DateTimePicker();
            this.dtpAnalysis2 = new System.Windows.Forms.DateTimePicker();
            this.btnAnalysisDate = new System.Windows.Forms.Button();
            this.grdAnalysisDate = new System.Windows.Forms.DataGridView();
            this.grpAnalysis1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChooseBefore = new System.Windows.Forms.Label();
            this.mnuAnalysis = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAnalysis2 = new System.Windows.Forms.GroupBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblSelectMeberType = new System.Windows.Forms.Label();
            this.grdAnalysisMembers = new System.Windows.Forms.DataGridView();
            this.grdAnalysisType = new System.Windows.Forms.DataGridView();
            this.lblMemberCount = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.txtMemberCount = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisDate)).BeginInit();
            this.grpAnalysis1.SuspendLayout();
            this.mnuAnalysis.SuspendLayout();
            this.grpAnalysis2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisType)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAnalysis1
            // 
            this.dtpAnalysis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpAnalysis1.Location = new System.Drawing.Point(196, 117);
            this.dtpAnalysis1.Name = "dtpAnalysis1";
            this.dtpAnalysis1.Size = new System.Drawing.Size(209, 21);
            this.dtpAnalysis1.TabIndex = 4;
            // 
            // dtpAnalysis2
            // 
            this.dtpAnalysis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpAnalysis2.Location = new System.Drawing.Point(459, 117);
            this.dtpAnalysis2.Name = "dtpAnalysis2";
            this.dtpAnalysis2.Size = new System.Drawing.Size(216, 21);
            this.dtpAnalysis2.TabIndex = 5;
            // 
            // btnAnalysisDate
            // 
            this.btnAnalysisDate.Location = new System.Drawing.Point(253, 208);
            this.btnAnalysisDate.Name = "btnAnalysisDate";
            this.btnAnalysisDate.Size = new System.Drawing.Size(200, 53);
            this.btnAnalysisDate.TabIndex = 8;
            this.btnAnalysisDate.Text = "Show Renewals";
            this.btnAnalysisDate.UseVisualStyleBackColor = true;
            this.btnAnalysisDate.Click += new System.EventHandler(this.btnAnalysisDate_Click);
            // 
            // grdAnalysisDate
            // 
            this.grdAnalysisDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnalysisDate.Location = new System.Drawing.Point(89, 288);
            this.grdAnalysisDate.Name = "grdAnalysisDate";
            this.grdAnalysisDate.Size = new System.Drawing.Size(520, 261);
            this.grdAnalysisDate.TabIndex = 9;
            // 
            // grpAnalysis1
            // 
            this.grpAnalysis1.Controls.Add(this.label1);
            this.grpAnalysis1.Controls.Add(this.lblChooseBefore);
            this.grpAnalysis1.Controls.Add(this.dtpAnalysis1);
            this.grpAnalysis1.Controls.Add(this.grdAnalysisDate);
            this.grpAnalysis1.Controls.Add(this.dtpAnalysis2);
            this.grpAnalysis1.Controls.Add(this.btnAnalysisDate);
            this.grpAnalysis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpAnalysis1.Location = new System.Drawing.Point(24, 27);
            this.grpAnalysis1.Name = "grpAnalysis1";
            this.grpAnalysis1.Size = new System.Drawing.Size(690, 573);
            this.grpAnalysis1.TabIndex = 10;
            this.grpAnalysis1.TabStop = false;
            this.grpAnalysis1.Text = "Show Renewals by date.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(411, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "and";
            // 
            // lblChooseBefore
            // 
            this.lblChooseBefore.AutoSize = true;
            this.lblChooseBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChooseBefore.Location = new System.Drawing.Point(6, 117);
            this.lblChooseBefore.Name = "lblChooseBefore";
            this.lblChooseBefore.Size = new System.Drawing.Size(181, 20);
            this.lblChooseBefore.TabIndex = 10;
            this.lblChooseBefore.Text = "Show renewals between";
            // 
            // mnuAnalysis
            // 
            this.mnuAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuAnalysis.Name = "mnuAnalysis";
            this.mnuAnalysis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuAnalysis.Size = new System.Drawing.Size(1335, 24);
            this.mnuAnalysis.TabIndex = 11;
            this.mnuAnalysis.Text = "menuStrip1";
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
            // grpAnalysis2
            // 
            this.grpAnalysis2.Controls.Add(this.txtIncome);
            this.grpAnalysis2.Controls.Add(this.txtMemberCount);
            this.grpAnalysis2.Controls.Add(this.lblIncome);
            this.grpAnalysis2.Controls.Add(this.lblMemberCount);
            this.grpAnalysis2.Controls.Add(this.lblMembers);
            this.grpAnalysis2.Controls.Add(this.lblSelectMeberType);
            this.grpAnalysis2.Controls.Add(this.grdAnalysisMembers);
            this.grpAnalysis2.Controls.Add(this.grdAnalysisType);
            this.grpAnalysis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpAnalysis2.Location = new System.Drawing.Point(738, 27);
            this.grpAnalysis2.Name = "grpAnalysis2";
            this.grpAnalysis2.Size = new System.Drawing.Size(585, 563);
            this.grpAnalysis2.TabIndex = 12;
            this.grpAnalysis2.TabStop = false;
            this.grpAnalysis2.Text = "Show Members by Member Type";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(155, 265);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(255, 20);
            this.lblMembers.TabIndex = 3;
            this.lblMembers.Text = "Members in selected Member Type";
            // 
            // lblSelectMeberType
            // 
            this.lblSelectMeberType.AutoSize = true;
            this.lblSelectMeberType.Location = new System.Drawing.Point(32, 54);
            this.lblSelectMeberType.Name = "lblSelectMeberType";
            this.lblSelectMeberType.Size = new System.Drawing.Size(519, 20);
            this.lblSelectMeberType.TabIndex = 2;
            this.lblSelectMeberType.Text = "Select a member type below to see the active members that are part of it";
            // 
            // grdAnalysisMembers
            // 
            this.grdAnalysisMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnalysisMembers.Location = new System.Drawing.Point(6, 288);
            this.grdAnalysisMembers.Name = "grdAnalysisMembers";
            this.grdAnalysisMembers.Size = new System.Drawing.Size(573, 160);
            this.grdAnalysisMembers.TabIndex = 1;
            // 
            // grdAnalysisType
            // 
            this.grdAnalysisType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnalysisType.Location = new System.Drawing.Point(6, 77);
            this.grdAnalysisType.Name = "grdAnalysisType";
            this.grdAnalysisType.Size = new System.Drawing.Size(573, 160);
            this.grdAnalysisType.TabIndex = 0;
            this.grdAnalysisType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAnalysisType_CellClick);
            // 
            // lblMemberCount
            // 
            this.lblMemberCount.AutoSize = true;
            this.lblMemberCount.Location = new System.Drawing.Point(7, 489);
            this.lblMemberCount.Name = "lblMemberCount";
            this.lblMemberCount.Size = new System.Drawing.Size(189, 20);
            this.lblMemberCount.TabIndex = 4;
            this.lblMemberCount.Text = "Total member in this type:";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(7, 529);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(255, 20);
            this.lblIncome.TabIndex = 5;
            this.lblIncome.Text = "Initial income from these members:";
            // 
            // txtMemberCount
            // 
            this.txtMemberCount.Enabled = false;
            this.txtMemberCount.Location = new System.Drawing.Point(277, 488);
            this.txtMemberCount.Name = "txtMemberCount";
            this.txtMemberCount.Size = new System.Drawing.Size(100, 26);
            this.txtMemberCount.TabIndex = 6;
            // 
            // txtIncome
            // 
            this.txtIncome.Enabled = false;
            this.txtIncome.Location = new System.Drawing.Point(277, 528);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 26);
            this.txtIncome.TabIndex = 7;
            // 
            // frmNewTypeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 612);
            this.Controls.Add(this.grpAnalysis2);
            this.Controls.Add(this.grpAnalysis1);
            this.Controls.Add(this.mnuAnalysis);
            this.MainMenuStrip = this.mnuAnalysis;
            this.Name = "frmNewTypeAnalysis";
            this.Text = "Membership Type Analysis - GolfMembersSys";
            this.Load += new System.EventHandler(this.frmNewTypeAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisDate)).EndInit();
            this.grpAnalysis1.ResumeLayout(false);
            this.grpAnalysis1.PerformLayout();
            this.mnuAnalysis.ResumeLayout(false);
            this.mnuAnalysis.PerformLayout();
            this.grpAnalysis2.ResumeLayout(false);
            this.grpAnalysis2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnalysisType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpAnalysis1;
        private System.Windows.Forms.DateTimePicker dtpAnalysis2;
        private System.Windows.Forms.Button btnAnalysisDate;
        private System.Windows.Forms.DataGridView grdAnalysisDate;
        private System.Windows.Forms.GroupBox grpAnalysis1;
        private System.Windows.Forms.MenuStrip mnuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChooseBefore;
        private System.Windows.Forms.GroupBox grpAnalysis2;
        private System.Windows.Forms.DataGridView grdAnalysisType;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblSelectMeberType;
        private System.Windows.Forms.DataGridView grdAnalysisMembers;
        private System.Windows.Forms.TextBox txtMemberCount;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblMemberCount;
        private System.Windows.Forms.TextBox txtIncome;
    }
}