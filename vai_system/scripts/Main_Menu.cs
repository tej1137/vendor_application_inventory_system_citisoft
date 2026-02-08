using Software_Development_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Software_Development_Project
{
    public partial class Main_Menu : Form
    {
        /*  
        *  boolean to switch the filters from products to vendors vice versa
        *  previously used two state boolean was not enough. A third state that the datatype can be is needed.
        *  A boolean with three states:       
        *  0 = program has no specific view; 1 = program is in product view; 2 = program is in vendor view
        */
        byte programState = 0;

        public Main_Menu()
        {
            InitializeComponent();

            if (privilage.userPrivilage == "admin")
            {

            }
            else if (privilage.userPrivilage == "analyst")
            {
                adminBtn.Visible = false;
                editBtn.Visible = false;
                deleteBtn.Visible = false;
                insertBtn.Visible = false;
            }
            else if (privilage.userPrivilage == "engineer")
            {
                adminBtn.Visible = false;
            }
        }

        //Loading Products/Vendors
        private void button_ViewProducts_Click(object sender, EventArgs e)
        {
            //"MainMenuedvg.Columns.Clear();" is used through the whole project to clear the display to ensure the queries are displayed freshly/correctly 
            MainMenuedvg.Columns.Clear();

            //connecting, getting, and loading required information from Database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();

            //getting data with query. Check file "Constants.cs" string "SHOWPREVIEWPRODUCTS" for exact query 
            DataSet dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS);

            //data set is being loaded into the DataGridView
            MainMenuedvg.DataSource = dataset.Tables[0];

            // Hide URl for product details
            MainMenuedvg.Columns[6].Visible = false;
            
            //"programState" makes it possible to have a switch in the program so the program can change from product-view to vendor-view and also to a none specific view
            programState = 1;

            //"label.Text" renaming Labels so they fit in which view (product-view/vendor-view)
            label_Filter.Text = Constants.ProductFilters;

            //"unselectButtons();" makes sure buttons are being freshly selectable after changing view.
            unselectButtons();

            //"radioButton_search.Checked" makes sure the searchbar is in right mod and connected to the the current selected view (product-view/vendor-view)
            radioButton_searchVendors.Checked = false;
            radioButton_searchProducts.Checked = true;

            //makes the categories panel visible
            panel_Categories.Visible = true;
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

            //switches to vendor-view
            programState = 2;

            //"label.Text" changing labels for vendor mode
            label_Filter.Text = Constants.VendorFilters;

            //"unselectButtons();" makes sure buttons are being freshly selectable after changing view.
            unselectButtons();

            //Searchbar is in vendor-view 
            radioButton_searchVendors.Checked = true;
            radioButton_searchProducts.Checked = false;

            //hides the categories panel
            panel_Categories.Visible = false;
        }

        //Filters
        //only one radio button can be selected at a time.
        private void radioButton_Popularity_CheckedChanged(object sender, EventArgs e) 
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //more quieries. check file "Constants" string "SHOWPREVIEWPRODUCTS" and ProductPopularityASC for specifics
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODUCTPopularityASC);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //more quieries. check file "Constants"
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYPopularityASC);
                //loading into DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_BestRating_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //more queries. check file "Constants"
                //Product rating sorted by DESC so highest rating is shown first
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODUCTBestRating);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //more queries. check file "Constants"
                //Company rating sorted by DESC so highest rating is shown first
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYBestRating);
                //Loading
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_AZ_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //Product names sorted by ACS (Alphabetically A-Z)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODUCTAZ);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Companies names sorted by ACS (Alphabetically A-Z)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYAZ);
                //Loading
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_ZA_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //Product names sorted by ACS (Alphabetically Z-A)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODCUTZA);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Company names sorted by ACS (Alphabetically Z-A)
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYZA);
                //Loading
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_NewestFirst_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //Product Added is a temporary value because there is not proper concept for an Attribute when a product is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODCUTNewestFirst);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Company Added is a temporary value because there is not proper concept for an Attribute when a company is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYNewestFirst);
                //Loading
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        private void radioButton_OldestFirst_CheckedChanged(object sender, EventArgs e)
        {
            //Connecting database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (programState == 1)
            {
                //Product Added is a temporary value because there is not proper concept for an Attribute when a product is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.PRODCUTOldestFirst);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                //Company Added is a temporary value because there is not proper concept for an Attribute when a company is added.
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWVENDORS + Constants.COMPANYOldestFirst);
                //Loading
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
                                                    Constants.WHERECompanyName + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyEstablished + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyNumberEmployees + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLastDemoDate + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLastReviewDate + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyRating + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationCountry + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationCity + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationTelephoneNumber + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationAddress + textBox_Searchbox.Text + Constants.EndPrecent);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else if (radioButton_searchProducts.Checked == true)
            {
                //"button_ViewVendors.PerformClick();" switches to the right vie (product-view/vendor-view
                button_ViewProducts.PerformClick();

                //The WHERE SQL query part could not be moved into the file constant because of variable (textBox_Searchbox.Text) used in the query
                //Over ways of using temporary variables in the file constant failed
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.SEARCHVIEWPRODUCTSJOIN +
                                                    Constants.WHEREProductName + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductTyp + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductDescription + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductRating + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyNameProduct + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductCapabilityAdditionalInfo + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREFinancialServiceClientTyp + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREBusinessArea + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREModule + textBox_Searchbox.Text + Constants.EndPrecent);
                //data set is being loaded into the DataGridView
                MainMenuedvg.DataSource = dataset.Tables[0];
                // Hide URl for product details
                MainMenuedvg.Columns[6].Visible = false;
            }
            else
            {
                radioButton_searchAll.Checked = true;

                //programState = 0: none of the "more details" forms are being shown
                programState = 0;
                //The WHERE SQL query part could not be moved into the file constant because of variable (textBox_Searchbox.Text) used in the query
                //Over ways of using temporary variables in the file constant failed
                dataset = dbConn.getDataSet(Constants.SEARCHFUNCTION +
                                                    Constants.WHERECompanyName + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyEstablished + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyNumberEmployees + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLastDemoDate + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLastReviewDate + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyRating + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationCountry + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationCity + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationTelephoneNumber + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHERECompanyLocationAddress + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductNameSearchAll + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductTyp + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductDescription + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductRating + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREProductCapabilityAdditionalInfo + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREFinancialServiceClientTyp + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREBusinessArea + textBox_Searchbox.Text + Constants.Precent +
                                                    Constants.WHEREModule + textBox_Searchbox.Text + Constants.EndPrecent);
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
        }

        //Categories

        public void button_SelectCategories_Click(object sender, EventArgs e)
        {

            //ShowDialog keeps the new opened form in focus

            frmCategories form2 = new frmCategories();
            form2.Show();
            //looking at values to check which category the user selected
            if (radioButton_businessAreas.Checked == true)
            {
                //changing the state to show another category class
                Constants.categoryState = 0;
            }
            else if (radioButton_modules.Checked == true)
            {
                Constants.categoryState = 1;
            }
            else if (radioButton_clientTypes.Checked == true)
            {
                Constants.categoryState = 2;
            }
            else
            {
                form2.Close();
                System.Windows.Forms.MessageBox.Show("Please select a category");
            }
        }
        private void button_categoriesSearch_Click(object sender, EventArgs e)
        {
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            //different searches with different SQL statments
            if (radioButton_businessAreas.Checked == true)
            {
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.ProductTypeLIKE + Constants.selectedCategory + Constants.EndPrecent);    
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else if (radioButton_modules.Checked == true)
            {
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.SEARCHVIEWPRODUCTSJOIN + Constants.ModuleLIKE + Constants.selectedCategory + Constants.EndPrecent);
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            else if (radioButton_clientTypes.Checked == true)
            {
                dataset = dbConn.getDataSet(Constants.SHOWPREVIEWPRODUCTS + Constants.SEARCHVIEWPRODUCTSJOIN + Constants.ClientTypLIKE + Constants.selectedCategory + Constants.EndPrecent);
                MainMenuedvg.DataSource = dataset.Tables[0];
            }
            MainMenuedvg.Columns[6].Visible = false;
        }

        //function to insure the Buttons are getting unselected
        private void unselectButtons()
        {
            //This function makes it possible to reselect the different filters after switching from the vendor to product an vice versa
            //Without unselecting the buttons another one has to be select first and then the wanted one again.
            radioButton_Popularity.Checked = false;
            radioButton_BestRating.Checked = false;
            radioButton_AZ.Checked = false;
            radioButton_ZA.Checked = false;
            radioButton_NewestFirst.Checked = false;
            radioButton_OldestFirst.Checked = false;
            radioButton_businessAreas.Checked = false;
            radioButton_modules.Checked = false;
            radioButton_clientTypes.Checked = false;
        }

        //Logout function
        private void button_Logout_Click(object sender, EventArgs e)
        {
            {
                Visible = false;
                Login_Registration form = new Login_Registration();
                form.Visible = true;
            }
        }

        //function for frmVendors new Window with more information
        private void MainMenuedvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (programState == 2)
            {
                if (e.RowIndex >= 0) //check if data is available
                {
                    DataGridViewRow dgr = MainMenuedvg.Rows[e.RowIndex];
                    // Get the data from the selected row
                    frmVendor frm = new frmVendor(); // create new instance of vendor form
                    //pass data to form
                    frm.companyname = dgr.Cells[0].Value.ToString();
                    frm.companywebsite = dgr.Cells[1].Value.ToString();
                    frm.companyreviewDate = dgr.Cells[3].Value.ToString();
                    //show vendor form
                    frm.ShowDialog();
                }
            }

            if (programState == 1)
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

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Admin_Form form2 = new Admin_Form();
            form2.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editDBForm form2 = new editDBForm();
            form2.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Insert_Delete form2 = new Insert_Delete();
            form2.ShowDialog();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Insert_Delete form2 = new Insert_Delete();
            form2.ShowDialog();
        }
    }
}