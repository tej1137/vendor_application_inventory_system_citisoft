using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Software_Engenieering_Project
{
    public partial class Main_Menu : Form
    {
        //boolean to switch the filters from products to vendors vice versa
        bool vendorLoaded = false;
        bool productloaded = false;
        public Main_Menu()
        {
            InitializeComponent();
        }

        //Loading Products/Vendors
        private void button_ViewProducts_Click(object sender, EventArgs e)
        {
            //"MainMenuedvg.Columns.Clear();" is used through the whole project to clear the display to ensure the queries are displayed freshly/correctly 
            MainMenuedvg.Columns.Clear();

            //connecting, getting, and loading requiert information from Database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();

            //getting data with query. Check file "Constants.cs" string "SHOWPREVIEWPRODUCTS" for exact query 
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);

            //data set is being loaded into the DataGridView
            MainMenuedvg.DataSource = dataset.Tables[0];
            // Hide URl for product details
            MainMenuedvg.Columns[6].Visible= false;
            //"vendorLoaded" makes it possible to have a switch in the programm so the programm can change from product-view to vendor-view
            vendorLoaded = false;

            //"label.Text" renaming Labels so they fit in which view (product-view/vendor-view)
            label_Filter.Text = "Product Filters";
            label_Categories.Text = "Product Categories";

            //"unselectButtons();" makes sure buttons are being fresly selectable after changing view.
            unselectButtons();

            //"radioButton_search.Checked" makes sure the searchbar is in right mod and connected to the the current selected view (product-view/vendor-view)
            radioButton_searchVendors.Checked = false;
            radioButton_searchProducts.Checked = true;
            productloaded = true;

        }

        private void button_ViewVendors_Click(object sender, EventArgs e)
        {
            //"MainMenuedvg.Columns.Clear();" is used through the whole project to clear the display to ensure the queries are displayed freshly/correctly 
            MainMenuedvg.Columns.Clear();

            //connecting with database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();

            //getting data with query. Check file "Constants.cs" string "SHOWPREVIEWVENDORS" for exact query
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS);

            //data set is being loaded into the DataGridView
            MainMenuedvg.DataSource = dataset.Tables[0];
            
            //program switched to vendor-view 
            vendorLoaded = true;

            //"label.Text" changing labels for vendor mode
            label_Filter.Text = "Vendor Filters";
            label_Categories.Text = "Vendor Categories";

            //"unselectButtons();" makes sure buttons are being fresly selectable after changing view.
            unselectButtons();

            //Searchbar is in vendor-view 
            radioButton_searchVendors.Checked = true;
            radioButton_searchProducts.Checked = false;
        }

        //Filters
        //only one radio button can be selected at a time.
        private void radioButton_Popularity_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //more quieries. check file "Constants" string "SHOWPREVIEWPRODUCTS" for specifics
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Added ASC");

                //loading into DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];

                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //more quieries. check file "Constants"
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Added ASC");
                //loading into DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
           
        }

        private void radioButton_BestRating_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //more quieries. check file "Constants"
                //Product rating sorted by DESC so highest rating is shown first
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Rating DESC");
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //more quieries. check file "Constants"
                //Company rating sorted by DESC so highest rating is shown first
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Rating DESC");

                //loading into DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            
        }

        private void radioButton_AZ_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //Product names sorted by ACS (Alphabetically A-Z)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name ASC");
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Companies names sorted by ACS (Alphabetically A-Z)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Name ASC");

                MainMenuedvg.DataSource = dataset.Tables[0];
            }
           
        }

        private void radioButton_ZA_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //Product names sorted by ACS (Alphabetically Z-A)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Name DESC");

                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Company names sorted by ACS (Alphabetically Z-A)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Name DESC");

                MainMenuedvg.DataSource = dataset.Tables[0];

            }
        }

        private void radioButton_NewestFirst_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //Product Added is a tempory value because there is not proper concept for an Attribute when a product is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Added ASC");

                MainMenuedvg.DataSource = dataset.Tables[0];

                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Company Added is a tempory value because there is not proper concept for an Attribute when a company is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Added ASC");

                MainMenuedvg.DataSource = dataset.Tables[0];

            }

        }

        private void radioButton_OldestFirst_CheckedChanged(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (vendorLoaded == false)
            {
                //Product Added is a tempory value because there is not proper concept for an Attribute when a product is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + " ORDER BY Products_Table.Product_Added DESC");

                MainMenuedvg.DataSource = dataset.Tables[0];

                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;

            }
            else
            {
                //Company Added is a tempory value because there is not proper concept for an Attribute when a company is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + " ORDER BY Companies_Table.Company_Added DESC");

                MainMenuedvg.DataSource = dataset.Tables[0];

            }
        }
        
        //Searchbar
        private void textBox_Searchbox_TextChanged(object sender, EventArgs e)
        {
            //Data grid is refreshed every time a new letter is typed.
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;
            unselectButtons();
            MainMenuedvg.Columns.Clear();
            if (radioButton_searchVendors.Checked == true)
            {
                //"button_ViewVendors.PerformClick();" switches to the right vie (product-view/vendor-view)
                button_ViewVendors.PerformClick();

                //The WHERE SQL query part could not be moved into the file constant because of variable (textBox_Searchbox.Text) used in the query
                //Over ways of using temporary variables in the file constant failed
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.SEARCHVIEWVENDORSJOIN + 
                                                    " WHERE Companies_Table.Company_Name LIKE '%" + textBox_Searchbox.Text + "%' " +
                                                    " OR Companies_Table.Company_Established LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Number_Employees LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Demo_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Review_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Rating LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Demo_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Review_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Country LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_City LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Telephone_Number LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Address LIKE '%" + textBox_Searchbox.Text + "%';");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else if(radioButton_searchProducts.Checked == true)
            {
                //"button_ViewVendors.PerformClick();" switches to the right vie (product-view/vendor-view
                button_ViewProducts.PerformClick();

                //The WHERE SQL query part could not be moved into the file constant because of variable (textBox_Searchbox.Text) used in the query
                //Over ways of using temporary variables in the file constant failed
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.SEARCHVIEWPRODUCTSJOIN +
                                                    " WHERE Products_Table.Product_Name LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Type LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Description LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Rating LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Name LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Capabilities_Table.Product_Capability_Additional_Info LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Financial_Services_Client_Types_Table.Financial_Service_Client_Typ LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Business_Areas_Table.Business_Area_ID LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Modules_Table.Module_ID LIKE '%" + textBox_Searchbox.Text + "%';");
                //loading into DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];

                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;

            }
            else
            {
                radioButton_searchAll.Checked = true;

                //The WHERE SQL query part could not be moved into the file constant because of variable (textBox_Searchbox.Text) used in the query
                //Over ways of using temporary variables in the file constant failed
                dataset = dbConn.getDataSet(Constants.SEARCHFUNCTION +
                                                    " WHERE Companies_Table.Company_Name LIKE '%" + textBox_Searchbox.Text + "%' " +
                                                    " OR Companies_Table.Company_Established LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Number_Employees LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Demo_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Review_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Rating LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Demo_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Table.Company_Last_Review_Date LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Country LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_City LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Telephone_Number LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Companies_Locations_Table.Company_Location_Address LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Name LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Type LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Description LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Table.Product_Rating LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Products_Capabilities_Table.Product_Capability_Additional_Info LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Financial_Services_Client_Types_Table.Financial_Service_Client_Typ LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Business_Areas_Table.Business_Area_ID LIKE '%" + textBox_Searchbox.Text + "%'" +
                                                    " OR Modules_Table.Module_ID LIKE '%" + textBox_Searchbox.Text + "%';");
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            
        }

        //function for frmVendors new Window with more information
        private void MainMenuedvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productloaded)
            {
                if (e.RowIndex >= 0) //check if data is available
                {
                    DataGridViewRow dgr = MainMenuedvg.Rows[e.RowIndex];
                    // Get the data from the selected row
                    frmProduct frm = new frmProduct();

                    //pass data to form
                    frm.productName = dgr.Cells[0].Value.ToString();
                    frm.productType = dgr.Cells[1].Value.ToString();
                    frm.productDescription = dgr.Cells[2].Value.ToString();
                    frm.productCompany = dgr.Cells[4].Value.ToString();
                    frm.productRating = dgr.Cells[3].Value.ToString();
                    frm.productURL = dgr.Cells[6].Value.ToString();

                    //show form
                    frm.ShowDialog();
                }
            }
        }

        //function to insure the Buttons are getting unselected
        private void unselectButtons()
        {
            //This function makes it possible to reselect the different filters after switching from the vendor to product an vice versa
            //Whitout unselecting the buttons another one has to be select first and then the wanted one again.
            radioButton_Popularity.Checked = false;
            radioButton_BestRating.Checked = false;
            radioButton_AZ.Checked = false;
            radioButton_ZA.Checked = false;
            radioButton_NewestFirst.Checked = false;
            radioButton_OldestFirst.Checked = false;
            radioButton_FullMatch.Checked = false;
            radioButton_PartialMatch.Checked = false;
        }
    }
}