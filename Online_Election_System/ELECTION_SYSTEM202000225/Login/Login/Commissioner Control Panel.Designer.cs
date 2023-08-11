namespace Login
{
    partial class Commissioner_Control_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commissioner_Control_Panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commissionerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commissionerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateFinalReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commissionerToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1272, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commissionerToolStripMenuItem
            // 
            this.commissionerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commissionerDetailsToolStripMenuItem,
            this.registerPartyToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.commissionerToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.commissionerToolStripMenuItem.Name = "commissionerToolStripMenuItem";
            this.commissionerToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.commissionerToolStripMenuItem.Text = "Commissioner";
            // 
            // commissionerDetailsToolStripMenuItem
            // 
            this.commissionerDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.commissionerDetailsToolStripMenuItem.Name = "commissionerDetailsToolStripMenuItem";
            this.commissionerDetailsToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.commissionerDetailsToolStripMenuItem.Text = "Commissioner Details";
            this.commissionerDetailsToolStripMenuItem.Click += new System.EventHandler(this.commissionerDetailsToolStripMenuItem_Click);
            // 
            // registerPartyToolStripMenuItem
            // 
            this.registerPartyToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.registerPartyToolStripMenuItem.Name = "registerPartyToolStripMenuItem";
            this.registerPartyToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.registerPartyToolStripMenuItem.Text = "Register Party";
            this.registerPartyToolStripMenuItem.Click += new System.EventHandler(this.registerPartyToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateFinalReportToolStripMenuItem});
            this.reportToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // generateFinalReportToolStripMenuItem
            // 
            this.generateFinalReportToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.generateFinalReportToolStripMenuItem.Name = "generateFinalReportToolStripMenuItem";
            this.generateFinalReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.generateFinalReportToolStripMenuItem.Text = "Generate Final Report";
            this.generateFinalReportToolStripMenuItem.Click += new System.EventHandler(this.generateFinalReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(60, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commissioner_Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources._80455763_the_arcade_independence_square_is_a_building_complex_in_the_center_of_colombo_sri_lanka;
            this.ClientSize = new System.Drawing.Size(1272, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Commissioner_Control_Panel";
            this.Text = "Commissioner_Control_Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commissionerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commissionerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateFinalReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}