using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.SqlClient;

namespace GEVS
{
    public partial class MainGEVS : Form
    {
        public MainGEVS()
        {
            InitializeComponent();
        }

        private void MainGEVS_Load(object sender, EventArgs e)
        {
            try
            {

                Globals.connectionString = "Data Source='" + Globals.strServer + "';Initial Catalog='" + Globals.strDatabase + "';user id='" + Globals.strUser + "';password='" + Globals.strPassword + "'";
                Globals.PCInfo();
             
                Login rL = new Login();
                rL.ShowDialog();

                lblUser.Text = Globals.strUserID;
                lblDate.Text = DateTime.Now.ToLongDateString();


                //Load company information
                //string mySelectQuery = "Select CompanyName, Address1, Address2, City, TelNo1, TelNo2, Fax1, Fax2, WebAddress, EMailAddress from CompanyDetails";

                //SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                //myConnection.Close();
                //myConnection.Open();
                //SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "CompanyDetails");
                //DataTable dt = ds.Tables["CompanyDetails"];

                //Globals.strCompany = ds.Tables[0].Rows[0][0].ToString();
                //this.Text = Globals.strCompany;
                //lblHeading.Text = Globals.strCompany + " " + "APPLICATION SUITE";
                //myConnection.Close();


                if (Globals.strAccType == "ADMIN")
                {

                    mnuFile.Enabled = true;
                    mnuReports.Enabled = true;
                    mnuUtilities.Enabled = true;
                    mnuEvent.Enabled = true;

                   
                    
                }
                else if (Globals.strAccType == "OPERATOR")
                {
                    mnuFile.Enabled = true;
                    mnuCodeGeneration.Enabled = true;
                    mnuFileSetup.Enabled = false;
                    mnuUtilities.Enabled = false;
                    mnuEvent.Enabled = true;
                } 
                else
                {
                    mnuFile.Enabled = false;
                    mnuReports.Enabled = false;
                    mnuUtilities.Enabled = false;
                    mnuEvent.Enabled = true;
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuUserAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccounts US = new UserAccounts();
                US.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuSetupConstutuency_Click(object sender, EventArgs e)
        {
            try
            {
                ConstituencyTB CNTB = new ConstituencyTB();
                CNTB.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuSetupPollingStation_Click(object sender, EventArgs e)
        {
            try
            {
                PollingStationTB PSTB = new PollingStationTB();
                PSTB.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuSetupPresidential_Click(object sender, EventArgs e)
        {
            try
            {
                PresidentialTB PrTB = new PresidentialTB();
                PrTB.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuSetupParliamentary_Click(object sender, EventArgs e)
        {
            try
            {
                ParliamentaryTB PlTB = new ParliamentaryTB();
                PlTB.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuFilePrintSetup_Click(object sender, EventArgs e)
        {
            try
            {


                PrintDialog pd = new PrintDialog();

                pd.ShowDialog();


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuFileLogOff_Click(object sender, EventArgs e)
        {
            try
            {
                Login rL = new Login();
                rL.ShowDialog();

                lblUser.Text = Globals.strUserID;
                lblDate.Text = DateTime.Now.ToLongDateString();


                if (Globals.strAccType != "ADMIN")
                {
                    //mnuFileCompany.Enabled = false;
                    //mnuSetup.Enabled = false;

                }
                else
                {
                    //mnuFileCompany.Enabled = true;
                    //mnuSetup.Enabled = true;
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Sure to close?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Application.Exit();
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuVoterReg_Click(object sender, EventArgs e)
        {
            try
            {
                VoterRegister VtReg = new VoterRegister();
                VtReg.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuCodeGeneration_Click(object sender, EventArgs e)
        {
            try
            {
                CodeGeneration CG = new CodeGeneration();
                CG.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuEventVoting_Click(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select VotingStatus from VotingSysStatus";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "VotingSysStatus");
                DataTable dt = ds.Tables["VotingSysStatus"];

                string strStat = ds.Tables[0].Rows[0][0].ToString();

                if (strStat == "CLOSED")
                {
                    MessageBox.Show("Voting has closed", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VotersAuthentication VAT = new VotersAuthentication();
                    VAT.Show();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }

        }

        private void mnuRepPresidential_Click(object sender, EventArgs e)
        {
            try
            {
                
                PresidentialReport ViewPresRep = new PresidentialReport();
                ViewPresRep.ShowDialog();
                
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuRepParliamentary_Click(object sender, EventArgs e)
        {
            try
            {

                ConstituencyInput constInput = new ConstituencyInput();
                constInput.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuRepCodeNotUsed_Click(object sender, EventArgs e)
        {
            try
            {

                CodeNotUsedReport myCod = new CodeNotUsedReport();
                myCod.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuRepDetailPresidential_Click(object sender, EventArgs e)
        {
            try
            {

                PresSummaryRepCont myPSumR = new PresSummaryRepCont();
                myPSumR.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
           
        }

        private void mnuRepDetailsParliamentary_Click(object sender, EventArgs e)
        {
            try
            {

                ParliamentarySummaryContainer myParlCont = new ParliamentarySummaryContainer();
                myParlCont.ShowDialog();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        
        private void mnuEventOpenVoting_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Sure to Open Voting?", "Open Voting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    string str = "OPEN";
                    string mySelectQuery = "Update VotingSysStatus" +

                                " SET VotingStatus='" + str + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    //update logfile
                    string strAct = "Open Voting";
                    mySelectQuery = "Insert into Logfile" +
                        "(Username,Activity,Logindate) " +
                        " Values ('" + Globals.strUserID + "','" + strAct + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";


                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuEventCloseVoting_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("Sure to Close Voting?", "Close Voting System", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    string str = "CLOSED";
                    string mySelectQuery = "Update VotingSysStatus" +

                                " SET VotingStatus='" + str + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    //update logfile
                    string strAct = "CLOSE Voting";
                    mySelectQuery = "Insert into Logfile" +
                        "(Username,Activity,Logindate) " +
                        " Values ('" + Globals.strUserID + "','" + strAct + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";


                    myConnection = new SqlConnection(Globals.connectionString);
                    myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

      

        private void mnuTransferPresident_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("You are about to transfer vote to a remote site, do you want to proceed?", "Vote Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    ServerName suv = new ServerName();
                    suv.ShowDialog();

                    //string mySelectQuery = "INSERT INTO [10.0.1.57\\cdr].VotingDB.dbo.PresidentVoteCast_t (CodeNo,PollCode,ConstCode,CandNum,Transdate,TID) select CodeNo,PollCode,ConstCode,CandNum,Transdate,TID from PresidentVoteCast_t where (status <>'FTP' or status is null);" +
                    //"UPDATE PresidentVoteCast_t SET Status='FTP' WHERE (status <>'FTP' or status is null);" +
                    
                    //"update PR set PR.VoteCount=PR.VoteCount + p.CandNumCount FROM [10.0.1.57\\cdr].VotingDB.dbo.PresidentialTB PR " +
                    //"INNER JOIN (select CandNum,count(*) AS CandNumCount from [10.0.1.57\\cdr].VotingDB.dbo.PresidentVoteCast_t PRC " + 
                    //"Where (PRC.status2 <>'UFTP' or PRC.status2 is null)GROUP BY CandNum)p on PR.PCandNum = p.CandNum;" +
                    //"UPDATE [10.0.1.57\\cdr].VotingDB.dbo.PresidentVoteCast_t  SET status2='UFTP' WHERE (status2 <>'UFTP' or status2 is null)";
                    

                    //SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    //SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    //myConnection.Open();
                    //myCommand.ExecuteNonQuery();

                    //myConnection.Close();
                    //MessageBox.Show("Transfer Completed","Vote Transfer");

                    
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void mnuTransferParliamentary_Click(object sender, EventArgs e)
        {
            try
            {

                if (DialogResult.Yes == MessageBox.Show("You are about to transfer vote to a remote site, do you want to proceed?", "Vote Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    ParlServerName psuv = new ParlServerName();
                    psuv.ShowDialog();
                    
                    //string mySelectQuery = "INSERT INTO [10.0.1.57\\cdr].VotingDB.dbo.ParliementaryVoteCast_t (CodeNo,PollCode,ConstCode,CandNum,Transdate,TID) select CodeNo,PollCode,ConstCode,CandNum,Transdate,TID from ParliementaryVoteCast_t where (status <>'FTP' or status is null);" +
                    //"UPDATE ParliementaryVoteCast_t SET Status='FTP' WHERE (status <>'FTP' or status is null);" +

                    //"update PR set PR.VoteCount=PR.VoteCount + p.CandNumCount FROM [10.0.1.57\\cdr].VotingDB.dbo.ParliamentaryTB PR " +
                    //"INNER JOIN (select CandNum,count(*) AS CandNumCount from [10.0.1.57\\cdr].VotingDB.dbo.ParliementaryVoteCast_t PRC " +
                    //"Where (PRC.status2 <>'UFTP' or PRC.status2 is null)GROUP BY CandNum)p on PR.CandNum = p.CandNum;" +
                    //"UPDATE [10.0.1.57\\cdr].VotingDB.dbo.ParliementaryVoteCast_t  SET status2='UFTP' WHERE (status2 <>'UFTP' or status2 is null)";


                    //SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    //SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    //myConnection.Open();
                    //myCommand.ExecuteNonQuery();

                    
                    ////
                    //myConnection.Close();
                    //MessageBox.Show("Transfer Completed", "Vote Transfer");

                    
                    
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

      
     
    }
}
