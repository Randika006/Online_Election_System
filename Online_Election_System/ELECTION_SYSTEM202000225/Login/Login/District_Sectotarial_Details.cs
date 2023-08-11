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
    public partial class District_Sectotarial_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string DNIC;
        string DFN;
        string DLN;
        string DOB;
        string DTP;
        string DSA;
        public District_Sectotarial_Details()
        {
            InitializeComponent();
        }

        private void District_Sectotarial_Details_Load(object sender, EventArgs e)
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
                    if (txtDSNIC.Text != "")
                    {
                        DNIC = txtDSNIC.Text;
                        DFN = txtDSFName.Text;
                        DLN = txtDSLName.Text;
                        DOB = dateTimePickerDSDOB.Text;
                        DTP = txtDSTP.Text;
                        DSA = txtDSAdd.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   Ddata values(@DNIC, @DFN, @DLN, @DOB, @DTP,@DSA)", con);
                        cmd.Parameters.AddWithValue("DNIC", DNIC);
                        cmd.Parameters.AddWithValue("DFN", DFN);
                        cmd.Parameters.AddWithValue("DLN", DLN);
                        cmd.Parameters.AddWithValue("DOB", DOB);
                        cmd.Parameters.AddWithValue("DTP", DTP);
                        cmd.Parameters.AddWithValue("DSA", DSA);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter DNIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Reopen form and make mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViw_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from  Ddata", con);
            adapt.Fill(dt);
            dataGridViewDSDe.DataSource = dt;
            con.Close();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtDSNIC.Text="";
            txtDSFName.Text="";
            txtDSLName.Text="";
            dateTimePickerDSDOB.Text="";
            txtDSTP.Text="";
            txtDSAdd.Text="";
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtDSNIC.Text;
            string sqlselect = "select * from  Ddata where DNIC='" + DNIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewDSDe.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter DNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtDSNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete Ddata where DNIC='" + DNIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from  Ddata", con);
                adapt.Fill(dt);
                dataGridViewDSDe.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter DNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update Ddata set DFN = @DFN, DLN = @DLN, DOB= @DOB,DTP=@DTP,DSA=@DSA where DNIC = @DNIC", con);
                        cmd.Parameters.AddWithValue("DNIC", txtDSNIC.Text);
                        cmd.Parameters.AddWithValue("DFN", txtDSFName.Text);
                        cmd.Parameters.AddWithValue("DLN", txtDSLName.Text);
                        cmd.Parameters.AddWithValue("DOB", dateTimePickerDSDOB.Text);
                        cmd.Parameters.AddWithValue("DTP", txtDSTP.Text);
                        cmd.Parameters.AddWithValue("DSA", txtDSAdd.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtDSNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from Ddata", con);
                            adapt.Fill(dt);
                            dataGridViewDSDe.DataSource = dt;



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

        private void dataGridViewDSDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNIC = dataGridViewDSDe.CurrentRow.Cells[0].Value.ToString();
            DFN = dataGridViewDSDe.CurrentRow.Cells[1].Value.ToString();
            DLN = dataGridViewDSDe.CurrentRow.Cells[2].Value.ToString();
            DOB = dataGridViewDSDe.CurrentRow.Cells[3].Value.ToString();
            DTP = dataGridViewDSDe.CurrentRow.Cells[4].Value.ToString();
            DSA = dataGridViewDSDe.CurrentRow.Cells[5].Value.ToString();

            txtDSNIC.Text = DNIC;
            txtDSFName.Text = DFN;
            txtDSLName.Text = DLN;
            dateTimePickerDSDOB.Text = DOB;
            txtDSTP.Text = DTP;
            txtDSAdd.Text = DSA;

            txtDSNIC.ReadOnly = true;
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtDSNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDSNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtDSFName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDSFName, "Can't Blank The First Name Field");
                MessageBox.Show("This First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtDSLName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDSTP, "Can't Blank The Last Name Field");
                MessageBox.Show("This Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDSDOB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDSDOB, "Can't Blank The Birth Date Field");
                MessageBox.Show("This Date Time Picker Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtDSTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDSTP, "Can't Blank The Tele Phone Numer Field");
                MessageBox.Show("This Tele Phone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtDSAdd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDSAdd, "Can't Blank The Address Field");
                MessageBox.Show("This Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDSFName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtDSFName, "This Field accept alperbatical character only");
                MessageBox.Show("This First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDSLName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtDSLName, "This Field accept alperbatical character only");
                MessageBox.Show("This Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
           /*if (System.Text.RegularExpressions.Regex.IsMatch(txtDSTP.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtDSTP, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }*/
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDSAdd.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtDSAdd, "This Field accept alperbatical character only");
                MessageBox.Show("This Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }



            return ok;


        }










    }





}
