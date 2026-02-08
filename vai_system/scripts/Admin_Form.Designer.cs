namespace Software_Development_Project
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.dGVLoad = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordChange = new System.Windows.Forms.TextBox();
            this.userPrivChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(9, 10);
            this.dGV1.Margin = new System.Windows.Forms.Padding(2);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(360, 346);
            this.dGV1.TabIndex = 0;
            // 
            // dGVLoad
            // 
            this.dGVLoad.Location = new System.Drawing.Point(374, 336);
            this.dGVLoad.Margin = new System.Windows.Forms.Padding(2);
            this.dGVLoad.Name = "dGVLoad";
            this.dGVLoad.Size = new System.Drawing.Size(56, 19);
            this.dGVLoad.TabIndex = 1;
            this.dGVLoad.Text = "Load";
            this.dGVLoad.UseVisualStyleBackColor = true;
            this.dGVLoad.Click += new System.EventHandler(this.dGVLoad_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(535, 336);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(56, 19);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(455, 87);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(56, 19);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(455, 228);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(56, 19);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(437, 54);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(97, 20);
            this.usernameInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter username of entry you wish to delete/edit.";
            // 
            // passwordChange
            // 
            this.passwordChange.Location = new System.Drawing.Point(445, 136);
            this.passwordChange.Margin = new System.Windows.Forms.Padding(2);
            this.passwordChange.Name = "passwordChange";
            this.passwordChange.Size = new System.Drawing.Size(76, 20);
            this.passwordChange.TabIndex = 7;
            // 
            // userPrivChange
            // 
            this.userPrivChange.Location = new System.Drawing.Point(445, 179);
            this.userPrivChange.Margin = new System.Windows.Forms.Padding(2);
            this.userPrivChange.Name = "userPrivChange";
            this.userPrivChange.Size = new System.Drawing.Size(76, 20);
            this.userPrivChange.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "New User Privilege";
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userPrivChange);
            this.Controls.Add(this.passwordChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dGVLoad);
            this.Controls.Add(this.dGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Tool Box";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button dGVLoad;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordChange;
        private System.Windows.Forms.TextBox userPrivChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}