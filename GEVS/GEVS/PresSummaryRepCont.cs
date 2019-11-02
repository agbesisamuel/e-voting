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
    public partial class PresSummaryRepCont : Form
    {
        public PresSummaryRepCont()
        {
            InitializeComponent();
        }

        private void crvPreSummary_Load(object sender, EventArgs e)
        {
            try
            {

                PresidentSummaryReport myPSumRep= new PresidentSummaryReport();

                myPSumRep.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myPSumRep.Refresh();

                crvPreSummary.ReportSource = myPSumRep;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }

        

       
    }
}
