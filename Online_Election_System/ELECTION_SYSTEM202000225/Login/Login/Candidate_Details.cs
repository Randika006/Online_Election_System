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
    public partial class Candidate_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string CNIC;
        string CFN;
        string CLN;
        string CDB;
        string CTP;
        string CAD;
        public Candidate_Details()
        {
            InitializeComponent();
        }

        private void Candidate_Details_Load(object sender, EventArgs e)
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
                    if (txtNIC.Text != "")
                    {


                        CNIC = txtNIC.Text;

                        CFN = txtCFN.Text;
                        CLN = textBox3.Text;  //That is a candidate last name text box identification
                        CDB = dateTimePickerCD.Text;
                        CTP = txtCTP.Text;
                        CAD = txtCAdd.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into   CADE values(@CNIC, @CFN,@CLN,@CDB,@CTP,@CAD)", con);
                        cmd.Parameters.AddWithValue("CNIC", CNIC);

                        cmd.Parameters.AddWithValue("CFN", CFN);
                        cmd.Parameters.AddWithValue("CLN", CLN);
                        cmd.Parameters.AddWithValue("CDB", CDB);
                        cmd.Parameters.AddWithValue("CTP", CTP);
                        cmd.Parameters.AddWithValue("CAD", CAD);


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

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtNIC.Text="";

            txtCFN.Text="";
            textBox3.Text="";  //That is a candidate last name text box identification
            dateTimePickerCD.Text="";
            txtCTP.Text="";
            txtCAdd.Text="";
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from CADE", con);
            adapt.Fill(dt);
            dataGridViewCDE.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtNIC.Text;
            string sqlselect = "select * from CADE where CNIC='" + CNIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewCDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete CADE where CNIC='" + CNIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from CADE", con);
                adapt.Fill(dt);
                dataGridViewCDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update CADE set CFN = @CFN, CLN = @CLN, CDB= @CDB,CTP=@CTP,CAD=@CAD where CNIC = @CNIC", con);
                        cmd.Parameters.AddWithValue("CNIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("CFN", txtCFN.Text);
                        cmd.Parameters.AddWithValue("CLN", textBox3.Text);
                        cmd.Parameters.AddWithValue("CDB", dateTimePickerCD.Text);
                        cmd.Parameters.AddWithValue("CTP", txtCTP.Text);
                        cmd.Parameters.AddWithValue("CAD", txtCAdd.Text);
                        
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from CADE", con);
                            adapt.Fill(dt);
                            dataGridViewCDE.DataSource = dt;



                        }
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Data not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNIC = dataGridViewCDE.CurrentRow.Cells[0].Value.ToString();
            CFN = dataGridViewCDE.CurrentRow.Cells[1].Value.ToString();
            CLN = dataGridViewCDE.CurrentRow.Cells[2].Value.ToString();
            CDB = dataGridViewCDE.CurrentRow.Cells[3].Value.ToString();
            CTP = dataGridViewCDE.CurrentRow.Cells[4].Value.ToString();
            CAD= dataGridViewCDE.CurrentRow.Cells[5].Value.ToString();
           
            txtNIC.Text = CNIC;
            txtCFN.Text = CFN;
            textBox3.Text = CLN;
            dateTimePickerCD.Text =CDB;
            txtCTP.Text =CTP;
            txtCAdd.Text = CAD;
            

            txtNIC.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtCFN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCFN, "Can't Blank The Candidates First Name Field");
                MessageBox.Show("This Candidates First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (textBox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3, "Can't Blank The Candidates Last Name Field");
                MessageBox.Show("This Candidates Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerCD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerCD, "Can't Blank Candidates Date Of Birth Field");
                MessageBox.Show("This Candidates Date Of Birth Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtCTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCTP, "Can't Blank The Telephone number Field");
                MessageBox.Show("This Candidates Telephone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtCAdd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCAdd, "Can't Blank The Candidates Address Field");
                MessageBox.Show("This Candidates Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCFN, "This Field accept alperbatical character only");
                MessageBox.Show("This Candidates First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(textBox3, "This Field accept alperbatical character only");
                MessageBox.Show("This Candidates Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
           /*if (System.Text.RegularExpressions.Regex.IsMatch(txtCTP.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtCTP, "Please enter only numbers.");
                MessageBox.Show("Please enter numbers in candidates telephone number text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }*/
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCAdd.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCAdd, "This Field accept alperbatical character only");
                MessageBox.Show("This Candidates Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }

            return ok;


        }





    }
}
