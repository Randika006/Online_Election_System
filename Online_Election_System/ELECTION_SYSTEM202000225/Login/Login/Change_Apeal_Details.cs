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
    public partial class Change_Apeal_Details : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;

        string NIC;
        //string ADE;
        string CFN;
        string CLN;
        string CRS;
        string PN;
        string RY;
        string HLNO;
        string VILL;
        string GD;
        string Dis;
        public Change_Apeal_Details()
        {
            InitializeComponent();
        }

        private void Change_Apeal_Details_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string NIC = txtCNIC.Text;
            if (NIC != "")
            {
                string sqldelete = "delete APD where CNIC='" + NIC + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
                adapt.Fill(dt);
                dataGridViewAde.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter NIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCNIC.Text = "";
            txtCFName.Text = "";
            txtCLName.Text = "";
            txtRlesh.Text = "";
            txtPassNo.Text = "";
            txtRYear.Text = "";
            txtVillage.Text = "";
            txtGND.Text = "";
            txtDistric.Text = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

           
            

            try
            {

                NIC = txtCNIC.Text;
              //  ADE = dateTimePickerADate.Text;
                CFN = txtCFName.Text;
                CLN = txtCLName.Text;
                CRS = txtRlesh.Text;
                PN = txtPassNo.Text;

                RY = txtRYear.Text;

                HLNO = txtlistno.Text;
                VILL = txtVillage.Text;
                GD = txtGND.Text;

                Dis = txtDistric.Text;

                con.Open();


                // cmd = new SqlCommand("Insert into   Adetails values(@CNIC,@ADate, @CFName, @CLName, @CRO,@PNo,@RYear,@HLN,@CVila,@GND,@Dist)", con);
                cmd = new SqlCommand("Insert into   Adetails values(@CNIC, @CFName)", con); // ", @CFName, @CLName, @CRO,@PNo,@RYear,@HLN,@CVila,@GND,@Dist)", con);
                cmd.Parameters.AddWithValue("CNIC", NIC);
              // cmd.Parameters.AddWithValue("ADate", ADE);
                cmd.Parameters.AddWithValue("CFName", CFN);
             /*   cmd.Parameters.AddWithValue("CLName", CLN);
                cmd.Parameters.AddWithValue("CRO", CRS);
                cmd.Parameters.AddWithValue("PNo", PN);
                cmd.Parameters.AddWithValue("RYear", RY);
                cmd.Parameters.AddWithValue("HLN", HLNO);
                cmd.Parameters.AddWithValue("CVila", VILL);
                cmd.Parameters.AddWithValue("GND", GD);
                cmd.Parameters.AddWithValue("Dist", Dis);*/

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Record Appended Successfully !");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                NIC = txtCNIC.Text;
               
                CFN = txtCFName.Text;
                CLN = txtCLName.Text;
                CRS = txtRlesh.Text;
                PN=txtPassNo.Text;
                RY=txtRYear.Text;
                HLNO=txtlistno.Text;
                VILL=txtVillage.Text;
                GD=txtVillage.Text;
                Dis=txtDistric.Text;
                con.Open();

                cmd = new SqlCommand("Insert into   APD values(@CNIC, @CFName,@CLName,@CRS,@PNo,@RYear,@HLINo,@VLL,@GND,@Dist)", con);
                cmd.Parameters.AddWithValue("CNIC", NIC);
                
                cmd.Parameters.AddWithValue("CFName", CFN);
                cmd.Parameters.AddWithValue("CLName", CLN);
                cmd.Parameters.AddWithValue("CRS", CRS);
                cmd.Parameters.AddWithValue("PNo", PN);
                cmd.Parameters.AddWithValue("RYear", RY);
                cmd.Parameters.AddWithValue("HLINO", HLNO);
                cmd.Parameters.AddWithValue("VLL", VILL);
                cmd.Parameters.AddWithValue("GND", GD);
                cmd.Parameters.AddWithValue("Dist", Dis);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Record Appended Successfully !");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViw_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
            adapt.Fill(dt);
            dataGridViewAde.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string NIC = txtCNIC.Text;
            string sqlselect = "select * from APD where CNIC='" + NIC + "'";
            if (NIC != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewAde.DataSource = dt;
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
                        cmd = new SqlCommand("update APD set CFName = @CFN, CLName = @CLN, CRS= @CRS,PNo=@PN,RYear=@RY,HLINo=@HLNO,VLL=@VILL,Dist=@Dis where CNIC = @NIC", con);
                        cmd.Parameters.AddWithValue("NIC", txtCNIC.Text);
                        cmd.Parameters.AddWithValue("CFN", txtCFName.Text);
                        cmd.Parameters.AddWithValue("CLN", txtCLName.Text);
                        cmd.Parameters.AddWithValue("CRS", txtRlesh.Text);
                        cmd.Parameters.AddWithValue("PN", txtPassNo.Text);
                        cmd.Parameters.AddWithValue("RY", txtRYear.Text);
                        cmd.Parameters.AddWithValue("HLNO", txtlistno.Text);
                        cmd.Parameters.AddWithValue("VILL", txtVillage.Text);
                        cmd.Parameters.AddWithValue("Dis", txtDistric.Text);
                       
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtCNIC.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from APD", con);
                            adapt.Fill(dt);
                            dataGridViewAde.DataSource = dt;



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

        private void dataGridViewAde_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NIC = dataGridViewAde.CurrentRow.Cells[0].Value.ToString();
            CFN = dataGridViewAde.CurrentRow.Cells[1].Value.ToString();
            CLN = dataGridViewAde.CurrentRow.Cells[2].Value.ToString();
            CRS = dataGridViewAde.CurrentRow.Cells[3].Value.ToString();
            PN = dataGridViewAde.CurrentRow.Cells[4].Value.ToString();
            RY = dataGridViewAde.CurrentRow.Cells[0].Value.ToString();
            HLNO = dataGridViewAde.CurrentRow.Cells[1].Value.ToString();
            VILL = dataGridViewAde.CurrentRow.Cells[2].Value.ToString();
            Dis = dataGridViewAde.CurrentRow.Cells[3].Value.ToString();
            

            txtCNIC.Text = NIC;
            txtCFName.Text = CFN;
            txtCLName.Text = CLN;
            txtRlesh.Text = CRS;
            txtPassNo.Text = PN;
            txtRYear.Text = RY;
            txtlistno.Text = HLNO;
            txtVillage.Text = VILL;
            txtDistric.Text = Dis;

            txtCNIC.ReadOnly = true;
        }
    }
}
