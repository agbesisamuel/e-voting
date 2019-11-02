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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccounts lA = new UserAccounts();
                MainGEVS MH = new MainGEVS();


                if (txtNewPassword.Text == "")
                {
                    string mySelectQuery = "Select PIN, UserName, ChangePIN, LockAccount, AccType  from UserAccount where UserName = '" + txtUserName.Text + "' and PIN ='" + lA.encryptPassword(txtPassword.Text) + "'";

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
                        MessageBox.Show("Account does not exist");
                        txtPassword.Focus();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "Y")
                    {
                        MessageBox.Show("Account is locked; contact administrator");
                        txtUserName.Focus();
                    }

                    else
                    {
                        if (ds.Tables[0].Rows[0][2].ToString() == "Y")
                        {
                            //This where user have to change password at first login
                            this.Width = 324;
                            this.Height = 242;

                            grpLogin.Width = 310;
                            grpLogin.Height = 127;


                            btnOK.Location = new System.Drawing.Point(129, 180);
                            btnCancel.Location = new System.Drawing.Point(210, 180);

                            txtNewPassword.Enabled = true;
                            txtConfirm.Enabled = true;
                            txtNewPassword.Focus();

                            Globals.strUserID = ds.Tables[0].Rows[0][1].ToString();
                            Globals.strAccType = ds.Tables[0].Rows[0][4].ToString();
                        }
                        else
                        {

                            Globals.strUserID = ds.Tables[0].Rows[0][1].ToString();
                            Globals.strAccType = ds.Tables[0].Rows[0][4].ToString();



                            Close();
                        }
                    }
                }
                else
                {
                    //validating the change password
                    if (txtNewPassword.Text != txtConfirm.Text)
                    {
                        MessageBox.Show("Password Mismatch");
                        txtNewPassword.Focus();
                    }
                    else
                    {

                        string mySelectQuery = "Update UserAccount" +
                                " Set PIN = '" + lA.encryptPassword(txtNewPassword.Text) + "'," +
                                " ChangePin = 'N'" +
                                " where UserName ='" + txtUserName.Text + "'";

                        SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                        SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                        myConnection.Open();
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();


                        Close();
                    }
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
                Application.Exit();
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

        

       

      

    }
}
