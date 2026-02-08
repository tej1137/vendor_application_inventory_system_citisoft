using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Project
{
    internal class Constants
    {

        //Main Menu Constants
        //Filter, Categories Names
        public static string ProductFilters = "Product Filters";
         
        public static string VendorFilters = "Vendor Filters";
        
        //SHOWPREVIEWPRODUCTS: A products preview of selected attributes displayed in the MainMenuedvg Datagrid
        public static string SHOWPREVIEWPRODUCTS = "SELECT Products_Table.Product_Name as 'Product Name', " +
                                                    "Products_Table.Product_Type as 'Type', " +
                                                    "Products_Table.Product_Description as 'Description', " +
                                                    "Products_Table.Product_Rating as 'Rating', " +
                                                    "Companies_Table.Company_Name as 'Company', " +
                                                    "Products_Capabilities_Table.Product_Capability_Attachment as 'PDF', " +
                                                    "Products_Capabilities_Table.Product_Capability_Attachment_PDF " +
                                                    "FROM Companies_Table " +
                                                        "INNER JOIN Products_Table " +
                                                            "ON Companies_Table.Company_ID = Products_Table.Company_ID " +
                                                        "INNER JOIN Products_Capabilities_Table " +
                                                            "ON Products_Table.Product_ID = Products_Capabilities_Table.Product_ID ";

        //SEARCHVIEWPRODUCTSJOIN: More JOIN statements to extend the product search.
        public static string SEARCHVIEWPRODUCTSJOIN = "INNER JOIN Financial_Services_Client_Types_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Financial_Services_Client_Types_Table.Product_Capability_ID " +
                                                        "INNER JOIN Modules_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Modules_Table.Product_Capability_ID " +
                                                        "INNER JOIN Business_Areas_Table " +
                                                            "ON Products_Capabilities_Table.Product_Capability_ID = Business_Areas_Table.Product_Capability_ID ";

        //SHOWPREVIEVENDORS: A vendor preview of selected attributes displayed on the MainMenuedvg Datagrid
        public static string SHOWPREVIEWVENDORS = "SELECT Company_Name as 'Company Name', " +
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
                                                        "ON Products_Table.Product_ID = Products_Capabilities_Table.Product_ID " +
                                                    "INNER JOIN Financial_Services_Client_Types_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Financial_Services_Client_Types_Table.Product_Capability_ID " +
                                                    "INNER JOIN Modules_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Modules_Table.Product_Capability_ID " +
                                                    "INNER JOIN Business_Areas_Table " +
                                                        "ON Products_Capabilities_Table.Product_Capability_ID = Business_Areas_Table.Product_Capability_ID " +
                                                    SEARCHVIEWVENDORSJOIN;

        //Searchfunction
        public static string Precent = "%'";

        public static string EndPrecent = "%';";

        //Searchfunction WHERE statements for Vendors and also Search All
        public static string WHERECompanyName = " WHERE Companies_Table.Company_Name LIKE '%";

        public static string WHERECompanyEstablished = " OR Companies_Table.Company_Established LIKE '%";

        public static string WHERECompanyNumberEmployees = " OR Companies_Table.Company_Number_Employees LIKE '%";

        public static string WHERECompanyLastDemoDate = " OR Companies_Table.Company_Last_Demo_Date LIKE '%";

        public static string WHERECompanyLastReviewDate = " OR Companies_Table.Company_Last_Review_Date LIKE '%";

        public static string WHERECompanyRating = " OR Companies_Table.Company_Rating LIKE '%";

        public static string WHERECompanyLocationCountry = " OR Companies_Locations_Table.Company_Location_Country LIKE '%";

        public static string WHERECompanyLocationCity = " OR Companies_Locations_Table.Company_Location_City LIKE '%";

        public static string WHERECompanyLocationTelephoneNumber = " OR Companies_Locations_Table.Company_Location_Telephone_Number LIKE '%";

        public static string WHERECompanyLocationAddress = " OR Companies_Locations_Table.Company_Location_Address LIKE '%";

        //Searchfunction WHERE statements for Products and also Search All
        public static string WHEREProductName = " WHERE Products_Table.Product_Name LIKE '%";
       
        public static string WHEREProductTyp = " OR Products_Table.Product_Type LIKE '%";
        
        public static string WHEREProductDescription = " OR Products_Table.Product_Description LIKE '%";
        
        public static string WHEREProductRating = " OR Products_Table.Product_Rating LIKE '%";

        public static string WHERECompanyNameProduct = " OR Companies_Table.Company_Name LIKE '%";

        public static string WHEREProductCapabilityAdditionalInfo = " OR Products_Capabilities_Table.Product_Capability_Additional_Info LIKE '%";
        
        public static string WHEREFinancialServiceClientTyp = " OR Financial_Services_Client_Types_Table.Financial_Service_Client_Typ LIKE '%";
        
        public static string WHEREBusinessArea = " OR Business_Areas_Table.Business_Area LIKE '%";
        
        public static string WHEREModule = " OR Modules_Table.Module LIKE '%";

        //Searchfunction WHERE statements for Search All
        public static string WHEREProductNameSearchAll = " OR Products_Table.Product_Name LIKE '%";

        //Filter SQL Statements

        //representative SQL statement no way of recognising a popularity yet. Concept a database entry that counts how often a company was selecte/frmforms were opened 
        public static string PRODUCTPopularityASC = " ORDER BY Products_Table.Product_Added ASC";
        
        //representative SQL statement no way of recognising a popularity yet. Concept a database entry that counts how often a company was selecte/frmforms were opened 
        public static string COMPANYPopularityASC = " ORDER BY Companies_Table.Company_Added ASC";

        public static string PRODUCTBestRating = " ORDER BY Products_Table.Product_Rating DESC";

        public static string COMPANYBestRating = " ORDER BY Companies_Table.Company_Rating DESC";

        public static string PRODUCTAZ = " ORDER BY Products_Table.Product_Name ASC";

        public static string COMPANYAZ = " ORDER BY Companies_Table.Company_Name ASC";

        public static string PRODCUTZA = " ORDER BY Products_Table.Product_Name DESC";

        public static string COMPANYZA = " ORDER BY Companies_Table.Company_Name DESC";

        //representative SQL statement is showing products in wrongly order no concept for a proper few.
        public static string PRODCUTNewestFirst = " ORDER BY Products_Table.Product_Added ASC";

        //representative SQL statement is showing products in wrongly order no concept for a proper few.
        public static string COMPANYNewestFirst = " ORDER BY Companies_Table.Company_Added ASC";

        //representative SQL statement is showing products in wrongly order no concept for a proper few.
        public static string PRODCUTOldestFirst = " ORDER BY Products_Table.Product_Added DESC";

        //representative SQL statement is showing products in wrongly order no concept for a proper few.
        public static string COMPANYOldestFirst = " ORDER BY Companies_Table.Company_Added DESC";

        //frmCategoires Constants
        
        //byte shows which category was selected
        public static byte categoryState;

        //saves the selected category into a string
        public static string selectedCategory;

        public static string ProductTypes = "Product Types";

        public static string Modules = "Modules";

        public static string ClientTypes = "Client Types";

        public static string DISTINCTProductTypes = "SELECT DISTINCT Products_Table.Product_Type as 'Type' FROM Products_Table";

        public static string DISTINCTModules = "SELECT DISTINCT Modules_Table.Module as 'Module' FROM Modules_Table";

        public static string DISTINCTClientTypes = "SELECT DISTINCT Financial_Services_Client_Types_Table.Financial_Service_Client_Typ as 'Client Type' FROM Financial_Services_Client_Types_Table";

        public static string ProductTypeLIKE = " WHERE Products_Table.Product_Type LIKE '%";

        public static string ModuleLIKE = " WHERE Modules_Table.Module LIKE '%";

        public static string ClientTypLIKE = " WHERE Financial_Services_Client_Types_Table.Financial_Service_Client_Typ LIKE '%";


        public static string SELECTALL = "SELECT * FROM Products_Table";
        public static string INSERT_Product_IN_DB = "INSERT INTO Products_Table(Company_ID, Product_Name, Product_Type, Product_Description, Product_Added) VALUES (@Company_ID, @Product_Name, @Product_Type, @Product_Description, @Product_Added)";
    }
}