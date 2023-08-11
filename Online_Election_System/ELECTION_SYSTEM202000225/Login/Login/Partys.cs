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
    public partial class Partys : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string PTY;
        string SYM;
        string COL;
        
        public Partys()
        {
            InitializeComponent();
        }

        private void Partys_Load(object sender, EventArgs e)
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
                    if (txtPty.Text != "")
                    {
                        PTY = txtPty.Text;
                        SYM = txtSym.Text;
                        COL = txtCol.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   PPTY values(@PTY, @SYM, @COL)", con);
                        cmd.Parameters.AddWithValue("PTY", PTY);
                        cmd.Parameters.AddWithValue("SYM", SYM);
                        cmd.Parameters.AddWithValue("COL", COL);


                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Record Appended Successfully !", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Party", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

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
            SqlDataAdapter adapt = new SqlDataAdapter("select * from  PPTY", con);
            adapt.Fill(dt);
            dataGridViewPS.DataSource = dt;
            con.Close();



        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            string PTY = txtPty.Text;
            string sqlselect = "select * from  PPTY where PTY='" + PTY + "'";
            if (PTY != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewPS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Party to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            string PTY = txtPty.Text;
            if (PTY != "")
            {
                string sqldelete = "delete PPTY where PTY='" + PTY + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from  PPTY", con);
                adapt.Fill(dt);
                dataGridViewPS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter DNIC to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {

            txtPty.Text="";
            txtSym.Text="";
            txtCol.Text="";




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
                        cmd = new SqlCommand("update PPTY set SYM = @SYM, COL= @COL where PTY = @PTY", con);
                        cmd.Parameters.AddWithValue("PTY", txtPty.Text);
                        cmd.Parameters.AddWithValue("SYM", txtSym.Text);
                        cmd.Parameters.AddWithValue("COL", txtCol.Text);
                      
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtPty.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from PPTY", con);
                            adapt.Fill(dt);
                            dataGridViewPS.DataSource = dt;



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

        private void dataGridViewPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            PTY = dataGridViewPS.CurrentRow.Cells[0].Value.ToString();
            SYM = dataGridViewPS.CurrentRow.Cells[1].Value.ToString();
            COL = dataGridViewPS.CurrentRow.Cells[2].Value.ToString();
           

            txtPty.Text = PTY;
            txtSym.Text = SYM;
            txtCol.Text = COL;
            
            txtPty.ReadOnly = true;








        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtPty.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPty, "Can't Party Name Field");

            }
            if (txtSym.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtSym, "Can't Blank Party Symbol  Name Field");
                MessageBox.Show("This Party Symbol Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtCol.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCol, "Can't Blank The Commisioner Last Name Field");
                MessageBox.Show("This Commisioner Last Name Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPty.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtPty, "This Field accept alperbatical character only");
                MessageBox.Show("This Party Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSym.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtSym, "This Field accept alperbatical character only");
                MessageBox.Show("This Symbol Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCol.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtCol, "This Field accept alperbatical character only");
                MessageBox.Show("This Color Name text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            return ok;


        }





    }
}
