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
    public partial class Change_Commitioner_Password : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string NIC;
        string NP;
        string VP;
        

        public Change_Commitioner_Password()
        {
            InitializeComponent();
        }

        private void Change_Commitioner_Password_Load(object sender, EventArgs e)
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
                    if (txtNIC.Text != "")
                    {
                        NIC = txtNIC.Text;
                        NP = txtNP.Text;
                        VP = txtVP.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   CCP values(@NIC, @NP, @VP)", con);
                        cmd.Parameters.AddWithValue("NIC", NIC);
                        cmd.Parameters.AddWithValue("NP", NP);
                        cmd.Parameters.AddWithValue("VP", VP);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter NIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void btnCl_Click(object sender, EventArgs e)
        {

            txtNIC.Text="";
             txtNP.Text="";
            txtVP.Text="";



        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtNP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNP, "Can't Blank The Commitioner Officer New Password Field");
                MessageBox.Show("This Returning Officer New Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtVP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVP, "Can't Blank The Commitioner Officer  Verify Password Field");
                MessageBox.Show("This Commitioner Officer  Verify Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }

            return ok;


        }






    }
}
