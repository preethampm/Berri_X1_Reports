namespace Berri_X1_Reports
{
    partial class MainFrom
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierProductListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSalesDivisonWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodicSalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purhaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDepartmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.purhaseToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.mISToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.supplierProductListToolStripMenuItem,
            this.productSalesDivisonWiseToolStripMenuItem,
            this.dailyToolStripMenuItem,
            this.periodicSalesReportToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // supplierProductListToolStripMenuItem
            // 
            this.supplierProductListToolStripMenuItem.Name = "supplierProductListToolStripMenuItem";
            this.supplierProductListToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.supplierProductListToolStripMenuItem.Text = "Product List";
            this.supplierProductListToolStripMenuItem.Click += new System.EventHandler(this.supplierProductListToolStripMenuItem_Click);
            // 
            // productSalesDivisonWiseToolStripMenuItem
            // 
            this.productSalesDivisonWiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withGPToolStripMenuItem,
            this.withoutGPToolStripMenuItem});
            this.productSalesDivisonWiseToolStripMenuItem.Name = "productSalesDivisonWiseToolStripMenuItem";
            this.productSalesDivisonWiseToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.productSalesDivisonWiseToolStripMenuItem.Text = "Product Sales Summary";
            this.productSalesDivisonWiseToolStripMenuItem.Click += new System.EventHandler(this.productSalesDivisonWiseToolStripMenuItem_Click);
            // 
            // withGPToolStripMenuItem
            // 
            this.withGPToolStripMenuItem.Name = "withGPToolStripMenuItem";
            this.withGPToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.withGPToolStripMenuItem.Text = "With GP";
            this.withGPToolStripMenuItem.Click += new System.EventHandler(this.withGPToolStripMenuItem_Click);
            // 
            // withoutGPToolStripMenuItem
            // 
            this.withoutGPToolStripMenuItem.Name = "withoutGPToolStripMenuItem";
            this.withoutGPToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.withoutGPToolStripMenuItem.Text = "Without GP";
            this.withoutGPToolStripMenuItem.Click += new System.EventHandler(this.withoutGPToolStripMenuItem_Click);
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.dailyToolStripMenuItem.Text = "Daily Sales Report";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
            // 
            // periodicSalesReportToolStripMenuItem
            // 
            this.periodicSalesReportToolStripMenuItem.Name = "periodicSalesReportToolStripMenuItem";
            this.periodicSalesReportToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.periodicSalesReportToolStripMenuItem.Text = "Periodic Sales Report";
            this.periodicSalesReportToolStripMenuItem.Click += new System.EventHandler(this.periodicSalesReportToolStripMenuItem_Click);
            // 
            // purhaseToolStripMenuItem
            // 
            this.purhaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseDepartmentReportToolStripMenuItem});
            this.purhaseToolStripMenuItem.Name = "purhaseToolStripMenuItem";
            this.purhaseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.purhaseToolStripMenuItem.Text = "Purhase";
            // 
            // purchaseDepartmentReportToolStripMenuItem
            // 
            this.purchaseDepartmentReportToolStripMenuItem.Name = "purchaseDepartmentReportToolStripMenuItem";
            this.purchaseDepartmentReportToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.purchaseDepartmentReportToolStripMenuItem.Text = "Purchase Department Summary Report ";
            this.purchaseDepartmentReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseDepartmentReportToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // mISToolStripMenuItem
            // 
            this.mISToolStripMenuItem.Name = "mISToolStripMenuItem";
            this.mISToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.mISToolStripMenuItem.Text = "MIS";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainFrom";
            this.Text = "Berri X1 Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purhaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierProductListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseDepartmentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSalesDivisonWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodicSalesReportToolStripMenuItem;
    }
}



