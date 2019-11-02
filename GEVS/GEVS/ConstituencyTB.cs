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
    public partial class ConstituencyTB : Form
    {
        public ConstituencyTB()
        {
            InitializeComponent();
        }

        private void locktextbox()
        {
            try
            {


                txtCode.ReadOnly = true;
                txtDesc.ReadOnly = true;
                txtDistrict.ReadOnly = true;


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
                txtDesc.ReadOnly = false;
                txtDistrict.ReadOnly = false;

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
                txtDesc.Clear();
                txtDistrict.Clear();
                txtTotalVoters.Clear();
                txtVoteCount.Clear();

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }


        private void ConstituencyTB_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                locktextbox();
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
                else if (txtDesc.Text == "")
                {
                    MessageBox.Show("Description Name can't be empty");
                    txtDesc.Focus();
                }
                else if (txtDistrict.Text == "")
                {
                    MessageBox.Show("District can't be empty");
                    txtDistrict.Focus();
                }

                else
                {

                    string mySelectQuery = "Select * from ConstituencyTB where ConstCode = '" + txtCode.Text + "' or ConstName ='" + txtDesc.Text.ToUpper() + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ConstituencyTB");
                    DataTable dt = ds.Tables["ConstituencyTB"];
                    myConnection.Close();

                    if (dt.Rows.Count == 0)
                    {
                        
                        mySelectQuery = "Insert into ConstituencyTB" +
                                        "(ConstCode,ConstName,District) " +
                                        " Values ('" + txtCode.Text + "','" + txtDesc.Text.ToUpper() + "'," +
                                        "'" + txtDistrict.Text.ToUpper() + "')";

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
                if (txtDesc.Text == "")
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
                    txtDesc.Focus();
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
                if (txtDesc.Text == "")
                {
                    MessageBox.Show("Description can't be empty");
                    txtDesc.Focus();
                }

                else if (txtDistrict.Text == "")
                {
                    MessageBox.Show("District can't be empty");
                    txtDistrict.Focus();
                }
                else
                {

                    string mySelectQuery = "Update ConstituencyTB" +

                                " SET ConstName='" + txtDesc.Text.ToUpper() + "'," +
                                " District='" + txtDistrict.Text + "'" +

                                " where ConstCode ='" + txtCode.Text + "'";

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
                if (txtDesc.Text == "")
                {
                    MessageBox.Show("No record to delete", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Sure to delete?", "Deleting records", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mySelectQuery = "Delete from ConstituencyTB where ConstCode = '" + txtCode.Text + "'";
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
                    LookupConst ContsLookup = new LookupConst();
                    ContsLookup.ShowDialog();



                    if (ContsLookup.lstConst.SelectedItems.Count > 0)
                    {
                        txtFindCode.Text = ContsLookup.lstConst.SelectedItems[0].Text;


                        string mySelectQuery = "Select ConstCode, ConstName,District, TotalVoters, VoteCount from ConstituencyTB where ConstCode = '" + txtFindCode.Text + "'";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        myConnection.Close();
                        myConnection.Open();
                        SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ConstituencyTB");
                        DataTable dt = ds.Tables["ConstituencyTB"];


                        txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtDesc.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtDistrict.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtTotalVoters.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                        txtFindCode.Clear();
                        myConnection.Close();
                    }
                    else
                    {
                        if (ContsLookup.txtCode.Text != "")
                        {
                            string mySelectQuery = "Select ConstCode, ConstName,District, TotalVoters, VoteCount from ConstituencyTB where ConstCode = '" + ContsLookup.txtCode.Text + "'";

                            SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                            myConnection.Close();
                            myConnection.Open();
                            SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "ConstituencyTB");
                            DataTable dt = ds.Tables["ConstituencyTB"];
                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtDesc.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtDistrict.Text = ds.Tables[0].Rows[0][2].ToString();
                                txtTotalVoters.Text = ds.Tables[0].Rows[0][3].ToString();
                                txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();
                        
                                myConnection.Close();
                            }
                        }
                    }
                }
                else {

                    string mySelectQuery = "Select ConstCode, ConstName, District, TotalVoters, VoteCount from ConstituencyTB where ConstCode = '" + txtFindCode.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ConstituencyTB");
                    DataTable dt = ds.Tables["ConstituencyTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtCode.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtDesc.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtDistrict.Text = ds.Tables[0].Rows[0][2].ToString();

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
