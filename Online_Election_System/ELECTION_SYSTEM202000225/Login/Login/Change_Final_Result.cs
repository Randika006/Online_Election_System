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
    public partial class Change_Final_Result : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string PTY;
        string VP;
        string NE;
        string VW;
        public Change_Final_Result()
        {
            InitializeComponent();
        }

        private void Change_Final_Result_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double VP = Convert.ToDouble(txtVPOl.Text);
            double NE = Convert.ToDouble(txtNElec.Text);
            double VM = Convert.ToDouble((NE /VP));
            double VW = Convert.ToDouble((VM*100));
            txtVWOn.Text = VW.ToString();
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
                        VP = txtVPOl.Text;
                        NE = txtNElec.Text;
                        VW = txtVWOn.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   FNR values(@PTY, @VP, @NE, @VW)", con);
                        cmd.Parameters.AddWithValue("PTY", PTY);
                        cmd.Parameters.AddWithValue("VP", VP);
                        cmd.Parameters.AddWithValue("NE", NE);
                        cmd.Parameters.AddWithValue("VW", VW);
                        // cmd.Parameters.AddWithValue("Gpass", Pword);
                        //  cmd.Parameters.AddWithValue("address", address);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Media Name", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

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
            txtVPOl.Text="";
            txtNElec.Text="";
            txtVWOn.Text="";
        }

        private void btnVW_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from FNR", con);
            adapt.Fill(dt);
            dataGridViewFRP.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string PTY = txtParty.Text;
            string sqlselect = "select * from FNR where PTY='" + PTY + "'";
            if (PTY != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewFRP.DataSource = dt;
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
                string sqldelete = "delete FNR where PTY='" + PTY + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from FNR", con);
                adapt.Fill(dt);
                dataGridViewFRP.DataSource = dt;
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
                        cmd = new SqlCommand("update FNR set VP = @VP, NE= @NE,VW=@VW where PTY = @PTY", con);
                        cmd.Parameters.AddWithValue("PTY", txtParty.Text);
                        cmd.Parameters.AddWithValue("VP", txtVPOl.Text);
                        cmd.Parameters.AddWithValue("NE", txtNElec.Text);
                        cmd.Parameters.AddWithValue("VW", txtVWOn.Text);
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
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from FNR", con);
                            adapt.Fill(dt);
                            dataGridViewFRP.DataSource = dt;



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

        private void dataGridViewFRP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PTY = dataGridViewFRP.CurrentRow.Cells[0].Value.ToString();
            VP = dataGridViewFRP.CurrentRow.Cells[1].Value.ToString();
            NE = dataGridViewFRP.CurrentRow.Cells[2].Value.ToString();
            VW = dataGridViewFRP.CurrentRow.Cells[3].Value.ToString();
            //word = dataGridViewGNDE.CurrentRow.Cells[4].Value.ToString();

            txtParty.Text = PTY;
            txtVPOl.Text = VP;
            txtNElec.Text = NE;
            txtVWOn.Text = VW;
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
            if (txtVPOl.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVPOl, "Can't Blank The Valied Polited Field");
                MessageBox.Show("This Valied Polited Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtNElec.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNElec, "Can't Blank The Number Of Elected Field");
                MessageBox.Show("This Number Of Elected Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtParty.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtParty, "This Field accept alperbatical character only");
                MessageBox.Show("This Political Party text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVPOl.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtVPOl, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Valied Polited text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNElec.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtNElec, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Number Of Elected text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            return ok;


        }








    }
}
