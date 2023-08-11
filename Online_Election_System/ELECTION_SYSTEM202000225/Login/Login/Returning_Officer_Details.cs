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
    public partial class Returning_Officer_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string RNIC;
        string RFN;
        string RLN;
        string RDB;
        string RTP;
        string RAD;
        public Returning_Officer_Details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from RDE", con);
            adapt.Fill(dt);
            dataGridViewROD.DataSource = dt;
            con.Close();
        }

        private void Returning_Officer_Details_Load(object sender, EventArgs e)
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
                    if (txtRNIC.Text != "")
                    {
                        RNIC = txtRNIC.Text;
                        RFN = txtRFN.Text;
                        RLN = txtRLN.Text;
                        RDB = dateTimePickerDB.Text;
                        RTP = txtTP.Text;
                        RAD = txtRADD.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   RDE values(@RNIC, @RFN, @RLN, @RDB,@RTP,@RAD)", con);
                        cmd.Parameters.AddWithValue("RNIC", RNIC);
                        cmd.Parameters.AddWithValue("RFN", RFN);
                        cmd.Parameters.AddWithValue("RLN", RLN);
                        cmd.Parameters.AddWithValue("RDB", RDB);
                        cmd.Parameters.AddWithValue("RTP", RTP);
                        cmd.Parameters.AddWithValue("RAD", RAD);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter RNIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

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

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtRNIC.Text="";
            txtRFN.Text="";
            txtRLN.Text="";
            dateTimePickerDB.Text="";
            txtTP.Text="";
            txtRADD.Text="";
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string RONIC = txtRNIC.Text;
            string sqlselect = "select * from RDE where RNIC='" + RNIC + "'";
            if (RONIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewROD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter RNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string RNIC = txtRNIC.Text;
            if (RNIC != "")
            {
                string sqldelete = "delete RDE where RNIC='" + RNIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from RDE", con);
                adapt.Fill(dt);
                dataGridViewROD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter RNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update RDE set RFN= @RFN,RLN=@RLN,RDB=@RDB,RTP=@RTP,RAD=@RAD where RNIC = @RNIC", con);
                        cmd.Parameters.AddWithValue("RNIC", txtRNIC.Text);
                        cmd.Parameters.AddWithValue("RFN", txtRFN.Text);
                        cmd.Parameters.AddWithValue("RLN", txtRLN.Text);
                        cmd.Parameters.AddWithValue("RDB", dateTimePickerDB.Text);
                        cmd.Parameters.AddWithValue("RTP", txtTP.Text);
                        cmd.Parameters.AddWithValue("RAD", txtRADD.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtRNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from RDE", con);
                            adapt.Fill(dt);
                            dataGridViewROD.DataSource = dt;



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

        private void dataGridViewROD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNIC = dataGridViewROD.CurrentRow.Cells[0].Value.ToString();
            RFN = dataGridViewROD.CurrentRow.Cells[1].Value.ToString();
            RLN = dataGridViewROD.CurrentRow.Cells[2].Value.ToString();
            RDB = dataGridViewROD.CurrentRow.Cells[3].Value.ToString();
            RTP = dataGridViewROD.CurrentRow.Cells[4].Value.ToString();
            RAD = dataGridViewROD.CurrentRow.Cells[5].Value.ToString();

            txtRNIC.Text = RNIC;
            txtRFN.Text = RFN;
            txtRLN.Text = RLN;
            dateTimePickerDB.Text = RDB;
            txtTP.Text = RTP;
            txtRADD.Text = RAD;
            txtRNIC.ReadOnly = true;
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtRNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtRFN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRFN, "Can't Blank The Returning Officer First Name Field");
                MessageBox.Show("This Returning Officer First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtRLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRLN, "Can't Blank The Returning Officer  Last Name Field");
                MessageBox.Show("This Returning Officer  Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDB, "Can't Blank The Returning Officer Birth Date Field");
                MessageBox.Show("This Returning Officer Birth DateText Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Can't Blank The Counting Officer Tele Phone Number Field");
                MessageBox.Show("This Counting Officer Tele Phone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Can't Blank The Returning Officer Tele Phone Number Field");
                MessageBox.Show("This Returning Officer Tele Phone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtRADD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRADD, "Can't Blank The Returning Officer Address Field");
                MessageBox.Show("This Returning Officer Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtRFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtRFN, "This Field accept alperbatical character only");
                MessageBox.Show("This Returning Officer First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtRLN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtRLN, "This Field accept alperbatical character only");
                MessageBox.Show("This Returning Officer Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtRADD.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtRADD, "This Field accept alperbatical character only");
                MessageBox.Show("This Returning Officer Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }


    }
}
