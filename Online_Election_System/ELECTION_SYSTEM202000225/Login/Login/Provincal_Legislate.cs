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
    public partial class Provincal_Legislate : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string PRV;
        string POP;
        string RV;
        string VPP;
        public Provincal_Legislate()
        {
            InitializeComponent();
        }

        private void Provincal_Legislate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double POP = Convert.ToDouble(textBox2.Text);
            double RV = Convert.ToDouble(textBox3.Text);
            double VPP = Convert.ToDouble((RV / POP * 1.0) * 100);
            textBox4.Text = VPP.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    if (textBox1.Text != "")
                    {
                        PRV = textBox1.Text;
                        POP = textBox2.Text;
                        RV = textBox3.Text;
                        VPP = textBox4.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   PLG values(@PRV, @POP, @RV, @VPP)", con);
                        cmd.Parameters.AddWithValue("PRV", PRV);
                        cmd.Parameters.AddWithValue("POP", POP);
                        cmd.Parameters.AddWithValue("RV", RV);
                        cmd.Parameters.AddWithValue("VPP", VPP);
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
                        MessageBox.Show("Please Enter Province", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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

        private void btnCl_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";

        }

        private void btnVW_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from PLG", con);
            adapt.Fill(dt);
            dataGridViewPL.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string PRV = textBox1.Text;
            string sqlselect = "select * from PLG where PRV='" + PRV + "'";
            if (PRV != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewPL.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Prty to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string PRV = textBox1.Text;
            if (PRV != "")
            {
                string sqldelete = "delete  PLG where PRV='" + PRV + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from PLG", con);
                adapt.Fill(dt);
                dataGridViewPL.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Prty to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update PLG set POP= @POP,RV=@RV,VPP=@VPP where PRV = @PRV", con);
                        cmd.Parameters.AddWithValue("PRV", textBox1.Text);
                        cmd.Parameters.AddWithValue("POP", textBox2.Text);
                        cmd.Parameters.AddWithValue("RV", textBox3.Text);
                        cmd.Parameters.AddWithValue("VPP", textBox4.Text);
                        //cmd.Parameters.AddWithValue("Pword", txtGPass.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        textBox1.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from  PLG", con);
                            adapt.Fill(dt);
                            dataGridViewPL.DataSource = dt;



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

        private void dataGridViewPL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PRV = dataGridViewPL.CurrentRow.Cells[0].Value.ToString();
            POP = dataGridViewPL.CurrentRow.Cells[1].Value.ToString();
            RV = dataGridViewPL.CurrentRow.Cells[2].Value.ToString();
            VPP = dataGridViewPL.CurrentRow.Cells[3].Value.ToString();
            //word = dataGridViewGNDE.CurrentRow.Cells[4].Value.ToString();

            textBox1.Text = PRV;
            textBox2.Text = POP;
            textBox3.Text =RV;
            textBox4.Text = VPP;
            //txtGPass.Text = Pword;

            textBox1.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (textBox1.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox1, "Can't Blank Province Name Field");

            }
            if (textBox2.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox2, "Can't Blank The Population Field");
                MessageBox.Show("This Population Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (textBox3.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox3, "Can't Blank The Number Of Registered Votes Field");
                MessageBox.Show("This Registered Votes Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(textBox1, "This Field accept alperbatical character only");
                MessageBox.Show("This Province text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(textBox2, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Population text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(textBox3, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Registered Votes  text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            return ok;


        }




    }
}
