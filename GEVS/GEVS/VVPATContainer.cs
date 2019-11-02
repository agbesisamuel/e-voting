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
    public partial class VVPATContainer : Form
    {
        public VVPATContainer()
        {
            InitializeComponent();
        }

        private void crvVVPAT_Load(object sender, EventArgs e)
        {

            try
            {

                VotePrintout myVotePrn = new VotePrintout();


                myVotePrn.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myVotePrn.Refresh();
                myVotePrn.SetParameterValue("myVVPAT", Globals.strTID);
                myVotePrn.PrintToPrinter(1, false, 0, 0);
               // crvVVPAT.ReportSource = myVotePrn;
            }


            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }  
    }
}
