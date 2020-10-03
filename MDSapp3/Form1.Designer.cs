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
            this.tabControl.SuspendLayout();
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
            this.tabPageMeasurementUnit.Location = new System.Drawing.Point(4, 33);
            this.tabPageMeasurementUnit.Name = "tabPageMeasurementUnit";
            this.tabPageMeasurementUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasurementUnit.Size = new System.Drawing.Size(1124, 522);
            this.tabPageMeasurementUnit.TabIndex = 2;
            this.tabPageMeasurementUnit.Text = "Measurement Unit";
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
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Order;
        private System.Windows.Forms.TabPage tabPagItems;
        private System.Windows.Forms.TabPage tabPageMeasurementUnit;
    }
}

