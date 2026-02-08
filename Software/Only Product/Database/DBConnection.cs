using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engenieering_Project
{
    internal class DBConnection
    {
        //attributes
        //private object of the class itelf
        private static DBConnection _instance;

        //the connection string
        private string dBConnectionString;


        //constructor
        private DBConnection()
        {
            //initialise the DB1ConnectionSting
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        /*
         * static method that gives access to the private object
         */
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
    }
}
