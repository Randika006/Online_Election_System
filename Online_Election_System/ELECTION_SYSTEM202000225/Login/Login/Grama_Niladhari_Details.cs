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
    public partial class Grama_Niladhari_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string NIC;
        string FName;
        string LName;
        string BDay;
        string Pword;
        public Grama_Niladhari_Details()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {

                try
                {
                    if (txtGNIC.Text != "")
                    {
                        NIC = txtGNIC.Text;
                        FName = txtGFName.Text;
                        LName = txtGLName.Text;
                        BDay = dateTimePickerBDate.Text;
                        Pword = txtGPass.Text;


                        con.Open();
                        cmd = new SqlCommand("Insert into   GDetails values(@GNIC, @GFName, @GLName, @GDOB, @GPass)", con);
                        cmd.Parameters.AddWithValue("GNIC", NIC);
                        cmd.Parameters.AddWithValue("GFName", FName);
                        cmd.Parameters.AddWithValue("GLName", LName);
                        cmd.Parameters.AddWithValue("GDOB", BDay);
                        cmd.Parameters.AddWithValue("Gpass", Pword);
                        //  cmd.Parameters.AddWithValue("address", address);
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
                    MessageBox.Show("Reopen the form and make the mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Grama_Niladhari_Details_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtGNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete GDetails where GNIC='" + NIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from GDetails", con);
                adapt.Fill(dt);
                dataGridViewGNDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtGNIC.Text;
            string sqlselect = "select * from GDetails where GNIC='" + NIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewGNDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCler_Click(object sender, EventArgs e)
        {
            txtGNIC.Text = "";
            txtGFName.Text = "";
            txtGLName.Text = "";
            dateTimePickerBDate.Text = "";
            txtGPass.Text = "";
            
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from GDetails",con);
            adapt.Fill(dt);
            dataGridViewGNDE.DataSource = dt;
            con.Close();
        }

        private void dataGridViewGNDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NIC = dataGridViewGNDE.CurrentRow.Cells[0].Value.ToString();
            FName = dataGridViewGNDE.CurrentRow.Cells[1].Value.ToString();
            LName = dataGridViewGNDE.CurrentRow.Cells[2].Value.ToString();
            BDay = dataGridViewGNDE.CurrentRow.Cells[3].Value.ToString();
            Pword = dataGridViewGNDE.CurrentRow.Cells[4].Value.ToString();

            txtGNIC.Text = NIC;
            txtGFName.Text = FName;
            txtGLName.Text = LName;
            dateTimePickerBDate.Text = BDay;
            txtGPass.Text = Pword;

            txtGNIC.ReadOnly = true;
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update GDetails set GFName = @FName, GLName = @LName, GDOB= @BDay,GPass=@Pword where GNIC = @NIC", con);
                        cmd.Parameters.AddWithValue("NIC", txtGNIC.Text);
                        cmd.Parameters.AddWithValue("FName", txtGFName.Text);
                        cmd.Parameters.AddWithValue("LName", txtGLName.Text);
                        cmd.Parameters.AddWithValue("BDay", dateTimePickerBDate.Text);
                        cmd.Parameters.AddWithValue("Pword", txtGPass.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtGNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from GDetails", con);
                            adapt.Fill(dt);
                            dataGridViewGNDE.DataSource = dt;



                        }
                        con.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Data not Updated", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information); if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update GDetails set GFName = @FName, GLName = @LName, GDOB= @BDay,GPass=@Pword where GNIC = @NIC", con);
                        cmd.Parameters.AddWithValue("NIC", txtGNIC.Text);
                        cmd.Parameters.AddWithValue("FName", txtGFName.Text);
                        cmd.Parameters.AddWithValue("LName", txtGLName.Text);
                        cmd.Parameters.AddWithValue("BDay", dateTimePickerBDate.Text);
                        cmd.Parameters.AddWithValue("Pword", txtGPass.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtGNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from GDetails", con);
                            adapt.Fill(dt);
                            dataGridViewGNDE.DataSource = dt;



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
        private bool ValidarCompas()
        {

            bool ok = true;
           if(txtGNIC.Text=="")
            {
                ok = false;
                errorProvider1.SetError(txtGNIC,"Can't Blank National Idintity Card Field");

            }
            if (txtGFName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGFName, "Can't Blank The First Name Field");
                MessageBox.Show("This First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtGLName.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGLName, "Can't Blank The Last Name Field");
                MessageBox.Show("This Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerBDate.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerBDate, "Can't Blank The Birth Date Field");
                MessageBox.Show("This Date Time Picker Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtGPass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGPass, "Can't Blank The Password Field");
                MessageBox.Show("This Password Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtGFName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtGFName, "This Field accept alperbatical character only");
                MessageBox.Show("This First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtGLName.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtGLName, "This Field accept alperbatical character only");
                MessageBox.Show("This Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGPass.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtGPass, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers.","New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                
            }

            return ok;


        }



        private void dateTimePickerBDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePickerBDate_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Back || e.KeyCode ==Keys.Delete || e.KeyCode==Keys.Escape)
            {
                dateTimePickerBDate.CustomFormat = "";



            }


        }
    }
}
