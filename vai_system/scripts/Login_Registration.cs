using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;

namespace Software_Development_Project
{
    public partial class Login_Registration : Form
    {
        public Login_Registration()
        {
            InitializeComponent();
            // Stops the user from being able to switch between tabs
            LoginTC.Controls.Remove(registerTab);
            LoginTC.Controls.Remove(regcompleteTab);
        }

        private void swapRegister_Click(object sender, EventArgs e)
        {
            // Swaps from the login tab to the registration tab
            LoginTC.Controls.Add(registerTab);
            LoginTC.Controls.Remove(loginTab);
        }

        private void swapLogin_Click(object sender, EventArgs e)
        {
            // Swaps from the registration tab to the login tab
            LoginTC.Controls.Add(loginTab);
            LoginTC.Controls.Remove(registerTab);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Collects the users inputted data
            string email = emailReg.Text;
            string password = passwordReg.Text;
            string passwordC = passwordRegC.Text;
            // Passes the data into the registration back end
            int pass = RegisterBE.register(email, password, passwordC);
            if (pass == 4)
            {
                // If pass = 4 then registration was successful and the user is notified
                // Swaps from the registration tab to the completion tab
                LoginTC.Controls.Remove(registerTab);
                LoginTC.Controls.Add(regcompleteTab);

            }
            else if (pass == 3)
            {
                // If pass = 3 then the passwords don't match and the user is not allowed entry
                // to the system and is told of the mistake
                System.Windows.Forms.MessageBox.Show("Passwords do not match");
            }

            else if (pass == 2)
            {
                // If pass = 2 then the password is not at least 8 character long and the user is not allowed entry
                // to the system and is told of the mistake
                System.Windows.Forms.MessageBox.Show("Password must be at least 8 characters long");
            }

            else if (pass == 1)
            {
                // If pass = 1 then no password has been entered and the user is not allowed entry
                // to the system and is told of the mistake
                System.Windows.Forms.MessageBox.Show("No Password Entered");
            }

            else if (pass == 0)
            {
                // If pass = 0 then the email entered is invalid and the user is not allowed entry
                // to the system and is told of the mistake
                System.Windows.Forms.MessageBox.Show("Wrong or Invalid e-mail address.");
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Collects the users inputted data
            string username = usernameLogin.Text;
            string password = passwordLogin.Text;
            // Passes the data into the login back end
            int pass = LoginBE.login(username, password);
            if (pass == 2)
            {
                // If pass = 2 then login is successful and the login form is closed
                // and the user is allowed entry to the system
                Visible = false;
                Main_Menu form2 = new Main_Menu();
                form2.Show();
            }

            else if (pass == 1)
            {
                // If pass = 1 then the user has input a correct username but the password
                // they input did match the one associated with the username and the user is denied access
                System.Windows.Forms.MessageBox.Show("Password Incorrect");
            }

            else if (pass == 0)
            {
                // If pass = 0 then the user has input a incorrect username and is denied access
                System.Windows.Forms.MessageBox.Show("Username Incorrect");
            }

            else if (pass == 3)
            {
                // If pass = 3 then the user has input a blank username and is denied access
                System.Windows.Forms.MessageBox.Show("Username is blank");
            }

            else if (pass == 4)
            {
                // If pass = 4 then the user has input a blank password and is denied access
                System.Windows.Forms.MessageBox.Show("Password is blank");
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            // closes the registration form
            Visible = false;
            Main_Menu form2 = new Main_Menu();
            form2.Show();
        }
    }
}