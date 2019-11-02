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
    public partial class ParliamentaryReport : Form
    {
        public ParliamentaryReport()
        {
            InitializeComponent();
        }

        private void crvParliamentaryRep_Load(object sender, EventArgs e)
        {
            try
            {

                ParliamentaryRep myParlRep = new ParliamentaryRep();

                myParlRep.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myParlRep.Refresh();
                myParlRep.SetParameterValue("ConstituencyName", Globals.strgblConstName);

                crvParliamentaryRep.ReportSource = myParlRep;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
