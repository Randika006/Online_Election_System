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
    public partial class District_Sectotarial_Control_Pannel : Form
    {
        public District_Sectotarial_Control_Pannel()
        {
            InitializeComponent();
        }

        private void districtSectotarialDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            District_Sectotarial_Details DSDE = new District_Sectotarial_Details();
            DSDE.Show();
        }

        private void apealsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apeal_Details AD = new Apeal_Details();
            AD.Show();
        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password_District_Officer CPD = new Change_Password_District_Officer();
            CPD.Show();
        }

        private void candidateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidate_Details CD = new Candidate_Details();
            CD.Show();
        }

        private void watcherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wacher_Details WD = new Wacher_Details();
            WD.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the District sectotarial Control Pannel!!!", "Exit Messagee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }
    }
}
