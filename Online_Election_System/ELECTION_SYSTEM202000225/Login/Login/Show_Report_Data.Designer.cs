namespace Login
{
    partial class Show_Report_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Report_Data));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLRV = new System.Windows.Forms.DataGridView();
            this.btnVi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLRV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Last Report Votes Calculation";
            // 
            // dataGridViewLRV
            // 
            this.dataGridViewLRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLRV.Location = new System.Drawing.Point(139, 79);
            this.dataGridViewLRV.Name = "dataGridViewLRV";
            this.dataGridViewLRV.Size = new System.Drawing.Size(697, 216);
            this.dataGridViewLRV.TabIndex = 1;
            // 
            // btnVi
            // 
            this.btnVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVi.Location = new System.Drawing.Point(403, 310);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(163, 65);
            this.btnVi.TabIndex = 2;
            this.btnVi.Text = "View";
            this.btnVi.UseVisualStyleBackColor = false;
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // Show_Report_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.ballot_vote_1698x8492;
            this.ClientSize = new System.Drawing.Size(1005, 413);
            this.Controls.Add(this.btnVi);
            this.Controls.Add(this.dataGridViewLRV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Report_Data";
            this.Text = "Show_Report_Data";
            this.Load += new System.EventHandler(this.Show_Report_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLRV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLRV;
        private System.Windows.Forms.Button btnVi;
    }
}