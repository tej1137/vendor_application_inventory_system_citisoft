using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Project
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();

            dataGridView_Categories.Columns.Clear();

            //connection to database
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            DataSet dataset;

            if (Constants.categoryState == 0) 
            {
                //changes Label to indicate which category is selected
                label_categoryName.Text = Constants.ProductTypes;
                //SQL statment to get the category entries
                dataset = dbConn.getDataSet(Constants.DISTINCTProductTypes);
                dataGridView_Categories.DataSource = dataset.Tables[0];
            }
            else if (Constants.categoryState == 1)
            {
                //changes Label to indicate which category is selected
                label_categoryName.Text = Constants.Modules;
                //SQL statment to get the category entries
                dataset = dbConn.getDataSet(Constants.DISTINCTModules);
                dataGridView_Categories.DataSource = dataset.Tables[0];
            }
            else if (Constants.categoryState == 2)
            {
                //changes Label to indicate which category is selected
                label_categoryName.Text = Constants.ClientTypes;
                //SQL statment to get the category entries
                dataset = dbConn.getDataSet(Constants.DISTINCTClientTypes);
                dataGridView_Categories.DataSource = dataset.Tables[0];
            }
        }

        private void dataGridView_Categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //check if data is available
            {
                DataGridViewRow dgr = dataGridView_Categories.Rows[e.RowIndex];
                //pass data to string
                Constants.selectedCategory = dgr.Cells[0].Value.ToString();
                System.Windows.Forms.MessageBox.Show(Constants.selectedCategory);
            }
        }
    }
}
