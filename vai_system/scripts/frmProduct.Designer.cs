namespace Software_Development_Project
{
    partial class frmProduct
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCompany.Location = new System.Drawing.Point(312, 39);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 16);
            this.lblCompany.TabIndex = 47;
            this.lblCompany.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(310, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Product Company:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblRating.Location = new System.Drawing.Point(312, 99);
            this.lblRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(46, 16);
            this.lblRating.TabIndex = 45;
            this.lblRating.Text = "Rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(310, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Product Rating:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblType.Location = new System.Drawing.Point(17, 99);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 16);
            this.lblType.TabIndex = 43;
            this.lblType.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Product Type:";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDescription.Location = new System.Drawing.Point(17, 157);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(505, 56);
            this.lblDescription.TabIndex = 41;
            this.lblDescription.Text = "Description";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblProduct.Location = new System.Drawing.Point(17, 39);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 16);
            this.lblProduct.TabIndex = 40;
            this.lblProduct.Text = "Name";
            // 
            // btnopen
            // 
            this.btnopen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnopen.Image = global::Software_Development_Project.Properties.Resources.open_pdf;
            this.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnopen.Location = new System.Drawing.Point(18, 218);
            this.btnopen.Margin = new System.Windows.Forms.Padding(2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(195, 29);
            this.btnopen.TabIndex = 39;
            this.btnopen.Text = "Open Product PDF";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Product Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Product Name:";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 264);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}