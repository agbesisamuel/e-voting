using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace GEVS
{
    public partial class VotingPresident : Form
    {
        //MemoryStream ms;
        byte[] photo_aray;
        public VotingPresident()
        {
            InitializeComponent();
        }

        //Load 
        private void LoadCandidate()
        {
            try
            {
                string mySelectQuery = "Select PCandPhoto,PCandName, PCandNum, PartyLogo from PresidentialTB";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "PresidentialTB");
                DataTable dt = ds.Tables["PresidentialTB"];
                myConnection.Close();

                int cnt = 1;
                foreach (DataRow dr in ds.Tables[0].Rows)
                {

                    if (cnt == 1) {
                        //cboConstCode.Items.Add(dr["ConstCode"].ToString());
                        
                        picPhoto1.Image = null;
                        picLogo1.Image = null;

                        if (dr["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picLogo1.Image = Image.FromStream(ms);
                        }

                        if (dr["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPhoto1.Image = Image.FromStream(ms);
                        }

                        label1.Text= dr["PCandNum"].ToString();
                        optCand1.Text = dr["PCandName"].ToString();
                    }
                    else if (cnt == 2)
                    {
                        picPhoto2.Image = null;
                        picLogo2.Image = null;

                        if (dr["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picLogo2.Image = Image.FromStream(ms);
                        }
                        if (dr["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPhoto2.Image = Image.FromStream(ms);
                        }
                        label2.Text = dr["PCandNum"].ToString();
                        optCand2.Text = dr["PCandName"].ToString();
                    }
                    else if (cnt == 3)
                    {
                        picPhoto3.Image = null;
                        picLogo3.Image = null;

                        if (dr["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picLogo3.Image = Image.FromStream(ms);
                        }
                        if (dr["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPhoto3.Image = Image.FromStream(ms);
                        }
                        label3.Text = dr["PCandNum"].ToString();
                        optCand3.Text = dr["PCandName"].ToString();
                    }
                    else if (cnt == 4)
                    {
                        picPhoto4.Image = null;
                        picLogo4.Image = null;

                        if (dr["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picLogo4.Image = Image.FromStream(ms);
                        }
                        if (dr["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPhoto4.Image = Image.FromStream(ms);
                        }
                        label4.Text = dr["PCandNum"].ToString();
                        optCand4.Text = dr["PCandName"].ToString();
                    }
                    else if (cnt == 5)
                    {
                        picPhoto5.Image = null;
                        picLogo5.Image = null;

                        if (dr["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picLogo5.Image = Image.FromStream(ms);
                        }
                        if (dr["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])dr["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPhoto5.Image = Image.FromStream(ms);
                        }
                        label5.Text = dr["PCandNum"].ToString();
                        optCand5.Text = dr["PCandName"].ToString();
                    }
                    cnt = cnt + 1;
                }


                //System.Windows.Forms.Button btn;
                //btn[10] = new Button();
                //btn[0].Left = 10;
                //btn[0].TOp = 10;
                //btn[0].Visible = true;
                //btn[0].Text = "";
                if (optCand1.Text == "Candidate 1")
                {
                    optCand1.Enabled = false;
                    optCand2.Enabled = false;
                    optCand3.Enabled = false;
                    optCand4.Enabled = false;
                    optCand5.Enabled = false;

                }
                else if (optCand2.Text == "Candidate 2")
                {
                    optCand2.Enabled = false;
                    optCand3.Enabled = false;
                    optCand4.Enabled = false;
                    optCand5.Enabled = false;

                }
                else if (optCand3.Text == "Candidate 3")
                {
                    
                    
                    optCand3.Enabled = false;
                    optCand4.Enabled = false;
                    optCand5.Enabled = false;

                }
                else if (optCand4.Text == "Candidate 4")
                {
                    
                    optCand4.Enabled = false;
                    optCand5.Enabled = false;

                }
                else if (optCand5.Text == "Candidate 5")
                {
                    optCand5.Enabled = false;

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void VotingPresident_Load(object sender, EventArgs e)
        {
            try
            {
                //Clear similar entries base on voter id
                string mySelect = "Delete from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";
                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                SqlCommand myCommand = new SqlCommand(mySelect, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();


                this.StartPosition = FormStartPosition.CenterScreen;
                LoadCandidate();
                labelhead.Text = "Select your preferred presidential candidate  " + Globals.strVoterName;
                
               
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (optCand1.Checked==true){
                
               
                    if (DialogResult.Yes == MessageBox.Show("You have selected " + optCand1.Text + " as President?", "Voting Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        //Insert selection into temp tabel
                        string mySelectQuery = "Insert into TempVoting" +
                                        "(VoterID,CodeNumber,PCandName,PCandNum) " +
                                        " Values ('" + Globals.strgblVoterID + "','" + Globals.strgblCodeNumber + "','" + optCand1.Text + "'," +
                                        "'" + label1.Text + "')";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                                                
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();


                        Close();

                        //Call Parliamentary voting screen
                        VotingParliament VotPa = new VotingParliament();
                        VotPa.Show();
                    }
                    else { 
                        return;
                    }
                 }
                else if (optCand2.Checked == true)
                {
                    if (DialogResult.Yes == MessageBox.Show("You have selected " + optCand2.Text + " as President?", "Voting Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        //Insert selection into temp tabel
                        string mySelectQuery = "Insert into TempVoting" +
                                        "(VoterID,CodeNumber,PCandName,PCandNum) " +
                                        " Values ('" + Globals.strgblVoterID + "','" + Globals.strgblCodeNumber + "','" + optCand2.Text + "'," +
                                        "'" + label2.Text + "')";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        //Call Parliamentary voting screen
                        Close();
                        VotingParliament VotPa = new VotingParliament();
                        VotPa.Show();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (optCand3.Checked == true)
                {
                    if (DialogResult.Yes == MessageBox.Show("You have selected " + optCand3.Text + " as President?", "Voting Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //Insert selection into temp tabel
                        string mySelectQuery = "Insert into TempVoting" +
                                       "(VoterID,CodeNumber,PCandName,PCandNum) " +
                                       " Values ('" + Globals.strgblVoterID + "','" + Globals.strgblCodeNumber + "','" + optCand3.Text + "'," +
                                       "'" + label3.Text + "')";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        //Call Parliamentary voting screen
                        Close();
                        VotingParliament VotPa = new VotingParliament();
                        VotPa.Show();
                    }
                    else
                    {
                        return;
                    }
                }

                else if (optCand4.Checked == true)
                {
                    if (DialogResult.Yes == MessageBox.Show("You have selected " + optCand4.Text + " as President?", "Voting Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //Insert selection into temp tabel
                        string mySelectQuery = "Insert into TempVoting" +
                                        "(VoterID,CodeNumber,PCandName,PCandNum) " +
                                        " Values ('" + Globals.strgblVoterID + "','" + Globals.strgblCodeNumber + "','" + optCand4.Text + "'," +
                                        "'" + label4.Text + "')";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        //Call Parliamentary voting screen
                        Close();
                        VotingParliament VotPa = new VotingParliament();
                        VotPa.Show();
                    }
                    else
                    {
                        return;
                    }
                }

                else if (optCand5.Checked == true)
                {
                    if (DialogResult.Yes == MessageBox.Show("You have selected " + optCand5.Text + " as President?", "Voting Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        //Insert selection into temp table
                        string mySelectQuery = "Insert into TempVoting" +
                                       "(VoterID,CodeNumber,PCandName,PCandNum) " +
                                       " Values ('" + Globals.strgblVoterID + "','" + Globals.strgblCodeNumber + "','" + optCand5.Text + "'," +
                                       "'" + label5.Text + "')";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        //Call Parliamentary voting screen
                        Close();
                        VotingParliament VotPa = new VotingParliament();
                        VotPa.Show();
                    }
                    else
                    {
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Select a candidate");
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        //Trigger option buttons when candidate name or picture is clicked
        private void picPhoto1_Click(object sender, EventArgs e)
        {
            try
            {
                optCand1.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picLogo1_Click(object sender, EventArgs e)
        {
            try
            {
                optCand1.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picPhoto2_Click(object sender, EventArgs e)
        {
            try
            {
                optCand2.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picLogo2_Click(object sender, EventArgs e)
        {
            try
            {
                optCand2.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picPhoto3_Click(object sender, EventArgs e)
        {
            try
            {
                optCand3.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picLogo3_Click(object sender, EventArgs e)
        {
            try
            {
                optCand3.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picPhoto4_Click(object sender, EventArgs e)
        {
            try
            {
                optCand4.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picLogo4_Click(object sender, EventArgs e)
        {
            try
            {
                optCand4.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picPhoto5_Click(object sender, EventArgs e)
        {
            try
            {
                optCand5.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void picLogo5_Click(object sender, EventArgs e)
        {
            try
            {
                optCand5.Checked = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
