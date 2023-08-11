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
    public partial class Generated_Report : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public Generated_Report()
        {
            InitializeComponent();
        }

        private void Generated_Report_Load(object sender, EventArgs e)
        {
            

            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";

            chartFDE2.Series["Precentage"].Points.Add(31);
            chartFDE2.Series["Precentage"].Points[0].Color = Color.Red;
            chartFDE2.Series["Precentage"].Points[0].AxisLabel = "JVP";
            chartFDE2.Series["Precentage"].Points[0].LegendText = "JVP";
            chartFDE2.Series["Precentage"].Points[0].Label = "31";





            chartFDE2.Series["Precentage"].Points.Add(75);
            chartFDE2.Series["Precentage"].Points[1].Color = Color.Blue;
            chartFDE2.Series["Precentage"].Points[1].AxisLabel = "SLPA";
            chartFDE2.Series["Precentage"].Points[1].LegendText = "SLPA";
            chartFDE2.Series["Precentage"].Points[1].Label = "75%";


            chartFDE2.Series["Precentage"].Points.Add(60);
            chartFDE2.Series["Precentage"].Points[2].Color = Color.Green;
            chartFDE2.Series["Precentage"].Points[2].AxisLabel = "UNP";
            chartFDE2.Series["Precentage"].Points[2].LegendText = "UNP";
            chartFDE2.Series["Precentage"].Points[2].Label = "60%";


            chartFDE2.Series["Precentage"].Points.Add(6);
            chartFDE2.Series["Precentage"].Points[3].Color = Color.Yellow;
            chartFDE2.Series["Precentage"].Points[3].AxisLabel = "other";
            chartFDE2.Series["Precentage"].Points[3].LegendText = "other";
            chartFDE2.Series["Precentage"].Points[3].Label = "6%";

        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from CommisionerRE", con);
            adapt.Fill(dt);
            dataGridViewCR.DataSource = dt;
            con.Close();
        }

        private void chartFE_Click(object sender, EventArgs e)
        {

        }
    }
}
