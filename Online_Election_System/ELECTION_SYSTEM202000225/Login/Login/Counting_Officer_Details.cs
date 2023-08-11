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
    public partial class Counting_Officer_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string CONIC;
        string COFN;
        string COLN;
        string CODB;
        string COTP;
        string COAD;
        public Counting_Officer_Details()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Counting_Officer_Details_Load(object sender, EventArgs e)
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
                    if (txtCNIC.Text != "")
                    {

                        CONIC = txtCNIC.Text;
                        COFN = txtCFN.Text;
                        COLN = txtCLN.Text;
                        CODB = dateTimePickerDB.Text;
                        COTP = txtTP.Text;
                        COAD = textBox6.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into  CounterDe values(@CONIC, @COFN, @COLN, @CODB, @COTP,@COAD)", con);
                        cmd.Parameters.AddWithValue("CONIC", CONIC);
                        cmd.Parameters.AddWithValue("COFN", COFN);
                        cmd.Parameters.AddWithValue("COLN", COLN);
                        cmd.Parameters.AddWithValue("CODB", CODB);
                        cmd.Parameters.AddWithValue("COTP", COTP);
                        cmd.Parameters.AddWithValue("COAD", COAD);
                        //  cmd.Parameters.AddWithValue("tp", tp);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter CONIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Reopen form and make mistake", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            txtCNIC.Text="";
            txtCFN.Text="";
            txtCLN.Text="";
            dateTimePickerDB.Text="";
            txtTP.Text="";
            textBox6.Text="";
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVW_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from  CounterDe", con);
            adapt.Fill(dt);
            dataGridViewCOFDE.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtCNIC.Text;
            string sqlselect = "select * from CounterDe where CONIC='" + CONIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewCOFDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CONIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtCNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete CounterDe  where CONIC='" + CONIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from  CounterDe", con);
                adapt.Fill(dt);
                dataGridViewCOFDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter CONIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update CounterDe set COFN = @COFN, COLN = @COLN, CODB= @CODB,COTP= @COTP,COAD= @COAD where CONIC = @CONIC", con);
                        cmd.Parameters.AddWithValue("CONIC", txtCNIC.Text);
                        cmd.Parameters.AddWithValue("COFN", txtCFN.Text);
                        cmd.Parameters.AddWithValue("COLN", txtCLN.Text);
                        cmd.Parameters.AddWithValue("CODB", dateTimePickerDB.Text);
                        cmd.Parameters.AddWithValue("COTP", txtTP.Text);
                        cmd.Parameters.AddWithValue("COAD", textBox6.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtCNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from  CounterDe ", con);
                            adapt.Fill(dt);
                            dataGridViewCOFDE.DataSource = dt;



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

        private void dataGridViewCOFDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CONIC = dataGridViewCOFDE.CurrentRow.Cells[0].Value.ToString();
            COFN = dataGridViewCOFDE.CurrentRow.Cells[1].Value.ToString();
            COLN = dataGridViewCOFDE.CurrentRow.Cells[2].Value.ToString();
            CODB = dataGridViewCOFDE.CurrentRow.Cells[3].Value.ToString();

            COTP = dataGridViewCOFDE.CurrentRow.Cells[4].Value.ToString();
            COAD = dataGridViewCOFDE.CurrentRow.Cells[5].Value.ToString();

            txtCNIC.Text = CONIC;
            txtCFN.Text = COFN;
            txtCLN.Text = COLN;
            dateTimePickerDB.Text = CODB;
            txtTP.Text = COTP;
            textBox6.Text = COAD;

            txtCNIC.ReadOnly = true;
        }

        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtCNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtCFN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCFN, "Can't Blank The Counting Officer First Name Field");
                MessageBox.Show("This Counting Officer First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtCLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCLN, "Can't Blank The Counting Officer  Last Name Field");
                MessageBox.Show("This Counting Officer  Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerDB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerDB, "Can't Blank The Counting Officer Birth Date Field");
                MessageBox.Show("This Counting Officer Birth DateText Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTP, "Can't Blank The Counting Officer Tele Phone Number Field");
                MessageBox.Show("This Counting Officer Tele Phone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (textBox6.Text == "")
            {
                ok = false;
                errorProvider1.SetError(textBox6, "Can't Blank The Counting Officer Address Field");
                MessageBox.Show("This Counting Officer Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCFN, "This Field accept alperbatical character only");
                MessageBox.Show("This Counting Officer First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCLN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCLN, "This Field accept alperbatical character only");
                MessageBox.Show("This Counting Officer Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(textBox6, "This Field accept alperbatical character only");
                MessageBox.Show("This Counting Officer Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }





    }
}
