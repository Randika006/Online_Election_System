namespace Login
{
    partial class Generated_Report
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFDE2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPri = new System.Windows.Forms.Button();
            this.votesSystemDataSet1 = new Login.VotesSystemDataSet1();
            this.sRDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRDTableAdapter = new Login.VotesSystemDataSet1TableAdapters.SRDTableAdapter();
            this.votesSystemDataSet2 = new Login.VotesSystemDataSet2();
            this.commisionerREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commisionerRETableAdapter = new Login.VotesSystemDataSet2TableAdapters.CommisionerRETableAdapter();
            this.sRDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnVi = new System.Windows.Forms.Button();
            this.dataGridViewCR = new System.Windows.Forms.DataGridView();
            this.chartFE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sRDBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFDE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commisionerREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Login.Properties.Resources.change_login_screen_background_windows_10_1280x600;
            this.panel1.Controls.Add(this.chartFE);
            this.panel1.Controls.Add(this.dataGridViewCR);
            this.panel1.Controls.Add(this.chartFDE2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 458);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(359, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final Election Details";
            // 
            // chartFDE2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFDE2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFDE2.Legends.Add(legend2);
            this.chartFDE2.Location = new System.Drawing.Point(456, 74);
            this.chartFDE2.Name = "chartFDE2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Precentage";
            this.chartFDE2.Series.Add(series2);
            this.chartFDE2.Size = new System.Drawing.Size(369, 186);
            this.chartFDE2.TabIndex = 2;
            this.chartFDE2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Final Details";
            this.chartFDE2.Titles.Add(title2);
            // 
            // btnPri
            // 
            this.btnPri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPri.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPri.ForeColor = System.Drawing.Color.Blue;
            this.btnPri.Location = new System.Drawing.Point(361, 476);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(272, 73);
            this.btnPri.TabIndex = 1;
            this.btnPri.Text = "Print";
            this.btnPri.UseVisualStyleBackColor = false;
            // 
            // votesSystemDataSet1
            // 
            this.votesSystemDataSet1.DataSetName = "VotesSystemDataSet1";
            this.votesSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sRDBindingSource
            // 
            this.sRDBindingSource.DataMember = "SRD";
            this.sRDBindingSource.DataSource = this.votesSystemDataSet1;
            // 
            // sRDTableAdapter
            // 
            this.sRDTableAdapter.ClearBeforeFill = true;
            // 
            // votesSystemDataSet2
            // 
            this.votesSystemDataSet2.DataSetName = "VotesSystemDataSet2";
            this.votesSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commisionerREBindingSource
            // 
            this.commisionerREBindingSource.DataMember = "CommisionerRE";
            this.commisionerREBindingSource.DataSource = this.votesSystemDataSet2;
            // 
            // commisionerRETableAdapter
            // 
            this.commisionerRETableAdapter.ClearBeforeFill = true;
            // 
            // sRDBindingSource1
            // 
            this.sRDBindingSource1.DataMember = "SRD";
            this.sRDBindingSource1.DataSource = this.votesSystemDataSet1;
            // 
            // btnVi
            // 
            this.btnVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVi.Location = new System.Drawing.Point(128, 476);
            this.btnVi.Name = "btnVi";
            this.btnVi.Size = new System.Drawing.Size(196, 73);
            this.btnVi.TabIndex = 2;
            this.btnVi.Text = "View";
            this.btnVi.UseVisualStyleBackColor = false;
            this.btnVi.Click += new System.EventHandler(this.btnVi_Click);
            // 
            // dataGridViewCR
            // 
            this.dataGridViewCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCR.Location = new System.Drawing.Point(73, 265);
            this.dataGridViewCR.Name = "dataGridViewCR";
            this.dataGridViewCR.Size = new System.Drawing.Size(752, 172);
            this.dataGridViewCR.TabIndex = 3;
            // 
            // chartFE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFE.ChartAreas.Add(chartArea1);
            this.chartFE.DataSource = this.sRDBindingSource2;
            legend1.Name = "Legend1";
            this.chartFE.Legends.Add(legend1);
            this.chartFE.Location = new System.Drawing.Point(86, 73);
            this.chartFE.Name = "chartFE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Precentage";
            this.chartFE.Series.Add(series1);
            this.chartFE.Size = new System.Drawing.Size(354, 187);
            this.chartFE.TabIndex = 4;
            this.chartFE.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Final Details";
            this.chartFE.Titles.Add(title1);
            this.chartFE.Click += new System.EventHandler(this.chartFE_Click);
            // 
            // sRDBindingSource2
            // 
            this.sRDBindingSource2.DataMember = "SRD";
            this.sRDBindingSource2.DataSource = this.votesSystemDataSet1;
            // 
            // Generated_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.ballot_vote_1698x849;
            this.ClientSize = new System.Drawing.Size(991, 582);
            this.Controls.Add(this.btnVi);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.panel1);
            this.Name = "Generated_Report";
            this.Text = "Generated_Report";
            this.Load += new System.EventHandler(this.Generated_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFDE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commisionerREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRDBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFDE2;
        private System.Windows.Forms.Button btnPri;
        private VotesSystemDataSet1 votesSystemDataSet1;
        private System.Windows.Forms.BindingSource sRDBindingSource;
        private VotesSystemDataSet1TableAdapters.SRDTableAdapter sRDTableAdapter;
        private VotesSystemDataSet2 votesSystemDataSet2;
        private System.Windows.Forms.BindingSource commisionerREBindingSource;
        private VotesSystemDataSet2TableAdapters.CommisionerRETableAdapter commisionerRETableAdapter;
        private System.Windows.Forms.BindingSource sRDBindingSource1;
        private System.Windows.Forms.Button btnVi;
        private System.Windows.Forms.DataGridView dataGridViewCR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFE;
        private System.Windows.Forms.BindingSource sRDBindingSource2;
    }
}