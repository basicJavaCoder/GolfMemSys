namespace GolfMemberSys
{
    partial class frmViewMembers
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
            this.grdViewMembers = new System.Windows.Forms.DataGridView();
            this.mnuViewMembers = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radFirstName = new System.Windows.Forms.RadioButton();
            this.radCounty = new System.Windows.Forms.RadioButton();
            this.radStatus = new System.Windows.Forms.RadioButton();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.picViewMember = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMembers)).BeginInit();
            this.mnuViewMembers.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewMembers
            // 
            this.grdViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewMembers.Location = new System.Drawing.Point(12, 309);
            this.grdViewMembers.Name = "grdViewMembers";
            this.grdViewMembers.Size = new System.Drawing.Size(1260, 281);
            this.grdViewMembers.TabIndex = 0;
            // 
            // mnuViewMembers
            // 
            this.mnuViewMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuViewMembers.Location = new System.Drawing.Point(0, 0);
            this.mnuViewMembers.Name = "mnuViewMembers";
            this.mnuViewMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuViewMembers.Size = new System.Drawing.Size(1284, 24);
            this.mnuViewMembers.TabIndex = 1;
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
            // radFirstName
            // 
            this.radFirstName.AutoSize = true;
            this.radFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radFirstName.Location = new System.Drawing.Point(776, 42);
            this.radFirstName.Name = "radFirstName";
            this.radFirstName.Size = new System.Drawing.Size(104, 24);
            this.radFirstName.TabIndex = 2;
            this.radFirstName.TabStop = true;
            this.radFirstName.Text = "First Name";
            this.radFirstName.UseVisualStyleBackColor = true;
            this.radFirstName.Click += new System.EventHandler(this.radFirstName_Click);
            // 
            // radCounty
            // 
            this.radCounty.AutoSize = true;
            this.radCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radCounty.Location = new System.Drawing.Point(41, 42);
            this.radCounty.Name = "radCounty";
            this.radCounty.Size = new System.Drawing.Size(77, 24);
            this.radCounty.TabIndex = 3;
            this.radCounty.TabStop = true;
            this.radCounty.Text = "County";
            this.radCounty.UseVisualStyleBackColor = true;
            this.radCounty.Click += new System.EventHandler(this.radCounty_Click);
            // 
            // radStatus
            // 
            this.radStatus.AutoSize = true;
            this.radStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radStatus.Location = new System.Drawing.Point(387, 42);
            this.radStatus.Name = "radStatus";
            this.radStatus.Size = new System.Drawing.Size(132, 24);
            this.radStatus.TabIndex = 4;
            this.radStatus.TabStop = true;
            this.radStatus.Text = "MemberStatus";
            this.radStatus.UseVisualStyleBackColor = true;
            this.radStatus.Click += new System.EventHandler(this.radStatus_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radCounty);
            this.grpOrder.Controls.Add(this.radFirstName);
            this.grpOrder.Controls.Add(this.radStatus);
            this.grpOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(193, 174);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(917, 100);
            this.grpOrder.TabIndex = 5;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Select a sort order";
            // 
            // picViewMember
            // 
            this.picViewMember.Location = new System.Drawing.Point(12, 27);
            this.picViewMember.Name = "picViewMember";
            this.picViewMember.Size = new System.Drawing.Size(247, 130);
            this.picViewMember.TabIndex = 6;
            this.picViewMember.TabStop = false;
            // 
            // frmViewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 602);
            this.Controls.Add(this.picViewMember);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grdViewMembers);
            this.Controls.Add(this.mnuViewMembers);
            this.MainMenuStrip = this.mnuViewMembers;
            this.Name = "frmViewMembers";
            this.Text = "View Members - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmViewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewMembers)).EndInit();
            this.mnuViewMembers.ResumeLayout(false);
            this.mnuViewMembers.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdViewMembers;
        private System.Windows.Forms.MenuStrip mnuViewMembers;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.RadioButton radFirstName;
        private System.Windows.Forms.RadioButton radCounty;
        private System.Windows.Forms.RadioButton radStatus;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.PictureBox picViewMember;
    }
}