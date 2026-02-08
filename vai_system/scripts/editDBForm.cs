using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Project
{
    public partial class editDBForm : Form
    {
        public editDBForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editBE.editDB(TableNameListBox.Text, ColumnSelectListBox.Text, TargetValueTextBox.Text, ConditionSelectListBox.Text, ConditionValueTextBox.Text, richTextBox1);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Updates the second and third listboxes when the first's option is selected
        {
            editBE.UpdateLists(TableNameListBox, ColumnSelectListBox, ConditionSelectListBox);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TargetColumnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ColumnSelectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

