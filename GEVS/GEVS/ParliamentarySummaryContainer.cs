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
    public partial class ParliamentarySummaryContainer : Form
    {
        public ParliamentarySummaryContainer()
        {
            InitializeComponent();
        }

        private void crvParliamentarySummar_Load(object sender, EventArgs e)
        {
            try
            {

                ParliamentarySummaryRep myPalumRep = new ParliamentarySummaryRep();

                myPalumRep.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myPalumRep.Refresh();
                //myPalumRep.PrintToPrinter(1, false, 0, 0);
                crvParliamentarySummar.ReportSource = myPalumRep;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
