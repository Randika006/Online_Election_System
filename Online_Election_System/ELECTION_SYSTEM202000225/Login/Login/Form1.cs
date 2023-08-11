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
    public partial class Form1 : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string Uid;
        string Pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtIDNum.Text = "";
            txtPass.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)   
        {
            con= new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtIDNum.Text != "") && (txtPass.Text != ""))
            {
                string Uid = txtIDNum.Text;
                string Pass = txtPass.Text;
                string sqlselect = "select UserID,password from LoginDetails where UserID='" + Uid + "' and Password= '" + Pass + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlselect, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucess Welcome to Control panel");
                    

                    Control_Pannel conpan = new Control_Pannel();
                    conpan.Show();
                }

                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }


            else
            {
                MessageBox.Show("Please Enter Correct UserID and Password to enter System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtIDNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
