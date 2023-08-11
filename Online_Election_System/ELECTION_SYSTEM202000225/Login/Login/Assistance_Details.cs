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
    public partial class Assistance_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string ANIC;
        string AFN;
        string ALN;
        string ADB;
        string ATP;
        string AD;
        public Assistance_Details()
        {
            InitializeComponent();
        }

        private void Assistance_Details_Load(object sender, EventArgs e)
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
                    if (txtASSNIC.Text != "")
                    {
                        ANIC = txtASSNIC.Text;
                        AFN = txtASSFName.Text;
                        ALN = txtASSLName.Text;
                        ADB = dateTimePickerDOB.Text;
                        ATP = txtASSTP.Text;
                        AD = txtASSAdd.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into   Adata values(@ANIC, @AFN, @ALN, @ADB, @ATP,@AD)", con);
                        cmd.Parameters.AddWithValue("ANIC", ANIC);
                        cmd.Parameters.AddWithValue("AFN", AFN);
                        cmd.Parameters.AddWithValue("ALN", ALN);
                        cmd.Parameters.AddWithValue("ADB", ADB);
                        cmd.Parameters.AddWithValue("ATP", ATP);
                        cmd.Parameters.AddWithValue("AD", AD);
                        //  cmd.Parameters.AddWithValue("tp", tp);

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

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViw_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Adata", con);
            adapt.Fill(dt);
            dataGridViewASSDe.DataSource = dt;
            con.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {

            txtASSNIC.Text="";
            txtASSFName.Text="";  
            txtASSLName.Text="";
            dateTimePickerDOB.Text="";
            txtASSTP.Text="";
            txtASSAdd.Text="";
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string ANIC = txtASSNIC.Text;
            string sqlselect = "select * from Adata where ANIC='" + ANIC + "'";
            if (ANIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewASSDe.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter ANIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string ANIC =txtASSNIC.Text;
            if (ANIC != "")
            {
                string sqldelete = "delete Adata where ANIC='" + ANIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Adata", con);
                adapt.Fill(dt);
                dataGridViewASSDe.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter ANIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update Adata set AFN = @AFN, ALN = @ALN, ADB= @ADB,ATP=@ATP,AD=@AD where ANIC = @ANIC", con);
                        cmd.Parameters.AddWithValue("ANIC", txtASSNIC.Text);
                        cmd.Parameters.AddWithValue("AFN", txtASSFName.Text);
                        cmd.Parameters.AddWithValue("ALN", txtASSLName.Text);
                        cmd.Parameters.AddWithValue("ADB", dataGridViewASSDe.Text);
                        cmd.Parameters.AddWithValue("ATP", txtASSTP.Text);
                        cmd.Parameters.AddWithValue("AD", txtASSAdd.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtASSNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from Adata", con);
                            adapt.Fill(dt);
                            dataGridViewASSDe.DataSource = dt;



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

        private void dataGridViewASSDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ANIC = dataGridViewASSDe.CurrentRow.Cells[0].Value.ToString();
            AFN = dataGridViewASSDe.CurrentRow.Cells[1].Value.ToString();
            ALN = dataGridViewASSDe.CurrentRow.Cells[2].Value.ToString();
            ADB = dataGridViewASSDe.CurrentRow.Cells[3].Value.ToString();
            ATP = dataGridViewASSDe.CurrentRow.Cells[4].Value.ToString();
            AD = dataGridViewASSDe.CurrentRow.Cells[5].Value.ToString();


            txtASSNIC.Text = ANIC;
            txtASSFName.Text = AFN;
            txtASSLName.Text = ALN;
            dateTimePickerDOB.Text = ADB;
            txtASSTP.Text = ATP;
            txtASSAdd.Text = AD;

            txtASSNIC.ReadOnly = true;
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtASSNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtASSNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtASSFName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtASSFName, "Can't Blank The First Name Field");
                MessageBox.Show("Assistance First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtASSLName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtASSLName, "Can't Blank The Last Name Field");
                MessageBox.Show("Assistace Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDOB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDOB, "Can't Blank The Birth Date Field");
                MessageBox.Show("This Date Time Picker Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtASSTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtASSTP, "Can't Blank The Password Field");
                MessageBox.Show("Assistance Telephone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtASSAdd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtASSAdd, "Can't Blank The Password Field");
                MessageBox.Show("Gramaniladhari Divition Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
          
          if (!System.Text.RegularExpressions.Regex.IsMatch(txtASSFName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtASSFName, "This Field accept alperbatical character only");
                MessageBox.Show("Assistance First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtASSLName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtASSLName, "This Field accept alperbatical character only");
                MessageBox.Show("Assistance Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtASSAdd.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtASSAdd, "This Field accept alperbatical character only");
                MessageBox.Show("Assistance Address  text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            
            return ok;


        }






    }
}
