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
            this.tabPageMeasurementUnit = new System.Windows.Forms.TabPage();
            this.label_U_M_Crud = new System.Windows.Forms.Label();
            this.panel_U_M = new System.Windows.Forms.Panel();
            this.button_U_M_Del = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_U_M_Add = new System.Windows.Forms.Button();
            this.button_U_M_Cancel = new System.Windows.Forms.Button();
            this.button_U_M_Search = new System.Windows.Forms.Button();
            this.label_U_M = new System.Windows.Forms.Label();
            this.textBox_ItemU_M = new System.Windows.Forms.TextBox();
            this.dataGridView_U_M = new System.Windows.Forms.DataGridView();
            this.M_U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_U_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
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
            this.tabPagItems.Location = new System.Drawing.Point(4, 33);
            this.tabPagItems.Name = "tabPagItems";
            this.tabPagItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagItems.Size = new System.Drawing.Size(1124, 522);
            this.tabPagItems.TabIndex = 1;
            this.tabPagItems.Text = "Items";
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
            this.panel_U_M.Controls.Add(this.button_U_M_Del);
            this.panel_U_M.Controls.Add(this.button4);
            this.panel_U_M.Controls.Add(this.button_U_M_Add);
            this.panel_U_M.Controls.Add(this.button_U_M_Cancel);
            this.panel_U_M.Controls.Add(this.button_U_M_Search);
            this.panel_U_M.Controls.Add(this.label_U_M);
            this.panel_U_M.Controls.Add(this.textBox_ItemU_M);
            this.panel_U_M.Location = new System.Drawing.Point(412, 57);
            this.panel_U_M.Name = "panel_U_M";
            this.panel_U_M.Size = new System.Drawing.Size(694, 198);
            this.panel_U_M.TabIndex = 1;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
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
            // 
            // button_U_M_Search
            // 
            this.button_U_M_Search.Location = new System.Drawing.Point(18, 140);
            this.button_U_M_Search.Name = "button_U_M_Search";
            this.button_U_M_Search.Size = new System.Drawing.Size(91, 37);
            this.button_U_M_Search.TabIndex = 2;
            this.button_U_M_Search.Text = "Search";
            this.button_U_M_Search.UseVisualStyleBackColor = true;
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
            this.M_U_ID.DataPropertyName = "ID";
            this.M_U_ID.HeaderText = "ID";
            this.M_U_ID.Name = "M_U_ID";
            this.M_U_ID.ReadOnly = true;
            // 
            // M_U_Name
            // 
            this.M_U_Name.DataPropertyName = "ItemU_M";
            this.M_U_Name.HeaderText = "Measurement Unit Name";
            this.M_U_Name.Name = "M_U_Name";
            this.M_U_Name.ReadOnly = true;
            this.M_U_Name.ToolTipText = "Kg, gram, etc ..";
            this.M_U_Name.Width = 200;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn M_U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_U_Name;
        private System.Windows.Forms.Label label_U_M_Crud;
        private System.Windows.Forms.Panel panel_U_M;
        private System.Windows.Forms.Label label_U_M;
        private System.Windows.Forms.TextBox textBox_ItemU_M;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_U_M_Add;
        private System.Windows.Forms.Button button_U_M_Cancel;
        private System.Windows.Forms.Button button_U_M_Search;
        private System.Windows.Forms.Button button_U_M_Del;
    }
}

