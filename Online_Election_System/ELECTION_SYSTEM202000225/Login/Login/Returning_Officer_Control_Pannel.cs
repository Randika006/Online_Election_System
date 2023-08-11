using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Returning_Officer_Control_Pannel : Form
    {
        public Returning_Officer_Control_Pannel()
        {
            InitializeComponent();
        }

        private void returningOfficerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returning_Officer_Details ROD = new Returning_Officer_Details();
            ROD.Show();
        }

        private void mediaDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meadia_Details MD = new Meadia_Details();
            MD.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Returning_Officer_Password CROP = new Change_Returning_Officer_Password();
            CROP.Show();
        }

        private void precentageOfResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Final_Data FR = new Final_Data();
            FR.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the Returning Officer Control Pannel!!!", "Exit Messagee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }

        private void lastYearsResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Last_Years_Result LYR = new Last_Years_Result();
            LYR.Show();
        }

        private void supportTOReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Report_Data SRD = new Show_Report_Data();
            SRD.Show();
        }
    }
}
