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
    public partial class Last_Years_Result : Form
    {
        public Last_Years_Result()
        {
            InitializeComponent();
        }

        private void Last_Years_Result_Load(object sender, EventArgs e)
        {
            chart2015.Series["result"].Points.Add(35);
            chart2015.Series["result"].Points[0].Color = Color.Red;
            chart2015.Series["result"].Points[0].AxisLabel = "JVP";
            chart2015.Series["result"].Points[0].LegendText = "JVP";
            chart2015.Series["result"].Points[0].Label = "35";





            chart2015.Series["result"].Points.Add(56);
            chart2015.Series["result"].Points[1].Color = Color.Blue;
            chart2015.Series["result"].Points[1].AxisLabel = "SLPA";
            chart2015.Series["result"].Points[1].LegendText = "SLPA";
            chart2015.Series["result"].Points[1].Label = "56%";


            chart2015.Series["result"].Points.Add(70);
            chart2015.Series["result"].Points[2].Color = Color.Green;
            chart2015.Series["result"].Points[2].AxisLabel = "UNP";
            chart2015.Series["result"].Points[2].LegendText = "UNP";
            chart2015.Series["result"].Points[2].Label = "70%";


            chart2015.Series["result"].Points.Add(30);
            chart2015.Series["result"].Points[3].Color = Color.Yellow;
            chart2015.Series["result"].Points[3].AxisLabel = "other";
            chart2015.Series["result"].Points[3].LegendText = "other";
            chart2015.Series["result"].Points[3].Label = "30%";

            //2010

            chart2010.Series["result"].Points.Add(35);
            chart2010.Series["result"].Points[0].Color = Color.Red;
            chart2010.Series["result"].Points[0].AxisLabel = "JVP";
            chart2010.Series["result"].Points[0].LegendText = "JVP";
            chart2010.Series["result"].Points[0].Label = "35";





            chart2010.Series["result"].Points.Add(77);
            chart2010.Series["result"].Points[1].Color = Color.Blue;
            chart2010.Series["result"].Points[1].AxisLabel = "SLPA";
            chart2010.Series["result"].Points[1].LegendText = "SLPA";
            chart2010.Series["result"].Points[1].Label = "77%";


            chart2010.Series["result"].Points.Add(60);
            chart2010.Series["result"].Points[2].Color = Color.Green;
            chart2010.Series["result"].Points[2].AxisLabel = "UNP";
            chart2010.Series["result"].Points[2].LegendText = "UNP";
            chart2010.Series["result"].Points[2].Label = "60%";


            chart2010.Series["result"].Points.Add(28);
            chart2010.Series["result"].Points[3].Color = Color.Yellow;
            chart2010.Series["result"].Points[3].AxisLabel = "other";
            chart2010.Series["result"].Points[3].LegendText = "other";
            chart2010.Series["result"].Points[3].Label = "28%";

            //2004


            chart2004.Series["result"].Points.Add(48);
            chart2004.Series["result"].Points[0].Color = Color.Red;
            chart2004.Series["result"].Points[0].AxisLabel = "JVP";
            chart2004.Series["result"].Points[0].LegendText = "JVP";
            chart2004.Series["result"].Points[0].Label = "48";





            chart2004.Series["result"].Points.Add(56);
            chart2004.Series["result"].Points[1].Color = Color.Blue;
            chart2004.Series["result"].Points[1].AxisLabel = "SLPA";
            chart2004.Series["result"].Points[1].LegendText = "SLPA";
            chart2004.Series["result"].Points[1].Label = "56%";


            chart2004.Series["result"].Points.Add(54);
            chart2004.Series["result"].Points[2].Color = Color.Green;
            chart2004.Series["result"].Points[2].AxisLabel = "UNP";
            chart2004.Series["result"].Points[2].LegendText = "UNP";
            chart2004.Series["result"].Points[2].Label = "54%";


            chart2004.Series["result"].Points.Add(28);
            chart2004.Series["result"].Points[3].Color = Color.Yellow;
            chart2004.Series["result"].Points[3].AxisLabel = "other";
            chart2004.Series["result"].Points[3].LegendText = "other";
            chart2004.Series["result"].Points[3].Label = "50%";


            //2001


            chart2001.Series["result"].Points.Add(48);
            chart2001.Series["result"].Points[0].Color = Color.Red;
            chart2001.Series["result"].Points[0].AxisLabel = "JVP";
            chart2001.Series["result"].Points[0].LegendText = "JVP";
            chart2001.Series["result"].Points[0].Label = "48";





            chart2001.Series["result"].Points.Add(66);
            chart2001.Series["result"].Points[1].Color = Color.Blue;
            chart2001.Series["result"].Points[1].AxisLabel = "SLPA";
            chart2001.Series["result"].Points[1].LegendText = "SLPA";
            chart2001.Series["result"].Points[1].Label = "66%";


            chart2001.Series["result"].Points.Add(74);
            chart2001.Series["result"].Points[2].Color = Color.Green;
            chart2001.Series["result"].Points[2].AxisLabel = "UNP";
            chart2001.Series["result"].Points[2].LegendText = "UNP";
            chart2001.Series["result"].Points[2].Label = "74%";


            chart2001.Series["result"].Points.Add(55);
            chart2001.Series["result"].Points[3].Color = Color.Yellow;
            chart2001.Series["result"].Points[3].AxisLabel = "other";
            chart2001.Series["result"].Points[3].LegendText = "other";
            chart2001.Series["result"].Points[3].Label = "55%";


            //2000

            chart2000.Series["result"].Points.Add(50);
            chart2000.Series["result"].Points[0].Color = Color.Red;
            chart2000.Series["result"].Points[0].AxisLabel = "JVP";
            chart2000.Series["result"].Points[0].LegendText = "JVP";
            chart2000.Series["result"].Points[0].Label = "50";





            chart2000.Series["result"].Points.Add(60);
            chart2000.Series["result"].Points[1].Color = Color.Blue;
            chart2000.Series["result"].Points[1].AxisLabel = "SLPA";
            chart2000.Series["result"].Points[1].LegendText = "SLPA";
            chart2000.Series["result"].Points[1].Label = "60%";


            chart2000.Series["result"].Points.Add(84);
            chart2000.Series["result"].Points[2].Color = Color.Green;
            chart2000.Series["result"].Points[2].AxisLabel = "UNP";
            chart2000.Series["result"].Points[2].LegendText = "UNP";
            chart2000.Series["result"].Points[2].Label = "84%";


            chart2000.Series["result"].Points.Add(45);
            chart2000.Series["result"].Points[3].Color = Color.Yellow;
            chart2000.Series["result"].Points[3].AxisLabel = "other";
            chart2000.Series["result"].Points[3].LegendText = "other";
            chart2000.Series["result"].Points[3].Label = "45%";

            //1994

            chart1994.Series["result"].Points.Add(50);
            chart1994.Series["result"].Points[0].Color = Color.Red;
            chart1994.Series["result"].Points[0].AxisLabel = "JVP";
            chart1994.Series["result"].Points[0].LegendText = "JVP";
            chart1994.Series["result"].Points[0].Label = "50";





            chart1994.Series["result"].Points.Add(70);
            chart1994.Series["result"].Points[1].Color = Color.Blue;
            chart1994.Series["result"].Points[1].AxisLabel = "SLPA";
            chart1994.Series["result"].Points[1].LegendText = "SLPA";
            chart1994.Series["result"].Points[1].Label = "70%";


            chart1994.Series["result"].Points.Add(64);
            chart1994.Series["result"].Points[2].Color = Color.Green;
            chart1994.Series["result"].Points[2].AxisLabel = "UNP";
            chart1994.Series["result"].Points[2].LegendText = "UNP";
            chart1994.Series["result"].Points[2].Label = "64%";


            chart1994.Series["result"].Points.Add(38);
            chart1994.Series["result"].Points[3].Color = Color.Yellow;
            chart1994.Series["result"].Points[3].AxisLabel = "other";
            chart1994.Series["result"].Points[3].LegendText = "other";
            chart1994.Series["result"].Points[3].Label = "38%";

            //1989

            chart1989.Series["result"].Points.Add(48);
            chart1989.Series["result"].Points[0].Color = Color.Red;
            chart1989.Series["result"].Points[0].AxisLabel = "JVP";
            chart1989.Series["result"].Points[0].LegendText = "JVP";
            chart1989.Series["result"].Points[0].Label = "48";





            chart1989.Series["result"].Points.Add(60);
            chart1989.Series["result"].Points[1].Color = Color.Blue;
            chart1989.Series["result"].Points[1].AxisLabel = "SLPA";
            chart1989.Series["result"].Points[1].LegendText = "SLPA";
            chart1989.Series["result"].Points[1].Label = "60%";


            chart1989.Series["result"].Points.Add(84);
            chart1989.Series["result"].Points[2].Color = Color.Green;
            chart1989.Series["result"].Points[2].AxisLabel = "UNP";
            chart1989.Series["result"].Points[2].LegendText = "UNP";
            chart1989.Series["result"].Points[2].Label = "84%";


            chart1989.Series["result"].Points.Add(38);
            chart1989.Series["result"].Points[3].Color = Color.Yellow;
            chart1989.Series["result"].Points[3].AxisLabel = "other";
            chart1989.Series["result"].Points[3].LegendText = "other";
            chart1989.Series["result"].Points[3].Label = "38%";

            //1977

            chart1977.Series["result"].Points.Add(45);
            chart1977.Series["result"].Points[0].Color = Color.Red;
            chart1977.Series["result"].Points[0].AxisLabel = "JVP";
            chart1977.Series["result"].Points[0].LegendText = "JVP";
            chart1977.Series["result"].Points[0].Label = "45";





            chart1977.Series["result"].Points.Add(69);
            chart1977.Series["result"].Points[1].Color = Color.Blue;
            chart1977.Series["result"].Points[1].AxisLabel = "SLPA";
            chart1977.Series["result"].Points[1].LegendText = "SLPA";
            chart1977.Series["result"].Points[1].Label = "69%";


            chart1977.Series["result"].Points.Add(89);
            chart1977.Series["result"].Points[2].Color = Color.Green;
            chart1977.Series["result"].Points[2].AxisLabel = "UNP";
            chart1977.Series["result"].Points[2].LegendText = "UNP";
            chart1977.Series["result"].Points[2].Label = "89%";


            chart1977.Series["result"].Points.Add(39);
            chart1977.Series["result"].Points[3].Color = Color.Yellow;
            chart1977.Series["result"].Points[3].AxisLabel = "other";
            chart1977.Series["result"].Points[3].LegendText = "other";
            chart1977.Series["result"].Points[3].Label = "39%";

        }

        private void chart1994_Click(object sender, EventArgs e)
        {

        }

        private void chart2000_Click(object sender, EventArgs e)
        {

        }

        private void chart2015_Click(object sender, EventArgs e)
        {

        }

        private void chart2010_Click(object sender, EventArgs e)
        {

        }

        private void chart2004_Click(object sender, EventArgs e)
        {

        }

        private void chart1989_Click(object sender, EventArgs e)
        {

        }

        private void chart1977_Click(object sender, EventArgs e)
        {

        }

        private void chart2001_Click(object sender, EventArgs e)
        {

        }
    }
}
