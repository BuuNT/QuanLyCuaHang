namespace QuanLyCuaHang
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.layoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_Center = new System.Windows.Forms.Panel();
            this.layoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.layoutPanel_Product = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_ExpDate = new System.Windows.Forms.TextBox();
            this.textBox_MfgDate = new System.Windows.Forms.TextBox();
            this.textBox_Company = new System.Windows.Forms.TextBox();
            this.label_ExpDate = new System.Windows.Forms.Label();
            this.label_MfgDate = new System.Windows.Forms.Label();
            this.label_Company = new System.Windows.Forms.Label();
            this.textBox_Category = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.tabPage_Category = new System.Windows.Forms.TabPage();
            this.layoutPanel_Category = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_CatHeader = new System.Windows.Forms.ComboBox();
            this.label_Category_Output = new System.Windows.Forms.Label();
            this.label_Category_Input = new System.Windows.Forms.Label();
            this.textBox_CatHeader = new System.Windows.Forms.TextBox();
            this.layoutPanel_SearchButton = new System.Windows.Forms.TableLayoutPanel();
            this.layoutPanel_Button = new System.Windows.Forms.TableLayoutPanel();
            this.button_Del = new System.Windows.Forms.Button();
            this.button_Get = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.layoutPanel_Search = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.layoutPanel1.SuspendLayout();
            this.panel_Center.SuspendLayout();
            this.layoutPanel2.SuspendLayout();
            this.layoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_Product.SuspendLayout();
            this.layoutPanel_Product.SuspendLayout();
            this.tabPage_Category.SuspendLayout();
            this.layoutPanel_Category.SuspendLayout();
            this.layoutPanel_SearchButton.SuspendLayout();
            this.layoutPanel_Button.SuspendLayout();
            this.layoutPanel_Search.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel1
            // 
            this.layoutPanel1.ColumnCount = 1;
            this.layoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel1.Controls.Add(this.panel_Bottom, 0, 2);
            this.layoutPanel1.Controls.Add(this.panel_Center, 0, 1);
            this.layoutPanel1.Controls.Add(this.panel_Top, 0, 0);
            this.layoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.layoutPanel1.Name = "layoutPanel1";
            this.layoutPanel1.RowCount = 3;
            this.layoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layoutPanel1.Size = new System.Drawing.Size(2016, 1181);
            this.layoutPanel1.TabIndex = 0;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(68)))));
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 1121);
            this.panel_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(2016, 60);
            this.panel_Bottom.TabIndex = 2;
            // 
            // panel_Center
            // 
            this.panel_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.panel_Center.Controls.Add(this.layoutPanel2);
            this.panel_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Center.Location = new System.Drawing.Point(0, 59);
            this.panel_Center.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Center.Name = "panel_Center";
            this.panel_Center.Size = new System.Drawing.Size(2016, 1062);
            this.panel_Center.TabIndex = 1;
            // 
            // layoutPanel2
            // 
            this.layoutPanel2.ColumnCount = 3;
            this.layoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.layoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.47619F));
            this.layoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.layoutPanel2.Controls.Add(this.layoutPanel3, 1, 0);
            this.layoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.layoutPanel2.Name = "layoutPanel2";
            this.layoutPanel2.RowCount = 1;
            this.layoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel2.Size = new System.Drawing.Size(2016, 1062);
            this.layoutPanel2.TabIndex = 0;
            // 
            // layoutPanel3
            // 
            this.layoutPanel3.ColumnCount = 1;
            this.layoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel3.Controls.Add(this.productGridView, 0, 2);
            this.layoutPanel3.Controls.Add(this.tabControl, 0, 0);
            this.layoutPanel3.Controls.Add(this.layoutPanel_SearchButton, 0, 1);
            this.layoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel3.Location = new System.Drawing.Point(96, 0);
            this.layoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel3.Name = "layoutPanel3";
            this.layoutPanel3.RowCount = 3;
            this.layoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.layoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.layoutPanel3.Size = new System.Drawing.Size(1824, 1062);
            this.layoutPanel3.TabIndex = 0;
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.productGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.productGridView.Location = new System.Drawing.Point(6, 483);
            this.productGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersWidth = 82;
            this.productGridView.Size = new System.Drawing.Size(1812, 573);
            this.productGridView.TabIndex = 0;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Product);
            this.tabControl.Controls.Add(this.tabPage_Category);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 20);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1812, 359);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_Product
            // 
            this.tabPage_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.tabPage_Product.Controls.Add(this.layoutPanel_Product);
            this.tabPage_Product.Location = new System.Drawing.Point(8, 28);
            this.tabPage_Product.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Product.Name = "tabPage_Product";
            this.tabPage_Product.Size = new System.Drawing.Size(1796, 323);
            this.tabPage_Product.TabIndex = 0;
            this.tabPage_Product.Text = "Product";
            // 
            // layoutPanel_Product
            // 
            this.layoutPanel_Product.ColumnCount = 3;
            this.layoutPanel_Product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel_Product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel_Product.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutPanel_Product.Controls.Add(this.textBox_ExpDate, 2, 3);
            this.layoutPanel_Product.Controls.Add(this.textBox_MfgDate, 1, 3);
            this.layoutPanel_Product.Controls.Add(this.textBox_Company, 0, 3);
            this.layoutPanel_Product.Controls.Add(this.label_ExpDate, 2, 2);
            this.layoutPanel_Product.Controls.Add(this.label_MfgDate, 1, 2);
            this.layoutPanel_Product.Controls.Add(this.label_Company, 0, 2);
            this.layoutPanel_Product.Controls.Add(this.textBox_Category, 2, 1);
            this.layoutPanel_Product.Controls.Add(this.textBox_Name, 1, 1);
            this.layoutPanel_Product.Controls.Add(this.label_Category, 2, 0);
            this.layoutPanel_Product.Controls.Add(this.label_Name, 1, 0);
            this.layoutPanel_Product.Controls.Add(this.label_ID, 0, 0);
            this.layoutPanel_Product.Controls.Add(this.textBox_Id, 0, 1);
            this.layoutPanel_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel_Product.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel_Product.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel_Product.Name = "layoutPanel_Product";
            this.layoutPanel_Product.RowCount = 4;
            this.layoutPanel_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Product.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Product.Size = new System.Drawing.Size(1796, 323);
            this.layoutPanel_Product.TabIndex = 0;
            // 
            // textBox_ExpDate
            // 
            this.textBox_ExpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ExpDate.Location = new System.Drawing.Point(1248, 265);
            this.textBox_ExpDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_ExpDate.Name = "textBox_ExpDate";
            this.textBox_ExpDate.Size = new System.Drawing.Size(496, 32);
            this.textBox_ExpDate.TabIndex = 11;
            // 
            // textBox_MfgDate
            // 
            this.textBox_MfgDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MfgDate.Location = new System.Drawing.Point(649, 265);
            this.textBox_MfgDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_MfgDate.Name = "textBox_MfgDate";
            this.textBox_MfgDate.Size = new System.Drawing.Size(496, 32);
            this.textBox_MfgDate.TabIndex = 10;
            // 
            // textBox_Company
            // 
            this.textBox_Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Company.Location = new System.Drawing.Point(51, 265);
            this.textBox_Company.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Company.Name = "textBox_Company";
            this.textBox_Company.Size = new System.Drawing.Size(496, 32);
            this.textBox_Company.TabIndex = 9;
            // 
            // label_ExpDate
            // 
            this.label_ExpDate.AutoSize = true;
            this.label_ExpDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_ExpDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_ExpDate.Location = new System.Drawing.Point(1202, 214);
            this.label_ExpDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ExpDate.Name = "label_ExpDate";
            this.label_ExpDate.Size = new System.Drawing.Size(588, 26);
            this.label_ExpDate.TabIndex = 8;
            this.label_ExpDate.Text = "Hạn sử dụng";
            this.label_ExpDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_MfgDate
            // 
            this.label_MfgDate.AutoSize = true;
            this.label_MfgDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_MfgDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_MfgDate.Location = new System.Drawing.Point(604, 214);
            this.label_MfgDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_MfgDate.Name = "label_MfgDate";
            this.label_MfgDate.Size = new System.Drawing.Size(586, 26);
            this.label_MfgDate.TabIndex = 7;
            this.label_MfgDate.Text = "Ngày sản xuất";
            this.label_MfgDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Company
            // 
            this.label_Company.AutoSize = true;
            this.label_Company.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Company.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Company.Location = new System.Drawing.Point(6, 214);
            this.label_Company.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Company.Name = "label_Company";
            this.label_Company.Size = new System.Drawing.Size(586, 26);
            this.label_Company.TabIndex = 6;
            this.label_Company.Text = "Công ty sản xuất";
            this.label_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Category
            // 
            this.textBox_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Category.Location = new System.Drawing.Point(1248, 104);
            this.textBox_Category.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.Size = new System.Drawing.Size(496, 32);
            this.textBox_Category.TabIndex = 5;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Name.Location = new System.Drawing.Point(649, 104);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(496, 32);
            this.textBox_Name.TabIndex = 4;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Category.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Category.Location = new System.Drawing.Point(1202, 54);
            this.label_Category.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(588, 26);
            this.label_Category.TabIndex = 3;
            this.label_Category.Text = "Loại sản phẩm";
            this.label_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Name.Location = new System.Drawing.Point(604, 54);
            this.label_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(586, 26);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Tên sản phẩm";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_ID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_ID.Location = new System.Drawing.Point(6, 54);
            this.label_ID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(586, 26);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "Mã sản phẩm";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Id.Location = new System.Drawing.Point(51, 104);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(496, 32);
            this.textBox_Id.TabIndex = 1;
            // 
            // tabPage_Category
            // 
            this.tabPage_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.tabPage_Category.Controls.Add(this.layoutPanel_Category);
            this.tabPage_Category.Location = new System.Drawing.Point(8, 28);
            this.tabPage_Category.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Category.Name = "tabPage_Category";
            this.tabPage_Category.Size = new System.Drawing.Size(1796, 324);
            this.tabPage_Category.TabIndex = 1;
            this.tabPage_Category.Text = "Category";
            // 
            // layoutPanel_Category
            // 
            this.layoutPanel_Category.ColumnCount = 1;
            this.layoutPanel_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel_Category.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel_Category.Controls.Add(this.comboBox_CatHeader, 0, 1);
            this.layoutPanel_Category.Controls.Add(this.label_Category_Output, 0, 0);
            this.layoutPanel_Category.Controls.Add(this.label_Category_Input, 0, 2);
            this.layoutPanel_Category.Controls.Add(this.textBox_CatHeader, 0, 3);
            this.layoutPanel_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel_Category.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel_Category.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel_Category.Name = "layoutPanel_Category";
            this.layoutPanel_Category.RowCount = 4;
            this.layoutPanel_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Category.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutPanel_Category.Size = new System.Drawing.Size(1796, 324);
            this.layoutPanel_Category.TabIndex = 0;
            // 
            // comboBox_CatHeader
            // 
            this.comboBox_CatHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_CatHeader.FormattingEnabled = true;
            this.comboBox_CatHeader.Location = new System.Drawing.Point(650, 104);
            this.comboBox_CatHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox_CatHeader.Name = "comboBox_CatHeader";
            this.comboBox_CatHeader.Size = new System.Drawing.Size(496, 34);
            this.comboBox_CatHeader.TabIndex = 5;
            this.comboBox_CatHeader.SelectedIndexChanged += new System.EventHandler(this.comboBox_CatHeader_SelectedIndexChanged);
            this.comboBox_CatHeader.SelectedValueChanged += new System.EventHandler(this.comboBox_CatHeader_SelectedValueChanged);
            // 
            // label_Category_Output
            // 
            this.label_Category_Output.AutoSize = true;
            this.label_Category_Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Category_Output.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Category_Output.Location = new System.Drawing.Point(6, 55);
            this.label_Category_Output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Category_Output.Name = "label_Category_Output";
            this.label_Category_Output.Size = new System.Drawing.Size(1784, 26);
            this.label_Category_Output.TabIndex = 3;
            this.label_Category_Output.Text = "Danh sách các sản phẩm theo nhóm";
            this.label_Category_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Category_Input
            // 
            this.label_Category_Input.AutoSize = true;
            this.label_Category_Input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Category_Input.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Category_Input.Location = new System.Drawing.Point(6, 217);
            this.label_Category_Input.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Category_Input.Name = "label_Category_Input";
            this.label_Category_Input.Size = new System.Drawing.Size(1784, 26);
            this.label_Category_Input.TabIndex = 4;
            this.label_Category_Input.Text = "Thêm mới hoặc sửa danh sách sản phẩm";
            this.label_Category_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_CatHeader
            // 
            this.textBox_CatHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_CatHeader.Location = new System.Drawing.Point(650, 267);
            this.textBox_CatHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_CatHeader.Name = "textBox_CatHeader";
            this.textBox_CatHeader.Size = new System.Drawing.Size(496, 32);
            this.textBox_CatHeader.TabIndex = 2;
            // 
            // layoutPanel_SearchButton
            // 
            this.layoutPanel_SearchButton.ColumnCount = 2;
            this.layoutPanel_SearchButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutPanel_SearchButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutPanel_SearchButton.Controls.Add(this.layoutPanel_Button, 1, 0);
            this.layoutPanel_SearchButton.Controls.Add(this.layoutPanel_Search, 0, 0);
            this.layoutPanel_SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel_SearchButton.Location = new System.Drawing.Point(6, 377);
            this.layoutPanel_SearchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.layoutPanel_SearchButton.Name = "layoutPanel_SearchButton";
            this.layoutPanel_SearchButton.RowCount = 1;
            this.layoutPanel_SearchButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel_SearchButton.Size = new System.Drawing.Size(1812, 94);
            this.layoutPanel_SearchButton.TabIndex = 2;
            // 
            // layoutPanel_Button
            // 
            this.layoutPanel_Button.ColumnCount = 5;
            this.layoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutPanel_Button.Controls.Add(this.button_Del, 3, 0);
            this.layoutPanel_Button.Controls.Add(this.button_Get, 4, 0);
            this.layoutPanel_Button.Controls.Add(this.button_Edit, 2, 0);
            this.layoutPanel_Button.Controls.Add(this.button_Add, 1, 0);
            this.layoutPanel_Button.Controls.Add(this.button_Search, 0, 0);
            this.layoutPanel_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel_Button.Location = new System.Drawing.Point(724, 0);
            this.layoutPanel_Button.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel_Button.Name = "layoutPanel_Button";
            this.layoutPanel_Button.RowCount = 1;
            this.layoutPanel_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel_Button.Size = new System.Drawing.Size(1088, 94);
            this.layoutPanel_Button.TabIndex = 1;
            // 
            // button_Del
            // 
            this.button_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Del.Location = new System.Drawing.Point(684, 23);
            this.button_Del.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(150, 48);
            this.button_Del.TabIndex = 4;
            this.button_Del.Text = "Xóa";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // button_Get
            // 
            this.button_Get.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Get.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Get.Location = new System.Drawing.Point(903, 23);
            this.button_Get.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(150, 48);
            this.button_Get.TabIndex = 3;
            this.button_Get.Text = "Tất cả SP";
            this.button_Get.UseVisualStyleBackColor = true;
            this.button_Get.Click += new System.EventHandler(this.button_Get_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Edit.Location = new System.Drawing.Point(467, 23);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(150, 48);
            this.button_Edit.TabIndex = 2;
            this.button_Edit.Text = "Sửa";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Add.Location = new System.Drawing.Point(250, 23);
            this.button_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(150, 48);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Thêm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Search.Location = new System.Drawing.Point(33, 23);
            this.button_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(150, 48);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "Tìm kiếm";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // layoutPanel_Search
            // 
            this.layoutPanel_Search.ColumnCount = 1;
            this.layoutPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel_Search.Controls.Add(this.textBox_Search, 0, 1);
            this.layoutPanel_Search.Controls.Add(this.label_Search, 0, 0);
            this.layoutPanel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel_Search.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel_Search.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel_Search.Name = "layoutPanel_Search";
            this.layoutPanel_Search.RowCount = 2;
            this.layoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel_Search.Size = new System.Drawing.Size(724, 94);
            this.layoutPanel_Search.TabIndex = 2;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Search.Location = new System.Drawing.Point(8, 55);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(708, 31);
            this.textBox_Search.TabIndex = 0;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Search.Location = new System.Drawing.Point(6, 17);
            this.label_Search.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(712, 30);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Nhập mã hoặc loại sản phẩm để tìm kiếm";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(68)))));
            this.panel_Top.Controls.Add(this.btnMinimize);
            this.panel_Top.Controls.Add(this.btnMaximize);
            this.panel_Top.Controls.Add(this.btnExit);
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(2016, 59);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::QuanLyCuaHang.Properties.Resources.white_minimize_32;
            this.btnMinimize.Location = new System.Drawing.Point(1808, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 46);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::QuanLyCuaHang.Properties.Resources.white_maximize_32;
            this.btnMaximize.Location = new System.Drawing.Point(1872, 7);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 46);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QuanLyCuaHang.Properties.Resources.white_exit_32;
            this.btnExit.Location = new System.Drawing.Point(1944, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Title.AutoSize = true;
            this.label_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Title.Location = new System.Drawing.Point(852, 21);
            this.label_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(247, 30);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Quản Lý Cửa Hàng";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2016, 1181);
            this.Controls.Add(this.layoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "View";
            this.Text = "Quản Lý Cửa Hàng";
            this.layoutPanel1.ResumeLayout(false);
            this.panel_Center.ResumeLayout(false);
            this.layoutPanel2.ResumeLayout(false);
            this.layoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_Product.ResumeLayout(false);
            this.layoutPanel_Product.ResumeLayout(false);
            this.layoutPanel_Product.PerformLayout();
            this.tabPage_Category.ResumeLayout(false);
            this.layoutPanel_Category.ResumeLayout(false);
            this.layoutPanel_Category.PerformLayout();
            this.layoutPanel_SearchButton.ResumeLayout(false);
            this.layoutPanel_Button.ResumeLayout(false);
            this.layoutPanel_Search.ResumeLayout(false);
            this.layoutPanel_Search.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel1;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Center;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.TableLayoutPanel layoutPanel2;
        private System.Windows.Forms.TableLayoutPanel layoutPanel3;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.TabPage tabPage_Category;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_Product;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_Category;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_SearchButton;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_Button;
        private System.Windows.Forms.Button button_Get;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_ExpDate;
        private System.Windows.Forms.TextBox textBox_MfgDate;
        private System.Windows.Forms.TextBox textBox_Company;
        private System.Windows.Forms.Label label_ExpDate;
        private System.Windows.Forms.Label label_MfgDate;
        private System.Windows.Forms.Label label_Company;
        private System.Windows.Forms.TextBox textBox_Category;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.ComboBox comboBox_CatHeader;
        private System.Windows.Forms.Label label_Category_Output;
        private System.Windows.Forms.Label label_Category_Input;
        private System.Windows.Forms.TextBox textBox_CatHeader;
        private System.Windows.Forms.Button button_Del;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}

