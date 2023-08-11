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
    public partial class Apeal_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string CNIC;
        string CFN;
        string CLN;
        string CRS;
        string CPN;
        string RY;
        string HLN;
        string VL;
        string GD;
        string DST;
        public Apeal_Details()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NIC = txtNIC.Text;
            string sqlselect = "select * from APD where CNIC='" + CNIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewAPDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
            adapt.Fill(dt);
            dataGridViewAPDE.DataSource = dt;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNIC.Text="";
            txtFN.Text="";
            txtLN.Text="";
            txtCR.Text="";
            txtPN.Text="";
            dateTimePickerAP.Text="";
            txtHL.Text="";
            txtVLL.Text="";

            txtGD.Text="";
            txtDis.Text="";
        }

        private void Apeal_Details_Load(object sender, EventArgs e)
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
                        CNIC = txtNIC.Text;
                        CFN = txtFN.Text;
                        CLN = txtLN.Text;
                        CRS = txtCR.Text;
                        CPN = txtPN.Text;
                        RY = dateTimePickerAP.Text;
                        HLN = txtHL.Text;
                        VL = txtVLL.Text;

                        GD = txtGD.Text;
                        DST = txtDis.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   APD values(@CNIC, @CFN, @CLN, @CRS, @CPN,@RY,@HLN,@VL,@GD,@DST)", con);
                        cmd.Parameters.AddWithValue("CNIC", CNIC);
                        cmd.Parameters.AddWithValue("CFN", CFN);
                        cmd.Parameters.AddWithValue("CLN", CLN);
                        cmd.Parameters.AddWithValue("CRS", CRS);
                        cmd.Parameters.AddWithValue("CPN", CPN);
                        cmd.Parameters.AddWithValue("RY", RY);
                        cmd.Parameters.AddWithValue("HLN", HLN);
                        cmd.Parameters.AddWithValue("VL", VL);
                        cmd.Parameters.AddWithValue("GD", GD);
                        cmd.Parameters.AddWithValue("DST", DST);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter CNIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


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

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete APD where CNIC='" + CNIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
                adapt.Fill(dt);
                dataGridViewAPDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update APD set CFN = @CFN, CLN = @CLN, CRS= @CRS,CPN=@CPN,RY=@RY,HLN=@HLN,VL=@VL,GD=@GD,DST=@DST where CNIC = @CNIC", con);
                        cmd.Parameters.AddWithValue("CNIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("CFN", txtFN.Text);
                        cmd.Parameters.AddWithValue("CLN", txtLN.Text);
                        cmd.Parameters.AddWithValue("CRS", txtCR.Text);
                        cmd.Parameters.AddWithValue("CPN", txtPN.Text);
                        cmd.Parameters.AddWithValue("RY", dateTimePickerAP.Text);
                        cmd.Parameters.AddWithValue("HLN", txtHL.Text);
                        cmd.Parameters.AddWithValue("VL", txtVLL.Text);
                        cmd.Parameters.AddWithValue("GD", txtGD.Text);
                        cmd.Parameters.AddWithValue("DST", txtDis.Text);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
                            adapt.Fill(dt);
                            dataGridViewAPDE.DataSource = dt;



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

        private void dataGridViewAPDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNIC = dataGridViewAPDE.CurrentRow.Cells[0].Value.ToString();
            CFN = dataGridViewAPDE.CurrentRow.Cells[1].Value.ToString();
            CLN = dataGridViewAPDE.CurrentRow.Cells[2].Value.ToString();
            CRS = dataGridViewAPDE.CurrentRow.Cells[3].Value.ToString();
            CPN = dataGridViewAPDE.CurrentRow.Cells[4].Value.ToString();
            RY = dataGridViewAPDE.CurrentRow.Cells[5].Value.ToString();

            HLN = dataGridViewAPDE.CurrentRow.Cells[6].Value.ToString();

            VL = dataGridViewAPDE.CurrentRow.Cells[7].Value.ToString();

            GD = dataGridViewAPDE.CurrentRow.Cells[8].Value.ToString();
            DST = dataGridViewAPDE.CurrentRow.Cells[9].Value.ToString();

            txtNIC.Text=CNIC;
            txtFN.Text=CFN;
            txtLN.Text=CLN;
            txtCR.Text=CRS;
            txtPN.Text=CPN;
            dateTimePickerAP.Text=RY;
            txtHL.Text=HLN;
            txtVLL.Text=VL;

            txtGD.Text=GD;
            txtDis.Text=DST;

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
                errorProvider1.SetError(txtFN, "Can't Blank The First Name Field");
                MessageBox.Show("This First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtLN, "Can't Blank The Last Name Field");
                MessageBox.Show("This Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtCR.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCR, "Can't Blank The Change Relationship Field");
                MessageBox.Show("This Change Relationship Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtPN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPN, "Can't Blank The Passport Number Field");
                MessageBox.Show("This Passport Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }


            if (dateTimePickerAP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerAP, "Can't Blank Register Year Field");
                MessageBox.Show("This Register Year Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtHL.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtHL, "Can't Blank The House Hold List No Field");
                MessageBox.Show("This House Hold List No Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtVLL.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVLL, "Can't Blank The Village Field");
                MessageBox.Show("This Village Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtGD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtGD, "Can't Blank The Gramaniladhari Divition Field");
                MessageBox.Show("This Gramaniladhari Divition Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtDis.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDis, "Can't Blank The District Field");
                MessageBox.Show("This District Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

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
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCR.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCR, "This Field accept alperbatical character only");
                MessageBox.Show("This Change Relationship text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPN.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtPN, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in passport number text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtHL.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtHL, "This Field accept numbers only");
                MessageBox.Show("This House hold list number text box accepts numbers only ", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtVLL.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtVLL, "This Field accept alperbatical character only");
                MessageBox.Show("This Village text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtGD.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtGD, "This Field accept alperbatical character only");
                MessageBox.Show("This Gramaniladhari Divition text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDis.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtDis, "This Field accept alperbatical character only");
                MessageBox.Show("This District text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }


            return ok;


        }





    }
}
