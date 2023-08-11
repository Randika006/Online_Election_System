namespace Login
{
    partial class Final_Data
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final_Data));
            this.chartFD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fNRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votesSystemDataSet = new Login.VotesSystemDataSet();
            this.dataGridViewFD = new System.Windows.Forms.DataGridView();
            this.pTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fNRTableAdapter = new Login.VotesSystemDataSetTableAdapters.FNRTableAdapter();
            this.chartFD2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFD2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFD.ChartAreas.Add(chartArea1);
            this.chartFD.DataSource = this.fNRBindingSource;
            legend1.Name = "Legend1";
            this.chartFD.Legends.Add(legend1);
            this.chartFD.Location = new System.Drawing.Point(38, 30);
            this.chartFD.Name = "chartFD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "result";
            series1.XValueMember = "PTY";
            series1.YValueMembers = "VW";
            this.chartFD.Series.Add(series1);
            this.chartFD.Size = new System.Drawing.Size(413, 196);
            this.chartFD.TabIndex = 0;
            this.chartFD.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Final Data";
            this.chartFD.Titles.Add(title1);
            // 
            // fNRBindingSource
            // 
            this.fNRBindingSource.DataMember = "FNR";
            this.fNRBindingSource.DataSource = this.votesSystemDataSet;
            // 
            // votesSystemDataSet
            // 
            this.votesSystemDataSet.DataSetName = "VotesSystemDataSet";
            this.votesSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewFD
            // 
            this.dataGridViewFD.AutoGenerateColumns = false;
            this.dataGridViewFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pTYDataGridViewTextBoxColumn,
            this.vPDataGridViewTextBoxColumn,
            this.nEDataGridViewTextBoxColumn,
            this.vWDataGridViewTextBoxColumn});
            this.dataGridViewFD.DataSource = this.fNRBindingSource1;
            this.dataGridViewFD.Location = new System.Drawing.Point(457, 30);
            this.dataGridViewFD.Name = "dataGridViewFD";
            this.dataGridViewFD.Size = new System.Drawing.Size(420, 196);
            this.dataGridViewFD.TabIndex = 1;
            // 
            // pTYDataGridViewTextBoxColumn
            // 
            this.pTYDataGridViewTextBoxColumn.DataPropertyName = "PTY";
            this.pTYDataGridViewTextBoxColumn.HeaderText = "PTY";
            this.pTYDataGridViewTextBoxColumn.Name = "pTYDataGridViewTextBoxColumn";
            // 
            // vPDataGridViewTextBoxColumn
            // 
            this.vPDataGridViewTextBoxColumn.DataPropertyName = "VP";
            this.vPDataGridViewTextBoxColumn.HeaderText = "VP";
            this.vPDataGridViewTextBoxColumn.Name = "vPDataGridViewTextBoxColumn";
            // 
            // nEDataGridViewTextBoxColumn
            // 
            this.nEDataGridViewTextBoxColumn.DataPropertyName = "NE";
            this.nEDataGridViewTextBoxColumn.HeaderText = "NE";
            this.nEDataGridViewTextBoxColumn.Name = "nEDataGridViewTextBoxColumn";
            // 
            // vWDataGridViewTextBoxColumn
            // 
            this.vWDataGridViewTextBoxColumn.DataPropertyName = "VW";
            this.vWDataGridViewTextBoxColumn.HeaderText = "VW";
            this.vWDataGridViewTextBoxColumn.Name = "vWDataGridViewTextBoxColumn";
            // 
            // fNRBindingSource1
            // 
            this.fNRBindingSource1.DataMember = "FNR";
            this.fNRBindingSource1.DataSource = this.votesSystemDataSet;
            // 
            // fNRTableAdapter
            // 
            this.fNRTableAdapter.ClearBeforeFill = true;
            // 
            // chartFD2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFD2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFD2.Legends.Add(legend2);
            this.chartFD2.Location = new System.Drawing.Point(12, 232);
            this.chartFD2.Name = "chartFD2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "result";
            this.chartFD2.Series.Add(series2);
            this.chartFD2.Size = new System.Drawing.Size(879, 199);
            this.chartFD2.TabIndex = 2;
            this.chartFD2.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Final Result";
            this.chartFD2.Titles.Add(title2);
            this.chartFD2.Click += new System.EventHandler(this.chartFD2_Click);
            // 
            // Final_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.ballot_vote_1698x8492;
            this.ClientSize = new System.Drawing.Size(916, 443);
            this.Controls.Add(this.chartFD2);
            this.Controls.Add(this.dataGridViewFD);
            this.Controls.Add(this.chartFD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Final_Data";
            this.Text = "Final_Data";
            this.Load += new System.EventHandler(this.Final_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFD2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFD;
        private System.Windows.Forms.DataGridView dataGridViewFD;
        private VotesSystemDataSet votesSystemDataSet;
        private System.Windows.Forms.BindingSource fNRBindingSource;
        private VotesSystemDataSetTableAdapters.FNRTableAdapter fNRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vWDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fNRBindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFD2;
    }
}