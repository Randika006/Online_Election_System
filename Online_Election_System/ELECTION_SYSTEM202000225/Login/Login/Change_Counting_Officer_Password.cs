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
    public partial class Change_Counting_Officer_Password : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string NIC;
        string NP;
        string VP;
        public Change_Counting_Officer_Password()
        {
            InitializeComponent();
        }

        private void Change_Counting_Officer_Password_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    NIC = textBox1.Text;
                    NP = textBox2.Text;
                    VP = textBox3.Text;



                    con.Open();

                    cmd = new SqlCommand("Insert into   CounterPassDe values(@CouNIC, @CouPass, @CouVPass)", con);
                    cmd.Parameters.AddWithValue("CouNIC", NIC);
                    cmd.Parameters.AddWithValue("CouPass", NP);
                    cmd.Parameters.AddWithValue("CouVPass", VP);
                    //  cmd.Parameters.AddWithValue("GDOB", BDay);
                    //  cmd.Parameters.AddWithValue("Gpass", Pword);
                    //  cmd.Parameters.AddWithValue("address", address);
                    //  cmd.Parameters.AddWithValue("tp", tp);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Record Appended Successfully !");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Reopen form and make mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (textBox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1, "Can't Blank National Idintity Card Field");

            }
            if (textBox2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2, "Can't Blank The Counting Officer New Password Field");
                MessageBox.Show("This Counting Officer New Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (textBox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3, "Can't Blank The Counting Officer  Verify Password Field");
                MessageBox.Show("This Counting Officer  Verify Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            
            return ok;


        }




    }
}
