using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace GEVS
{
    public partial class UserAccounts : Form
    {
        public UserAccounts()
        {
            InitializeComponent();
        }

        private void locktextbox()
        {
            try
            {

                chkChangePin.Enabled = false;
                chkLockAcc.Enabled = false;
                optAdmin.Enabled = false;
                optOperator.Enabled = false;
               // cboDept.Enabled = false;

                
                txtEmpName.ReadOnly = true;
                txtEmailAddress.ReadOnly = true;
                txtConfirm.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtTelNo.ReadOnly = true;
               // txtDivision.ReadOnly = true;
                txtUserName.ReadOnly = true;

                dtpDCreated.Enabled = false;
                

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
                chkChangePin.Enabled = true;
                chkLockAcc.Enabled = true;
                optAdmin.Enabled = true;
                optOperator.Enabled = true;
                //cboDept.Enabled = true;

                
                txtEmpName.ReadOnly = false;
                txtEmailAddress.ReadOnly = false;
                txtConfirm.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtTelNo.ReadOnly = false;
                txtUserName.ReadOnly = false;
                txtUserName.ReadOnly = false;
                //txtDivision.ReadOnly = false;
                dtpDCreated.Enabled = true;
                
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
                txtEmpName.Clear();
                txtEmailAddress.Clear();
                txtConfirm.Clear();
                txtPassword.Clear();
                txtTelNo.Clear();
                txtUserName.Clear();
                //txtDivision.Clear();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        //
        public string encryptPassword(string strText)
        {

            return Encrypt(strText, "&%#@?,:*");
        }

        public string decryptPassword(string str)
        {

            return Decrypt(str, "&%#@?,:*");
        }


        private string Encrypt(string strText, string strEncrypt)
        {
            byte[] byKey = new byte[20];
            byte[] dv ={ 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrypt.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputArray = System.Text.Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, dv), CryptoStreamMode.Write);
                cs.Write(inputArray, 0, inputArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string Decrypt(string strText, string strEncrypt)
        {
            byte[] bKey = new byte[20];
            byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                bKey = System.Text.Encoding.UTF8.GetBytes(strEncrypt.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                Byte[] inputByteArray = inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length); cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8; return encoding.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UserAccounts_Load(object sender, EventArgs e)
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
                txtEmpName.Focus();
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
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Employee Name can't be empty");
                    txtEmpName.Focus();
                }
                
                else if (txtUserName.Text == "")
                {
                    MessageBox.Show("User Name can't be empty");
                    txtUserName.Focus();
                }

                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password can't be empty");
                    txtPassword.Focus();
                }
                else if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password Mismatch");
                    txtPassword.Focus();
                }
                else if (optAdmin.Checked == false && optOperator.Checked == false)
                {
                    MessageBox.Show("Select an account type");
                    optOperator.Focus();
                }
                else
                {
                    string mySelectQuery = "Select * from UserAccount where UserName = '" + txtUserName.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "UserAccount");
                    DataTable dt = ds.Tables["UserAccount"];
                    myConnection.Close();

                    if (dt.Rows.Count == 0)
                    {
                        string strChangePin;
                        string strLockAccount;
                        string strAccType;

                        if (chkChangePin.Checked == true)
                        {
                            strChangePin = "Y";
                        }
                        else
                        {
                            strChangePin = "N";
                        }

                        if (chkLockAcc.Checked == true)
                        {
                            strLockAccount = "Y";
                        }
                        else
                        {
                            strLockAccount = "N";
                        }

                        if (optAdmin.Checked == true)
                        {
                            strAccType = "ADMIN";
                        }
                        else
                        {
                            strAccType = "OPERATOR";
                        }

                        string strPIN = encryptPassword(txtPassword.Text);
                        mySelectQuery = "Insert into UserAccount" +
                                        "(PIN,UserName, Name, Email, UserPhone, DCreated, ChangePIN, LockAccount, AccType) " +
                                        " Values ('" + strPIN.ToString() + "','" + txtUserName.Text + "','" + txtEmpName.Text.ToUpper() + "'," +
                                        "'" + txtEmailAddress.Text + "'," +
                                        "'" + txtTelNo.Text + "','" + dtpDCreated.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" + strChangePin.ToString() + "'," +
                                        "'" + strLockAccount.ToString() + "','" + strAccType.ToString() + "')";

                
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
                        MessageBox.Show("User Name Already Exist", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        myConnection.Close();
                        txtUserName.Focus();
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
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("No Record to edit", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    unlocktextbox();
                    dtpDCreated.Enabled = false;
                    btnModify.Enabled = false;
                    btnModify.Visible = false;

                    btnUpdate.Enabled = true;
                    btnUpdate.Visible = true;

                    btnCancel.Enabled = true;

                    btnCreate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    btnSearch.Enabled = false;
                    txtUserName.ReadOnly = true;
                    txtEmpName.Focus();
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
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Employee Name can't be empty");
                    txtEmpName.Focus();
                }
                
                else if (txtUserName.Text == "")
                {
                    MessageBox.Show("User Name can't be empty");
                    txtUserName.Focus();
                }

                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password can't be empty");
                    txtPassword.Focus();
                }
                else if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password Mismatch");
                    txtPassword.Focus();
                }
                else if (optAdmin.Checked == false && optOperator.Checked == false)
                {
                    MessageBox.Show("Select an account type");
                    optOperator.Focus();
                }
                else
                {
                    string strChangePin;
                    string strLockAccount;
                    string strAccType;

                    if (chkChangePin.Checked == true)
                    {
                        strChangePin = "Y";
                    }
                    else
                    {
                        strChangePin = "N";
                    }

                    if (chkLockAcc.Checked == true)
                    {
                        strLockAccount = "Y";
                    }
                    else
                    {
                        strLockAccount = "N";
                    }

                    if (optAdmin.Checked == true)
                    {
                        strAccType = "ADMIN";
                    }
                    else
                    {
                        strAccType = "OPERATOR";
                    }

                    string strPIN = encryptPassword(txtPassword.Text);

                    string mySelectQuery = "Update UserAccount" +
                                " Set PIN = '" + strPIN.ToString() + "', Name= '" + txtEmpName.Text.ToUpper() + "'," +
                               
                                " Email='" + txtEmailAddress.Text + "'," +
                               
                                " UserPhone='" + txtTelNo.Text + "'," +
                                " ChangePIN ='" + strChangePin.ToString() + "', LockAccount ='" + strLockAccount.ToString() + "'," +
                                " AccType ='" + strAccType.ToString() + "'" +
                                " where UserName ='" + txtUserName.Text + "'";

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
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("No record to delete", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Sure to delete?", "Deleting records", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string mySelectQuery = "Delete from UserAccount where UserName = '" + txtUserName.Text + "'";
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
                string strChangePin;
                string strLockAccount;
                string strAccType;

                LookUpAccount UAcc = new LookUpAccount();
                UAcc.ShowDialog();


                if (UAcc.lstUserAccounts.SelectedItems.Count > 0)
                {
                    txtUserName.Text = UAcc.lstUserAccounts.SelectedItems[0].Text;


                    string mySelectQuery = "Select PIN, UserName, Name,  Email, UserPhone, DCreated, ChangePIN, LockAccount, AccType from UserAccount where UserName = '" + txtUserName.Text + "'";

                    SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                    myConnection.Close();
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "UserAccount");
                    DataTable dt = ds.Tables["UserAccount"];

                    txtPassword.Text = decryptPassword(ds.Tables[0].Rows[0][0].ToString());
                    txtConfirm.Text = txtPassword.Text.ToString();
                    txtUserName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtEmpName.Text = ds.Tables[0].Rows[0][2].ToString();
                    
                    txtEmailAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtTelNo.Text = ds.Tables[0].Rows[0][4].ToString();
                    dtpDCreated.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][5]);

                    strChangePin = ds.Tables[0].Rows[0][6].ToString();
                    strLockAccount = ds.Tables[0].Rows[0][7].ToString();
                    strAccType = ds.Tables[0].Rows[0][8].ToString();


                    if (strChangePin == "Y")
                    {
                        chkChangePin.Checked = true;
                    }
                    else
                    {
                        chkChangePin.Checked = false;
                    }

                    if (strLockAccount == "Y")
                    {
                        chkLockAcc.Checked = true;

                    }
                    else
                    {
                        chkLockAcc.Checked = false;
                    }

                    if (strAccType == "ADMIN")
                    {
                        optAdmin.Checked = true;
                    }
                    else
                    {
                        optOperator.Checked = true;
                    }
                    myConnection.Close();
                }
                else
                {
                    if (UAcc.txtUserName.Text != "")
                    {
                        string mySelectQuery = "Select PIN, UserName, Name,  Email, UserPhone, DCreated, ChangePIN, LockAccount, AccType from UserAccount where UserName = '" + UAcc.txtUserName.Text + "'";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        myConnection.Close();
                        myConnection.Open();
                        SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "FoodDeatils");
                        DataTable dt = ds.Tables["FoodDeatils"];
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Record found", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtPassword.Text = decryptPassword(ds.Tables[0].Rows[0][0].ToString());
                            txtConfirm.Text = txtPassword.Text.ToString();
                            txtUserName.Text = ds.Tables[0].Rows[0][1].ToString();
                            txtEmpName.Text = ds.Tables[0].Rows[0][2].ToString();

                           
                            txtEmailAddress.Text = ds.Tables[0].Rows[0][3].ToString();
                            txtTelNo.Text = ds.Tables[0].Rows[0][4].ToString();
                            dtpDCreated.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][5]);

                            strChangePin = ds.Tables[0].Rows[0][6].ToString();
                            strLockAccount = ds.Tables[0].Rows[0][7].ToString();
                            strAccType = ds.Tables[0].Rows[0][8].ToString();


                            if (strChangePin == "Y")
                            {
                                chkChangePin.Checked = true;
                            }
                            else
                            {
                                chkChangePin.Checked = false;
                            }

                            if (strLockAccount == "Y")
                            {
                                chkLockAcc.Checked = true;

                            }
                            else
                            {
                                chkLockAcc.Checked = false;
                            }

                            if (strAccType == "ADMIN")
                            {
                                optAdmin.Checked = true;
                            }
                            else
                            {
                                optOperator.Checked = true;
                            }
                        }
                    }
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && (e.KeyChar < (char)65 || e.KeyChar > (char)90 && (e.KeyChar < (char)97 || e.KeyChar > (char)122)) && (e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar !='-'))
                {
                    e.Handled = true;
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && (e.KeyChar < (char)65 || e.KeyChar > (char)90 && (e.KeyChar < (char)97 || e.KeyChar > (char)122)) && (e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if ((e.KeyChar < (char)48 || e.KeyChar > (char)57) && (e.KeyChar < (char)65 || e.KeyChar > (char)90 && (e.KeyChar < (char)97 || e.KeyChar > (char)122)) && (e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != '-'))
                {
                    e.Handled = true;
                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        
    }
}