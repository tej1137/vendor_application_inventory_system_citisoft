using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Software_Development_Project
{
    internal class LoginBE
    {
        public static int login(string username, string password)
        {
            // Initiates variables and constants        
            int pass = 0;
            string dummy = string.Empty;
            bool userCheck;
            bool passCheck;
            string userpriv;

            if (username == "")
            {
                // If username is blank pss = 3 is returned
                pass = 3;
                return pass;
            }

            else if (password == "")
            {
                // If password is blank pss = 3 is returned
                pass = 4;
                return pass;
            }

            // The database class is called and the data is passed in as well as the SQL query
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            userCheck = dbConn.DBcheck("SELECT Username FROM Login_Table WHERE Username = '" + username + "'", username, dummy);
            if (userCheck == true)
            {
                // If the username is found in the database the first check is passed
                pass++;

                passCheck = dbConn.DBcheck("SELECT Password FROM Login_Table WHERE Username = '" + username + "'", username, password);
                if (passCheck == true)
                {
                    // If the password linked to the username entered
                    // matches the one the user entered the second check is passed
                    pass++;
                }
            }
            // pass is returned to let the front end know login has been completed successfully/unsuccessfully
            userpriv = dbConn.checkPrivilage("SELECT User_Privileges FROM Login_Table WHERE Username = '" + username + "'");
            privilage.userPrivilage = userpriv;
            return pass;
        }
    }
}
