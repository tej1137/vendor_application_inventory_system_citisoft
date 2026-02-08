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
    public partial class Insert_Delete : Form
    {
        private DBConnection dbConn = DBConnection.getInstanceofDBConnection();

        public Insert_Delete()
        {
            InitializeComponent();            
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            //returns the object of the DBConnection class
            DataSet datasetProduct = dbConn.getDataSet(Constants.SELECTALL);
            dgvProduct.DataSource = datasetProduct.Tables[0];
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string company_ID = tbCompanyID.Text;
            string Product_Name = tbProductName.Text;
            string Product_Type = tbProductType.Text;
            string Product_Description = tbDescription.Text;
            string Product_Added;
            Product_Added = DateTime.Now.ToString("dd/MM/yyyy");
            char[] delimiterChars = { '/' };
            string[] datesplit = Product_Added.Split(delimiterChars);
            Product_Added = datesplit[0] + datesplit[1] + datesplit[2];
            dbConn.saveToDB_INSERT(Constants.INSERT_Product_IN_DB, company_ID, Product_Name, Product_Type, Product_Description, Product_Added);
        }

        private void btDeleteData_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row in the DataGridView
            if (dgvProduct.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];

                // Assuming you have an ID column in your DataGridView
                // and it corresponds to the primary key in your database table
                int productId = Convert.ToInt32(selectedRow.Cells["Product_ID"].Value);

                // Call a method in your DBConnection class to delete the record
                dbConn.deleteFromDB("DELETE FROM Products_Table WHERE Product_ID = @ID", productId);

                // Refresh the DataGridView to reflect the changes
                btLoadData_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}