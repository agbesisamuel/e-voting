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
    public partial class CodeGeneration : Form
    {
        //MemoryStream ms;
        byte[] photo_aray;
        string strValue;
        string cText;
        public CodeGeneration()
        {
            InitializeComponent();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Sure to clear?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    txtVoterID.Clear();
                    txtCodeNumber.Clear();
                    txtName.Clear();
                    txtStatus.Clear();
                    txtCreatedTime.Clear();
                    picVoterPhoto.Image = null;
                }

                

               

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }

        private void btnCodeGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVoterID.Text == "")
                {
                    MessageBox.Show("Enter a voter id", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVoterID.Focus();
                }
                else
                {

                    string mySelectQuery = "Select VoterID, FName,LName, Photo from VoterRegisterTB where VoterID = '" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "VoterRegisterTB");
                    DataTable dt = ds.Tables["VoterRegisterTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        string mySelectQuery1 = "Select VoterID, CodeNumber Photo from CodeGeneratorTB where VoterID = '" + txtVoterID.Text + "'";

                        myConnection = new SqlConnection(Globals.connectionString);
                        myConnection.Close();
                        myConnection.Open();
                        SqlDataAdapter da1 = new SqlDataAdapter(mySelectQuery1, myConnection);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "CodeGeneratorTB");
                        DataTable dt1 = ds1.Tables["CodeGeneratorTB"];

                        if (dt1.Rows.Count == 0)
                        {
                     
                            txtVoterID.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtName.Text = ds.Tables[0].Rows[0][1].ToString() + " " + ds.Tables[0].Rows[0][2].ToString();
                            
                            //Convert Voter ID into ascii value
                            string s = txtVoterID.Text;
                            strValue="";
                            double dblValue;

                            foreach (byte b in System.Text.Encoding.UTF8.GetBytes(s.ToCharArray()))
                            //foreach (char c in s)
                            {
                                strValue = strValue + b.ToString();

                                
                            }
                            
                            dblValue = Convert.ToDouble(strValue);
                            TimeSpan span = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0));
                            //int ec;

                            ////encrypt the ascii value using Ceasers Cipher
                            //cText="";
                            //foreach (char c in dblValue.ToString())
                            //{
                            //    ec = (c + 6) % 26;
                            //    cText = cText + ec;
                                
                            //}
                            double dblSpan;
                            dblSpan = Convert.ToDouble(span.TotalMinutes);
                            double dblFinal = (Convert.ToDouble(dblValue) /dblSpan)* 2013;
                            //Math.Floor(Math.Abs(number))
                            string strfinal = Math.Floor(Math.Abs((dblFinal))).ToString();
                           
                            //txtCodeNumber.Text = cText.Substring(1,10);
                            txtCodeNumber.Text = strfinal.Substring(1, 8);
                            //txtCodeNumber.Text = strfinal;
                            txtCreatedTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                           
                            picVoterPhoto.Image = null;
                            if (ds.Tables[0].Rows[0]["Photo"] != System.DBNull.Value)
                            {
                                photo_aray = (byte[])ds.Tables[0].Rows[0]["Photo"];
                                MemoryStream ms = new MemoryStream(photo_aray);
                                picVoterPhoto.Image = Image.FromStream(ms);
                            }
                            string myStatus = "NEW";
                            txtStatus.Text = myStatus;

                            //Insert into Code generator table
                            mySelectQuery = "Insert into CodeGeneratorTB" +
                                            "(CodeNumber,VoterID,CreatedTime,Status) " +
                                            " Values ('" + txtCodeNumber.Text + "','" + txtVoterID.Text.ToUpper() + "'," +
                                            "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + myStatus.ToString() + "')";

                            myConnection = new SqlConnection(Globals.connectionString);
                            SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                            myConnection.Open();
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();


                        }
                        else {
                            MessageBox.Show("Code has been issued already", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }


                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVoterID.Text == "")
                {
                    MessageBox.Show("No record to search", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVoterID.Focus();
                }
                else
                {

                    string mySelectQuery = "Select VoterID, CodeNumber, CreatedTime,Status from CodeGeneratorTB where VoterID = '" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "CodeGeneratorTB");
                    DataTable dt = ds.Tables["CodeGeneratorTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtCodeNumber.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtCreatedTime.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtStatus.Text = ds.Tables[0].Rows[0][3].ToString();

                        if (txtStatus.Text == "LOCKED")
                        {
                            btnUnlock.Enabled = true;
                        }
                    }


                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            try
            {
                string strOldSata = "LOCKED";
                string strStat = "NEW";
                string mySelect = "Update CodeGeneratorTB" +

                    " SET Status='" + strStat + "'" +
                    " where CodeNumber ='" + txtCodeNumber.Text + "' AND Status = '" + strOldSata + "'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                SqlCommand myCommand = new SqlCommand(mySelect, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();

                //insert into audit trail
                string myAct = "UNLOCK CODE";
                string strDes = "Unlock Voters Code Number";
                string mySelectQuery = "Insert into AUDITTRAIL_T" +
                       "(USERNAME,TRANSDATE,ACTIVITY,DESCRIPTION) " +
                       " Values ('" + Globals.strUserID + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + myAct + "','" + strDes + "')";


                myConnection = new SqlConnection(Globals.connectionString);
                myCommand = new SqlCommand(mySelectQuery, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }

        
    }
}
