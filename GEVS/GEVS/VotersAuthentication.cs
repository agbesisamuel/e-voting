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
    public partial class VotersAuthentication : Form
    {
        public VotersAuthentication()
        {
            InitializeComponent();
        }

        private void picClose_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Sure to close?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    //Close();
                    Application.Exit();
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtVoterID.Text == "" || txtCodeNumber.Text == "")
                {
                    MessageBox.Show("Voter ID or Code Number can't be empty", "Searching", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVoterID.Focus();
                }
                else
                {
                    //check if id exit in voter register
                    string mySelectQuery = "Select * from VoterRegisterTB where VoterID = '" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "VoterRegisterTB");
                    DataTable dt = ds.Tables["VoterRegisterTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Voter ID not foound in Voter Register", "Search Ressults", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodeNumber.Clear();
                        txtVoterID.Focus();
                    }
                    else
                    {
                        Globals.strVoterName = ds.Tables[0].Rows[0]["FName"].ToString() + " " + ds.Tables[0].Rows[0]["LName"].ToString();
                        Globals.strPollCode = ds.Tables[0].Rows[0]["PollCode"].ToString();
                        txtCodeNumber.Enabled = false;
                        //check if login is valid with code generator table
                        string mySelect = "Select * from CodeGeneratorTB where VoterID = '" + txtVoterID.Text + "' and CodeNumber = '" + txtCodeNumber.Text + "'";

                        SqlConnection myConnection1 = new SqlConnection(Globals.connectionString);
                        myConnection1.Close();
                        myConnection1.Open();
                        SqlDataAdapter da1 = new SqlDataAdapter(mySelect, myConnection1);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "CodeGeneratorTB");
                        DataTable dt1 = ds1.Tables["CodeGeneratorTB"];
                        if (dt1.Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid login credential", "Search Ressults", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodeNumber.Clear();
                            txtVoterID.Focus();
                          
                        }
                        else if (ds1.Tables[0].Rows[0]["Status"].ToString() =="LOCKED") 
                        
                        {
                            MessageBox.Show("Login credentials is being used", "Search Ressults", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodeNumber.Clear();
                            txtVoterID.Focus();
                        }
                        else if (ds1.Tables[0].Rows[0]["Status"].ToString() == "USED")
                        {
                            MessageBox.Show("Login credentials has been used already", "Search Ressults", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodeNumber.Clear();

                            txtVoterID.Focus();
                        }
                        else { 

                            // update code to LOCKED
                            Globals.strgblVoterID = txtVoterID.Text;
                            Globals.strgblCodeNumber = txtCodeNumber.Text;
                            string strStat="LOCKED";
                            string mySelect2 = "Update CodeGeneratorTB" +

                                " SET Status='" + strStat + "'" +
                                " where CodeNumber ='" + txtCodeNumber.Text + "'";

                            SqlConnection myConnection2 = new SqlConnection(Globals.connectionString);
                            SqlCommand myCommand2 = new SqlCommand(mySelect2, myConnection2);
                            myConnection2.Open();
                            myCommand2.ExecuteNonQuery();
                            myConnection2.Close();
                            txtCodeNumber.Enabled = true;
                            //Call Presidential voting screen
                            Close();
                            VotingPresident VotP = new VotingPresident();
                            VotP.Show();
                            



                            

                        }
                      

                    }
                    txtCodeNumber.Enabled = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }

        private void VotersAuthentication_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        
    }
}
