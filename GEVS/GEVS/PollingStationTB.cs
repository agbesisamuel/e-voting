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
    public partial class PollingStationTB : Form
    {
        public PollingStationTB()
        {
            InitializeComponent();
        }


        private void locktextbox()
        {
            try
            {


                txtCode.ReadOnly = true;
                txtPollStationName.ReadOnly = true;
                cboConstCode.Enabled = false;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }


        //method that unlock controls
        private void unlocktextbox()
        {
            try
            {
                txtCode.ReadOnly = false;
                txtPollStationName.ReadOnly = false;
                cboConstCode.Enabled = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }

        }

        //method that cleas data in text box
        private void Cleardata()
        {
            try
            {
                txtCode.Clear();
                txtFindCode.Clear();
                txtPollStationName.Clear();
                cboConstCode.SelectedIndex = -1;
                lblConstName.Clear();
                txtTotalVoters.Clear();
                txtVoteCount.Clear();

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
        //Load Position description to the comb box
        private void LoadConstituencies()
        {
            try
            {
                string mySelectQuery = "Select ConstCode from ConstituencyTB";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds1 = new DataSet();


                da1.Fill(ds1, "ConstituencyTB");
                DataTable dt1 = ds1.Tables["ConstituencyTB"];
                myConnection.Close();


                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    cboConstCode.Items.Add(dr["ConstCode"].ToString());

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void PollingStationTB_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                locktextbox();
                LoadConstituencies();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void cboConstCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select ConstName from ConstituencyTB where ConstCode = '" + cboConstCode.Text + "'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "ConstituencyTB");
                DataTable dt = ds.Tables["ConstituencyTB"];

                if (dt.Rows.Count != 0)
                {
                    lblConstName.Text = ds.Tables[0].Rows[0][0].ToString();

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                unlocktextbox();
                Cleardata();
                btnCreate.Enabled = false;
                btnCreate.Visible = false;

                btnSave.Enabled = true;
                btnSave.Visible = true;

                btnCancel.Enabled = true;

                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnClose.Enabled = false;
                btnSearch.Enabled = false;
                txtCode.Focus();
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
                locktextbox();
                Cleardata();
                btnCreate.Enabled = true;
                btnCreate.Visible = true;

                btnSave.Enabled = false;
                btnSave.Visible = false;

                btnCancel.Enabled = false;

                btnModify.Enabled = true;
                btnUpdate.Enabled = false;

                btnModify.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Enabled = true;
                btnClose.Enabled = true;
                btnSearch.Enabled = true;
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Code can't be empty");
                    txtCode.Focus();
                }
                else if (txtPollStationName.Text == "")
                {
                    MessageBox.Show("Polling Station Name can't be empty");
                    txtPollStationName.Focus();
                }
                else if (cboConstCode.Text == "")
                {
                    MessageBox.Show("Constituency can't be empty");
                    cboConstCode.Focus();
                }

                else
                {

                    string mySelectQuery = "Select * from PollingStationTB where PollCode = '" + txtCode.Text + "' or PollStationName ='" + txtPollStationName.Text.ToUpper() + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PollingStationTB");
                    DataTable dt = ds.Tables["PollingStationTB"];
                    myConnection.Close();

                    if (dt.Rows.Count == 0)
                    {

                        mySelectQuery = "Insert into PollingStationTB" +
                                        "(PollCode,PollStationName,ConstCode) " +
                                        " Values ('" + txtCode.Text + "','" + txtPollStationName.Text.ToUpper() + "'," +
                                        "'" + cboConstCode.Text + "')";

                        myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();


                        locktextbox();
                        btnCreate.Enabled = true;
                        btnCreate.Visible = true;

                        btnSave.Enabled = false;
                        btnSave.Visible = false;

                        btnCancel.Enabled = false;
                        btnModify.Enabled = true;
                        btnDelete.Enabled = true;
                        btnClose.Enabled = true;
                        btnSearch.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Code/Name Already Exist", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myConnection.Close();
                        txtCode.Focus();
                    }
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPollStationName.Text == "")
                {
                    MessageBox.Show("No Record to edit", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    unlocktextbox();

                    btnModify.Enabled = false;
                    btnModify.Visible = false;

                    btnUpdate.Enabled = true;
                    btnUpdate.Visible = true;

                    btnCancel.Enabled = true;

                    btnCreate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    btnSearch.Enabled = false;
                    //txtDesc.ReadOnly = true;
                    txtCode.ReadOnly = true;
                    txtPollStationName.Focus();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPollStationName.Text == "")
                {
                    MessageBox.Show("Polling Station Name can't be empty");
                    txtPollStationName.Focus();
                }
                else if (cboConstCode.Text == "")
                {
                    MessageBox.Show("Constituency can't be empty");
                    cboConstCode.Focus();
                }
                else
                {

                    string mySelectQuery = "Update PollingStationTB" +

                                " SET PollStationName='" + txtPollStationName.Text.ToUpper() + "'," +
                                " ConstCode='" + cboConstCode.Text + "'" +

                                " where PollCode ='" + txtCode.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();


                    locktextbox();
                    btnModify.Enabled = true;
                    btnModify.Visible = true;

                    btnUpdate.Enabled = false;
                    btnUpdate.Visible = false;

                    btnCancel.Enabled = false;
                    btnCreate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    btnSearch.Enabled = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPollStationName.Text == "")
                {
                    MessageBox.Show("No record to delete", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Sure to delete?", "Deleting records", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mySelectQuery = "Delete from PollingStationTB where PollCode = '" + txtCode.Text + "'";
                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        Cleardata();

                    }
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFindCode.Text == "")
                {
                    LookupPoll PollLookup = new LookupPoll();
                    PollLookup.ShowDialog();



                    if (PollLookup.lstPoll.SelectedItems.Count > 0)
                    {
                        txtFindCode.Text = PollLookup.lstPoll.SelectedItems[0].Text;


                        string mySelectQuery = "Select PollCode, PollStationName,ConstCode, TotalVoters, VoteCount from PollingStationTB where PollCode = '" + txtFindCode.Text + "'";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        myConnection.Close();
                        myConnection.Open();
                        SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PollingStationTB");
                        DataTable dt = ds.Tables["PollingStationTB"];


                        txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtPollStationName.Text = ds.Tables[0].Rows[0][1].ToString();
                        cboConstCode.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtTotalVoters.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                        txtFindCode.Clear();
                        myConnection.Close();
                    }
                    else
                    {
                        if (PollLookup.txtCode.Text != "")
                        {
                            string mySelectQuery = "Select PollCode, PollStationName,ConstCode, TotalVoters, VoteCount from PollingStationTB where PollCode = '" + PollLookup.txtCode + "'";

                            SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                            myConnection.Close();
                            myConnection.Open();
                            SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "PollingStationTB");
                            DataTable dt = ds.Tables["PollingStationTB"];
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtPollStationName.Text = ds.Tables[0].Rows[0][1].ToString();
                                cboConstCode.Text = ds.Tables[0].Rows[0][2].ToString();
                                txtTotalVoters.Text = ds.Tables[0].Rows[0][3].ToString();
                                txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                                myConnection.Close();
                            }
                        }
                    }
                }
                else
                {

                    string mySelectQuery = "Select PollCode, PollStationName, ConstCode, TotalVoters, VoteCount from PollingStationTB where PollCode = '" + txtFindCode.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PollingStationTB");
                    DataTable dt = ds.Tables["PollingStationTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtPollStationName.Text = ds.Tables[0].Rows[0][1].ToString();
                        cboConstCode.Text = ds.Tables[0].Rows[0][2].ToString();

                        txtTotalVoters.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();
                    }


                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);

            }
        }
    }
}
