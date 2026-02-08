namespace Software_Development_Project
{
    partial class frmCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_categoryName = new System.Windows.Forms.Label();
            this.dataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.radioButton_partialMatch = new System.Windows.Forms.RadioButton();
            this.radioButton_fullMatch = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label_categoryName);
            this.panel1.Controls.Add(this.dataGridView_Categories);
            this.panel1.Controls.Add(this.radioButton_partialMatch);
            this.panel1.Controls.Add(this.radioButton_fullMatch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 315);
            this.panel1.TabIndex = 0;
            // 
            // label_categoryName
            // 
            this.label_categoryName.AutoSize = true;
            this.label_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_categoryName.Location = new System.Drawing.Point(33, 9);
            this.label_categoryName.Name = "label_categoryName";
            this.label_categoryName.Size = new System.Drawing.Size(89, 15);
            this.label_categoryName.TabIndex = 4;
            this.label_categoryName.Text = "CategoryName";
            // 
            // dataGridView_Categories
            // 
            this.dataGridView_Categories.AllowUserToAddRows = false;
            this.dataGridView_Categories.AllowUserToDeleteRows = false;
            this.dataGridView_Categories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView_Categories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Categories.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Categories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Categories.EnableHeadersVisualStyles = false;
            this.dataGridView_Categories.Location = new System.Drawing.Point(36, 31);
            this.dataGridView_Categories.Name = "dataGridView_Categories";
            this.dataGridView_Categories.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Categories.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Categories.RowHeadersVisible = false;
            this.dataGridView_Categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Categories.Size = new System.Drawing.Size(167, 207);
            this.dataGridView_Categories.TabIndex = 3;
            this.dataGridView_Categories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Categories_CellClick);
            // 
            // radioButton_partialMatch
            // 
            this.radioButton_partialMatch.AutoSize = true;
            this.radioButton_partialMatch.Location = new System.Drawing.Point(77, 278);
            this.radioButton_partialMatch.Name = "radioButton_partialMatch";
            this.radioButton_partialMatch.Size = new System.Drawing.Size(87, 17);
            this.radioButton_partialMatch.TabIndex = 2;
            this.radioButton_partialMatch.TabStop = true;
            this.radioButton_partialMatch.Text = "Partial Match";
            this.radioButton_partialMatch.UseVisualStyleBackColor = true;
            // 
            // radioButton_fullMatch
            // 
            this.radioButton_fullMatch.AutoSize = true;
            this.radioButton_fullMatch.Location = new System.Drawing.Point(77, 255);
            this.radioButton_fullMatch.Name = "radioButton_fullMatch";
            this.radioButton_fullMatch.Size = new System.Drawing.Size(74, 17);
            this.radioButton_fullMatch.TabIndex = 1;
            this.radioButton_fullMatch.TabStop = true;
            this.radioButton_fullMatch.Text = "Full Match";
            this.radioButton_fullMatch.UseVisualStyleBackColor = true;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 315);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_partialMatch;
        private System.Windows.Forms.RadioButton radioButton_fullMatch;
        private System.Windows.Forms.DataGridView dataGridView_Categories;
        private System.Windows.Forms.Label label_categoryName;
    }
}