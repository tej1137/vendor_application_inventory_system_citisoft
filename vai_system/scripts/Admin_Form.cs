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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dGVLoad_Click(object sender, EventArgs e)
        {
            DataSet dsUsers = Admin_Functions.loadDB();
            dGV1.DataSource = dsUsers.Tables[0];
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            Admin_Functions.deleteFromDB(username);

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string newpassword = passwordChange.Text;
            string newuserpriv = userPrivChange.Text;
            Admin_Functions.editDB(username, newpassword, newuserpriv);
        }
    }
}
