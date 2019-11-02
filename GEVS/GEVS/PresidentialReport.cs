using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GEVS
{
    public partial class PresidentialReport : Form
    {
        public PresidentialReport()
        {
            InitializeComponent();
        }

        private void crvPresidential_Load(object sender, EventArgs e)
        {
            try
            {

                PresidentialRep myPresR = new PresidentialRep();

                myPresR.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myPresR.Refresh();
                //myPresR.SetParameterValue("StartDate", Convert.ToDateTime(Globals.strStartDate));
                //myPresR.SetParameterValue("EndDate", Convert.ToDateTime(Globals.strEndDate));

                crvPresidential.ReportSource = myPresR;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
