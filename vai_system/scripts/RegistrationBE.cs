using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Software_Development_Project
{
    internal class RegisterBE
    {
        public static int register(string email, string password, string passwordC)
        {
            // Initiates variables and constants
            int pass = 0;
            bool Bool;
            string regex = @"^[^@\s]+@(admin|analyst|engineer)+\.(com|co.uk|net|org|gov)$";

            Bool = Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);

            if (Bool == true)
            {
                // If the email is in the correct format then the first check is passed
                pass++;
            }
            if (password != "" &&  pass == 1)
            {
                // If password is present in the field
                pass++;
            }
            if (password.Length > 7 && pass == 2)
            {
                // If password is at least 8 characters
                pass++;
            }
            if (password == passwordC && pass == 3)
            {
                // If the passwords match then the second check is passed
                pass++;
            }

            if (pass == 4)
            {
                // If both checks are passed the data is readied to be put in the database
                // the email is split into parts becoming both the username and the user priverlage 
                // level as well as also the email itself
                char[] delimiterChars = { '@', '.' };
                string[] words = email.Split(delimiterChars);
                string username = words[0];
                string userpriv = words[1];

                // The database class is called and the data is passed in as well as the SQL query 
                DBConnection dbConn = DBConnection.getInstanceofDBConnection();
                dbConn.saveToDB("INSERT INTO Login_Table(Username, Password, User_Privileges, Email) " +
                    "VALUES (@Username, @Password, @User_Privileges, @Email)", username, password, userpriv, email);

            }
            // pass is returned to let the front end know registration has been completed successfully/unsuccessfully 
            return pass;

        }
    }
}
