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
    public partial class Final_Graph : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        public Final_Graph()
        {
            InitializeComponent();
        }

        private void Final_Graph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'votesSystemDataSet.FNR' table. You can move, or remove it, as needed.
            this.fNRTableAdapter.Fill(this.votesSystemDataSet.FNR);
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";


        }
    }
}
