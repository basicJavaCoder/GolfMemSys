namespace GolfMemberSys
{
    partial class frmRecordPayment
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
            this.mnuMakePayment = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRecordPayment = new System.Windows.Forms.GroupBox();
            this.cboRecPayAmount = new System.Windows.Forms.ComboBox();
            this.cboRecPayMemberID = new System.Windows.Forms.ComboBox();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.txtRecPayRenewalID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdRecordPayment = new System.Windows.Forms.DataGridView();
            this.lblRecordPayment = new System.Windows.Forms.Label();
            this.oracleDataAdapter1 = new Oracle.ManagedDataAccess.Client.OracleDataAdapter();
            this.mnuMakePayment.SuspendLayout();
            this.grpRecordPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMakePayment
            // 
            this.mnuMakePayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuMakePayment.Location = new System.Drawing.Point(0, 0);
            this.mnuMakePayment.Name = "mnuMakePayment";
            this.mnuMakePayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMakePayment.Size = new System.Drawing.Size(960, 24);
            this.mnuMakePayment.TabIndex = 0;
            this.mnuMakePayment.Text = "menuStrip1";
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
            // grpRecordPayment
            // 
            this.grpRecordPayment.Controls.Add(this.cboRecPayAmount);
            this.grpRecordPayment.Controls.Add(this.cboRecPayMemberID);
            this.grpRecordPayment.Controls.Add(this.btnRecordPayment);
            this.grpRecordPayment.Controls.Add(this.txtRecPayRenewalID);
            this.grpRecordPayment.Controls.Add(this.label5);
            this.grpRecordPayment.Controls.Add(this.label4);
            this.grpRecordPayment.Controls.Add(this.label3);
            this.grpRecordPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpRecordPayment.Location = new System.Drawing.Point(192, 371);
            this.grpRecordPayment.Name = "grpRecordPayment";
            this.grpRecordPayment.Size = new System.Drawing.Size(572, 208);
            this.grpRecordPayment.TabIndex = 6;
            this.grpRecordPayment.TabStop = false;
            this.grpRecordPayment.Text = "Payment Details";
            // 
            // cboRecPayAmount
            // 
            this.cboRecPayAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecPayAmount.FormattingEnabled = true;
            this.cboRecPayAmount.Location = new System.Drawing.Point(204, 128);
            this.cboRecPayAmount.Name = "cboRecPayAmount";
            this.cboRecPayAmount.Size = new System.Drawing.Size(100, 24);
            this.cboRecPayAmount.TabIndex = 8;
            // 
            // cboRecPayMemberID
            // 
            this.cboRecPayMemberID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecPayMemberID.FormattingEnabled = true;
            this.cboRecPayMemberID.Location = new System.Drawing.Point(204, 83);
            this.cboRecPayMemberID.Name = "cboRecPayMemberID";
            this.cboRecPayMemberID.Size = new System.Drawing.Size(100, 24);
            this.cboRecPayMemberID.TabIndex = 7;
            // 
            // btnRecordPayment
            // 
            this.btnRecordPayment.Location = new System.Drawing.Point(380, 65);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(165, 52);
            this.btnRecordPayment.TabIndex = 6;
            this.btnRecordPayment.Text = "Record Payment";
            this.btnRecordPayment.UseVisualStyleBackColor = true;
            this.btnRecordPayment.Click += new System.EventHandler(this.btnRecordPayment_Click);
            // 
            // txtRecPayRenewalID
            // 
            this.txtRecPayRenewalID.Enabled = false;
            this.txtRecPayRenewalID.Location = new System.Drawing.Point(204, 38);
            this.txtRecPayRenewalID.MaxLength = 3;
            this.txtRecPayRenewalID.Name = "txtRecPayRenewalID";
            this.txtRecPayRenewalID.Size = new System.Drawing.Size(100, 23);
            this.txtRecPayRenewalID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount to Pay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Member ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Renewal ID:";
            // 
            // grdRecordPayment
            // 
            this.grdRecordPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecordPayment.Location = new System.Drawing.Point(12, 80);
            this.grdRecordPayment.Name = "grdRecordPayment";
            this.grdRecordPayment.Size = new System.Drawing.Size(936, 265);
            this.grdRecordPayment.TabIndex = 7;
            // 
            // lblRecordPayment
            // 
            this.lblRecordPayment.AutoSize = true;
            this.lblRecordPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRecordPayment.Location = new System.Drawing.Point(366, 43);
            this.lblRecordPayment.Name = "lblRecordPayment";
            this.lblRecordPayment.Size = new System.Drawing.Size(220, 24);
            this.lblRecordPayment.TabIndex = 8;
            this.lblRecordPayment.Text = "Payment Information Grid";
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 591);
            this.Controls.Add(this.grdRecordPayment);
            this.Controls.Add(this.lblRecordPayment);
            this.Controls.Add(this.grpRecordPayment);
            this.Controls.Add(this.mnuMakePayment);
            this.MainMenuStrip = this.mnuMakePayment;
            this.Name = "frmRecordPayment";
            this.Text = "Record Payment - GolfMemberSys";
            this.Load += new System.EventHandler(this.frmRecordPayment_Load);
            this.mnuMakePayment.ResumeLayout(false);
            this.mnuMakePayment.PerformLayout();
            this.grpRecordPayment.ResumeLayout(false);
            this.grpRecordPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecordPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMakePayment;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpRecordPayment;
        private System.Windows.Forms.TextBox txtRecPayRenewalID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecordPayment;
        private System.Windows.Forms.ComboBox cboRecPayMemberID;
        private System.Windows.Forms.ComboBox cboRecPayAmount;
        private System.Windows.Forms.DataGridView grdRecordPayment;
        private System.Windows.Forms.Label lblRecordPayment;
        private Oracle.ManagedDataAccess.Client.OracleDataAdapter oracleDataAdapter1;
    }
}