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
    public partial class LookupParliamentary : Form
    {
        public LookupParliamentary()
        {
            InitializeComponent();
        }

        private void LookupParliamentary_Load(object sender, EventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.TextLength > 1)
                {
                    lstParl.Items.Clear();
                    Close();
                }
                else if (lstParl.Items.Count > 0)
                {

                    txtCode.Text = lstParl.SelectedItems[0].Text;
                    lstParl.Items.Clear();
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
                txtCode.Clear();
                if (lstParl.Items.Count > 0)
                {
                    lstParl.Items.Clear();
                    Close();
                }
                Close();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mySelectQuery = "Select CandNum, CandName,CandPhoto, PartyName, PartyLogo, ConstCode, VoteCount from ParliamentaryTB where CandName Like '" + txtName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "ParliamentaryTB");
                DataTable dt = ds.Tables["ParliamentaryTB"];
                myConnection.Close();

                if (lstParl.Items.Count > 0)
                {
                    lstParl.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstParl.Items.Add(dr["CandNum"].ToString());
                    lstParl.Items[lstParl.Items.Count - 1].SubItems.Add(dr["CandName"].ToString());
                  

                }
                if (lstParl.Items.Count > 0)
                {
                    lstParl.TopItem.Selected = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        

        private void lstParl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lstParl_Click(object sender, EventArgs e)
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
