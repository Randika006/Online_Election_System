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
    public partial class Counting_Officer_Control_Pannel : Form
    {
        public Counting_Officer_Control_Pannel()
        {
            InitializeComponent();
        }

        private void countingOfficerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Counting_Officer_Details COD = new Counting_Officer_Details();
            COD.Show();
        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Counting_Officer_Password COP = new Change_Counting_Officer_Password();
            COP.Show();
        }

        private void nationalListSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            National_List_Seat NLS = new National_List_Seat();
            NLS.Show();
        }

        private void regionalListSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regional_List_Seat RLS = new Regional_List_Seat();
            RLS.Show();
        }

        private void changeFinalResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Final_Result CFR = new Change_Final_Result();
            CFR.Show();
        }

        private void provincalRegistureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provincal_Legislate PL = new Provincal_Legislate();
            PL.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the Counting Officer Control Pannel!!!", "Exit Messagee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnLG_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }

        private void supportToTheReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support_the_report str = new Support_the_report();
            str.Show();
        }
    }
}
