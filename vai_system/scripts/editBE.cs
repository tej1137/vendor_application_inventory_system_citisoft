using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Software_Development_Project
{
    internal class editBE
    {

        static public void editDB(string Table, string TargetField, string TargetValue, string ConditionField, string ConditionValue, RichTextBox richTextBox1)
        {
            string sqlText = "UPDATE " + Table + " SET " + TargetField + "='" + TargetValue + "' WHERE " + ConditionField + "='" + ConditionValue + "'";
            DBConnection dbConn = DBConnection.getInstanceofDBConnection();
            dbConn.EditDatabase(richTextBox1, sqlText);
        }

        static public void UpdateLists(ListBox TableNameListBox, ListBox ColumnSelectListBox, ListBox ConditionSelectListBox)
        {
            int selectedValue = TableNameListBox.SelectedIndex; //Stores the table selected
            List<string> boxValues = new List<string>();

            ColumnSelectListBox.Items.Clear();
            ConditionSelectListBox.Items.Clear();

            if (selectedValue == 0)
            {
                boxValues.Add("Business_Area_ID");
                boxValues.Add("Product_Capability_ID");
                boxValues.Add("Business_Area");
            }
            else if (selectedValue == 1)
            {
                boxValues.Add("Company_Location_ID");
                boxValues.Add("Company_ID");
                boxValues.Add("Company_Location_Country");
                boxValues.Add("Company_Location_City");
                boxValues.Add("Company_Location_Telephone_Number");
                boxValues.Add("Company_Location_Address");
            }
            else if (selectedValue == 2)
            {
                boxValues.Add("Company_ID");
                boxValues.Add("Company_Name");
                boxValues.Add("Company_Website");
                boxValues.Add("Company_Established");
                boxValues.Add("Company_Number_Employees");
                boxValues.Add("Company_Internal_Professional_Service");
                boxValues.Add("Company_Last_Demo_Date");
                boxValues.Add("Company_Last_Review_Date");
            }
            else if (selectedValue == 3)
            {
                boxValues.Add("Financial_Service_Client_Typ_ID");
                boxValues.Add("Product_Capability_ID");
                boxValues.Add("Financial_Service_Client_Typ");
            }
            else if (selectedValue == 4)
            {
                boxValues.Add("Module_ID");
                boxValues.Add("Product_Capability_ID");
                boxValues.Add("Module");
            }
            else if (selectedValue == 5)
            {
                boxValues.Add("Product_Capability_ID");
                boxValues.Add("Product_ID");
                boxValues.Add("Product_Capability_Cloud");
                boxValues.Add("Product_Capability_Additional_Info");
                boxValues.Add("Product_Capability_Attachment");
            }
            else if (selectedValue == 6)
            {
                boxValues.Add("Product_ID");
                boxValues.Add("Company_ID");
                boxValues.Add("Product_Name");
                boxValues.Add("Product_Type");
                boxValues.Add("Product_Description");
            }

            for (int i = 0; i < boxValues.Count; i++)
            {
                ColumnSelectListBox.Items.Add(boxValues[i]);
                ConditionSelectListBox.Items.Add(boxValues[i]);
            }

        }
    }
}
