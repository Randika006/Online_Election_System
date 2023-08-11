namespace Login
{
    partial class Final_Result
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
            this.dataGridViewFR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.votesSystemDataSet = new Login.VotesSystemDataSet();
            this.fNRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fNRTableAdapter = new Login.VotesSystemDataSetTableAdapters.FNRTableAdapter();
            this.pTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFR
            // 
            this.dataGridViewFR.AutoGenerateColumns = false;
            this.dataGridViewFR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pTYDataGridViewTextBoxColumn,
            this.vPDataGridViewTextBoxColumn,
            this.nEDataGridViewTextBoxColumn,
            this.vWDataGridViewTextBoxColumn});
            this.dataGridViewFR.DataSource = this.fNRBindingSource;
            this.dataGridViewFR.Location = new System.Drawing.Point(34, 68);
            this.dataGridViewFR.Name = "dataGridViewFR";
            this.dataGridViewFR.Size = new System.Drawing.Size(421, 212);
            this.dataGridViewFR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(477, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Final Result";
            // 
            // chartFN
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFN.ChartAreas.Add(chartArea2);
            this.chartFN.DataSource = this.fNRBindingSource1;
            legend2.Name = "Legend1";
            this.chartFN.Legends.Add(legend2);
            this.chartFN.Location = new System.Drawing.Point(494, 68);
            this.chartFN.Name = "chartFN";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Party";
            series2.XValueMember = "10";
            series2.YValueMembers = "10";
            this.chartFN.Series.Add(series2);
            this.chartFN.Size = new System.Drawing.Size(492, 212);
            this.chartFN.TabIndex = 5;
            this.chartFN.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Final Result";
            this.chartFN.Titles.Add(title2);
            // 
            // votesSystemDataSet
            // 
            this.votesSystemDataSet.DataSetName = "VotesSystemDataSet";
            this.votesSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNRBindingSource
            // 
            this.fNRBindingSource.DataMember = "FNR";
            this.fNRBindingSource.DataSource = this.votesSystemDataSet;
            // 
            // fNRTableAdapter
            // 
            this.fNRTableAdapter.ClearBeforeFill = true;
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
            // Final_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Chams_VOTA_evoting;
            this.ClientSize = new System.Drawing.Size(1075, 519);
            this.Controls.Add(this.chartFN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFR);
            this.Name = "Final_Result";
            this.Text = "Final_Result";
            this.Load += new System.EventHandler(this.Final_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votesSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNRBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewFR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFN;
        private VotesSystemDataSet votesSystemDataSet;
        private System.Windows.Forms.BindingSource fNRBindingSource;
        private VotesSystemDataSetTableAdapters.FNRTableAdapter fNRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vWDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fNRBindingSource1;
    }
}