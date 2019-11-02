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
    public partial class VoterLookup : Form
    {
        public VoterLookup()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVoterID.TextLength>1){
                    lstVoters.Items.Clear();
                    Close();
                }
                else if (lstVoters.Items.Count > 0)
                {
                    txtVoterID.Text = lstVoters.SelectedItems[0].Text;
                    lstVoters.Items.Clear();
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
                txtVoterID.Clear();
                if (lstVoters.Items.Count > 0)
                {
                    lstVoters.Items.Clear();
                    Close();
                }
                Close();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select VoterID, LName,FName from VoterRegisterTB where LName Like '" + txtLName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "VoterRegisterTB");
                DataTable dt = ds.Tables["VoterRegisterTB"];
                myConnection.Close();

                if (lstVoters.Items.Count > 0)
                {
                    lstVoters.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstVoters.Items.Add(dr["VoterID"].ToString());
                    lstVoters.Items[lstVoters.Items.Count - 1].SubItems.Add(dr["LName"].ToString());
                    lstVoters.Items[lstVoters.Items.Count - 1].SubItems.Add(dr["FName"].ToString());

                }
                if (lstVoters.Items.Count > 0)
                {
                    lstVoters.TopItem.Selected = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        

        
        private void VoterLookup_Load(object sender, EventArgs e)
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

        private void lstVoters_Click(object sender, EventArgs e)
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

        private void lstVoters_KeyPress(object sender, KeyPressEventArgs e)
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
