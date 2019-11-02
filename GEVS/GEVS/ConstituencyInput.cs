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
    public partial class ConstituencyInput : Form
    {
        public ConstituencyInput()
        {
            InitializeComponent();
        }

        //Load Position description to the comb box
        private void LoadConstituencies()
        {
            try
            {
                string mySelectQuery = "Select ConstName from ConstituencyTB";

                SqlConnection myConnection = new SqlConnection(Globals.connectionString);
                myConnection.Close();
                myConnection.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(mySelectQuery, myConnection);
                DataSet ds1 = new DataSet();


                da1.Fill(ds1, "ConstituencyTB");
                DataTable dt1 = ds1.Tables["ConstituencyTB"];
                myConnection.Close();


                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    cboConstName.Items.Add(dr["ConstName"].ToString());

                }

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void ConstituencyInput_Load(object sender, EventArgs e)
        {
            try
            {
                this.StartPosition = FormStartPosition.CenterScreen;
                LoadConstituencies();
            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboConstName.Text == "")
                {
                    MessageBox.Show("Select a Constituency", "ID input ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboConstName.Focus();
                }
                
                else
                {
                    Globals.strgblConstName = cboConstName.Text;
                    ParliamentaryReport mrParlRep = new ParliamentaryReport();
                    mrParlRep.ShowDialog();
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
                
                    Close();
               

            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            } 
        }
    }
}
