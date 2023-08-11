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
using System.Windows.Forms.DataVisualization.Charting;

namespace Login
{
    public partial class Final_Result : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public Final_Result()
        {
            InitializeComponent();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            /*this.Close();*/
        }

        private void Final_Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votesSystemDataSet.FNR' table. You can move, or remove it, as needed.
            this.fNRTableAdapter.Fill(this.votesSystemDataSet.FNR);
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnVW_Click(object sender, EventArgs e)
        {
           /* con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from FNR", con);
            adapt.Fill(dt);
            dataGridViewFR.DataSource = dt;
            con.Close();*/
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           /* chartFN.Series["PTY"].XValueMember = "PTY";
            chartFN.Series["PTY"].YValueMembers = "VW";
            chartFN.DataSource = dataGridViewFR.DataSource;
            chartFN.DataBind();*/

            
        }
    }
}
