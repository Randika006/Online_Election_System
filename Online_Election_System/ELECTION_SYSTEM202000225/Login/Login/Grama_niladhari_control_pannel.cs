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
    public partial class Grama_niladhari_control_pannel : Form
    {
        public Grama_niladhari_control_pannel()
        {
            InitializeComponent();
        }

        private void gramaNiladhariDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grama_Niladhari_Details GD = new Grama_Niladhari_Details();
            GD.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 FR = new Form1();
            FR.Show();
        }

        private void passwordChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password CP = new Change_Password();
            CP.Show();
        }

        private void voterDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            voter VD = new voter();
            VD.Show();
        }

        private void assistantDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assistance_Details AD = new Assistance_Details();
            AD.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the Grama Niladhari Control Pannel!!!", "Exit Messagee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
