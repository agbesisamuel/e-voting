using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.IO;
namespace GEVS
{
    public partial class LookUpAccount : Form
    {
        public LookUpAccount()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.TextLength > 1)
                {
                    lstUserAccounts.Items.Clear();
                    Close();
                }
                else if (lstUserAccounts.Items.Count > 0)
                {
                    txtUserName.Text = lstUserAccounts.SelectedItems[0].Text;
                    lstUserAccounts.Items.Clear();
                    Close();
                }
                else
                {
                    Close();
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
                txtUserName.Clear();
                if (lstUserAccounts.Items.Count > 0)
                {
                    lstUserAccounts.Items.Clear();
                    Close();
                }
                Close();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void lstUserAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == (char)13)
                {
                    Close();
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void LookUpAccount_Load(object sender, EventArgs e)
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

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select UserName, Name from UserAccount where Name Like '" + txtEmpName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "UserAccount");
                DataTable dt = ds.Tables["UserAccount"];
                myConnection.Close();

                if (lstUserAccounts.Items.Count > 0)
                {
                    lstUserAccounts.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstUserAccounts.Items.Add(dr["UserName"].ToString());
                    lstUserAccounts.Items[lstUserAccounts.Items.Count - 1].SubItems.Add(dr["Name"].ToString());

                }
                if (lstUserAccounts.Items.Count > 0)
                {
                    lstUserAccounts.TopItem.Selected = true;
                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void lstUserAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                Close();

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}