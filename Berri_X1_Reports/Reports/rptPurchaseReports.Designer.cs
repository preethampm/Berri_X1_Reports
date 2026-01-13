
namespace Berri_X1_Reports
{
    partial class rptPurchaseReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPurchaseReports));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRowFilter = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmsPrintOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuInvoiceRcpt = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.cmbSummaryType = new System.Windows.Forms.ComboBox();
            this.btnBrnLookup = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBranches = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPurchType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.pnlRptType = new System.Windows.Forms.Panel();
            this.rbSummary = new System.Windows.Forms.RadioButton();
            this.rbDetailed = new System.Windows.Forms.RadioButton();
            this.btnCloseFilter = new System.Windows.Forms.Button();
            this.btnHideFilter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbReportName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnproItemSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grdData = new Telerik.WinControls.UI.RadGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsPrintOptions.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlRptType.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.pnlHeader.Controls.Add(this.lblFormName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 35);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(8, 5);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(161, 28);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Purchase Reports";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(188)))));
            this.pnlFooter.Controls.Add(this.panel2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 721);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(984, 40);
            this.pnlFooter.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnRowFilter);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(417, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 40);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filterl";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRowFilter
            // 
            this.btnRowFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRowFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRowFilter.Location = new System.Drawing.Point(228, 4);
            this.btnRowFilter.Name = "btnRowFilter";
            this.btnRowFilter.Size = new System.Drawing.Size(104, 35);
            this.btnRowFilter.TabIndex = 4;
            this.btnRowFilter.Text = "Row Filter";
            this.btnRowFilter.UseVisualStyleBackColor = true;
            this.btnRowFilter.Click += new System.EventHandler(this.btnRowFilter_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(122, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(104, 35);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(444, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(338, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 35);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmsPrintOptions
            // 
            this.cmsPrintOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsMenuInvoiceRcpt});
            this.cmsPrintOptions.Name = "cmsPrintOptions";
            this.cmsPrintOptions.Size = new System.Drawing.Size(197, 26);
            // 
            // cmsMenuInvoiceRcpt
            // 
            this.cmsMenuInvoiceRcpt.Name = "cmsMenuInvoiceRcpt";
            this.cmsMenuInvoiceRcpt.Size = new System.Drawing.Size(196, 22);
            this.cmsMenuInvoiceRcpt.Text = "Print Simplified Invoice";
            this.cmsMenuInvoiceRcpt.Click += new System.EventHandler(this.cmsMenuInvoiceRcpt_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.cmbSummaryType);
            this.pnlFilter.Controls.Add(this.btnBrnLookup);
            this.pnlFilter.Controls.Add(this.label14);
            this.pnlFilter.Controls.Add(this.txtBranches);
            this.pnlFilter.Controls.Add(this.label13);
            this.pnlFilter.Controls.Add(this.cmbPurchType);
            this.pnlFilter.Controls.Add(this.label12);
            this.pnlFilter.Controls.Add(this.btnRemoveSupplier);
            this.pnlFilter.Controls.Add(this.btnSupplier);
            this.pnlFilter.Controls.Add(this.txtSupplier);
            this.pnlFilter.Controls.Add(this.pnlRptType);
            this.pnlFilter.Controls.Add(this.btnCloseFilter);
            this.pnlFilter.Controls.Add(this.btnHideFilter);
            this.pnlFilter.Controls.Add(this.comboBox1);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.btnView);
            this.pnlFilter.Controls.Add(this.panel3);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.lblItemCode);
            this.pnlFilter.Controls.Add(this.btnproItemSearch);
            this.pnlFilter.Controls.Add(this.label8);
            this.pnlFilter.Controls.Add(this.cmbDepartment);
            this.pnlFilter.Controls.Add(this.label7);
            this.pnlFilter.Controls.Add(this.cmbCategory);
            this.pnlFilter.Controls.Add(this.label9);
            this.pnlFilter.Controls.Add(this.cmbSubCategory);
            this.pnlFilter.Controls.Add(this.label10);
            this.pnlFilter.Controls.Add(this.cmbDivision);
            this.pnlFilter.Controls.Add(this.label11);
            this.pnlFilter.Controls.Add(this.txtItemName);
            this.pnlFilter.Controls.Add(this.txtItemCode);
            this.pnlFilter.Controls.Add(this.cmbBrand);
            this.pnlFilter.Location = new System.Drawing.Point(95, 28);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(764, 247);
            this.pnlFilter.TabIndex = 8;
            // 
            // cmbSummaryType
            // 
            this.cmbSummaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummaryType.FormattingEnabled = true;
            this.cmbSummaryType.Items.AddRange(new object[] {
            "Branchwise Detailed",
            "Datewise Detailed",
            "Branchwise Summary",
            "Datewise Summary"});
            this.cmbSummaryType.Location = new System.Drawing.Point(102, 165);
            this.cmbSummaryType.Name = "cmbSummaryType";
            this.cmbSummaryType.Size = new System.Drawing.Size(239, 25);
            this.cmbSummaryType.TabIndex = 154;
            // 
            // btnBrnLookup
            // 
            this.btnBrnLookup.BackColor = System.Drawing.Color.Transparent;
            this.btnBrnLookup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrnLookup.FlatAppearance.BorderSize = 0;
            this.btnBrnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrnLookup.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrnLookup.Image = ((System.Drawing.Image)(resources.GetObject("btnBrnLookup.Image")));
            this.btnBrnLookup.Location = new System.Drawing.Point(343, 50);
            this.btnBrnLookup.Name = "btnBrnLookup";
            this.btnBrnLookup.Size = new System.Drawing.Size(23, 23);
            this.btnBrnLookup.TabIndex = 153;
            this.btnBrnLookup.Tag = "SRCH";
            this.btnBrnLookup.UseVisualStyleBackColor = false;
            this.btnBrnLookup.Click += new System.EventHandler(this.btnBrnLookup_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 151;
            this.label14.Text = "Branch";
            // 
            // txtBranches
            // 
            this.txtBranches.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranches.Location = new System.Drawing.Point(102, 51);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.ReadOnly = true;
            this.txtBranches.Size = new System.Drawing.Size(239, 22);
            this.txtBranches.TabIndex = 150;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 148;
            this.label13.Text = "Supplier";
            // 
            // cmbPurchType
            // 
            this.cmbPurchType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPurchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPurchType.FormattingEnabled = true;
            this.cmbPurchType.Items.AddRange(new object[] {
            "INTER BRANCH",
            "INTER COMPANY",
            "OUTSIDE"});
            this.cmbPurchType.Location = new System.Drawing.Point(102, 78);
            this.cmbPurchType.Name = "cmbPurchType";
            this.cmbPurchType.Size = new System.Drawing.Size(264, 25);
            this.cmbPurchType.TabIndex = 147;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 146;
            this.label12.Text = "Purchase Type";
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveSupplier.BackgroundImage")));
            this.btnRemoveSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveSupplier.FlatAppearance.BorderSize = 0;
            this.btnRemoveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSupplier.Location = new System.Drawing.Point(347, 112);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(11, 15);
            this.btnRemoveSupplier.TabIndex = 145;
            this.btnRemoveSupplier.Tag = "SRCH";
            this.btnRemoveSupplier.UseVisualStyleBackColor = false;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click_1);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.BackgroundImage")));
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(328, 109);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(13, 19);
            this.btnSupplier.TabIndex = 144;
            this.btnSupplier.Tag = "SRCH";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click_1);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(102, 108);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(264, 23);
            this.txtSupplier.TabIndex = 143;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // pnlRptType
            // 
            this.pnlRptType.Controls.Add(this.rbSummary);
            this.pnlRptType.Controls.Add(this.rbDetailed);
            this.pnlRptType.Location = new System.Drawing.Point(504, 161);
            this.pnlRptType.Name = "pnlRptType";
            this.pnlRptType.Size = new System.Drawing.Size(223, 31);
            this.pnlRptType.TabIndex = 142;
            this.pnlRptType.Visible = false;
            // 
            // rbSummary
            // 
            this.rbSummary.AutoSize = true;
            this.rbSummary.Checked = true;
            this.rbSummary.Location = new System.Drawing.Point(147, 5);
            this.rbSummary.Name = "rbSummary";
            this.rbSummary.Size = new System.Drawing.Size(80, 21);
            this.rbSummary.TabIndex = 0;
            this.rbSummary.TabStop = true;
            this.rbSummary.Text = "Summary";
            this.rbSummary.UseVisualStyleBackColor = true;
            // 
            // rbDetailed
            // 
            this.rbDetailed.AutoSize = true;
            this.rbDetailed.Location = new System.Drawing.Point(11, 5);
            this.rbDetailed.Name = "rbDetailed";
            this.rbDetailed.Size = new System.Drawing.Size(78, 21);
            this.rbDetailed.TabIndex = 0;
            this.rbDetailed.Text = "Detailed";
            this.rbDetailed.UseVisualStyleBackColor = true;
            // 
            // btnCloseFilter
            // 
            this.btnCloseFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCloseFilter.FlatAppearance.BorderSize = 0;
            this.btnCloseFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCloseFilter.Location = new System.Drawing.Point(428, 205);
            this.btnCloseFilter.Name = "btnCloseFilter";
            this.btnCloseFilter.Size = new System.Drawing.Size(111, 35);
            this.btnCloseFilter.TabIndex = 141;
            this.btnCloseFilter.Text = "&Close";
            this.btnCloseFilter.UseVisualStyleBackColor = false;
            this.btnCloseFilter.Click += new System.EventHandler(this.btnCloseFilter_Click);
            // 
            // btnHideFilter
            // 
            this.btnHideFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHideFilter.FlatAppearance.BorderSize = 0;
            this.btnHideFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideFilter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHideFilter.Location = new System.Drawing.Point(313, 205);
            this.btnHideFilter.Name = "btnHideFilter";
            this.btnHideFilter.Size = new System.Drawing.Size(111, 35);
            this.btnHideFilter.TabIndex = 141;
            this.btnHideFilter.Text = "&Hide";
            this.btnHideFilter.UseVisualStyleBackColor = false;
            this.btnHideFilter.Click += new System.EventHandler(this.btnHideFilter_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Summary",
            "Detailed",
            "Transactionwise"});
            this.comboBox1.Location = new System.Drawing.Point(737, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(66, 29);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 17);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "From";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.Window;
            this.btnView.Location = new System.Drawing.Point(198, 205);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 35);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbReportName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(73, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 47);
            this.panel3.TabIndex = 6;
            this.panel3.Visible = false;
            // 
            // cmbReportName
            // 
            this.cmbReportName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportName.FormattingEnabled = true;
            this.cmbReportName.Items.AddRange(new object[] {
            "Opening Stock",
            "Stock Value",
            "Stock Card"});
            this.cmbReportName.Location = new System.Drawing.Point(65, 11);
            this.cmbReportName.Name = "cmbReportName";
            this.cmbReportName.Size = new System.Drawing.Size(90, 25);
            this.cmbReportName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Report";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(102, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(114, 22);
            this.dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(259, 26);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(107, 22);
            this.dtpTo.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(235, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(21, 17);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "To";
            this.lblFrom.Visible = false;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblItemCode.ForeColor = System.Drawing.Color.Black;
            this.lblItemCode.Location = new System.Drawing.Point(32, 135);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(71, 17);
            this.lblItemCode.TabIndex = 121;
            this.lblItemCode.Text = "Item Code";
            // 
            // btnproItemSearch
            // 
            this.btnproItemSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnproItemSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproItemSearch.FlatAppearance.BorderSize = 0;
            this.btnproItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproItemSearch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnproItemSearch.Image")));
            this.btnproItemSearch.Location = new System.Drawing.Point(343, 133);
            this.btnproItemSearch.Name = "btnproItemSearch";
            this.btnproItemSearch.Size = new System.Drawing.Size(24, 25);
            this.btnproItemSearch.TabIndex = 125;
            this.btnproItemSearch.Tag = "SRCH";
            this.btnproItemSearch.UseVisualStyleBackColor = false;
            this.btnproItemSearch.Click += new System.EventHandler(this.btnproItemSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(419, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 122;
            this.label8.Text = "Division";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(477, 50);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(264, 25);
            this.cmbDepartment.TabIndex = 134;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(384, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = "Sub Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(477, 106);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(264, 25);
            this.cmbCategory.TabIndex = 133;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(409, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 124;
            this.label9.Text = "Category";
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubCategory.FormattingEnabled = true;
            this.cmbSubCategory.Location = new System.Drawing.Point(477, 134);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(264, 25);
            this.cmbSubCategory.TabIndex = 132;
            this.cmbSubCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategory_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(392, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 126;
            this.label10.Text = "Department";
            // 
            // cmbDivision
            // 
            this.cmbDivision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(477, 78);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(264, 25);
            this.cmbDivision.TabIndex = 131;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(431, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 127;
            this.label11.Text = "Brand";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(182, 134);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(159, 24);
            this.txtItemName.TabIndex = 130;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(102, 134);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(79, 24);
            this.txtItemCode.TabIndex = 128;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(477, 23);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(264, 25);
            this.cmbBrand.TabIndex = 129;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlFilter);
            this.pnlMain.Controls.Add(this.grdData);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 686);
            this.pnlMain.TabIndex = 2;
            // 
            // grdData
            // 
            this.grdData.AutoScroll = true;
            this.grdData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EnableKineticScrolling = true;
            this.grdData.HideSelection = true;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowDeleteRow = false;
            this.grdData.MasterTemplate.AllowEditRow = false;
            this.grdData.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.grdData.MasterTemplate.EnableFiltering = true;
            this.grdData.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.grdData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdData.Name = "grdData";
            // 
            // 
            // 
            this.grdData.RootElement.AutoSize = true;
            this.grdData.RootElement.ControlBounds = new System.Drawing.Rectangle(0, 0, 240, 150);
            this.grdData.Size = new System.Drawing.Size(984, 686);
            this.grdData.TabIndex = 8;
            this.grdData.ThemeName = "TelerikMetroBlue";
            // 
            // rptPurchaseReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "rptPurchaseReports";
            this.Text = "Purchase Report";
            this.Load += new System.EventHandler(this.rptPurchaseReports_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.cmsPrintOptions.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlRptType.ResumeLayout(false);
            this.pnlRptType.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private Berri_X1_UI_Common.UC.UCFormCtrlButtons ucButtons;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsPrintOptions;
        private System.Windows.Forms.ToolStripMenuItem cmsMenuInvoiceRcpt;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private System.Windows.Forms.Button btnRowFilter;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cmbPurchType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.Button btnSupplier;    
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Panel pnlRptType;
        private System.Windows.Forms.RadioButton rbSummary;
        private System.Windows.Forms.RadioButton rbDetailed;
        private System.Windows.Forms.Button btnCloseFilter;
        private System.Windows.Forms.Button btnHideFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbReportName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnproItemSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBranches;
        private System.Windows.Forms.Button btnBrnLookup;
        private System.Windows.Forms.ComboBox cmbSummaryType;
        private System.Windows.Forms.Panel pnlMain;
        private Telerik.WinControls.UI.RadGridView grdData;
        private System.Windows.Forms.Button button1;
    }
}