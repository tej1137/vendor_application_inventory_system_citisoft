using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Software_Development_Project
{
    partial class Login_Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTC = new System.Windows.Forms.TabControl();
            this.regcompleteTab = new System.Windows.Forms.TabPage();
            this.label_complete = new System.Windows.Forms.Label();
            this.completeBtn = new System.Windows.Forms.Button();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.swapRegister = new System.Windows.Forms.Button();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.lable_registration = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordRegC = new System.Windows.Forms.TextBox();
            this.passwordReg = new System.Windows.Forms.TextBox();
            this.emailReg = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.swapLogin = new System.Windows.Forms.Button();
            this.LoginTC.SuspendLayout();
            this.regcompleteTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.registerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTC
            // 
            this.LoginTC.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.LoginTC.Controls.Add(this.loginTab);
            this.LoginTC.Controls.Add(this.registerTab);
            this.LoginTC.Controls.Add(this.regcompleteTab);
            this.LoginTC.ItemSize = new System.Drawing.Size(0, 1);
            this.LoginTC.Location = new System.Drawing.Point(0, 0);
            this.LoginTC.Margin = new System.Windows.Forms.Padding(2);
            this.LoginTC.Multiline = true;
            this.LoginTC.Name = "LoginTC";
            this.LoginTC.SelectedIndex = 0;
            this.LoginTC.Size = new System.Drawing.Size(700, 390);
            this.LoginTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LoginTC.TabIndex = 0;
            this.LoginTC.TabStop = false;
            // 
            // regcompleteTab
            // 
            this.regcompleteTab.BackColor = System.Drawing.Color.Silver;
            this.regcompleteTab.Controls.Add(this.label_complete);
            this.regcompleteTab.Controls.Add(this.completeBtn);
            this.regcompleteTab.Location = new System.Drawing.Point(4, 5);
            this.regcompleteTab.Margin = new System.Windows.Forms.Padding(2);
            this.regcompleteTab.Name = "regcompleteTab";
            this.regcompleteTab.Size = new System.Drawing.Size(692, 381);
            this.regcompleteTab.TabIndex = 2;
            this.regcompleteTab.Text = "Registration";
            // 
            // label_complete
            // 
            this.label_complete.AutoSize = true;
            this.label_complete.Location = new System.Drawing.Point(284, 186);
            this.label_complete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_complete.Name = "label_complete";
            this.label_complete.Size = new System.Drawing.Size(126, 26);
            this.label_complete.TabIndex = 3;
            this.label_complete.Text = "Registration complete. \r\nPress Button to continue.";
            this.label_complete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeBtn
            // 
            this.completeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.completeBtn.ForeColor = System.Drawing.Color.White;
            this.completeBtn.Location = new System.Drawing.Point(604, 342);
            this.completeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(80, 30);
            this.completeBtn.TabIndex = 0;
            this.completeBtn.Text = "Continue";
            this.completeBtn.UseVisualStyleBackColor = false;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.Silver;
            this.loginTab.Controls.Add(this.pictureBox1);
            this.loginTab.Controls.Add(this.passwordLogin);
            this.loginTab.Controls.Add(this.usernameLogin);
            this.loginTab.Controls.Add(this.loginBtn);
            this.loginTab.Controls.Add(this.swapRegister);
            this.loginTab.Location = new System.Drawing.Point(4, 5);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(2);
            this.loginTab.Size = new System.Drawing.Size(692, 381);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Development_Project.Properties.Resources.citisoft;
            this.pictureBox1.Location = new System.Drawing.Point(258, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(303, 208);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.Size = new System.Drawing.Size(107, 20);
            this.passwordLogin.TabIndex = 3;
            this.passwordLogin.Text = "Password";
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(303, 179);
            this.usernameLogin.Margin = new System.Windows.Forms.Padding(2);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(107, 20);
            this.usernameLogin.TabIndex = 2;
            this.usernameLogin.Text = "Username";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(315, 245);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(80, 30);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // swapRegister
            // 
            this.swapRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.swapRegister.ForeColor = System.Drawing.Color.White;
            this.swapRegister.Location = new System.Drawing.Point(604, 342);
            this.swapRegister.Margin = new System.Windows.Forms.Padding(2);
            this.swapRegister.Name = "swapRegister";
            this.swapRegister.Size = new System.Drawing.Size(80, 30);
            this.swapRegister.TabIndex = 0;
            this.swapRegister.Text = "Register";
            this.swapRegister.UseVisualStyleBackColor = false;
            this.swapRegister.Click += new System.EventHandler(this.swapRegister_Click);
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.Silver;
            this.registerTab.Controls.Add(this.lable_registration);
            this.registerTab.Controls.Add(this.pictureBox2);
            this.registerTab.Controls.Add(this.passwordRegC);
            this.registerTab.Controls.Add(this.passwordReg);
            this.registerTab.Controls.Add(this.emailReg);
            this.registerTab.Controls.Add(this.registerBtn);
            this.registerTab.Controls.Add(this.swapLogin);
            this.registerTab.Location = new System.Drawing.Point(4, 5);
            this.registerTab.Margin = new System.Windows.Forms.Padding(2);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(2);
            this.registerTab.Size = new System.Drawing.Size(692, 381);
            this.registerTab.TabIndex = 1;
            this.registerTab.Text = "Register";
            // 
            // lable_registration
            // 
            this.lable_registration.AutoSize = true;
            this.lable_registration.Location = new System.Drawing.Point(233, 90);
            this.lable_registration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_registration.Name = "lable_registration";
            this.lable_registration.Size = new System.Drawing.Size(264, 52);
            this.lable_registration.TabIndex = 6;
            this.lable_registration.Text = "Welcome to the CitiSoft registration page\r\n\r\nPlease enter your E-Mail and type yo" +
    "ur password twice\r\ninto the different textboxes below\r\n";
            this.lable_registration.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Development_Project.Properties.Resources.citisoft;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // passwordRegC
            // 
            this.passwordRegC.Location = new System.Drawing.Point(310, 212);
            this.passwordRegC.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegC.Name = "passwordRegC";
            this.passwordRegC.PasswordChar = '*';
            this.passwordRegC.Size = new System.Drawing.Size(95, 20);
            this.passwordRegC.TabIndex = 4;
            // 
            // passwordReg
            // 
            this.passwordReg.Location = new System.Drawing.Point(310, 184);
            this.passwordReg.Margin = new System.Windows.Forms.Padding(2);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.PasswordChar = '*';
            this.passwordReg.Size = new System.Drawing.Size(95, 20);
            this.passwordReg.TabIndex = 3;
            // 
            // emailReg
            // 
            this.emailReg.Location = new System.Drawing.Point(310, 156);
            this.emailReg.Margin = new System.Windows.Forms.Padding(2);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(95, 20);
            this.emailReg.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(315, 245);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(80, 30);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // swapLogin
            // 
            this.swapLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            this.swapLogin.ForeColor = System.Drawing.Color.White;
            this.swapLogin.Location = new System.Drawing.Point(604, 342);
            this.swapLogin.Margin = new System.Windows.Forms.Padding(2);
            this.swapLogin.Name = "swapLogin";
            this.swapLogin.Size = new System.Drawing.Size(80, 30);
            this.swapLogin.TabIndex = 0;
            this.swapLogin.Text = "Login";
            this.swapLogin.UseVisualStyleBackColor = false;
            this.swapLogin.Click += new System.EventHandler(this.swapLogin_Click);
            // 
            // Login_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 388);
            this.Controls.Add(this.LoginTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LoginTC.ResumeLayout(false);
            this.regcompleteTab.ResumeLayout(false);
            this.regcompleteTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl LoginTC;
        private TabPage regcompleteTab;
        private Button completeBtn;
        private TabPage loginTab;
        private TextBox passwordLogin;
        private TextBox usernameLogin;
        private Button loginBtn;
        private Button swapRegister;
        private TextBox passwordRegC;
        private TextBox passwordReg;
        private TextBox emailReg;
        private Button registerBtn;
        private Button swapLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TabPage registerTab;
        private Label lable_registration;
        private Label label_complete;
    }
}

