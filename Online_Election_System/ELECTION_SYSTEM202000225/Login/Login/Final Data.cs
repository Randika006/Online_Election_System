using System;
using System.Data.SqlClient;
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
    public partial class Final_Data : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public Final_Data()
        {
            InitializeComponent();
        }

        private void Final_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votesSystemDataSet.FNR' table. You can move, or remove it, as needed.
            this.fNRTableAdapter.Fill(this.votesSystemDataSet.FNR);

            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";

            chartFD2.Series["result"].Points.Add(31);
            chartFD2.Series["result"].Points[0].Color = Color.Red;
            chartFD2.Series["result"].Points[0].AxisLabel = "JVP";
            chartFD2.Series["result"].Points[0].LegendText = "JVP";
            chartFD2.Series["result"].Points[0].Label = "31";


            


            chartFD2.Series["result"].Points.Add(75);
            chartFD2.Series["result"].Points[1].Color = Color.Blue;
            chartFD2.Series["result"].Points[1].AxisLabel = "SLPA";
            chartFD2.Series["result"].Points[1].LegendText = "SLPA";
            chartFD2.Series["result"].Points[1].Label = "75%";


            chartFD2.Series["result"].Points.Add(60);
            chartFD2.Series["result"].Points[2].Color = Color.Green;
            chartFD2.Series["result"].Points[2].AxisLabel = "UNP";
            chartFD2.Series["result"].Points[2].LegendText = "UNP";
            chartFD2.Series["result"].Points[2].Label = "60%";


            chartFD2.Series["result"].Points.Add(6);
            chartFD2.Series["result"].Points[3].Color = Color.Yellow;
            chartFD2.Series["result"].Points[3].AxisLabel = "other";
            chartFD2.Series["result"].Points[3].LegendText = "other";
            chartFD2.Series["result"].Points[3].Label = "6%";





        }

        private void chartFD2_Click(object sender, EventArgs e)
        {

        }
    }
}
