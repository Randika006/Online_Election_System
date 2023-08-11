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
    public partial class Support_the_report : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string VV;
        string RV;
        string TP;
        string RE;
        string TU;
        public Support_the_report()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SLP = Convert.ToDouble(txtSLP.Text);
            double UN = Convert.ToDouble(txtUN.Text);
            double JV = Convert.ToDouble(txtJV.Text);
            double OT = Convert.ToDouble(txtOT.Text);
            double TP = Convert.ToDouble(txtTP.Text);
            double RE = Convert.ToDouble(txtRE.Text);
            double VV = Convert.ToDouble(SLP+UN+JV+OT);
            double RV = Convert.ToDouble((TP -VV ));
            double TU = Convert.ToDouble((TP/RE)*100);

            txtVV.Text = VV.ToString();
            txtRV.Text = RV.ToString();
            //double VW = Convert.ToDouble((VM * 100));
            txtTU.Text = TU.ToString();




        }

        private void Support_the_report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnSEND_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    if (txtVV.Text != "")
                    {


                        VV = txtVV.Text;
                        RV = txtRV.Text;
                        TP = txtTP.Text;
                        RE = txtRE.Text;
                        TU = txtTU.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   SRD values(@VV, @RV, @TP, @RE,@TU)", con);
                        cmd.Parameters.AddWithValue("VV", VV);
                        cmd.Parameters.AddWithValue("RV", RV);
                        cmd.Parameters.AddWithValue("TP", TP);
                        cmd.Parameters.AddWithValue("RE", RE);
                        cmd.Parameters.AddWithValue("TU", TU);
                        //  cmd.Parameters.AddWithValue("address", address);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter valide votes", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Reopen form and make mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {

            txtVV.Text="";
            txtRV.Text="";
            txtTP.Text="";
            txtRE.Text="";
            txtTU.Text="";
            txtSLP.Text = "";
            txtTU.Text = "";
            txtJV.Text = "";
            txtOT.Text = "";
            txtUN.Text = "";

        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from SRD", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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
                        cmd = new SqlCommand("update SRD set RV = @RV,TP= @TP,RE=@RE TU=@TU where VV = @VV", con);
                        cmd.Parameters.AddWithValue("VV", txtVV.Text);
                        cmd.Parameters.AddWithValue("RV", txtRV.Text);
                        cmd.Parameters.AddWithValue("TP", txtTP.Text);
                        cmd.Parameters.AddWithValue("RE", txtRE.Text);
                        cmd.Parameters.AddWithValue("TU", txtTU.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtVV.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from SRD", con);
                            adapt.Fill(dt);
                            dataGridView1.DataSource = dt;



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VV = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            RV = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TP = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            RE = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            TU = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            txtVV.Text = VV;
            txtRV.Text = RV;
            txtTP.Text = TP;
            txtRE.Text = RE;
            txtTU.Text = TU;

            txtVV.ReadOnly = true;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            string TP = txtTP.Text;
            if (TP != "")
            {
                string sqldelete = "delete SRD where TP='" + TP + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from SRD", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Total Polited to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string TP = txtTP.Text;
            string sqlselect = "select * from SRD where TP='" + TP + "'";
            if (TP != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Total Polited to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtSLP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtSLP, "Can't Blank The Sri Lanka Freedom Party Field");

            }
            if (txtUN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUN, "Can't Blank The United National Party Field");
                MessageBox.Show("This United National Party Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtJV.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtJV, "Can't Blank JVP Field");
                MessageBox.Show("This JVP Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtOT.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtOT, "Can't Blank Other Party Field");
                MessageBox.Show("This Other Party Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }

            if (txtTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Can't Blank Total Polited Field");
                MessageBox.Show("This Total Polited Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtRE.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRE, "Can't Blank Register Elector Field");
                MessageBox.Show("This Register Elector Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSLP.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtSLP, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Sri Lanka Freedom Party", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUN.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtUN, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in United National Party text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJV.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtJV, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in JVP Party text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtJV.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtJV, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in JVP Party text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txtOT.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtOT, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Other Party text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRE.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtRE, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Register Elector text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }


            return ok;


        }





    }
}
