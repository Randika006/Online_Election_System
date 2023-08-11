namespace Login
{
    partial class Final_Graph
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
            this.chartFN2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fNRBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.votesSystemDataSet = new Login.VotesSystemDataSet();
            this.chartFN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fNRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fNRTableAdapter = new Login.VotesSystemDataSetTableAdapters.FNRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartFN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFN2
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFN2.ChartAreas.Add(chartArea1);
            this.chartFN2.DataSource = this.fNRBindingSource2;
            legend1.Name = "Legend1";
            this.chartFN2.Legends.Add(legend1);
            this.chartFN2.Location = new System.Drawing.Point(38, 230);
            this.chartFN2.Name = "chartFN2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "precentage";
            this.chartFN2.Series.Add(series1);
            this.chartFN2.Size = new System.Drawing.Size(481, 193);
            this.chartFN2.TabIndex = 0;
            this.chartFN2.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Final Result";
            this.chartFN2.Titles.Add(title1);
            // 
            // fNRBindingSource2
            // 
            this.fNRBindingSource2.DataMember = "FNR";
            this.fNRBindingSource2.DataSource = this.votesSystemDataSet;
            // 
            // votesSystemDataSet
            // 
            this.votesSystemDataSet.DataSetName = "VotesSystemDataSet";
            this.votesSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartFN
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFN.ChartAreas.Add(chartArea2);
            this.chartFN.DataSource = this.fNRBindingSource;
            legend2.Name = "Legend1";
            this.chartFN.Legends.Add(legend2);
            this.chartFN.Location = new System.Drawing.Point(58, 13);
            this.chartFN.Name = "chartFN";
            this.chartFN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "precentages";
            series2.XValueMember = "PTY";
            series2.YValueMembers = "VM";
            this.chartFN.Series.Add(series2);
            this.chartFN.Size = new System.Drawing.Size(445, 211);
            this.chartFN.TabIndex = 1;
            this.chartFN.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Final Result";
            this.chartFN.Titles.Add(title2);
            // 
            // fNRBindingSource
            // 
            this.fNRBindingSource.DataMember = "FNR";
            this.fNRBindingSource.DataSource = this.votesSystemDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pTYDataGridViewTextBoxColumn,
            this.vPDataGridViewTextBoxColumn,
            this.nEDataGridViewTextBoxColumn,
            this.vWDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fNRBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(539, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 199);
            this.dataGridView1.TabIndex = 2;
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
            // Final_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.ballot_vote_1698x849;
            this.ClientSize = new System.Drawing.Size(1072, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartFN);
            this.Controls.Add(this.chartFN2);
            this.Name = "Final_Graph";
            this.Text = "Final_Graph";
            this.Load += new System.EventHandler(this.Final_Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFN2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VotesSystemDataSet votesSystemDataSet;
        private System.Windows.Forms.BindingSource fNRBindingSource;
        private VotesSystemDataSetTableAdapters.FNRTableAdapter fNRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vWDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fNRBindingSource1;
        private System.Windows.Forms.BindingSource fNRBindingSource2;
    }
}