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
    public partial class LookupConst : Form
    {
        public LookupConst()
        {
            InitializeComponent();
        }

        private void LookupConst_Load(object sender, EventArgs e)
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
                    lstConst.Items.Clear();
                    Close();
                }
                else if (lstConst.Items.Count > 0)
                {
                    txtCode.Text = lstConst.SelectedItems[0].Text;
                    lstConst.Items.Clear();
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
                if (lstConst.Items.Count > 0)
                {
                    lstConst.Items.Clear();
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
                string mySelectQuery = "Select ConstCode, ConstName from ConstituencyTB where ConstName Like '" + txtName.Text + "%'";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds = new DataSet();


                da.Fill(ds, "ConstituencyTB");
                DataTable dt = ds.Tables["ConstituencyTB"];
                myConnection.Close();

                if (lstConst.Items.Count > 0)
                {
                    lstConst.Items.Clear();
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lstConst.Items.Add(dr["ConstCode"].ToString());
                    lstConst.Items[lstConst.Items.Count - 1].SubItems.Add(dr["ConstName"].ToString());
                   

                }
                if (lstConst.Items.Count > 0)
                {
                    lstConst.TopItem.Selected = true;

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
