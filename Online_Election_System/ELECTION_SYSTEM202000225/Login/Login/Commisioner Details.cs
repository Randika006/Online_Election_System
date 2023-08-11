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
    public partial class Commisioner_Details : Form
    {

        public SqlCommand cmd;
        public SqlConnection con;
        string NIC;
        string FN;
        string LN;
        string DB;
        string AD;
        public Commisioner_Details()
        {
            InitializeComponent();
        }

        private void Commisioner_Details_Load(object sender, EventArgs e)
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
                        NIC = txtNIC.Text;
                        FN = txtFN.Text;
                        LN = txtLN.Text;
                        DB = dateTimePickerDB.Text;
                        AD = txtAD.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into   CDE values(@NIC, @FN, @LN,@DB,@AD)", con);
                        cmd.Parameters.AddWithValue("NIC", NIC);
                        cmd.Parameters.AddWithValue("FN", FN);
                        cmd.Parameters.AddWithValue("LN", LN);
                        cmd.Parameters.AddWithValue("DB", DB);
                        cmd.Parameters.AddWithValue("AD", AD);


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

        private void btnVi_Click(object sender, EventArgs e)
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from  CDE", con);
            adapt.Fill(dt);
            dataGridViewCD.DataSource = dt;
            con.Close();


        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtNIC.Text="";
            txtFN.Text="";
            txtLN.Text="";
            dateTimePickerDB.Text="";
            txtAD.Text="";




        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            string NIC= txtNIC.Text;
            string sqlselect = "select * from  CDE where NIC='" + NIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewCD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            string NIC = txtNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete CDE where NIC='" + NIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from  CDE", con);
                adapt.Fill(dt);
                dataGridViewCD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update CDE set FN = @FN, LN= @LN,DB=@DB,AD=@AD where NIC = @NIC", con);
                        cmd.Parameters.AddWithValue("NIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("FN", txtFN.Text);
                        cmd.Parameters.AddWithValue("LN", txtLN.Text);
                        cmd.Parameters.AddWithValue("DB", dateTimePickerDB.Text);
                        cmd.Parameters.AddWithValue("AD", txtAD.Text);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from CDE", con);
                            adapt.Fill(dt);
                            dataGridViewCD.DataSource = dt;



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
        private void dataGridViewCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            NIC = dataGridViewCD.CurrentRow.Cells[0].Value.ToString();
            FN = dataGridViewCD.CurrentRow.Cells[1].Value.ToString();
            LN = dataGridViewCD.CurrentRow.Cells[2].Value.ToString();
            DB = dataGridViewCD.CurrentRow.Cells[3].Value.ToString();
            AD = dataGridViewCD.CurrentRow.Cells[4].Value.ToString();



            txtNIC.Text = NIC;
            txtFN.Text = FN;
            txtLN.Text = LN;
            dateTimePickerDB.Text = DB;
            txtAD.Text = AD;





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
            if (txtFN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFN, "Can't Blank The Commisioner First Name Field");
                MessageBox.Show("This Commisioner First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtLN, "Can't Blank The Commisioner Last Name Field");
                MessageBox.Show("This Commisioner Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDB, "Can't Blank The Counting Officer Birth Date Field");
                MessageBox.Show("This Counting Officer Birth DateText Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtAD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAD, "Can't Blank The Commisioner Address Field");
                MessageBox.Show("This Commisioner Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
           if (!System.Text.RegularExpressions.Regex.IsMatch(txtFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtFN, "This Field accept alperbatical character only");
                MessageBox.Show("This Commisioner First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtLN, "This Field accept alperbatical character only");
                MessageBox.Show("This Commisioner Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtAD.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtAD, "This Field accept alperbatical character only");
                MessageBox.Show("This Commisioner Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }




    }
}
