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
    public partial class Wacher_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string WNIC;
        string WFN;
        string WLN;
        string WDB;
        string WTP;
        string WAD;
        public Wacher_Details()
        {
            InitializeComponent();
        }

        private void Wacher_Details_Load(object sender, EventArgs e)
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
                    if (txtWNIC.Text != "")
                    {



                        WNIC = txtWNIC.Text;

                        WFN = txtWFN.Text;
                        WLN = txtWLN.Text;  //That is a candidate last name text box identification
                        WDB = dateTimePickerWDB.Text;
                        WTP = txtWTP.Text;
                        WAD = txtWAD.Text;

                        con.Open();

                        cmd = new SqlCommand("Insert into   WDE values(@WNIC, @WFN,@WLN,@WDB,@WTP,@WAD)", con);
                        cmd.Parameters.AddWithValue("WNIC", WNIC);

                        cmd.Parameters.AddWithValue("WFN", WFN);
                        cmd.Parameters.AddWithValue("WLN", WLN);
                        cmd.Parameters.AddWithValue("WDB", WDB);
                        cmd.Parameters.AddWithValue("WTP", WTP);
                        cmd.Parameters.AddWithValue("WAD", WAD);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter WNIC", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


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
            txtWNIC.Text="";

            txtWFN.Text="";
            txtWLN.Text="";  //That is a candidate last name text box identification
            dateTimePickerWDB.Text="";
            txtWTP.Text="";
            txtWAD.Text="";
        }

        private void btnViw_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from WDE", con);
            adapt.Fill(dt);
            dataGridViewWDE.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtWNIC.Text;
            string sqlselect = "select * from WDE where WNIC='" + NIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewWDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string NIC = txtWNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete WDE where WNIC='" + NIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from WDE", con);
                adapt.Fill(dt);
                dataGridViewWDE.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter WNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update WDE set WFN = @WFN, WLN = @WLN, WDB= @WDB,WTP=@WTP,WAD=@WAD where WNIC = @WNIC", con);
                        cmd.Parameters.AddWithValue("WNIC", txtWNIC.Text);
                        cmd.Parameters.AddWithValue("WFN", txtWFN.Text);
                        cmd.Parameters.AddWithValue("WLN", txtWLN.Text);
                        cmd.Parameters.AddWithValue("WDB", dateTimePickerWDB.Text);
                        cmd.Parameters.AddWithValue("WTP", txtWTP.Text);
                        cmd.Parameters.AddWithValue("WAD", txtWAD.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtWNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from WDE", con);
                            adapt.Fill(dt);
                            dataGridViewWDE.DataSource = dt;



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

        private void dataGridViewWDE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            WNIC = dataGridViewWDE.CurrentRow.Cells[0].Value.ToString();
            WFN = dataGridViewWDE.CurrentRow.Cells[1].Value.ToString();
            WLN = dataGridViewWDE.CurrentRow.Cells[2].Value.ToString();
            WDB = dataGridViewWDE.CurrentRow.Cells[3].Value.ToString();
            WTP = dataGridViewWDE.CurrentRow.Cells[4].Value.ToString();
            WAD = dataGridViewWDE.CurrentRow.Cells[5].Value.ToString();

            txtWNIC.Text = WNIC;
            txtWFN.Text = WFN;
            txtWLN.Text = WLN;
            dateTimePickerWDB.Text = WDB;
            txtWTP.Text = WTP;
            txtWAD.Text = WAD;


            txtWNIC.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtWNIC.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtWNIC, "Can't Blank National Idintity Card Field");

            }
            if (txtWFN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtWFN, "Can't Blank The Watcher First Name Field");
                MessageBox.Show("This Watcher First Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtWLN.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtWLN, "Can't Blank The Watcher Last Name Field");
                MessageBox.Show("This Wacher Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (dateTimePickerWDB.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dateTimePickerWDB, "Can't Blank Watcher Date Of Birth Field");
                MessageBox.Show("This Watcher Date Of Birth Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (txtWTP.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtWTP, "Can't Blank The Telephone number Field");
                MessageBox.Show("This Watcher Telephone Number Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtWAD.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtWAD, "Can't Blank The Watcher Address Field");
                MessageBox.Show("This Watcher Address Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtWFN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtWFN, "This Field accept alperbatical character only");
                MessageBox.Show("This Watcher First Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtWLN.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtWLN, "This Field accept alperbatical character only");
                MessageBox.Show("This Watcher Last Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
           /* if (System.Text.RegularExpressions.Regex.IsMatch(txtWTP.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtWTP, "Please enter only numbers.");
                MessageBox.Show("Please enter watcher telephone numbers in telephone number text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }*/
           if (!System.Text.RegularExpressions.Regex.IsMatch(txtWAD.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtWAD, "This Field accept alperbatical character only");
                MessageBox.Show("This Watcher Address text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
           
          return ok;


        }





    }
}
