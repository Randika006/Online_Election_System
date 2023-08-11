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
    public partial class Show_Report_Data : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public Show_Report_Data()
        {
            InitializeComponent();
        }

        private void Show_Report_Data_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";


        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from  SRD", con);
            adapt.Fill(dt);
            dataGridViewLRV.DataSource = dt;
            con.Close();
        }
    }
}
