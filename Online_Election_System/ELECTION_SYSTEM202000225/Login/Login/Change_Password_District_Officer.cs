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
    public partial class Change_Password_District_Officer : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string CNIC;
        string NP;
        string VP;
        public Change_Password_District_Officer()
        {
            InitializeComponent();
        }

        private void Change_Password_District_Officer_Load(object sender, EventArgs e)
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
                    if (textBox1.Text != "")
                    {


                        CNIC = textBox1.Text;

                        NP = textBox2.Text;
                        VP = textBox3.Text;  //That is a candidate last name text box identification
                                             //WDOB = dateTimePickerWDB.Text;
                                             //WTP = txtWTP.Text;
                                             //WADD = txtWAD.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into   CDO values(@DNIC, @NDP,@NVP)", con);
                        cmd.Parameters.AddWithValue("DNIC", CNIC);

                        cmd.Parameters.AddWithValue("NDP", NP);
                        cmd.Parameters.AddWithValue("NVP", VP);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter CNIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);



                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Reopen form and make mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            textBox1.Text="";

            textBox2.Text="";
            textBox3.Text="";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
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
                errorProvider1.SetError(textBox2, "Can't Blank The New Password Field");
                MessageBox.Show("This New Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (textBox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3, "Can't Blank The Verify Password Field");
                MessageBox.Show("This Verify Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            

            return ok;


        }





    }
}
