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
            this.mnuMemTypeAnalysis = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMemType = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTypeCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTypeRevenue = new System.Windows.Forms.Label();
            this.grdDisplayMembers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mnuMemTypeAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMemTypeAnalysis
            // 
            this.mnuMemTypeAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuMemTypeAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuMemTypeAnalysis.Name = "mnuMemTypeAnalysis";
            this.mnuMemTypeAnalysis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMemTypeAnalysis.Size = new System.Drawing.Size(971, 24);
            this.mnuMemTypeAnalysis.TabIndex = 0;
            this.mnuMemTypeAnalysis.Text = "menuStrip1";
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Member Type to see information related to it.";
            // 
            // grdMemType
            // 
            this.grdMemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMemType.Location = new System.Drawing.Point(408, 43);
            this.grdMemType.Name = "grdMemType";
            this.grdMemType.Size = new System.Drawing.Size(378, 150);
            this.grdMemType.TabIndex = 2;
            this.grdMemType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "There are :";
            // 
            // lblTypeCount
            // 
            this.lblTypeCount.AutoSize = true;
            this.lblTypeCount.Location = new System.Drawing.Point(123, 288);
            this.lblTypeCount.Name = "lblTypeCount";
            this.lblTypeCount.Size = new System.Drawing.Size(0, 13);
            this.lblTypeCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(170, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "registered members of this type.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current revenue generated by this member type is:  ";
            // 
            // lblTypeRevenue
            // 
            this.lblTypeRevenue.AutoSize = true;
            this.lblTypeRevenue.Location = new System.Drawing.Point(405, 350);
            this.lblTypeRevenue.Name = "lblTypeRevenue";
            this.lblTypeRevenue.Size = new System.Drawing.Size(0, 13);
            this.lblTypeRevenue.TabIndex = 7;
            // 
            // grdDisplayMembers
            // 
            this.grdDisplayMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayMembers.Location = new System.Drawing.Point(507, 282);
            this.grdDisplayMembers.Name = "grdDisplayMembers";
            this.grdDisplayMembers.Size = new System.Drawing.Size(452, 150);
            this.grdDisplayMembers.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(606, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Members from selected Member Type.";
            // 
            // frmMemberTypeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdDisplayMembers);
            this.Controls.Add(this.lblTypeRevenue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTypeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdMemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMemTypeAnalysis);
            this.MainMenuStrip = this.mnuMemTypeAnalysis;
            this.Name = "frmMemberTypeAnalysis";
            this.Text = "Membership Type Analysis - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmMemberTypeAnalysis_Load);
            this.mnuMemTypeAnalysis.ResumeLayout(false);
            this.mnuMemTypeAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMemTypeAnalysis;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdMemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTypeCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTypeRevenue;
        private System.Windows.Forms.DataGridView grdDisplayMembers;
        private System.Windows.Forms.Label label5;
    }
}