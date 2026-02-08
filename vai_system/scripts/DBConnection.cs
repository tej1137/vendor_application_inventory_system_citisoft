using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Software_Development_Project
{
    internal class DBConnection
    {
        //attributes
        //private object of the class itelf
        private static DBConnection _instance;

        //the connection string
        private string dBConnectionString;

        // Connection to the database
        private SqlConnection connToDB;

        //constructor
        private DBConnection()
        {
            //initialise the DB1ConnectionSting
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods

        // static method that gives access to the private object

        public static DBConnection getInstanceofDBConnection()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        //method to get Data out of a Database
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();
           

            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                //send SQL query to the database
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                adapter.Fill(dataset);
            }
            return dataset;
        }


        public bool DBcheck(string sqlQuery, string username, string password)
        {
            // Bool variable hold if the item was found in the database
            bool checkBool = true;

            // If password string is not empty then the program is checking for a password
            if (password != string.Empty)
            {
                // Create an empty datatable
                DataTable dataTable = new DataTable();

                // Using the previously created connection string
                using (connToDB = new SqlConnection(dBConnectionString))
                {
                    // Opens a connection to the database
                    connToDB.Open();

                    // Creates an object dataAdapter to send a query to the database
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                    // Fills in the empty dataset with either nothing if the password does not match
                    // or the password if the password does match
                    dataAdapter.Fill(dataTable);

                    // Closes the connection to the database
                    connToDB.Close();
                }
                // Creates a datatable out of the dataset holding the password if it matched
                string foundPassword;
                DataRow dataRow = dataTable.Rows[0];
                foundPassword = dataRow[0].ToString();
                byte[] s_additionalEntropy = { 9, 8, 7, 6, 5 };
                foundPassword = Encoding.Unicode.GetString(ProtectedData.Unprotect(Convert.FromBase64String(foundPassword), s_additionalEntropy, DataProtectionScope.CurrentUser));

                if (foundPassword != password)
                {
                    // If the password did not matched then checkBool becomes false 
                    // otherwise it stays true 
                    checkBool = false;
                }

                // checkBool is returned letting the login backend know that the password is good/bad
                return checkBool;
            }

            else
            {
                // Create an empty dataset
                DataSet dataSet = new DataSet();

                // Using the previously created connection string
                using (connToDB = new SqlConnection(dBConnectionString))
                {
                    // Opens a connection to the database
                    connToDB.Open();

                    // Creates an object dataAdapter to send a query to the database
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                    // Fills in the empty dataset with either nothing if the username was not found
                    // or the username if it was found
                    dataAdapter.Fill(dataSet);

                    // Closes the connection to the database
                    connToDB.Close();
                }
                // Creates a datatable out of the dataset holding the username if it was found
                DataTable dt = dataSet.Tables[0];
                DataRow[] foundusername = dt.Select("Username = '" + username + "'");
                if (foundusername.Length == 0)
                {
                    // If the username was not found then checkBool becomes false 
                    // otherwise it stays true
                    checkBool = false;
                }
                // checkBool is returned letting the login backend know that the username is good/bad
                return checkBool;
            }

        }

        public void saveToDB(string sqlQuery, string username, string password, string userpriv, string email)
        {
            // Using the previously created connection string
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                byte[] s_additionalEntropy = { 9, 8, 7, 6, 5 };
                password = Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(password), s_additionalEntropy, DataProtectionScope.CurrentUser));

                // Opens a connection to the database
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Sets the SQLCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                // Adds the parameters to the sqlCommand
                sqlCommand.Parameters.Add(new SqlParameter("Username", username));
                sqlCommand.Parameters.Add(new SqlParameter("Password", password));
                sqlCommand.Parameters.Add(new SqlParameter("User_Privileges", userpriv));
                sqlCommand.Parameters.Add(new SqlParameter("Email", email));

                // Executes the SQL command
                sqlCommand.ExecuteNonQuery();

                // Closes the connection to the database
                connToDB.Close();


                privilage.userPrivilage = userpriv;
            }

        }

        public string checkPrivilage(string sqlQuery)
        {
            string dummy = "";

            // Create an empty dataset
            DataSet dataSet = new DataSet();

            // Using the previously created connection string
            using (connToDB = new SqlConnection(dBConnectionString))
            {
                // Opens a connection to the database
                connToDB.Open();

                // Creates an object dataAdapter to send a query to the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                // Fills in the empty dataset with either nothing if the password does not match
                // or the password if the password does match
                dataAdapter.Fill(dataSet);

                // Closes the connection to the database
                connToDB.Close();
            }
            // Creates a datatable out of the dataset 
            DataTable dt = dataSet.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                dummy = row["User_Privileges"].ToString();

            }
            return dummy;
        }

        public DataSet GetDataSet(string sqlQuery)
        {
            //create an empty dataset
            DataSet dataSet = new DataSet();

            using (connToDB = new SqlConnection(dBConnectionString))
            {
                //open the connection
                connToDB.Open();

                //create teh object dataAdapter to send a query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connToDB);

                //fill in the dataset
                dataAdapter.Fill(dataSet);

            }

            return dataSet;
        }

        public void deleteFromDB_ADMIN(string sqlQuery)
        {
            // Using the previously created connection string
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                // Opens a connection to the database
                connToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                // Sets the SQLCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                // Executes the SQL command
                sqlCommand.ExecuteNonQuery();

                // Closes the connection to the database
                connToDB.Close();


            }
        }

        public void editDB(string sqlQuery, string newPassword, string newUserPriv)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                byte[] s_additionalEntropy = { 9, 8, 7, 6, 5 };
                newPassword = Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(newPassword), s_additionalEntropy, DataProtectionScope.CurrentUser));

                // Opens a connection to the database
                connToDB.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, connToDB);
                da.Fill(dt);

                //start the editing of the selected record
                dt.Rows[0].BeginEdit();
                if (newPassword != "")
                {
                    dt.Rows[0][2] = newPassword;
                }

                if (newUserPriv != "")
                {
                    dt.Rows[0][3] = newUserPriv;
                }

                //stop editing
                dt.Rows[0].EndEdit();

                //sql commandbuilder that allow saving of records
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                //update the database
                da.Update(dt);

                //close connection
                connToDB.Close();

            }

        }

        public void EditDatabase(RichTextBox richTextBox1, string sqlText) //Runs the SQL command on the database
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                connToDB.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(sqlText, connToDB); //Loads in the command to the SQL interface
                try
                {
                    cmd.ExecuteNonQuery();
                    richTextBox1.Text = "Table updated.";
                }
                catch (Exception) //Displays error message if user inputs wrong data
                {
                    richTextBox1.Text = "Error! Incorrect parameters.";
                }
            }
        }

        public void deleteFromDB(string sqlQuery, int idToDelete)
        {
            using (SqlConnection connection = new SqlConnection(dBConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    // Assuming you have a parameter named "@ID" in your delete query
                    cmd.Parameters.AddWithValue("@ID", idToDelete);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void saveToDB_INSERT(string sqlQuery, string Company_ID, string Product_Name, string Product_Type, string Product_Description, string Product_Added)
        {
            using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
            {
                //open connection
                connToDB.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add(new SqlParameter("Company_ID", Company_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Product_Name", Product_Name));
                sqlCommand.Parameters.Add(new SqlParameter("Product_Type", Product_Type));
                sqlCommand.Parameters.Add(new SqlParameter("Product_Description", Product_Description));
                sqlCommand.Parameters.Add(new SqlParameter("Product_Added", Product_Added));

                //execute the command
                sqlCommand.ExecuteNonQuery();

            }
        }
    }
}