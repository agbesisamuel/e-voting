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
    public partial class PresidentialTB : Form
    {
        MemoryStream ms;
        byte[] photo_aray;
        public PresidentialTB()
        {
            InitializeComponent();
        }

        private void locktextbox()
        {
            try
            {
                txtCandNum.ReadOnly = true;
                txtCandName.ReadOnly = true;
                txtPartyName.ReadOnly = true;
                cboElectionYr.Enabled = false;

                picCandPhoto.Enabled = false;
                picPartyLogo.Enabled = false;
                btnPLoad.Enabled = false;
                btnPRemove.Enabled = false;
                btnCandLoad.Enabled = false;
                btnCandRemove.Enabled = false;
   
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
                txtCandNum.ReadOnly = false;
                txtCandName.ReadOnly = false;
                txtPartyName.ReadOnly = false;
                cboElectionYr.Enabled = true;

                picCandPhoto.Enabled = true;
                picPartyLogo.Enabled = true;
                btnPLoad.Enabled = true;
                btnPRemove.Enabled = true;
                btnCandLoad.Enabled = true;
                btnCandRemove.Enabled = true;

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
                txtFindCandNum.Clear();
                txtCandNum.Clear();
                txtCandName.Clear();
                txtPartyName.Clear();
                cboElectionYr.SelectedIndex = -1;
                txtVoteCount.Clear();
                picCandPhoto.Image = null;
                picPartyLogo.Image = null;
           
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnCandLoad_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (Image.FromFile(dlg.FileName).Height > 230 || Image.FromFile(dlg.FileName).Width > 210)
                    {
                        MessageBox.Show("Invalid Picture Size, Picture should be around 200 x 225");
                    }
                    else
                    {
                        picCandPhoto.Image = Image.FromFile(dlg.FileName);
                    }
                    

                }


                dlg.Dispose();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnPLoad_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    if (Image.FromFile(dlg.FileName).Height > 230 || Image.FromFile(dlg.FileName).Width > 210)
                    {
                        MessageBox.Show("Invalid Picture Size, Picture should be around 200 x 225");
                    }
                    else
                    {
                        picPartyLogo.Image = Image.FromFile(dlg.FileName);
                    }
                  

                }


                dlg.Dispose();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnCandRemove_Click(object sender, EventArgs e)
        {
            try
            {

                picCandPhoto.Image = null;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnPRemove_Click(object sender, EventArgs e)
        {
            try
            {

                picPartyLogo.Image = null;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void PresidentialTB_Load(object sender, EventArgs e)
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
                txtCandNum.Focus();
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
                if (txtCandNum.Text == "")
                {
                    MessageBox.Show("Candidate number can't be empty");
                    txtCandNum.Focus();
                }
                else if (txtCandName.Text == "")
                {
                    MessageBox.Show("Candidate Name can't be empty");
                    txtCandName.Focus();
                }
                else if (txtPartyName.Text == "")
                {
                    MessageBox.Show("Party Name can't be empty");
                    txtPartyName.Focus();
                }
                else if (cboElectionYr.Text == "")
                {
                    MessageBox.Show("Election Year can't be empty");
                    cboElectionYr.Focus();
                }
                else if (picCandPhoto.Image == null)
                {
                    MessageBox.Show("Candidate photo can't be empty");
                    picCandPhoto.Focus();
                }
                else if (picPartyLogo.Image == null)
                {
                    MessageBox.Show("Party logo can't be empty");
                    picPartyLogo.Focus();
                }
                else
                {

                    string mySelectQuery = "Select * from PresidentialTB where PCandNum = '" + txtCandNum.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PresidentialTB");
                    DataTable dt = ds.Tables["PresidentialTB"];
                    myConnection.Close();

                    if (dt.Rows.Count == 0)
                    {

                        mySelectQuery = "Insert into PresidentialTB" +
                                        "(PCandNum,PCandName,PartyName, ElectionYR, PCandPhoto,PartyLogo) " +
                                        " Values ('" + txtCandNum.Text + "','" + txtCandName.Text.ToUpper() + "','" + txtPartyName.Text.ToUpper() + "'," +
                                        "'" + cboElectionYr.Text + "', @cphoto, @photo)";

                        myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);


                        //Save President pix
                        if (picCandPhoto.Image != null)
                        {

                            ms = new MemoryStream();
                            picCandPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] photo_aray = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(photo_aray, 0, photo_aray.Length);
                            myCommand.Parameters.AddWithValue("@cphoto", photo_aray);

                        }

                        //Save party logo
                        if (picPartyLogo.Image != null)
                        {

                            ms = new MemoryStream();
                            picPartyLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] photo_aray = new byte[ms.Length];
                            ms.Position = 0;
                            ms.Read(photo_aray, 0, photo_aray.Length);
                            myCommand.Parameters.AddWithValue("@photo", photo_aray);

                        }

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
                        MessageBox.Show("Candidate Number Already Exist", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myConnection.Close();
                        txtCandNum.Focus();
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
                if (txtCandName.Text == "")
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
                   
                    txtCandNum.ReadOnly = true;
                    txtCandName.Focus();
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
                if (txtCandName.Text == "")
                {
                    MessageBox.Show("Candidate Name can't be empty");
                    txtCandName.Focus();
                }
                else if (txtPartyName.Text == "")
                {
                    MessageBox.Show("Party Name can't be empty");
                    txtPartyName.Focus();
                }
                else if (picCandPhoto.Image == null)
                {
                    MessageBox.Show("Candidate photo can't be empty");
                    picCandPhoto.Focus();
                }
                else if (picPartyLogo.Image == null)
                {
                    MessageBox.Show("Party logo can't be empty");
                    picPartyLogo.Focus();
                }
                else if (cboElectionYr.Text == "")
                {
                    MessageBox.Show("Election Year can't be empty");
                    cboElectionYr.Focus();
                }
                else
                {

                    string mySelectQuery = "Update PresidentialTB" +

                                " SET PCandName='" + txtCandName.Text.ToUpper() + "'," +
                                " PartyName='" + txtPartyName.Text.ToUpper() + "'," +
                                " PCandPhoto = @cphoto ," +
                                " PartyLogo = @photo ," +
                                " ElectionYR ='" + cboElectionYr.Text + "'" +
                                " where PCandNum ='" + txtCandNum.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                    //update President pix
                    if (picCandPhoto.Image != null)
                    {

                        ms = new MemoryStream();
                        picCandPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] photo_aray = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, photo_aray.Length);
                        myCommand.Parameters.AddWithValue("@cphoto", photo_aray);

                    }

                    //update party logo
                    if (picPartyLogo.Image != null)
                    {

                        ms = new MemoryStream();
                        picPartyLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] photo_aray = new byte[ms.Length];
                        ms.Position = 0;
                        ms.Read(photo_aray, 0, photo_aray.Length);
                        myCommand.Parameters.AddWithValue("@photo", photo_aray);

                    }
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
                if (txtCandName.Text == "")
                {
                    MessageBox.Show("No record to delete", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Sure to delete?", "Deleting records", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mySelectQuery = "Delete from PresidentialTB where PCandNum = '" + txtCandNum.Text + "'";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFindCandNum.Text == "")
                {
                    //
                    LookupPresident LKupPressTB = new LookupPresident();
                    LKupPressTB.ShowDialog();
                  
                    if (LKupPressTB.lstPres.SelectedItems.Count > 0)
                    {
                        txtFindCandNum.Text = LKupPressTB.lstPres.SelectedItems[0].Text;
                        string mySelectQuery = "Select PCandNum, PCandName, PartyName, ElectionYr, VoteCount, PCandPhoto, PartyLogo from PresidentialTB where PCandNum = '" + txtFindCandNum.Text + "'";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        myConnection.Close();
                        myConnection.Open();
                        SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PresidentialTB");
                        DataTable dt = ds.Tables["PresidentialTB"];

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtCandNum.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtCandName.Text = ds.Tables[0].Rows[0][1].ToString();
                            txtPartyName.Text = ds.Tables[0].Rows[0][2].ToString();
                            cboElectionYr.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                            picCandPhoto.Image = null;
                            if (ds.Tables[0].Rows[0]["PCandPhoto"] != System.DBNull.Value)
                            {
                                photo_aray = (byte[])ds.Tables[0].Rows[0]["PCandPhoto"];
                                MemoryStream ms = new MemoryStream(photo_aray);
                                picCandPhoto.Image = Image.FromStream(ms);
                            }

                            picPartyLogo.Image = null;
                            if (ds.Tables[0].Rows[0]["PartyLogo"] != System.DBNull.Value)
                            {
                                photo_aray = (byte[])ds.Tables[0].Rows[0]["PartyLogo"];
                                MemoryStream ms = new MemoryStream(photo_aray);
                                picPartyLogo.Image = Image.FromStream(ms);
                            }
                        }
                        txtFindCandNum.Clear();
                        myConnection.Close();
                    }
                    else {
                        if (LKupPressTB.txtCode.Text != "")
                        {
                            string mySelectQuery = "Select PCandNum, PCandName, PartyName, ElectionYr, VoteCount, PCandPhoto, PartyLogo from PresidentialTB where PCandNum = '" + LKupPressTB.txtCode.Text + "'";

                            SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                            myConnection.Close();
                            myConnection.Open();
                            SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "PresidentialTB");
                            DataTable dt = ds.Tables["PresidentialTB"];

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                txtCandNum.Text = ds.Tables[0].Rows[0][0].ToString();
                                txtCandName.Text = ds.Tables[0].Rows[0][1].ToString();
                                txtPartyName.Text = ds.Tables[0].Rows[0][2].ToString();
                                cboElectionYr.Text = ds.Tables[0].Rows[0][3].ToString();
                                txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                                picCandPhoto.Image = null;
                                if (ds.Tables[0].Rows[0]["PCandPhoto"] != System.DBNull.Value)
                                {
                                    photo_aray = (byte[])ds.Tables[0].Rows[0]["PCandPhoto"];
                                    MemoryStream ms = new MemoryStream(photo_aray);
                                    picCandPhoto.Image = Image.FromStream(ms);
                                }

                                picPartyLogo.Image = null;
                                if (ds.Tables[0].Rows[0]["PartyLogo"] != System.DBNull.Value)
                                {
                                    photo_aray = (byte[])ds.Tables[0].Rows[0]["PartyLogo"];
                                    MemoryStream ms = new MemoryStream(photo_aray);
                                    picPartyLogo.Image = Image.FromStream(ms);
                                }
                            }
                            txtFindCandNum.Clear();
                            myConnection.Close();
                        }
                    
                    }
                    //
                }
                else
                {

                    string mySelectQuery = "Select PCandNum, PCandName, PartyName, ElectionYr, VoteCount, PCandPhoto, PartyLogo from PresidentialTB where PCandNum = '" + txtFindCandNum.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PresidentialTB");
                    DataTable dt = ds.Tables["PresidentialTB"];

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtCandNum.Text = ds.Tables[0].Rows[0][0].ToString();
                        txtCandName.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtPartyName.Text = ds.Tables[0].Rows[0][2].ToString();
                        cboElectionYr.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtVoteCount.Text = ds.Tables[0].Rows[0][4].ToString();

                        picCandPhoto.Image = null;
                        if (ds.Tables[0].Rows[0]["PCandPhoto"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])ds.Tables[0].Rows[0]["PCandPhoto"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picCandPhoto.Image = Image.FromStream(ms);
                        }

                        picPartyLogo.Image = null;
                        if (ds.Tables[0].Rows[0]["PartyLogo"] != System.DBNull.Value)
                        {
                            photo_aray = (byte[])ds.Tables[0].Rows[0]["PartyLogo"];
                            MemoryStream ms = new MemoryStream(photo_aray);
                            picPartyLogo.Image = Image.FromStream(ms);
                        }
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
    }
}
