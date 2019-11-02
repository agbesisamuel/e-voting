using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace GEVS
{
    class Globals
    {
        public static string strStartDate, strEndDate, strPresID, strParlID, strgblVoterID, strgblCodeNumber, strVoterName,strPollCode, strgblConstName, strTID;
        public static string strUser = "Agbesi", strPassword = "samlina", strDatabase = "VOTINGDB", strServer = "SERVERPC";

        public static string connectionString;



        public static string strHostIP;
        public static string strHostName;

        public static string strUserID, strAccType;
      


        public static bool IsNumeric(string thevalue)
        {
            try
            {
                Convert.ToDouble(thevalue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsDate(string thevalue)
        {
            try
            {
                Convert.ToDateTime(thevalue);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Method for getting the Host name and IP Address
        public static string PCInfo()
        {

            strHostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                strHostIP = addr[i].ToString();
            }

            return strHostIP;
        }
    }
}
