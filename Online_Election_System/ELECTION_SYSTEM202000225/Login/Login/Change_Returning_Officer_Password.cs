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
    public partial class Change_Returning_Officer_Password : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string ReturNIC;
        string ReturPass;
        string ReturVPass;
        public Change_Returning_Officer_Password()
        {
            InitializeComponent();
        }

        private void Change_Returning_Officer_Password_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    ReturNIC = txtRNIC.Text;
                    ReturPass = txrRNP.Text;
                    ReturVPass = txtRVP.Text;



                    con.Open();

                    cmd = new SqlCommand("Insert into   ReturnerPass values(@ReturNIC, @ReturPass, @ReturVPass)", con);
                    cmd.Parameters.AddWithValue("ReturNIC", ReturNIC);
                    cmd.Parameters.AddWithValue("ReturPass", ReturPass);
                    cmd.Parameters.AddWithValue("ReturVPass", ReturVPass);
                    //cmd.Parameters.AddWithValue("GDOB", BDay);
                    //cmd.Parameters.AddWithValue("Gpass", Pword);
                    //  cmd.Parameters.AddWithValue("address", address);
                    //  cmd.Parameters.AddWithValue("tp", tp);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Record Appended Successfully !");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtRNIC.Text="";
            txrRNP.Text="";
            txtRVP.Text="";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtRNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRNIC, "Can't Blank National Idintity Card Field");

            }
            if (txrRNP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txrRNP, "Can't Blank The Returning Officer New Password Field");
                MessageBox.Show("This Returning Officer New Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtRVP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRVP, "Can't Blank The Returning Officer  Verify Password Field");
                MessageBox.Show("This Returning Officer  Verify Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }

            return ok;


        }

    }
}
