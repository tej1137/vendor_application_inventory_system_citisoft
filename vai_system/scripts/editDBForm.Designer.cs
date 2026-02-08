namespace Software_Development_Project
{
    partial class editDBForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TargetValueTextBox = new System.Windows.Forms.RichTextBox();
            this.ConditionValueTextBox = new System.Windows.Forms.RichTextBox();
            this.TableNameListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnSelectListBox = new System.Windows.Forms.ListBox();
            this.ConditionSelectListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(69, 264);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(598, 79);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // TargetValueTextBox
            // 
            this.TargetValueTextBox.Location = new System.Drawing.Point(297, 185);
            this.TargetValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TargetValueTextBox.Name = "TargetValueTextBox";
            this.TargetValueTextBox.Size = new System.Drawing.Size(154, 41);
            this.TargetValueTextBox.TabIndex = 5;
            this.TargetValueTextBox.Text = "SetTargetTo";
            this.TargetValueTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // ConditionValueTextBox
            // 
            this.ConditionValueTextBox.Location = new System.Drawing.Point(541, 185);
            this.ConditionValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConditionValueTextBox.Name = "ConditionValueTextBox";
            this.ConditionValueTextBox.Size = new System.Drawing.Size(167, 41);
            this.ConditionValueTextBox.TabIndex = 7;
            this.ConditionValueTextBox.Text = "ConditionValue";
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.Items.AddRange(new object[] {
            "Business_Areas_Table",
            "Companies_Locations_Table",
            "Companies_Table",
            "Financial_Services_Client_Types_Table",
            "Modules_Table",
            "Products_Capabilites_Table",
            "Products_Table"});
            this.TableNameListBox.Location = new System.Drawing.Point(24, 65);
            this.TableNameListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(190, 95);
            this.TableNameListBox.TabIndex = 8;
            this.TableNameListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColumnSelectListBox
            // 
            this.ColumnSelectListBox.FormattingEnabled = true;
            this.ColumnSelectListBox.Location = new System.Drawing.Point(297, 65);
            this.ColumnSelectListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnSelectListBox.Name = "ColumnSelectListBox";
            this.ColumnSelectListBox.Size = new System.Drawing.Size(154, 95);
            this.ColumnSelectListBox.TabIndex = 10;
            this.ColumnSelectListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectListBox_SelectedIndexChanged);
            // 
            // ConditionSelectListBox
            // 
            this.ConditionSelectListBox.FormattingEnabled = true;
            this.ConditionSelectListBox.Location = new System.Drawing.Point(541, 65);
            this.ConditionSelectListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConditionSelectListBox.Name = "ConditionSelectListBox";
            this.ConditionSelectListBox.Size = new System.Drawing.Size(167, 95);
            this.ConditionSelectListBox.TabIndex = 11;
            this.ConditionSelectListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select Field to Edit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Condition to Filter By";
            // 
            // editDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConditionSelectListBox);
            this.Controls.Add(this.ColumnSelectListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameListBox);
            this.Controls.Add(this.ConditionValueTextBox);
            this.Controls.Add(this.TargetValueTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editDBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox TargetValueTextBox;
        private System.Windows.Forms.RichTextBox ConditionValueTextBox;
        private System.Windows.Forms.ListBox TableNameListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ColumnSelectListBox;
        private System.Windows.Forms.ListBox ConditionSelectListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

