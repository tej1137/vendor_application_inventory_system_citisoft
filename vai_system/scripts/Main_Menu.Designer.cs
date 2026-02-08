using Software_Development_Project.Properties;

namespace Software_Development_Project
{
    partial class Main_Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuedvg = new System.Windows.Forms.DataGridView();
            this.button_ViewVendors = new System.Windows.Forms.Button();
            this.panel_Categories = new System.Windows.Forms.Panel();
            this.radioButton_clientTypes = new System.Windows.Forms.RadioButton();
            this.radioButton_modules = new System.Windows.Forms.RadioButton();
            this.radioButton_businessAreas = new System.Windows.Forms.RadioButton();
            this.button_SelectCategories = new System.Windows.Forms.Button();
            this.label_Categories = new System.Windows.Forms.Label();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.radioButton_OldestFirst = new System.Windows.Forms.RadioButton();
            this.radioButton_NewestFirst = new System.Windows.Forms.RadioButton();
            this.radioButton_ZA = new System.Windows.Forms.RadioButton();
            this.radioButton_AZ = new System.Windows.Forms.RadioButton();
            this.radioButton_BestRating = new System.Windows.Forms.RadioButton();
            this.radioButton_Popularity = new System.Windows.Forms.RadioButton();
            this.label_Filter = new System.Windows.Forms.Label();
            this.button_ViewProducts = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.textBox_Searchbox = new System.Windows.Forms.TextBox();
            this.panel_search = new System.Windows.Forms.Panel();
            this.radioButton_searchVendors = new System.Windows.Forms.RadioButton();
            this.radioButton_searchProducts = new System.Windows.Forms.RadioButton();
            this.radioButton_searchAll = new System.Windows.Forms.RadioButton();
            this.insertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_categoriesSearch = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuedvg)).BeginInit();
            this.panel_Categories.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            pictureBox1.Enabled = false;
            pictureBox1.Image = global::Software_Development_Project.Properties.Resources.Logout;
            pictureBox1.Location = new System.Drawing.Point(982, 543);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(28, 27);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // MainMenuedvg
            // 
            this.MainMenuedvg.AllowUserToAddRows = false;
            this.MainMenuedvg.AllowUserToDeleteRows = false;
            this.MainMenuedvg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainMenuedvg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainMenuedvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainMenuedvg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MainMenuedvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainMenuedvg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainMenuedvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainMenuedvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainMenuedvg.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainMenuedvg.EnableHeadersVisualStyles = false;
            this.MainMenuedvg.Location = new System.Drawing.Point(218, 177);
            this.MainMenuedvg.Name = "MainMenuedvg";
            this.MainMenuedvg.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(191)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainMenuedvg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MainMenuedvg.RowHeadersVisible = false;
            this.MainMenuedvg.RowHeadersWidth = 82;
            this.MainMenuedvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainMenuedvg.Size = new System.Drawing.Size(643, 370);
            this.MainMenuedvg.TabIndex = 0;
            this.MainMenuedvg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainMenuedvg_CellClick);
            // 
            // button_ViewVendors
            // 
            this.button_ViewVendors.Location = new System.Drawing.Point(545, 145);
            this.button_ViewVendors.Margin = new System.Windows.Forms.Padding(2);
            this.button_ViewVendors.Name = "button_ViewVendors";
            this.button_ViewVendors.Size = new System.Drawing.Size(179, 27);
            this.button_ViewVendors.TabIndex = 12;
            this.button_ViewVendors.Text = "View Vendors";
            this.button_ViewVendors.UseVisualStyleBackColor = true;
            this.button_ViewVendors.Click += new System.EventHandler(this.button_ViewVendors_Click);
            // 
            // panel_Categories
            // 
            this.panel_Categories.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Categories.Controls.Add(this.button_categoriesSearch);
            this.panel_Categories.Controls.Add(this.radioButton_clientTypes);
            this.panel_Categories.Controls.Add(this.radioButton_modules);
            this.panel_Categories.Controls.Add(this.radioButton_businessAreas);
            this.panel_Categories.Controls.Add(this.button_SelectCategories);
            this.panel_Categories.Controls.Add(this.label_Categories);
            this.panel_Categories.Location = new System.Drawing.Point(24, 367);
            this.panel_Categories.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Categories.Name = "panel_Categories";
            this.panel_Categories.Size = new System.Drawing.Size(164, 169);
            this.panel_Categories.TabIndex = 9;
            // 
            // radioButton_clientTypes
            // 
            this.radioButton_clientTypes.AutoSize = true;
            this.radioButton_clientTypes.Location = new System.Drawing.Point(42, 121);
            this.radioButton_clientTypes.Name = "radioButton_clientTypes";
            this.radioButton_clientTypes.Size = new System.Drawing.Size(83, 17);
            this.radioButton_clientTypes.TabIndex = 9;
            this.radioButton_clientTypes.TabStop = true;
            this.radioButton_clientTypes.Text = "Client Types";
            this.radioButton_clientTypes.UseVisualStyleBackColor = true;
            // 
            // radioButton_modules
            // 
            this.radioButton_modules.AutoSize = true;
            this.radioButton_modules.Location = new System.Drawing.Point(42, 98);
            this.radioButton_modules.Name = "radioButton_modules";
            this.radioButton_modules.Size = new System.Drawing.Size(65, 17);
            this.radioButton_modules.TabIndex = 8;
            this.radioButton_modules.TabStop = true;
            this.radioButton_modules.Text = "Modules";
            this.radioButton_modules.UseVisualStyleBackColor = true;
            // 
            // radioButton_businessAreas
            // 
            this.radioButton_businessAreas.AutoSize = true;
            this.radioButton_businessAreas.Location = new System.Drawing.Point(42, 75);
            this.radioButton_businessAreas.Name = "radioButton_businessAreas";
            this.radioButton_businessAreas.Size = new System.Drawing.Size(97, 17);
            this.radioButton_businessAreas.TabIndex = 7;
            this.radioButton_businessAreas.TabStop = true;
            this.radioButton_businessAreas.Text = "Business Areas";
            this.radioButton_businessAreas.UseVisualStyleBackColor = true;
            // 
            // button_SelectCategories
            // 
            this.button_SelectCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_SelectCategories.Location = new System.Drawing.Point(15, 35);
            this.button_SelectCategories.Name = "button_SelectCategories";
            this.button_SelectCategories.Size = new System.Drawing.Size(132, 34);
            this.button_SelectCategories.TabIndex = 6;
            this.button_SelectCategories.Text = "Select Categories";
            this.button_SelectCategories.UseVisualStyleBackColor = false;
            this.button_SelectCategories.Click += new System.EventHandler(this.button_SelectCategories_Click);
            // 
            // label_Categories
            // 
            this.label_Categories.AutoSize = true;
            this.label_Categories.Location = new System.Drawing.Point(12, 16);
            this.label_Categories.Name = "label_Categories";
            this.label_Categories.Size = new System.Drawing.Size(97, 13);
            this.label_Categories.TabIndex = 5;
            this.label_Categories.Text = "Product Categories";
            // 
            // panel_Filter
            // 
            this.panel_Filter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Filter.Controls.Add(this.radioButton_OldestFirst);
            this.panel_Filter.Controls.Add(this.radioButton_NewestFirst);
            this.panel_Filter.Controls.Add(this.radioButton_ZA);
            this.panel_Filter.Controls.Add(this.radioButton_AZ);
            this.panel_Filter.Controls.Add(this.radioButton_BestRating);
            this.panel_Filter.Controls.Add(this.radioButton_Popularity);
            this.panel_Filter.Controls.Add(this.label_Filter);
            this.panel_Filter.Location = new System.Drawing.Point(24, 177);
            this.panel_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(164, 174);
            this.panel_Filter.TabIndex = 8;
            // 
            // radioButton_OldestFirst
            // 
            this.radioButton_OldestFirst.AutoSize = true;
            this.radioButton_OldestFirst.Location = new System.Drawing.Point(42, 133);
            this.radioButton_OldestFirst.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_OldestFirst.Name = "radioButton_OldestFirst";
            this.radioButton_OldestFirst.Size = new System.Drawing.Size(77, 17);
            this.radioButton_OldestFirst.TabIndex = 6;
            this.radioButton_OldestFirst.TabStop = true;
            this.radioButton_OldestFirst.Text = "Oldest First";
            this.radioButton_OldestFirst.UseVisualStyleBackColor = true;
            this.radioButton_OldestFirst.CheckedChanged += new System.EventHandler(this.radioButton_OldestFirst_CheckedChanged);
            // 
            // radioButton_NewestFirst
            // 
            this.radioButton_NewestFirst.AutoSize = true;
            this.radioButton_NewestFirst.Location = new System.Drawing.Point(42, 114);
            this.radioButton_NewestFirst.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_NewestFirst.Name = "radioButton_NewestFirst";
            this.radioButton_NewestFirst.Size = new System.Drawing.Size(83, 17);
            this.radioButton_NewestFirst.TabIndex = 5;
            this.radioButton_NewestFirst.TabStop = true;
            this.radioButton_NewestFirst.Text = "Newest First";
            this.radioButton_NewestFirst.UseVisualStyleBackColor = true;
            this.radioButton_NewestFirst.CheckedChanged += new System.EventHandler(this.radioButton_NewestFirst_CheckedChanged);
            // 
            // radioButton_ZA
            // 
            this.radioButton_ZA.AutoSize = true;
            this.radioButton_ZA.Location = new System.Drawing.Point(42, 95);
            this.radioButton_ZA.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_ZA.Name = "radioButton_ZA";
            this.radioButton_ZA.Size = new System.Drawing.Size(109, 17);
            this.radioButton_ZA.TabIndex = 4;
            this.radioButton_ZA.TabStop = true;
            this.radioButton_ZA.Text = "Alphabetical Z - A";
            this.radioButton_ZA.UseVisualStyleBackColor = true;
            this.radioButton_ZA.CheckedChanged += new System.EventHandler(this.radioButton_ZA_CheckedChanged);
            // 
            // radioButton_AZ
            // 
            this.radioButton_AZ.AutoSize = true;
            this.radioButton_AZ.Location = new System.Drawing.Point(42, 76);
            this.radioButton_AZ.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_AZ.Name = "radioButton_AZ";
            this.radioButton_AZ.Size = new System.Drawing.Size(109, 17);
            this.radioButton_AZ.TabIndex = 3;
            this.radioButton_AZ.TabStop = true;
            this.radioButton_AZ.Text = "Alphabetical A - Z";
            this.radioButton_AZ.UseVisualStyleBackColor = true;
            this.radioButton_AZ.CheckedChanged += new System.EventHandler(this.radioButton_AZ_CheckedChanged);
            // 
            // radioButton_BestRating
            // 
            this.radioButton_BestRating.AutoSize = true;
            this.radioButton_BestRating.Location = new System.Drawing.Point(42, 58);
            this.radioButton_BestRating.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_BestRating.Name = "radioButton_BestRating";
            this.radioButton_BestRating.Size = new System.Drawing.Size(80, 17);
            this.radioButton_BestRating.TabIndex = 2;
            this.radioButton_BestRating.TabStop = true;
            this.radioButton_BestRating.Text = "Best Rating";
            this.radioButton_BestRating.UseVisualStyleBackColor = true;
            this.radioButton_BestRating.CheckedChanged += new System.EventHandler(this.radioButton_BestRating_CheckedChanged);
            // 
            // radioButton_Popularity
            // 
            this.radioButton_Popularity.AutoSize = true;
            this.radioButton_Popularity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_Popularity.Location = new System.Drawing.Point(42, 39);
            this.radioButton_Popularity.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_Popularity.Name = "radioButton_Popularity";
            this.radioButton_Popularity.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Popularity.TabIndex = 1;
            this.radioButton_Popularity.TabStop = true;
            this.radioButton_Popularity.Text = "Popularity";
            this.radioButton_Popularity.UseVisualStyleBackColor = true;
            this.radioButton_Popularity.CheckedChanged += new System.EventHandler(this.radioButton_Popularity_CheckedChanged);
            // 
            // label_Filter
            // 
            this.label_Filter.AutoSize = true;
            this.label_Filter.Location = new System.Drawing.Point(12, 18);
            this.label_Filter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter.Name = "label_Filter";
            this.label_Filter.Size = new System.Drawing.Size(34, 13);
            this.label_Filter.TabIndex = 0;
            this.label_Filter.Text = "Filters";
            // 
            // button_ViewProducts
            // 
            this.button_ViewProducts.Location = new System.Drawing.Point(361, 145);
            this.button_ViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.button_ViewProducts.Name = "button_ViewProducts";
            this.button_ViewProducts.Size = new System.Drawing.Size(179, 27);
            this.button_ViewProducts.TabIndex = 7;
            this.button_ViewProducts.Text = "View Products";
            this.button_ViewProducts.UseVisualStyleBackColor = true;
            this.button_ViewProducts.Click += new System.EventHandler(this.button_ViewProducts_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Software_Development_Project.Properties.Resources.citisoft;
            this.pictureBox_Logo.Location = new System.Drawing.Point(888, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(156, 50);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 13;
            this.pictureBox_Logo.TabStop = false;
            // 
            // textBox_Searchbox
            // 
            this.textBox_Searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Searchbox.Location = new System.Drawing.Point(361, 69);
            this.textBox_Searchbox.Name = "textBox_Searchbox";
            this.textBox_Searchbox.Size = new System.Drawing.Size(363, 26);
            this.textBox_Searchbox.TabIndex = 14;
            this.textBox_Searchbox.TextChanged += new System.EventHandler(this.textBox_Searchbox_TextChanged);
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.radioButton_searchVendors);
            this.panel_search.Controls.Add(this.radioButton_searchProducts);
            this.panel_search.Controls.Add(this.radioButton_searchAll);
            this.panel_search.Location = new System.Drawing.Point(313, 43);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(452, 82);
            this.panel_search.TabIndex = 15;
            // 
            // radioButton_searchVendors
            // 
            this.radioButton_searchVendors.AutoSize = true;
            this.radioButton_searchVendors.Location = new System.Drawing.Point(236, 58);
            this.radioButton_searchVendors.Name = "radioButton_searchVendors";
            this.radioButton_searchVendors.Size = new System.Drawing.Size(101, 17);
            this.radioButton_searchVendors.TabIndex = 2;
            this.radioButton_searchVendors.TabStop = true;
            this.radioButton_searchVendors.Text = "Search Vendors";
            this.radioButton_searchVendors.UseVisualStyleBackColor = true;
            // 
            // radioButton_searchProducts
            // 
            this.radioButton_searchProducts.AutoSize = true;
            this.radioButton_searchProducts.Location = new System.Drawing.Point(126, 58);
            this.radioButton_searchProducts.Name = "radioButton_searchProducts";
            this.radioButton_searchProducts.Size = new System.Drawing.Size(104, 17);
            this.radioButton_searchProducts.TabIndex = 1;
            this.radioButton_searchProducts.TabStop = true;
            this.radioButton_searchProducts.Text = "Search Products";
            this.radioButton_searchProducts.UseVisualStyleBackColor = true;
            // 
            // radioButton_searchAll
            // 
            this.radioButton_searchAll.AutoSize = true;
            this.radioButton_searchAll.Location = new System.Drawing.Point(48, 58);
            this.radioButton_searchAll.Name = "radioButton_searchAll";
            this.radioButton_searchAll.Size = new System.Drawing.Size(73, 17);
            this.radioButton_searchAll.TabIndex = 0;
            this.radioButton_searchAll.TabStop = true;
            this.radioButton_searchAll.Text = "Search All";
            this.radioButton_searchAll.UseVisualStyleBackColor = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(922, 291);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 32);
            this.insertBtn.TabIndex = 15;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(922, 399);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 32);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(922, 344);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 32);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.LightCoral;
            this.adminBtn.Location = new System.Drawing.Point(922, 220);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 45);
            this.adminBtn.TabIndex = 18;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Location = new System.Drawing.Point(966, 527);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(61, 48);
            this.button_Logout.TabIndex = 19;
            this.button_Logout.Text = "Logout";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_categoriesSearch
            // 
            this.button_categoriesSearch.Location = new System.Drawing.Point(51, 141);
            this.button_categoriesSearch.Name = "button_categoriesSearch";
            this.button_categoriesSearch.Size = new System.Drawing.Size(62, 23);
            this.button_categoriesSearch.TabIndex = 10;
            this.button_categoriesSearch.Text = "GO";
            this.button_categoriesSearch.UseVisualStyleBackColor = true;
            this.button_categoriesSearch.Click += new System.EventHandler(this.button_categoriesSearch_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1045, 591);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.textBox_Searchbox);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.button_ViewVendors);
            this.Controls.Add(this.panel_Categories);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.button_ViewProducts);
            this.Controls.Add(this.MainMenuedvg);
            this.Controls.Add(this.panel_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citisoft ";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuedvg)).EndInit();
            this.panel_Categories.ResumeLayout(false);
            this.panel_Categories.PerformLayout();
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainMenuedvg;
        private System.Windows.Forms.Button button_ViewVendors;
        private System.Windows.Forms.Panel panel_Categories;
        private System.Windows.Forms.RadioButton radioButton_modules;
        private System.Windows.Forms.RadioButton radioButton_businessAreas;
        private System.Windows.Forms.Button button_SelectCategories;
        private System.Windows.Forms.Label label_Categories;
        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.RadioButton radioButton_OldestFirst;
        private System.Windows.Forms.RadioButton radioButton_NewestFirst;
        private System.Windows.Forms.RadioButton radioButton_ZA;
        private System.Windows.Forms.RadioButton radioButton_AZ;
        private System.Windows.Forms.RadioButton radioButton_BestRating;
        private System.Windows.Forms.RadioButton radioButton_Popularity;
        private System.Windows.Forms.Label label_Filter;
        private System.Windows.Forms.Button button_ViewProducts;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.RadioButton radioButton_searchProducts;
        private System.Windows.Forms.RadioButton radioButton_searchAll;
        private System.Windows.Forms.RadioButton radioButton_searchVendors;
        private System.Windows.Forms.TextBox textBox_Searchbox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.RadioButton radioButton_clientTypes;
        private System.Windows.Forms.Button button_categoriesSearch;
    }
}

