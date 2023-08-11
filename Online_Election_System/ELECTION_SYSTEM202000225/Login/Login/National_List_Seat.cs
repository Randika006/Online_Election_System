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
    public partial class National_List_Seat : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string PTY;
        string TP;
        string RS;
        string PS;
        public National_List_Seat()
        {
            InitializeComponent();
        }

        private void National_List_Seat_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //double RS, PS;
            
            //RSeat = txtRS.Text;
            //TPS= txtTP.Text;
            double TP = Convert.ToDouble(txtTP.Text);
            double RS = Convert.ToDouble(txtRS.Text);
            double PS = Convert.ToDouble((TP-RS));
            txtPS.Text = PS.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    if (txtParty.Text != "")
                    {

                        PTY = txtParty.Text;
                        TP = txtTP.Text;
                        RS = txtRS.Text;
                        PS = txtPS.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   NLS values(@PTY, @TP, @RS, @PS)", con);
                        cmd.Parameters.AddWithValue("PTY", PTY);
                        cmd.Parameters.AddWithValue("TP", TP);
                        cmd.Parameters.AddWithValue("RS", RS);
                        cmd.Parameters.AddWithValue("PS", PS);
                        // cmd.Parameters.AddWithValue("Gpass", Pword);
                        //  cmd.Parameters.AddWithValue("address", address);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk); ;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Party", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
            txtParty.Text="";
            txtTP.Text="";
            txtRS.Text="";
            txtPS.Text="";
        }

        private void btnVw_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from NLS", con);
            adapt.Fill(dt);
            dataGridViewNlS.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string PTY = txtParty.Text;
            string sqlselect = "select * from NLS where PTY='" + PTY + "'";
            if (PTY != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewNlS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Prty to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string PTY = txtParty.Text;
            if (PTY != "")
            {
                string sqldelete = "delete NLS where PTY='" + PTY + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from NLS", con);
                adapt.Fill(dt);
                dataGridViewNlS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Prty to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update NLS set TP = @TP, RS= @RS,PS =@PS where PTY = @PTY", con);
                        cmd.Parameters.AddWithValue("PTY", txtParty.Text);
                        cmd.Parameters.AddWithValue("TP", txtTP.Text);
                        cmd.Parameters.AddWithValue("RS", txtRS.Text);
                        cmd.Parameters.AddWithValue("PS", txtPS.Text);
                        //cmd.Parameters.AddWithValue("Pword", txtGPass.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtParty.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from NLS", con);
                            adapt.Fill(dt);
                            dataGridViewNlS.DataSource = dt;



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

        private void dataGridViewNlS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PTY = dataGridViewNlS.CurrentRow.Cells[0].Value.ToString();
            TP = dataGridViewNlS.CurrentRow.Cells[1].Value.ToString();
            RS = dataGridViewNlS.CurrentRow.Cells[2].Value.ToString();
            PS = dataGridViewNlS.CurrentRow.Cells[3].Value.ToString();
            //word = dataGridViewGNDE.CurrentRow.Cells[4].Value.ToString();

            txtParty.Text = PTY;
            txtTP.Text = TP;
            txtRS.Text = RS;
            txtPS.Text = PS;
            //txtGPass.Text = Pword;

            txtParty.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtParty.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtParty, "Can't Blank Party Name Field");

            }
            if (txtTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Can't Blank The Total Party Field");
                MessageBox.Show("This Total Party Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtRS.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRS, "Can't Blank The Regional Seat Field");
                MessageBox.Show("This Counting Officer Regional Seat Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtParty.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtParty, "This Field accept alperbatical character only");
                MessageBox.Show("This Political Party text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTP.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Total Party text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRS.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtRS, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Regional Seat text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            return ok;


        }







    }
}
