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
    public partial class ParlServerName : Form
    {
        public ParlServerName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServerName.Text == "")
                {
                    MessageBox.Show("Provide server details");
                    txtServerName.Focus();
                }
                else {
                    string mySelectQuery = "INSERT INTO [" + txtServerName.Text + "].VotingDB.dbo.ParliementaryVoteCast_t (CodeNo,PollCode,ConstCode,CandNum,Transdate,TID) select CodeNo,PollCode,ConstCode,CandNum,Transdate,TID from ParliementaryVoteCast_t where (status <>'FTP' or status is null);" +
                    "UPDATE ParliementaryVoteCast_t SET Status='FTP' WHERE (status <>'FTP' or status is null);" +

                    "update PR set PR.VoteCount=PR.VoteCount + p.CandNumCount FROM [" + txtServerName.Text + "].VotingDB.dbo.ParliamentaryTB PR " +
                    "INNER JOIN (select CandNum,count(*) AS CandNumCount from [" + txtServerName.Text + "].VotingDB.dbo.ParliementaryVoteCast_t PRC " +
                    "Where (PRC.status2 <>'UFTP' or PRC.status2 is null)GROUP BY CandNum)p on PR.CandNum = p.CandNum;" +
                    "UPDATE [" + txtServerName.Text + "].VotingDB.dbo.ParliementaryVoteCast_t  SET status2='UFTP' WHERE (status2 <>'UFTP' or status2 is null)";


                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();


                    //
                    myConnection.Close();
                    MessageBox.Show("Transfer Completed", "Vote Transfer");
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
            
        }

        private void ParlServerName_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Sure to close?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Close();
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }
    }
}
