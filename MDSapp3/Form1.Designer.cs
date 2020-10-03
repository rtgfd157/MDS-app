namespace MDSapp3
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Order = new System.Windows.Forms.TabPage();
            this.tabPagItems = new System.Windows.Forms.TabPage();
            this.labelItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxItemsAmount = new System.Windows.Forms.TextBox();
            this.labelItemsAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonItemsDel = new System.Windows.Forms.Button();
            this.buttonItemsEdit = new System.Windows.Forms.Button();
            this.buttonItemsAdd = new System.Windows.Forms.Button();
            this.buttonItemsCancel = new System.Windows.Forms.Button();
            this.buttonIndexSearch = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemU_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMeasurementUnit = new System.Windows.Forms.TabPage();
            this.label_U_M_Crud = new System.Windows.Forms.Label();
            this.panel_U_M = new System.Windows.Forms.Panel();
            this.label_Slash = new System.Windows.Forms.Label();
            this.button_U_M_Desc = new System.Windows.Forms.Button();
            this.button_U_M_Asc = new System.Windows.Forms.Button();
            this.label_U_M_Sorting = new System.Windows.Forms.Label();
            this.button_U_M_Del = new System.Windows.Forms.Button();
            this.button_U_M_Edit = new System.Windows.Forms.Button();
            this.button_U_M_Add = new System.Windows.Forms.Button();
            this.button_U_M_Cancel = new System.Windows.Forms.Button();
            this.button_U_M_Search = new System.Windows.Forms.Button();
            this.label_U_M = new System.Windows.Forms.Label();
            this.textBox_ItemU_M = new System.Windows.Forms.TextBox();
            this.dataGridView_U_M = new System.Windows.Forms.DataGridView();
            this.M_U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_U_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxItemsPrice = new System.Windows.Forms.TextBox();
            this.labelItemsPrice = new System.Windows.Forms.Label();
            this.labelItemsMeasuremntUnit = new System.Windows.Forms.Label();
            this.comboBoxMeasuremntUnit = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPagItems.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.tabPageMeasurementUnit.SuspendLayout();
            this.panel_U_M.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_U_M)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Order);
            this.tabControl.Controls.Add(this.tabPagItems);
            this.tabControl.Controls.Add(this.tabPageMeasurementUnit);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1132, 559);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Order
            // 
            this.tabPage_Order.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage_Order.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Order.Name = "tabPage_Order";
            this.tabPage_Order.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Order.Size = new System.Drawing.Size(1124, 522);
            this.tabPage_Order.TabIndex = 0;
            this.tabPage_Order.Text = "Order";
            // 
            // tabPagItems
            // 
            this.tabPagItems.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPagItems.Controls.Add(this.labelItems);
            this.tabPagItems.Controls.Add(this.panel1);
            this.tabPagItems.Controls.Add(this.dataGridViewItems);
            this.tabPagItems.Location = new System.Drawing.Point(4, 33);
            this.tabPagItems.Name = "tabPagItems";
            this.tabPagItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagItems.Size = new System.Drawing.Size(1124, 522);
            this.tabPagItems.TabIndex = 1;
            this.tabPagItems.Text = "Items";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelItems.Location = new System.Drawing.Point(752, 6);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(120, 31);
            this.labelItems.TabIndex = 3;
            this.labelItems.Text = "Actions:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxMeasuremntUnit);
            this.panel1.Controls.Add(this.labelItemsMeasuremntUnit);
            this.panel1.Controls.Add(this.textBoxItemsPrice);
            this.panel1.Controls.Add(this.labelItemsPrice);
            this.panel1.Controls.Add(this.textBoxItemsAmount);
            this.panel1.Controls.Add(this.labelItemsAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonItemsDel);
            this.panel1.Controls.Add(this.buttonItemsEdit);
            this.panel1.Controls.Add(this.buttonItemsAdd);
            this.panel1.Controls.Add(this.buttonItemsCancel);
            this.panel1.Controls.Add(this.buttonIndexSearch);
            this.panel1.Location = new System.Drawing.Point(758, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 442);
            this.panel1.TabIndex = 1;
            // 
            // textBoxItemsAmount
            // 
            this.textBoxItemsAmount.Location = new System.Drawing.Point(109, 15);
            this.textBoxItemsAmount.Name = "textBoxItemsAmount";
            this.textBoxItemsAmount.Size = new System.Drawing.Size(100, 29);
            this.textBoxItemsAmount.TabIndex = 21;
            this.textBoxItemsAmount.TextChanged += new System.EventHandler(this.textBoxItemsAmount_TextChanged);
            // 
            // labelItemsAmount
            // 
            this.labelItemsAmount.AutoSize = true;
            this.labelItemsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelItemsAmount.Location = new System.Drawing.Point(15, 15);
            this.labelItemsAmount.Name = "labelItemsAmount";
            this.labelItemsAmount.Size = new System.Drawing.Size(88, 24);
            this.labelItemsAmount.TabIndex = 20;
            this.labelItemsAmount.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(141, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "DESC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "ASC";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sorting:";
            // 
            // buttonItemsDel
            // 
            this.buttonItemsDel.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonItemsDel.Location = new System.Drawing.Point(249, 398);
            this.buttonItemsDel.Name = "buttonItemsDel";
            this.buttonItemsDel.Size = new System.Drawing.Size(106, 37);
            this.buttonItemsDel.TabIndex = 15;
            this.buttonItemsDel.Text = "Delete";
            this.buttonItemsDel.UseCompatibleTextRendering = true;
            this.buttonItemsDel.UseVisualStyleBackColor = true;
            // 
            // buttonItemsEdit
            // 
            this.buttonItemsEdit.Location = new System.Drawing.Point(264, 300);
            this.buttonItemsEdit.Name = "buttonItemsEdit";
            this.buttonItemsEdit.Size = new System.Drawing.Size(91, 37);
            this.buttonItemsEdit.TabIndex = 14;
            this.buttonItemsEdit.Text = "Edit";
            this.buttonItemsEdit.UseVisualStyleBackColor = true;
            // 
            // buttonItemsAdd
            // 
            this.buttonItemsAdd.Location = new System.Drawing.Point(143, 300);
            this.buttonItemsAdd.Name = "buttonItemsAdd";
            this.buttonItemsAdd.Size = new System.Drawing.Size(91, 37);
            this.buttonItemsAdd.TabIndex = 13;
            this.buttonItemsAdd.Text = "Add";
            this.buttonItemsAdd.UseVisualStyleBackColor = true;
            // 
            // buttonItemsCancel
            // 
            this.buttonItemsCancel.Location = new System.Drawing.Point(264, 222);
            this.buttonItemsCancel.Name = "buttonItemsCancel";
            this.buttonItemsCancel.Size = new System.Drawing.Size(91, 37);
            this.buttonItemsCancel.TabIndex = 12;
            this.buttonItemsCancel.Text = "Cancel";
            this.buttonItemsCancel.UseVisualStyleBackColor = true;
            // 
            // buttonIndexSearch
            // 
            this.buttonIndexSearch.Location = new System.Drawing.Point(143, 222);
            this.buttonIndexSearch.Name = "buttonIndexSearch";
            this.buttonIndexSearch.Size = new System.Drawing.Size(91, 37);
            this.buttonIndexSearch.TabIndex = 11;
            this.buttonIndexSearch.Text = "Search";
            this.buttonIndexSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.OrderID,
            this.ItemAmount,
            this.ItemPrice,
            this.ItemU_M,
            this.ItemDescription});
            this.dataGridViewItems.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.Size = new System.Drawing.Size(740, 510);
            this.dataGridViewItems.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "Item Amount";
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // ItemU_M
            // 
            this.ItemU_M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemU_M.DataPropertyName = "ItemU_M";
            this.ItemU_M.HeaderText = "Measuremnt Unit";
            this.ItemU_M.MinimumWidth = 10;
            this.ItemU_M.Name = "ItemU_M";
            this.ItemU_M.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // tabPageMeasurementUnit
            // 
            this.tabPageMeasurementUnit.BackColor = System.Drawing.Color.LightGray;
            this.tabPageMeasurementUnit.Controls.Add(this.label_U_M_Crud);
            this.tabPageMeasurementUnit.Controls.Add(this.panel_U_M);
            this.tabPageMeasurementUnit.Controls.Add(this.dataGridView_U_M);
            this.tabPageMeasurementUnit.Location = new System.Drawing.Point(4, 33);
            this.tabPageMeasurementUnit.Name = "tabPageMeasurementUnit";
            this.tabPageMeasurementUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasurementUnit.Size = new System.Drawing.Size(1124, 522);
            this.tabPageMeasurementUnit.TabIndex = 2;
            this.tabPageMeasurementUnit.Text = "Measurement Unit";
            // 
            // label_U_M_Crud
            // 
            this.label_U_M_Crud.AutoSize = true;
            this.label_U_M_Crud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_U_M_Crud.Location = new System.Drawing.Point(406, 23);
            this.label_U_M_Crud.Name = "label_U_M_Crud";
            this.label_U_M_Crud.Size = new System.Drawing.Size(120, 31);
            this.label_U_M_Crud.TabIndex = 2;
            this.label_U_M_Crud.Text = "Actions:";
            // 
            // panel_U_M
            // 
            this.panel_U_M.Controls.Add(this.label_Slash);
            this.panel_U_M.Controls.Add(this.button_U_M_Desc);
            this.panel_U_M.Controls.Add(this.button_U_M_Asc);
            this.panel_U_M.Controls.Add(this.label_U_M_Sorting);
            this.panel_U_M.Controls.Add(this.button_U_M_Del);
            this.panel_U_M.Controls.Add(this.button_U_M_Edit);
            this.panel_U_M.Controls.Add(this.button_U_M_Add);
            this.panel_U_M.Controls.Add(this.button_U_M_Cancel);
            this.panel_U_M.Controls.Add(this.button_U_M_Search);
            this.panel_U_M.Controls.Add(this.label_U_M);
            this.panel_U_M.Controls.Add(this.textBox_ItemU_M);
            this.panel_U_M.Location = new System.Drawing.Point(412, 57);
            this.panel_U_M.Name = "panel_U_M";
            this.panel_U_M.Size = new System.Drawing.Size(694, 334);
            this.panel_U_M.TabIndex = 1;
            // 
            // label_Slash
            // 
            this.label_Slash.AutoSize = true;
            this.label_Slash.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Slash.Location = new System.Drawing.Point(126, 242);
            this.label_Slash.Name = "label_Slash";
            this.label_Slash.Size = new System.Drawing.Size(23, 33);
            this.label_Slash.TabIndex = 10;
            this.label_Slash.Text = "/";
            // 
            // button_U_M_Desc
            // 
            this.button_U_M_Desc.Location = new System.Drawing.Point(143, 242);
            this.button_U_M_Desc.Name = "button_U_M_Desc";
            this.button_U_M_Desc.Size = new System.Drawing.Size(80, 33);
            this.button_U_M_Desc.TabIndex = 9;
            this.button_U_M_Desc.Text = "DESC";
            this.button_U_M_Desc.UseVisualStyleBackColor = true;
            this.button_U_M_Desc.Click += new System.EventHandler(this.button_U_M_Desc_Click);
            // 
            // button_U_M_Asc
            // 
            this.button_U_M_Asc.Location = new System.Drawing.Point(36, 242);
            this.button_U_M_Asc.Name = "button_U_M_Asc";
            this.button_U_M_Asc.Size = new System.Drawing.Size(91, 33);
            this.button_U_M_Asc.TabIndex = 8;
            this.button_U_M_Asc.Text = "ASC";
            this.button_U_M_Asc.UseVisualStyleBackColor = true;
            this.button_U_M_Asc.Click += new System.EventHandler(this.button_U_M_Asc_Click);
            // 
            // label_U_M_Sorting
            // 
            this.label_U_M_Sorting.AutoSize = true;
            this.label_U_M_Sorting.Location = new System.Drawing.Point(32, 205);
            this.label_U_M_Sorting.Name = "label_U_M_Sorting";
            this.label_U_M_Sorting.Size = new System.Drawing.Size(74, 24);
            this.label_U_M_Sorting.TabIndex = 7;
            this.label_U_M_Sorting.Text = "Sorting:";
            // 
            // button_U_M_Del
            // 
            this.button_U_M_Del.ForeColor = System.Drawing.Color.DarkRed;
            this.button_U_M_Del.Location = new System.Drawing.Point(518, 140);
            this.button_U_M_Del.Name = "button_U_M_Del";
            this.button_U_M_Del.Size = new System.Drawing.Size(106, 37);
            this.button_U_M_Del.TabIndex = 6;
            this.button_U_M_Del.Text = "Delete";
            this.button_U_M_Del.UseCompatibleTextRendering = true;
            this.button_U_M_Del.UseVisualStyleBackColor = true;
            this.button_U_M_Del.Click += new System.EventHandler(this.button_U_M_Del_Click);
            // 
            // button_U_M_Edit
            // 
            this.button_U_M_Edit.Location = new System.Drawing.Point(389, 140);
            this.button_U_M_Edit.Name = "button_U_M_Edit";
            this.button_U_M_Edit.Size = new System.Drawing.Size(91, 37);
            this.button_U_M_Edit.TabIndex = 5;
            this.button_U_M_Edit.Text = "Edit";
            this.button_U_M_Edit.UseVisualStyleBackColor = true;
            this.button_U_M_Edit.Click += new System.EventHandler(this.button_U_M_Edit_Click);
            // 
            // button_U_M_Add
            // 
            this.button_U_M_Add.Location = new System.Drawing.Point(268, 140);
            this.button_U_M_Add.Name = "button_U_M_Add";
            this.button_U_M_Add.Size = new System.Drawing.Size(91, 37);
            this.button_U_M_Add.TabIndex = 4;
            this.button_U_M_Add.Text = "Add";
            this.button_U_M_Add.UseVisualStyleBackColor = true;
            this.button_U_M_Add.Click += new System.EventHandler(this.button_U_M_Add_Click);
            // 
            // button_U_M_Cancel
            // 
            this.button_U_M_Cancel.Location = new System.Drawing.Point(132, 140);
            this.button_U_M_Cancel.Name = "button_U_M_Cancel";
            this.button_U_M_Cancel.Size = new System.Drawing.Size(91, 37);
            this.button_U_M_Cancel.TabIndex = 3;
            this.button_U_M_Cancel.Text = "Cancel";
            this.button_U_M_Cancel.UseVisualStyleBackColor = true;
            this.button_U_M_Cancel.Click += new System.EventHandler(this.button_U_M_Cancel_Click);
            // 
            // button_U_M_Search
            // 
            this.button_U_M_Search.Location = new System.Drawing.Point(18, 140);
            this.button_U_M_Search.Name = "button_U_M_Search";
            this.button_U_M_Search.Size = new System.Drawing.Size(91, 37);
            this.button_U_M_Search.TabIndex = 2;
            this.button_U_M_Search.Text = "Search";
            this.button_U_M_Search.UseVisualStyleBackColor = true;
            this.button_U_M_Search.Click += new System.EventHandler(this.button_U_M_Search_Click);
            // 
            // label_U_M
            // 
            this.label_U_M.AutoSize = true;
            this.label_U_M.Location = new System.Drawing.Point(14, 19);
            this.label_U_M.Name = "label_U_M";
            this.label_U_M.Size = new System.Drawing.Size(318, 24);
            this.label_U_M.TabIndex = 1;
            this.label_U_M.Text = "Measurement Unit(Kg, Gram, etc\' ...):";
            // 
            // textBox_ItemU_M
            // 
            this.textBox_ItemU_M.Location = new System.Drawing.Point(346, 19);
            this.textBox_ItemU_M.Name = "textBox_ItemU_M";
            this.textBox_ItemU_M.Size = new System.Drawing.Size(310, 29);
            this.textBox_ItemU_M.TabIndex = 0;
            // 
            // dataGridView_U_M
            // 
            this.dataGridView_U_M.AllowUserToDeleteRows = false;
            this.dataGridView_U_M.AllowUserToOrderColumns = true;
            this.dataGridView_U_M.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_U_M.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_U_ID,
            this.M_U_Name});
            this.dataGridView_U_M.Location = new System.Drawing.Point(57, 23);
            this.dataGridView_U_M.Name = "dataGridView_U_M";
            this.dataGridView_U_M.ReadOnly = true;
            this.dataGridView_U_M.Size = new System.Drawing.Size(343, 462);
            this.dataGridView_U_M.TabIndex = 0;
            this.dataGridView_U_M.DoubleClick += new System.EventHandler(this.dataGridView_U_M_DoubleClick);
            // 
            // M_U_ID
            // 
            this.M_U_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_U_ID.DataPropertyName = "ID";
            this.M_U_ID.HeaderText = "ID";
            this.M_U_ID.Name = "M_U_ID";
            this.M_U_ID.ReadOnly = true;
            this.M_U_ID.Visible = false;
            // 
            // M_U_Name
            // 
            this.M_U_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.M_U_Name.DataPropertyName = "ItemU_M";
            this.M_U_Name.HeaderText = "Measurement Unit Name";
            this.M_U_Name.Name = "M_U_Name";
            this.M_U_Name.ReadOnly = true;
            this.M_U_Name.ToolTipText = "Kg, gram, etc ..";
            // 
            // textBoxItemsPrice
            // 
            this.textBoxItemsPrice.Location = new System.Drawing.Point(109, 64);
            this.textBoxItemsPrice.Name = "textBoxItemsPrice";
            this.textBoxItemsPrice.Size = new System.Drawing.Size(100, 29);
            this.textBoxItemsPrice.TabIndex = 23;
            this.textBoxItemsPrice.TextChanged += new System.EventHandler(this.textBoxItemsPrice_TextChanged);
            // 
            // labelItemsPrice
            // 
            this.labelItemsPrice.AutoSize = true;
            this.labelItemsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelItemsPrice.Location = new System.Drawing.Point(15, 64);
            this.labelItemsPrice.Name = "labelItemsPrice";
            this.labelItemsPrice.Size = new System.Drawing.Size(64, 24);
            this.labelItemsPrice.TabIndex = 22;
            this.labelItemsPrice.Text = "Price:";
            // 
            // labelItemsMeasuremntUnit
            // 
            this.labelItemsMeasuremntUnit.AutoSize = true;
            this.labelItemsMeasuremntUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelItemsMeasuremntUnit.Location = new System.Drawing.Point(15, 112);
            this.labelItemsMeasuremntUnit.Name = "labelItemsMeasuremntUnit";
            this.labelItemsMeasuremntUnit.Size = new System.Drawing.Size(173, 24);
            this.labelItemsMeasuremntUnit.TabIndex = 24;
            this.labelItemsMeasuremntUnit.Text = "Measuremnt Unit:";
            // 
            // comboBoxMeasuremntUnit
            // 
            this.comboBoxMeasuremntUnit.FormattingEnabled = true;
            this.comboBoxMeasuremntUnit.Location = new System.Drawing.Point(210, 112);
            this.comboBoxMeasuremntUnit.Name = "comboBoxMeasuremntUnit";
            this.comboBoxMeasuremntUnit.Size = new System.Drawing.Size(121, 32);
            this.comboBoxMeasuremntUnit.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 584);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDS App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPagItems.ResumeLayout(false);
            this.tabPagItems.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.tabPageMeasurementUnit.ResumeLayout(false);
            this.tabPageMeasurementUnit.PerformLayout();
            this.panel_U_M.ResumeLayout(false);
            this.panel_U_M.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_U_M)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Order;
        private System.Windows.Forms.TabPage tabPagItems;
        private System.Windows.Forms.TabPage tabPageMeasurementUnit;
        private System.Windows.Forms.DataGridView dataGridView_U_M;
        private System.Windows.Forms.Label label_U_M_Crud;
        private System.Windows.Forms.Panel panel_U_M;
        private System.Windows.Forms.Label label_U_M;
        private System.Windows.Forms.TextBox textBox_ItemU_M;
        private System.Windows.Forms.Button button_U_M_Edit;
        private System.Windows.Forms.Button button_U_M_Add;
        private System.Windows.Forms.Button button_U_M_Cancel;
        private System.Windows.Forms.Button button_U_M_Search;
        private System.Windows.Forms.Button button_U_M_Del;
        private System.Windows.Forms.Label label_Slash;
        private System.Windows.Forms.Button button_U_M_Desc;
        private System.Windows.Forms.Button button_U_M_Asc;
        private System.Windows.Forms.Label label_U_M_Sorting;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_U_Name;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxItemsAmount;
        private System.Windows.Forms.Label labelItemsAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonItemsDel;
        private System.Windows.Forms.Button buttonItemsEdit;
        private System.Windows.Forms.Button buttonItemsAdd;
        private System.Windows.Forms.Button buttonItemsCancel;
        private System.Windows.Forms.Button buttonIndexSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemU_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.TextBox textBoxItemsPrice;
        private System.Windows.Forms.Label labelItemsPrice;
        private System.Windows.Forms.ComboBox comboBoxMeasuremntUnit;
        private System.Windows.Forms.Label labelItemsMeasuremntUnit;
    }
}

