namespace GolfMemberSys
{
    partial class frmAddType
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
            this.mnuAddType = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddType = new System.Windows.Forms.GroupBox();
            this.txtTypePrice = new System.Windows.Forms.TextBox();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.mnuAddType.SuspendLayout();
            this.grpAddType.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddType
            // 
            this.mnuAddType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.backToolStripMenuItem});
            this.mnuAddType.Location = new System.Drawing.Point(0, 0);
            this.mnuAddType.Name = "mnuAddType";
            this.mnuAddType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuAddType.Size = new System.Drawing.Size(800, 24);
            this.mnuAddType.TabIndex = 0;
            this.mnuAddType.Text = "menuStrip1";
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
            this.quitAppToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitAppToolStripMenuItem.Text = "Quit";
            this.quitAppToolStripMenuItem.Click += new System.EventHandler(this.quitAppToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpAddType
            // 
            this.grpAddType.Controls.Add(this.txtTypePrice);
            this.grpAddType.Controls.Add(this.txtTypeName);
            this.grpAddType.Controls.Add(this.txtTypeId);
            this.grpAddType.Controls.Add(this.label3);
            this.grpAddType.Controls.Add(this.label2);
            this.grpAddType.Controls.Add(this.label1);
            this.grpAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpAddType.Location = new System.Drawing.Point(142, 59);
            this.grpAddType.Name = "grpAddType";
            this.grpAddType.Size = new System.Drawing.Size(513, 215);
            this.grpAddType.TabIndex = 1;
            this.grpAddType.TabStop = false;
            this.grpAddType.Text = "New Type Details";
            // 
            // txtTypePrice
            // 
            this.txtTypePrice.Location = new System.Drawing.Point(238, 164);
            this.txtTypePrice.Name = "txtTypePrice";
            this.txtTypePrice.Size = new System.Drawing.Size(269, 26);
            this.txtTypePrice.TabIndex = 5;
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(238, 109);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(269, 26);
            this.txtTypeName.TabIndex = 4;
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(238, 53);
            this.txtTypeId.MaxLength = 2;
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(269, 26);
            this.txtTypeId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type ID:";
            // 
            // btnAddType
            // 
            this.btnAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddType.Location = new System.Drawing.Point(265, 319);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(269, 101);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.Text = "Add Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // frmAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.grpAddType);
            this.Controls.Add(this.mnuAddType);
            this.MainMenuStrip = this.mnuAddType;
            this.Name = "frmAddType";
            this.Text = "Add Member Type - GolfMemberSys";
            this.mnuAddType.ResumeLayout(false);
            this.mnuAddType.PerformLayout();
            this.grpAddType.ResumeLayout(false);
            this.grpAddType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAddType;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpAddType;
        private System.Windows.Forms.TextBox txtTypePrice;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddType;
    }
}