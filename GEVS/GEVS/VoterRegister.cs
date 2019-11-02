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
    public partial class VoterRegister : Form
    {
        MemoryStream ms;
        byte[] photo_aray;


        public VoterRegister()
        {
            InitializeComponent();
        }

        private void locktextbox()
        {
            try
            {
                // txtAge.ReadOnly = true;
                txtDistrict.ReadOnly = true;
                txtFathersName.ReadOnly = true;
                txtFName.ReadOnly = true;
                txtHomeTown.ReadOnly = true;
                txtLName.ReadOnly = true;
                txtMothersName.ReadOnly = true;
                txtRegCenterCode.ReadOnly = true;
                txtResAddress.ReadOnly = true;
                txtVoterID.ReadOnly = true;
                cboGender.Enabled = false;
                cboPollCode.Enabled = false;
                dtpDOB.Enabled = false;

                picVoterPhoto.Enabled = false;
                btnCandLoad.Enabled = false;
                btnCandRemove.Enabled = false;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }


        private void unlocktextbox()
        {
            try
            {
                //txtAge.ReadOnly = false;
                txtDistrict.ReadOnly = false;
                txtFathersName.ReadOnly = false;
                txtFName.ReadOnly = false;
                txtHomeTown.ReadOnly = false;
                txtLName.ReadOnly = false;
                txtMothersName.ReadOnly = false;
                txtRegCenterCode.ReadOnly = false;
                txtResAddress.ReadOnly = false;
                txtVoterID.ReadOnly = false;
                cboGender.Enabled = true;
                cboPollCode.Enabled = true;
                dtpDOB.Enabled = true;


                picVoterPhoto.Enabled = true;
                btnCandLoad.Enabled = true;
                btnCandRemove.Enabled = true;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }


        private void Cleardata()
        {
            try
            {
                txtAge.Clear();
                txtDistrict.Clear();
                txtFathersName.Clear();
                txtFName.Clear();
                txtHomeTown.Clear();
                txtLName.Clear();
                txtMothersName.Clear();
                txtRegCenterCode.Clear();
                txtResAddress.Clear();
                txtVoterID.Clear();
                lblStationName.Clear();
                cboGender.SelectedIndex = -1;
                cboPollCode.SelectedIndex = -1;
                dtpDOB.Value = DateTime.Now;
                picVoterPhoto.Image = null;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        //Load Position description to the comb box
        private void LoadPollingStations()
        {
            try
            {
                string mySelectQuery = "Select PollCode from PollingStationTB";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds1 = new DataSet();


                da1.Fill(ds1, "PollingStationTB");
                DataTable dt1 = ds1.Tables["PollingStationTB"];
                myConnection.Close();


                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    cboPollCode.Items.Add(dr["PollCode"].ToString());

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void VoterRegister_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
                locktextbox();
                LoadPollingStations();

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
                txtVoterID.Focus();
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
                if (txtVoterID.Text == "")
                {
                    MessageBox.Show("Voter ID can't be empty");
                    txtVoterID.Focus();
                }
                else if (txtFName.Text == "")
                {
                    MessageBox.Show("First Name can't be empty");
                    txtFName.Focus();
                }
                else if (txtLName.Text == "")
                {
                    MessageBox.Show("Last Name can't be empty");
                    txtLName.Focus();
                }
                else if (Convert.ToInt16(txtAge.Text)<18){
                    MessageBox.Show("Voters' Age can't be less than 18 years");
                    dtpDOB.Focus();
                }
                else if (cboPollCode.Text == "")
                {
                    MessageBox.Show("Polling Station Code can't be empty");
                    cboPollCode.Focus();
                }
                else if (txtRegCenterCode.Text == "")
                {
                    MessageBox.Show("Registration Center Code can't be empty");
                    txtRegCenterCode.Focus();
                }
                else if (picVoterPhoto.Image == null)
                {
                    MessageBox.Show("Voter photo can't be empty");
                    picVoterPhoto.Focus();
                }

                else
                {

                    string mySelectQuery = "Select * from VoterRegisterTB where VoterID = '" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "VoterRegisterTB");
                    DataTable dt = ds.Tables["VoterRegisterTB"];
                    myConnection.Close();

                    if (dt.Rows.Count == 0)
                    {

                        mySelectQuery = "Insert into VoterRegisterTB" +
                                        "(VoterID,FName,LName, DOB, Age,Sex,ResAddress,FatherName,MotherName,HomeTown,District,RegCenterCode,PollCode,Photo) " +
                                        " Values ('" + txtVoterID.Text.ToUpper() + "','" + txtFName.Text.ToUpper() + "','" + txtLName.Text.ToUpper() + "'," +
                                        "'" + dtpDOB.Value.ToString("yyyy/MM/dd") + "','" + Convert.ToInt16(txtAge.Text) + "','" + cboGender.Text + "'," +
                                        "'" + txtResAddress.Text.ToUpper() + "','" + txtFathersName.Text.ToUpper() + "','" + txtMothersName.Text.ToUpper() + "'," +
                                         "'" + txtHomeTown.Text.ToUpper() + "','" + txtDistrict.Text.ToUpper() + "','" + txtRegCenterCode.Text.ToUpper() + "'," +
                                        "'" + cboPollCode.Text + "',@photo)";

                        myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);


                        //Save Voters pix
                        if (picVoterPhoto.Image != null)
                        {

                            ms = new MemoryStream();
                            picVoterPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
                        MessageBox.Show("Voter ID Already Exist", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myConnection.Close();
                        txtVoterID.Focus();
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
                if (txtFName.Text == "")
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

                    txtVoterID.ReadOnly = true;
                    txtFName.Focus();
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
                if (txtFName.Text == "")
                {
                    MessageBox.Show("First Name can't be empty");
                    txtFName.Focus();
                }
                else if (txtLName.Text == "")
                {
                    MessageBox.Show("Last Name can't be empty");
                    txtLName.Focus();
                }
                else if (cboPollCode.Text == "")
                {
                    MessageBox.Show("Polling Station Code can't be empty");
                    cboPollCode.Focus();
                }
                else if (txtRegCenterCode.Text == "")
                {
                    MessageBox.Show("Registration Center Code can't be empty");
                    txtRegCenterCode.Focus();
                }
                else if (picVoterPhoto.Image == null)
                {
                    MessageBox.Show("Voter photo can't be empty");
                    picVoterPhoto.Focus();
                }

                else
                {

                    string mySelectQuery = "Update VoterRegisterTB" +

                                " SET FName='" + txtFName.Text.ToUpper() + "'," +
                                " LName='" + txtLName.Text.ToUpper() + "'," +
                                " DOB='" + dtpDOB.Value.ToString("yyyy/MM/dd") + "'," +
                                " Age='" + Convert.ToInt16(txtAge.Text) + "'," +
                                " Sex='" + cboGender.Text + "'," +
                                " ResAddress='" + txtResAddress.Text.ToUpper() + "'," +
                                " FatherName='" + txtFathersName.Text.ToUpper() + "'," +
                                " MotherName='" + txtMothersName.Text.ToUpper() + "'," +
                                " HomeTown='" + txtHomeTown.Text.ToUpper() + "'," +
                                " District='" + txtDistrict.Text.ToUpper() + "'," +
                                " RegCenterCode='" + txtRegCenterCode.Text.ToUpper() + "'," +
                                " Photo = @photo ," +
                                " PollCode ='" + cboPollCode.Text + "'" +
                                " where VoterID='" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);

                    //update Voters pix
                    if (picVoterPhoto.Image != null)
                    {

                        ms = new MemoryStream();
                        picVoterPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                VoterLookup VTLk = new VoterLookup();
                VTLk.ShowDialog();



                if (VTLk.lstVoters.SelectedItems.Count > 0)
                {
                    txtVoterID.Text = VTLk.lstVoters.SelectedItems[0].Text;


                    string mySelectQuery = "Select VoterID, FName,LName, DOB, Age,Sex,ResAddress,FatherName,MotherName,HomeTown,District,RegCenterCode,PollCode,Photo from VoterRegisterTB where VoterID = '" + txtVoterID.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "VoterRegisterTB");
                    DataTable dt = ds.Tables["VoterRegisterTB"];


                    txtVoterID.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtFName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtLName.Text = ds.Tables[0].Rows[0][2].ToString();
                    dtpDOB.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
                    txtAge.Text = ds.Tables[0].Rows[0][4].ToString();
                    cboGender.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtResAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtFathersName.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtMothersName.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtHomeTown.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtDistrict.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtRegCenterCode.Text = ds.Tables[0].Rows[0][11].ToString();
                    cboPollCode.Text = ds.Tables[0].Rows[0][12].ToString();

                    picVoterPhoto.Image = null;
                    if (ds.Tables[0].Rows[0]["Photo"] != System.DBNull.Value)
                    {
                        photo_aray = (byte[])ds.Tables[0].Rows[0]["Photo"];
                        MemoryStream ms = new MemoryStream(photo_aray);
                        picVoterPhoto.Image = Image.FromStream(ms);
                    }



                    myConnection.Close();
                }
                else
                {
                    if (VTLk.txtVoterID.Text != "")
                    {
                        string mySelectQuery = "Select VoterID, FName,LName, DOB, Age,Sex,ResAddress,FatherName,MotherName,HomeTown,District,RegCenterCode,PollCode,Photo from VoterRegisterTB where VoterID = '" + VTLk.txtVoterID.Text + "'";

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

                            txtVoterID.Text = ds.Tables[0].Rows[0][0].ToString();
                            txtFName.Text = ds.Tables[0].Rows[0][1].ToString();
                            txtLName.Text = ds.Tables[0].Rows[0][2].ToString();
                            dtpDOB.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
                            txtAge.Text = ds.Tables[0].Rows[0][4].ToString();
                            cboGender.Text = ds.Tables[0].Rows[0][5].ToString();
                            txtResAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                            txtFathersName.Text = ds.Tables[0].Rows[0][7].ToString();
                            txtMothersName.Text = ds.Tables[0].Rows[0][8].ToString();
                            txtHomeTown.Text = ds.Tables[0].Rows[0][9].ToString();
                            txtDistrict.Text = ds.Tables[0].Rows[0][10].ToString();
                            txtRegCenterCode.Text = ds.Tables[0].Rows[0][11].ToString();
                            cboPollCode.Text = ds.Tables[0].Rows[0][12].ToString();

                            picVoterPhoto.Image = null;
                            if (ds.Tables[0].Rows[0]["Photo"] != System.DBNull.Value)
                            {
                                photo_aray = (byte[])ds.Tables[0].Rows[0]["Photo"];
                                MemoryStream ms = new MemoryStream(photo_aray);
                                picVoterPhoto.Image = Image.FromStream(ms);
                            }

                            myConnection.Close();
                        }
                    }
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
                if (txtFName.Text == "")
                {
                    MessageBox.Show("No record to delete", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Sure to delete?", "Deleting records", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mySelectQuery = "Delete from VoterRegisterTB where VoterID = '" + txtVoterID.Text + "'";
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

        //date difference in months
        private static int MonthDiff(DateTime d1, DateTime d2)
        {
            if (d1 > d2)
            {
                return MonthDiff(d2, d1);
            }

            int months = (d2.Year * 12 + d2.Month) - (d1.Year * 12 + d1.Month);

            if (d2.Day < d1.Day)
            {
                months--;
            }

            return months;
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                int intMonth;
                int age;


                //today = DateTime.Today;
                //intMonth = today.Month - dtpDOB.Value.Month;
                //age = intMonth / 12;
                //txtAge.Text = age.ToString();

                intMonth = MonthDiff(today, dtpDOB.Value);
                age = intMonth / 12;
                txtAge.Text = age.ToString();

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void cboPollCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select PollStationName from PollingStationTB where PollCode = '" + cboPollCode.Text + "'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "PollingStationTB");
                DataTable dt = ds.Tables["PollingStationTB"];

                if (dt.Rows.Count != 0)
                {
                    lblStationName.Text = ds.Tables[0].Rows[0][0].ToString();

                }

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
                        picVoterPhoto.Image = Image.FromFile(dlg.FileName);
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

                picVoterPhoto.Image = null;

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
