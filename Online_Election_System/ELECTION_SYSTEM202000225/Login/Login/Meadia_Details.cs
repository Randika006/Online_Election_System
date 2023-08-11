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
    public partial class Meadia_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string MNM;
        string MAD;
        string MTP;
        string MO;

        public Meadia_Details()
        {
            InitializeComponent();
        }

        private void Meadia_Details_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    if (txtMN.Text != "")
                    {
                        MNM = txtMN.Text;
                        MAD = txtMAdd.Text;
                        MTP = txtMTP.Text;
                        MO = txtMO.Text;



                        con.Open();

                        cmd = new SqlCommand("Insert into   MDE values(@MNM, @MAD, @MTP, @MO)", con);
                        cmd.Parameters.AddWithValue("MNM", MNM);
                        cmd.Parameters.AddWithValue("MAD", MAD);
                        cmd.Parameters.AddWithValue("MTP", MTP);
                        cmd.Parameters.AddWithValue("MO", MO);
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
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCLE_Click(object sender, EventArgs e)
        {
            txtMN.Text="";
            txtMAdd.Text="";
             txtMTP.Text="";
            txtMO.Text="";
        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVW_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from MDE", con);
            adapt.Fill(dt);
            dataGridViewMDE.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string MNM = txtMN.Text;
            string sqlselect = "select * from MDE where MNM='" + MNM + "'";
            if (MNM != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewMDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter MDE to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            string MNM = txtMN.Text;
            if (MNM != "")
            {
                string sqldelete = "delete MDE where MNM='" + MNM + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from MDE", con);
                adapt.Fill(dt);
                dataGridViewMDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Media Name to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update MDE set MAD = @MAD, MTP = @MTP, MO= @MO where MNM = @MNM", con);
                        cmd.Parameters.AddWithValue("MNM", txtMN.Text);
                        cmd.Parameters.AddWithValue("MAD", txtMAdd.Text);
                        cmd.Parameters.AddWithValue("MTP", txtMTP.Text);
                        cmd.Parameters.AddWithValue("MO", txtMO.Text);
                       

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtMN.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from MDE", con);
                            adapt.Fill(dt);
                            dataGridViewMDE.DataSource = dt;



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

        private void dataGridViewMDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MNM = dataGridViewMDE.CurrentRow.Cells[0].Value.ToString();
            MAD = dataGridViewMDE.CurrentRow.Cells[1].Value.ToString();
            MTP = dataGridViewMDE.CurrentRow.Cells[2].Value.ToString();
            MO = dataGridViewMDE.CurrentRow.Cells[3].Value.ToString();
            //word = dataGridViewGNDE.CurrentRow.Cells[4].Value.ToString();

            txtMN.Text = MNM;
            txtMAdd.Text = MAD;
            txtMTP.Text = MTP;
            txtMO.Text = MO;
            //txtGPass.Text = Pword;

            txtMN.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtMN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMN, "Can't Blank Media Name Field");

            }
            if (txtMAdd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMAdd, "Can't Blank The Meadia Address Name Field");
                MessageBox.Show("This Meadia Address Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtMTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMTP, "Can't Blank The Meadia Tele Phone Number Field");
                MessageBox.Show("This Meadia Tele Phone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtMO.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMO, "Can't Blank The Meadia Owner Field");
                MessageBox.Show("This Meadia Owner Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
           if (!System.Text.RegularExpressions.Regex.IsMatch(txtMN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtMN, "This Field accept alperbatical character only");
                MessageBox.Show("This Meadia Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMAdd.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtMAdd, "This Field accept alperbatical character only");
                MessageBox.Show("This Meadia Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtMO.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtMO, "This Field accept alperbatical character only");
                MessageBox.Show("This Meadia Owner text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }


    }
}
