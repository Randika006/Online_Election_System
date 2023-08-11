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
    public partial class Regional_List_Seat : Form
    {
        public SqlCommand cmd;
        public SqlConnection con;
        string PTY;
        string SEAT;
        string VVOTE;
        string QUTA;
        string VDQ;
        string FCAL;
        string REM;
        string FALL;
        public Regional_List_Seat()
        {
            InitializeComponent();
        }

        private void Regional_List_Seat_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(local);Initial Catalog=VotesSystem;Integrated Security=True";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
           // double Z = 1;
            double SEAT = Convert.ToDouble(txtSET.Text);
            double VVOTE = Convert.ToDouble(txtVVote.Text);
            double QUTA = Convert.ToDouble(VVOTE/(SEAT+1)*1.0+1);
            double VDQ = Convert.ToDouble(VVOTE / QUTA * 1.0);
            double FCAL = VDQ;
            double REM = (VDQ - FCAL);
            double FALL = (FCAL + REM);
            textBox1.Text = QUTA.ToString();
            txtVDQ.Text = VDQ.ToString();
            txtFCAL.Text = FCAL.ToString();
            txtRD.Text = REM.ToString();
            txtFA.Text = FALL.ToString();
         //   textBox4.Text = VPP.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (ValidarCompas())
            {
                try
                {
                    if (txtParty.Text != "")
                    {

                        PTY = txtParty.Text;
                        SEAT = txtSET.Text;
                        VVOTE = txtVVote.Text;
                        QUTA = textBox1.Text;
                        VDQ = txtVDQ.Text;
                        FCAL = txtFCAL.Text;
                        REM = txtRD.Text;

                        FALL = txtFA.Text;


                        con.Open();

                        cmd = new SqlCommand("Insert into   RLSE values(@PTY, @SEAT, @VVOTE, @QUTA,@VDQ,@FCAL,@REM,@FALL)", con);
                        cmd.Parameters.AddWithValue("PTY", PTY);
                        cmd.Parameters.AddWithValue("SEAT", SEAT);
                        cmd.Parameters.AddWithValue("VVOTE", VVOTE);
                        cmd.Parameters.AddWithValue("QUTA", QUTA);
                        cmd.Parameters.AddWithValue("VDQ", VDQ);
                        cmd.Parameters.AddWithValue("FCAL", FCAL);
                        cmd.Parameters.AddWithValue("REM", REM);
                        cmd.Parameters.AddWithValue("FALL", FALL);
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
            txtParty.Text="";
            txtSET.Text="";
            txtVVote.Text="";
            textBox1.Text="";
            txtVDQ.Text="";
            txtFCAL.Text="";
            txtRD.Text="";

            txtFA.Text="";

        }

        private void btnVW_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from RLSE", con);
            adapt.Fill(dt);
            dataGridViewRLS.DataSource = dt;
            con.Close();
        }

        private void btnSear_Click(object sender, EventArgs e)
        {
            string PTY = txtParty.Text;
            string sqlselect = "select * from RLSE where PTY='" + PTY + "'";
            if (PTY != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(sqlselect, con);
                adapt.Fill(dt);
                dataGridViewRLS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter PTY to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string PTY = txtParty.Text;
            if (PTY != "")
            {
                string sqldelete = "delete RLSE where PTY='" + PTY + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "New Message",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from RLSE", con);
                adapt.Fill(dt);
                dataGridViewRLS.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter PTY to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        cmd = new SqlCommand("update RLSE set SEAT= @SEAT,VVOTE=@VVOTE,QUTA=@QUTA,VDQ=@VDQ,FCAL=@FCAL,REM=@REM,FALL=@FALL where PTY = @PTY", con);
                        cmd.Parameters.AddWithValue("PTY", txtParty.Text);
                        cmd.Parameters.AddWithValue("SEAT", txtSET.Text);
                        cmd.Parameters.AddWithValue("VVOTE", txtVVote.Text);
                        cmd.Parameters.AddWithValue("QUTA", textBox1.Text);
                        cmd.Parameters.AddWithValue("VDQ", txtVDQ.Text);
                        cmd.Parameters.AddWithValue("FCAL", txtFCAL.Text);
                        cmd.Parameters.AddWithValue("REM", txtRD.Text);
                        cmd.Parameters.AddWithValue("FALL", txtFA.Text);

                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        int chkupdate = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        txtParty.ReadOnly = true;
                        if (chkupdate == 1)
                        {
                            MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataTable dt = new DataTable();
                            SqlDataAdapter adapt = new SqlDataAdapter("select * from RLSE", con);
                            adapt.Fill(dt);
                            dataGridViewRLS.DataSource = dt;



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

        private void dataGridViewRLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PTY = dataGridViewRLS.CurrentRow.Cells[0].Value.ToString();
            SEAT = dataGridViewRLS.CurrentRow.Cells[1].Value.ToString();
            VVOTE= dataGridViewRLS.CurrentRow.Cells[2].Value.ToString();
            QUTA= dataGridViewRLS.CurrentRow.Cells[3].Value.ToString();
            VDQ = dataGridViewRLS.CurrentRow.Cells[4].Value.ToString();
            FCAL = dataGridViewRLS.CurrentRow.Cells[5].Value.ToString();

            REM = dataGridViewRLS.CurrentRow.Cells[6].Value.ToString();
            FALL = dataGridViewRLS.CurrentRow.Cells[7].Value.ToString();

            txtParty.Text = PTY;
            txtSET.Text = SEAT;
            txtVVote.Text = VVOTE;
            textBox1.Text = QUTA;
            txtVDQ.Text = VDQ;
            txtFCAL.Text = FCAL;
            txtRD.Text = REM;
            txtFA.Text = FALL;

            txtParty.ReadOnly = true;
        }
        private bool ValidarCompas()
        {

            bool ok = true;
            if (txtParty.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtParty, "Can't Blank Party Name Field");

            }
            if (txtSET.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtSET, "Can't Blank The Number Of Seat Field");
                MessageBox.Show("This Number Of Seat Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (txtVVote.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtVVote, "Can't Blank The Valide Vote Field");
                MessageBox.Show("This Valide Vote Text Box Can't empty", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtParty.Text, "^[a-zA-Z ]"))
            {
                ok = false;
                errorProvider1.SetError(txtParty, "This Field accept alperbatical character only");
                MessageBox.Show("This Political Party text box accepts only alphabetical characters", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSET.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtSET, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Number Of Seat text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVVote.Text, "[^0-9]"))
            {
                ok = false;
                errorProvider1.SetError(txtVVote, "Please enter only numbers.");
                MessageBox.Show("Please enter only numbers in Valied Votes text box.", "New Message", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            }
            return ok;


        }






    }
}
