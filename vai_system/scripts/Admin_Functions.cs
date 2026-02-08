using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Software_Development_Project
{
    internal class Admin_Functions
    {
        public static DataSet loadDB()
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dsUsers = dbConn.GetDataSet("SELECT * FROM Login_Table");
            return dsUsers;

        }

        public static void deleteFromDB(string username)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            dbConn.deleteFromDB_ADMIN("DELETE FROM Login_Table WHERE Username ='" + username + "'");

        }

        public static void editDB(string username, string newpassword, string newuserpriv)
        {
            if (username != "")
            {
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                dbConn.editDB("SELECT * FROM Login_Table WHERE Username ='" + username + "'", newpassword, newuserpriv);
            }

        }
    }
}
