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
    public partial class Metro : Form
    {
        public Metro()
        {
            InitializeComponent();
        }

        private void btnFR_Click(object sender, EventArgs e)
        {
            The_Report TR = new The_Report();
            TR.Show();
        }

        private void btnLg_Click(object sender, EventArgs e)
        {
            Form1 Fr = new Form1();
            Fr.Show();
        }

        private void btnLR_Click(object sender, EventArgs e)
        {
            Final_Data FD = new Final_Data();
            FD.Show();




        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            Last_Years_Result LYR = new Last_Years_Result();
            LYR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 Fr = new Form1();
            Fr.Show();
        }
    }
}
