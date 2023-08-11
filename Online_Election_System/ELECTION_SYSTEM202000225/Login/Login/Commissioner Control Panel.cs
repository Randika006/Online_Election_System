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
    public partial class Commissioner_Control_Panel : Form
    {
        public Commissioner_Control_Panel()
        {
            InitializeComponent();
        }

        private void commissionerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commisioner_Details CD = new Commisioner_Details();
            CD.Show();
        }

        private void registerPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partys pt = new Partys();
            pt.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Commitioner_Password CCP = new Change_Commitioner_Password();
            CCP.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the Commissioner Control Pannel!!!", "Exit Messagee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }

        private void generateFinalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            The_Report TP = new The_Report();
            TP.Show();
        }
    }
}
