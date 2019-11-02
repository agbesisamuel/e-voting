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
    public partial class SummaryOfVotes : Form
    {
        public SummaryOfVotes()
        {
            InitializeComponent();
        }

        private void SummaryOfVotes_Load(object sender, EventArgs e)
        {
            try
            {

                string mySelectQuery = "Select PCandNum, PCandName from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "TempVoting");
                DataTable dt = ds.Tables["TempVoting"];
                myConnection.Close();

                if (lstSummaryVotes.Items.Count > 0)
                {
                    lstSummaryVotes.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstSummaryVotes.Items.Add(dr["PCandNum"].ToString());
                    lstSummaryVotes.Items[lstSummaryVotes.Items.Count - 1].SubItems.Add(dr["PCandName"].ToString());

                }
                //if (lstSummaryVotes.Items.Count > 0)
                //{
                //    lstSummaryVotes.TopItem.Selected = true;
                //}

                string mySelectQuery1 = "Select CandNum, CandName from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";

                SqlConnection myConnection1 = new SqlConnection(Globals.connectionString);
                myConnection1.Close();
                myConnection1.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(mySelectQuery1, myConnection1);
                DataSet ds1= new DataSet();


                da1.Fill(ds1, "TempVoting");
                DataTable dt1 = ds1.Tables["TempVoting"];
                myConnection1.Close();

              

                foreach (DataRow dr1 in ds1.Tables[0].Rows)
                {
                    lstParlView.Items.Add(dr1["CandNum"].ToString());
                    lstParlView.Items[lstParlView.Items.Count - 1].SubItems.Add(dr1["CandName"].ToString());

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            try
            {
                if (DialogResult.Yes == MessageBox.Show("Sure to cancel selected candidates?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string mySelect = "Delete from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";
                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelect, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    Close();
                    //Call Presidential voting screen
              
                    VotingPresident VotP = new VotingPresident();
                    VotP.Show();

                }

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
                if (DialogResult.Yes == MessageBox.Show("Sure to Submit the selected candidates?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string myCodeNo, myPresCandNum, myPalCandNum, myTID;

                    //Load current TID in number table

                    string mySelect2 = "Select * from Numbers";

                    SqlConnection myConnect2 = new SqlConnection(Globals.connectionString);
                    myConnect2.Close();
                    myConnect2.Open();
                    SqlDataAdapter da2 = new SqlDataAdapter(mySelect2, myConnect2);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "Numbers");
                    DataTable dt2 = ds2.Tables["Numbers"];
                    myConnect2.Close();

                    String strTID = ds2.Tables[0].Rows[0]["TID"].ToString();
                    int intTID;
                    intTID =Convert.ToInt16(strTID);
                    intTID = intTID + 1;
                    Globals.strTID =Globals.strPollCode + "-" + intTID.ToString();

                    //Update number table
                    string mySelectQuery1 = "Update Numbers" +

                            " SET TID='" + intTID + "'";

                    SqlConnection myConnection1 = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand1= new SqlCommand(mySelectQuery1, myConnection1);
                    myConnection1.Open();
                    myCommand1.ExecuteNonQuery();
                    myConnection1.Close();

                    //
                    
                    //Update temp voting table with TID
                  
                    string mySelectQuery3 = "Update TempVoting" +

                            " SET TID='" + Globals.strTID + "'" +
                            " where VoterID ='" + Globals.strgblVoterID + "'";

                    SqlConnection myConnection3 = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand3 = new SqlCommand(mySelectQuery3, myConnection3);
                    myConnection3.Open();
                    myCommand3.ExecuteNonQuery();
                    myConnection3.Close();
                    //
                    
                    //Select from tempvoting table
                    string mySelect = "Select * from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";

                    SqlConnection myConnect = new SqlConnection(Globals.connectionString);
                    myConnect.Close();
                    myConnect.Open();
                    SqlDataAdapter da1 = new SqlDataAdapter(mySelect, myConnect);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "TempVoting");
                    DataTable dt1 = ds1.Tables["TempVoting"];
                    myConnect.Close();

                    myCodeNo=ds1.Tables[0].Rows[0]["CodeNumber"].ToString();
                    myPresCandNum = ds1.Tables[0].Rows[0]["PCandNum"].ToString();
                    myPalCandNum= ds1.Tables[0].Rows[0]["CandNum"].ToString();
                    myTID = ds1.Tables[0].Rows[0]["TID"].ToString();

                    //Insert into Presidential votes table

                    //string mySelectQuery = "Insert into PresidentVoteCast_t" +
                    //                   "(CodeNo,PollCode,CandNum,TID,Transdate) " +
                    //                   " Values ('" + myCodeNo + "','" + Globals.strPollCode + "','" + myPresCandNum + "','" + myTID + "'," +
                    //                   "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";

                    string mySelectQuery = "Insert into PresidentVoteCast_t" +
                                        "(PollCode,CandNum,TID,Transdate) " +
                                        " Values ('" + Globals.strPollCode + "','" + myPresCandNum + "','" + myTID + "'," +
                                        "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    //Insert into parliamentary votes table

                    //mySelectQuery = "Insert into ParliementaryVoteCast_t" +
                    //                   "(CodeNo,PollCode,CandNum,TID,Transdate) " +
                    //                   " Values ('" + myCodeNo + "','" + Globals.strPollCode + "','" + myPalCandNum + "','" + myTID + "'," +
                    //                   "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";


                    mySelectQuery = "Insert into ParliementaryVoteCast_t" +
                                        "(PollCode,CandNum,TID,Transdate) " +
                                        " Values ('" + Globals.strPollCode + "','" + myPalCandNum + "','" + myTID +"'," +
                                        "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";

                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    //Close();
                    int cnt = 1;
                    //Increase presidential candidate vote by 1
                    mySelectQuery = "Update PresidentialTB" +

                               " SET VoteCount= VoteCount + " + cnt + "" +
                               " where PCandNum ='" + myPresCandNum + "'";

                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                   
                    //Increase Parliamentary candidate votes by 1
                    mySelectQuery = "Update ParliamentaryTB" +

                            " SET VoteCount= VoteCount + " + cnt + "" +
                            " where CandNum ='" + myPalCandNum + "'";
                    

                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();


                    //Update Code number to used
                    string strStat = "USED";
                    string mySelect4 = "Update CodeGeneratorTB" +

                        " SET Status='" + strStat + "'" +
                        " where CodeNumber ='" + myCodeNo + "'";

                    SqlConnection myConnection4 = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand4 = new SqlCommand(mySelect4, myConnection4);
                    myConnection4.Open();
                    myCommand4.ExecuteNonQuery();
                    myConnection4.Close();

                    //Insert into Voted_t

                    mySelectQuery = "Insert into Voted_t" +
                                        "(VoterID,CodeNumber,PollCode,Transdate) " +
                                        " Values ('" + Globals.strgblVoterID.ToUpper() + "','" + Globals.strgblCodeNumber +"','" + Globals.strPollCode + "'," +
                                        "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";

                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    //Print votes
                    VotePrintout myVotePrn = new VotePrintout();
                    myVotePrn.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                    myVotePrn.Refresh();
                    myVotePrn.SetParameterValue("myVVPAT", Globals.strTID);
                    myVotePrn.PrintToPrinter(1, false, 0, 0);

                    //

                    //Delete from tempvoting table
                    mySelect = "Delete from TempVoting where VoterID = '" + Globals.strgblVoterID + "'";
                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelect, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    

                    MessageBox.Show("You vote has been cast sucessfully, Thank you " + Globals.strVoterName);
                    Close();
                    
                    //Call Authentication screen
                    VotersAuthentication VAT = new VotersAuthentication();
                    VAT.Show();

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
            
        }

        
    }
}
