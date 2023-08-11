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
    public partial class Control_Pannel : Form
    {
        public Control_Pannel()
        {
            InitializeComponent();
        }

        private void Control_Pannel_Load(object sender, EventArgs e)
        {

        }

        private void btnGN_Click(object sender, EventArgs e)
        {
            Grama_niladhari_control_pannel GC = new Grama_niladhari_control_pannel();
            GC.Show();
        }

        private void btnGN_Click_1(object sender, EventArgs e)
        {
            Grama_niladhari_control_pannel GC = new Grama_niladhari_control_pannel();
            GC.Show();
        }

        private void btnds_Click(object sender, EventArgs e)
        {
            District_Sectotarial_Control_Pannel DSCP = new District_Sectotarial_Control_Pannel();
            DSCP.Show();
        }

        private void btnCO_Click(object sender, EventArgs e)
        {
            Counting_Officer_Control_Pannel CCP = new Counting_Officer_Control_Pannel();
            CCP.Show();
        }

        private void btnRO_Click(object sender, EventArgs e)
        {
            Returning_Officer_Control_Pannel RCP = new Returning_Officer_Control_Pannel();
            RCP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commissioner_Control_Panel CPL = new Commissioner_Control_Panel();
            CPL.Show();
        }
    }
}
