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
    public partial class voter : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string VNIC;
        string VFN;
        string VLN;
        string VDB;
        string VILL;
        string GND;
        string DIS;
        public voter()
        {
            InitializeComponent();
        }

        private void voter_Load(object sender, EventArgs e)
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
                        VNIC = txtNIC.Text;
                        VFN = txtFN.Text;
                        VLN = txtLN.Text;
                        VDB = dateTimePickerDB.Text;
                        VILL = txtVL.Text;
                        GND = txtGD.Text;
                        DIS = txtDI.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   VData values(@VNIC, @VFN, @VLN, @VDB, @VILL,@GND,@DIS)", con);
                        cmd.Parameters.AddWithValue("VNIC", VNIC);
                        cmd.Parameters.AddWithValue("VFN", VFN);
                        cmd.Parameters.AddWithValue("VLN", VLN);
                        cmd.Parameters.AddWithValue("VDB", VDB);
                        cmd.Parameters.AddWithValue("VILL", VILL);
                        cmd.Parameters.AddWithValue("GND", GND);
                        cmd.Parameters.AddWithValue("DIS", DIS);

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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from VData", con);
            adapt.Fill(dt);
            dataGridViewVD.DataSource = dt;
            con.Close();




        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to update the selected row ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString() == "Yes")
                {
                    if (dr.ToString() == "Yes")
                    {
                        con.Open();
                        cmd = new SqlCommand("update VData set VFN = @VFN, VLN = @VLN, VDB= @VDB,VILL = @VILL,GND =@GND,DIS = @DIS where VNIC = @VNIC", con);
                        cmd.Parameters.AddWithValue("VNIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("VFN", txtFN.Text);
                        cmd.Parameters.AddWithValue("VLN", txtLN.Text);
                        cmd.Parameters.AddWithValue("VDB", dateTimePickerDB.Text);
                        cmd.Parameters.AddWithValue("VILL", txtVL.Text);
                        cmd.Parameters.AddWithValue("GND",txtGD.Text);
                        cmd.Parameters.AddWithValue("DIS",txtDI.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from GDetails", con);
                            adapt.Fill(dt);
                            dataGridViewVD.DataSource = dt;



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

        private void dataGridViewVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VNIC = dataGridViewVD.CurrentRow.Cells[0].Value.ToString();
            VFN = dataGridViewVD.CurrentRow.Cells[1].Value.ToString();
            VLN = dataGridViewVD.CurrentRow.Cells[2].Value.ToString();
            VDB = dataGridViewVD.CurrentRow.Cells[3].Value.ToString();
            VILL = dataGridViewVD.CurrentRow.Cells[4].Value.ToString();
            GND = dataGridViewVD.CurrentRow.Cells[5].Value.ToString();
            DIS = dataGridViewVD.CurrentRow.Cells[6].Value.ToString();

            txtNIC.Text = VNIC;
            txtFN.Text = VFN;
            txtLN.Text = VLN;
            dateTimePickerDB.Text = VDB;
            txtVL.Text = VILL;
            txtGD.Text = GND;
            txtDI.Text = DIS;

            txtNIC.ReadOnly = false;










        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string VNIC = txtNIC.Text;
            if (VNIC != "")
            {
                string sqldelete = "delete VData where VNIC='" + VNIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from VData", con);
                adapt.Fill(dt);
                dataGridViewVD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter VNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







            
        }

        private void btnser_Click(object sender, EventArgs e)
        {
            string VNIC = txtNIC.Text;
            string sqlselect = "select * from VData where VNIC='" + VNIC + "'";
            if (VNIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewVD.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter VNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnCle_Click(object sender, EventArgs e)
        {

            txtNIC.Text ="";
            txtFN.Text = "";
            txtLN.Text = "";
            dateTimePickerDB.Text = "";
            txtVL.Text = "";
            txtGD.Text = "";
            txtDI.Text = "";





        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
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
                errorProvider1.SetError(txtFN, "Can't Blank The First Name Field");
                MessageBox.Show("This First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtLN, "Can't Blank The Last Name Field");
                MessageBox.Show("This Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDB, "Can't Blank The Birth Date Field");
                MessageBox.Show("This Date Time Picker Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtVL.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVL, "Can't Blank The Password Field");
                MessageBox.Show("Village Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtGD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGD, "Can't Blank The Password Field");
                MessageBox.Show("Gramaniladhari Divition Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtDI.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDI, "Can't Blank The Password Field");
                MessageBox.Show("District Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }

           if (!System.Text.RegularExpressions.Regex.IsMatch(txtFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtFN, "This Field accept alperbatical character only");
                MessageBox.Show("This First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtLN, "This Field accept alperbatical character only");
                MessageBox.Show("This Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtVL.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtVL, "This Field accept alperbatical character only");
                MessageBox.Show("This Village Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtGD.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtGD, "This Field accept alperbatical character only");
                MessageBox.Show("This Gramaniladhari Divition text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDI.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtDI, "This Field accept alperbatical character only");
                MessageBox.Show("This District text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }




    }
}
