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
    public partial class CodeNotUsedReport : Form
    {
        public CodeNotUsedReport()
        {
            InitializeComponent();
        }

        private void crvCodeNotUsed_Load(object sender, EventArgs e)
        {
            try
            {

                CodesNotUsed myCodNUsed = new CodesNotUsed();

                myCodNUsed.SetDatabaseLogon(Globals.strUser, Globals.strPassword, Globals.strServer, Globals.strDatabase);
                myCodNUsed.Refresh();

                crvCodeNotUsed.ReportSource = myCodNUsed;


            }
            catch (Exception j)
            {
                MessageBox.Show("Error: " + j);
            }
        }
    }
}
