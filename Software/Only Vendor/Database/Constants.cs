using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engenieering_Project
{
    internal class Constants
    {
        //SHOWPREVIEWPRODUCTS: A products preview of selected attributes displayed in the MainMenuedvg Datagrid
        public static string SHOWPREVIEWPRODUCTS = "SELECT Products_Table.Product_Name as 'Product Name', " +
                                                    "Products_Table.Product_Type as 'Type', " +
                                                    "Products_Table.Product_Description as 'Description', " +
                                                    "Products_Table.Product_Rating as 'Rating', " +
                                                    "Companies_Table.Company_Name as 'Company' " +
                                                    "FROM Companies_Table " +
                                                        "INNER JOIN Products_Table " +
                                                            "ON Companies_Table.Company_ID = Products_Table.Company_ID INNER JOIN Products_Capabilities_Table ON Products_Table.Product_ID=Products_Capabilities_Table.Product_ID ";

        //SEARCHVIEWPRODUCTSJOIN: More JOIN statments to extend the product search.
        public static string SEARCHVIEWPRODUCTSJOIN =   "INNER JOIN Products_Capabilities_Table " +
                                                            "ON Products_Table.Product_ID = Products_Capabilities_Table.Product_Capability_ID " +
                                                        "INNER JOIN Financial_Services_Client_Types_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Financial_Services_Client_Types_Table.Financial_Service_Client_Typ_ID " +
                                                        "INNER JOIN Modules_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Modules_Table.Module_ID " +
                                                        "INNER JOIN Business_Areas_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Business_Areas_Table.Business_Area_ID ";
        
        //SHOWPREVIEVENDORS: A vendor preview of selected attributes displayed on the MainMenuedvg Datagrid
        public static string SHOWPREVIEWVENDORS =   "SELECT Company_Name as 'Company Name', " +
                                                    "Company_Website as 'Website', " +
                                                    "Company_Rating as 'Company Rating', " +
                                                    "Company_Last_Review_Date as 'Last Review' " +
                                                    "FROM Companies_Table ";

        //SEARCHVIEWVENDORSSELECT: Extension for the Searchfunction for only Vendors to also include Company Location.
        public static string SEARCHVIEWVENDORSJOIN = "INNER JOIN Companies_Locations_Table " +
                                                                "ON Companies_Table.Company_ID = Companies_Locations_Table.Company_Location_ID ";

        //SEARCHFUNCTION: Searching selected tables
        public static string SEARCHFUNCTION = "SELECT Products_Table.Product_Name as 'Product Name'," +
                                                "Products_Table.Product_Type as 'Type', " +
                                                "Products_Table.Product_Description as 'Description', " +
                                                "Products_Table.Product_Rating as 'Rating', " +
                                                "Companies_Table.Company_Name as 'Company' " +
                                                "FROM Companies_Table " +
                                                    "INNER JOIN Products_Table " +
                                                        "ON Companies_Table.Company_ID = Products_Table.Company_ID " +
                                                    "INNER JOIN Products_Capabilities_Table " +
                                                        "ON Products_Table.Product_ID = Products_Capabilities_Table.Product_Capability_ID " +
                                                    "INNER JOIN Financial_Services_Client_Types_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Financial_Services_Client_Types_Table.Financial_Service_Client_Typ_ID " +
                                                    "INNER JOIN Modules_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Modules_Table.Module_ID " +
                                                    "INNER JOIN Business_Areas_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Business_Areas_Table.Business_Area_ID " +
                                                    SEARCHVIEWVENDORSJOIN;
    }
}