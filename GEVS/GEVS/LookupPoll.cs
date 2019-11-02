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
    public partial class LookupPoll : Form
    {
        public LookupPoll()
        {
            InitializeComponent();
        }

        private void LookupPoll_Load(object sender, EventArgs e)
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
                    lstPoll.Items.Clear();
                    Close();
                }
                else if (lstPoll.Items.Count > 0)
                {
                    txtCode.Text = lstPoll.SelectedItems[0].Text;
                    lstPoll.Items.Clear();
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
                if (lstPoll.Items.Count > 0)
                {
                    lstPoll.Items.Clear();
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
                string mySelectQuery = "Select PollCode, PollStationName from PollingStationTB where PollCode Like '" + txtName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "PollingStationTB");
                DataTable dt = ds.Tables["PollingStationTB"];
                myConnection.Close();

                if (lstPoll.Items.Count > 0)
                {
                    lstPoll.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstPoll.Items.Add(dr["PollCode"].ToString());
                    lstPoll.Items[lstPoll.Items.Count - 1].SubItems.Add(dr["PollStationName"].ToString());


                }
                if (lstPoll.Items.Count > 0)
                {
                    lstPoll.TopItem.Selected = true;

                }
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void lstConst_Click(object sender, EventArgs e)
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

        private void lstConst_KeyPress(object sender, KeyPressEventArgs e)
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
