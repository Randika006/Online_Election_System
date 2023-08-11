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
    public partial class Change_Password : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string NIC;
        string NPWord;
        string VWord;
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
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
                    if (txtGNIC.Text != "")
                    {
                        NIC = txtGNIC.Text;
                        NPWord = txtGNPASS.Text;
                        VWord = txtGVPASS.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   GNCPass values(@GNIC, @GNPASS, @GVPASS)", con);
                        cmd.Parameters.AddWithValue("GNIC", NIC);
                        cmd.Parameters.AddWithValue("GNPASS", NPWord);
                        cmd.Parameters.AddWithValue("GVPASS", VWord);
                        //cmd.Parameters.AddWithValue("GDOB", BDay);
                        //cmd.Parameters.AddWithValue("Gpass", Pword);
                        //  cmd.Parameters.AddWithValue("address", address);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !");
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

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtGNIC.Text="" ;
            txtGNPASS.Text="";
            txtGVPASS.Text="";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtGNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtGNPASS.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGNPASS, "Can't Blank The First Name Field");
                MessageBox.Show("New Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtGVPASS.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGVPASS, "Can't Blank The Last Name Field");
                MessageBox.Show("Verify Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
           
            return ok;


        }




    }
}

