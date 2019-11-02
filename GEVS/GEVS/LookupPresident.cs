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
    public partial class LookupPresident : Form
    {
        public LookupPresident()
        {
            InitializeComponent();
        }

        private void LookupPresident_Load(object sender, EventArgs e)
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
                    lstPres.Items.Clear();
                    Close();
                }
                else if (lstPres.Items.Count > 0)
                {

                    txtCode.Text = lstPres.SelectedItems[0].Text;
                    lstPres.Items.Clear();
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
                if (lstPres.Items.Count > 0)
                {
                    lstPres.Items.Clear();
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
                string mySelectQuery = "Select PCandNum, PCandName from PresidentialTB where PCandName Like '" + txtName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "PresidentialTB");
                DataTable dt = ds.Tables["PresidentialTB"];
                myConnection.Close();

                if (lstPres.Items.Count > 0)
                {
                    lstPres.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstPres.Items.Add(dr["PCandNum"].ToString());
                    lstPres.Items[lstPres.Items.Count - 1].SubItems.Add(dr["PCandName"].ToString());


                }
                if (lstPres.Items.Count > 0)
                {
                    lstPres.TopItem.Selected = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void lstPres_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lstPres_Click(object sender, EventArgs e)
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
