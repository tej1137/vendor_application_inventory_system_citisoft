namespace Software_Development_Project
{
    partial class frmVendor
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
            this.lblReview = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblReview.Location = new System.Drawing.Point(274, 53);
            this.lblReview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(44, 16);
            this.lblReview.TabIndex = 25;
            this.lblReview.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(274, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last Review Date:";
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblWebsite.Location = new System.Drawing.Point(13, 116);
            this.lblWebsite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(37, 16);
            this.lblWebsite.TabIndex = 23;
            this.lblWebsite.Text = "www.";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCompany.Location = new System.Drawing.Point(13, 53);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(44, 16);
            this.lblCompany.TabIndex = 22;
            this.lblCompany.Text = "Name";
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnopen.Image = global::Software_Development_Project.Properties.Resources.internet;
            this.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnopen.Location = new System.Drawing.Point(14, 156);
            this.btnopen.Margin = new System.Windows.Forms.Padding(2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(162, 29);
            this.btnopen.TabIndex = 21;
            this.btnopen.Text = "Open Website";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company Website:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Company Name:";
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 216);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Information";
            this.Load += new System.EventHandler(this.frmVendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}