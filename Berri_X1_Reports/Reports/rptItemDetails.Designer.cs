namespace Berri_X1_Reports.Reports
{
    partial class rptItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptItemDetails));
            this.grdData = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRemoveBranch = new System.Windows.Forms.Button();
            this.btnBrnLookup = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtBranches = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDivison = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubCat = new System.Windows.Forms.ComboBox();
            this.lblPurchaseType = new System.Windows.Forms.Label();
            this.cmbPurchaseType = new System.Windows.Forms.ComboBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.btnproItemSearch = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnRemoveItemCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 157);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(984, 559);
            this.grdData.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnFilter);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnPrint);
            this.pnlBottom.Controls.Add(this.btnView);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 716);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(984, 45);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(563, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 37);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(881, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(669, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 37);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnView.Location = new System.Drawing.Point(775, 6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 37);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnRemoveBranch);
            this.pnlTop.Controls.Add(this.btnRemoveItemCode);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cmbSubCat);
            this.pnlTop.Controls.Add(this.btnBrnLookup);
            this.pnlTop.Controls.Add(this.lblBranch);
            this.pnlTop.Controls.Add(this.txtBranches);
            this.pnlTop.Controls.Add(this.lblSupplier);
            this.pnlTop.Controls.Add(this.cmbPurchaseType);
            this.pnlTop.Controls.Add(this.lblPurchaseType);
            this.pnlTop.Controls.Add(this.btnRemoveSupplier);
            this.pnlTop.Controls.Add(this.btnSupplier);
            this.pnlTop.Controls.Add(this.txtSupplier);
            this.pnlTop.Controls.Add(this.comboBox1);
            this.pnlTop.Controls.Add(this.lblItemCode);
            this.pnlTop.Controls.Add(this.btnproItemSearch);
            this.pnlTop.Controls.Add(this.lblDivison);
            this.pnlTop.Controls.Add(this.cmbDepartment);
            this.pnlTop.Controls.Add(this.cmbCategory);
            this.pnlTop.Controls.Add(this.lblCategory);
            this.pnlTop.Controls.Add(this.lblDepartment);
            this.pnlTop.Controls.Add(this.cmbDivision);
            this.pnlTop.Controls.Add(this.lblBrand);
            this.pnlTop.Controls.Add(this.txtItemName);
            this.pnlTop.Controls.Add(this.txtItemCode);
            this.pnlTop.Controls.Add(this.cmbBrand);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 157);
            this.pnlTop.TabIndex = 9;
            // 
            // btnRemoveBranch
            // 
            this.btnRemoveBranch.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveBranch.BackgroundImage")));
            this.btnRemoveBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveBranch.FlatAppearance.BorderSize = 0;
            this.btnRemoveBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBranch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBranch.Location = new System.Drawing.Point(457, 10);
            this.btnRemoveBranch.Name = "btnRemoveBranch";
            this.btnRemoveBranch.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveBranch.TabIndex = 157;
            this.btnRemoveBranch.Tag = "SRCH";
            this.btnRemoveBranch.UseVisualStyleBackColor = false;
            this.btnRemoveBranch.Click += new System.EventHandler(this.btnRemoveBranch_Click);
            // 
            // btnBrnLookup
            // 
            this.btnBrnLookup.BackColor = System.Drawing.Color.Transparent;
            this.btnBrnLookup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrnLookup.FlatAppearance.BorderSize = 0;
            this.btnBrnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrnLookup.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrnLookup.Image = ((System.Drawing.Image)(resources.GetObject("btnBrnLookup.Image")));
            this.btnBrnLookup.Location = new System.Drawing.Point(427, 10);
            this.btnBrnLookup.Name = "btnBrnLookup";
            this.btnBrnLookup.Size = new System.Drawing.Size(24, 23);
            this.btnBrnLookup.TabIndex = 153;
            this.btnBrnLookup.Tag = "SRCH";
            this.btnBrnLookup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBrnLookup.UseVisualStyleBackColor = false;
            this.btnBrnLookup.Click += new System.EventHandler(this.btnBrnLookup_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.Location = new System.Drawing.Point(127, 14);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(49, 17);
            this.lblBranch.TabIndex = 151;
            this.lblBranch.Text = "Branch";
            // 
            // txtBranches
            // 
            this.txtBranches.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranches.Location = new System.Drawing.Point(182, 11);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.ReadOnly = true;
            this.txtBranches.Size = new System.Drawing.Size(239, 22);
            this.txtBranches.TabIndex = 150;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(120, 77);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(56, 17);
            this.lblSupplier.TabIndex = 148;
            this.lblSupplier.Text = "Supplier";
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveSupplier.BackgroundImage")));
            this.btnRemoveSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveSupplier.FlatAppearance.BorderSize = 0;
            this.btnRemoveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSupplier.Location = new System.Drawing.Point(457, 71);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveSupplier.TabIndex = 145;
            this.btnRemoveSupplier.Tag = "SRCH";
            this.btnRemoveSupplier.UseVisualStyleBackColor = false;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplier.BackgroundImage")));
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.Location = new System.Drawing.Point(427, 72);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(24, 23);
            this.btnSupplier.TabIndex = 144;
            this.btnSupplier.Tag = "SRCH";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.txtSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(182, 71);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(239, 23);
            this.txtSupplier.TabIndex = 143;
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
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // lblDivison
            // 
            this.lblDivison.AutoSize = true;
            this.lblDivison.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblDivison.ForeColor = System.Drawing.Color.Black;
            this.lblDivison.Location = new System.Drawing.Point(564, 65);
            this.lblDivison.Name = "lblDivison";
            this.lblDivison.Size = new System.Drawing.Size(54, 17);
            this.lblDivison.TabIndex = 122;
            this.lblDivison.Text = "Division";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(624, 34);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(264, 25);
            this.cmbDepartment.TabIndex = 134;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(624, 90);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(264, 25);
            this.cmbCategory.TabIndex = 133;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(554, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 17);
            this.lblCategory.TabIndex = 124;
            this.lblCategory.Text = "Category";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblDepartment.ForeColor = System.Drawing.Color.Black;
            this.lblDepartment.Location = new System.Drawing.Point(539, 37);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(81, 17);
            this.lblDepartment.TabIndex = 126;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDivision
            // 
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(624, 62);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(264, 25);
            this.cmbDivision.TabIndex = 131;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(576, 6);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(42, 17);
            this.lblBrand.TabIndex = 127;
            this.lblBrand.Text = "Brand";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(624, 3);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(264, 25);
            this.cmbBrand.TabIndex = 129;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(528, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 155;
            this.label1.Text = "Sub-Category";
            // 
            // cmbSubCat
            // 
            this.cmbSubCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubCat.FormattingEnabled = true;
            this.cmbSubCat.Location = new System.Drawing.Point(624, 121);
            this.cmbSubCat.Name = "cmbSubCat";
            this.cmbSubCat.Size = new System.Drawing.Size(264, 25);
            this.cmbSubCat.TabIndex = 154;
            this.cmbSubCat.SelectedIndexChanged += new System.EventHandler(this.cmbSubCat_SelectedIndexChanged);
            // 
            // lblPurchaseType
            // 
            this.lblPurchaseType.AutoSize = true;
            this.lblPurchaseType.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPurchaseType.ForeColor = System.Drawing.Color.Black;
            this.lblPurchaseType.Location = new System.Drawing.Point(84, 46);
            this.lblPurchaseType.Name = "lblPurchaseType";
            this.lblPurchaseType.Size = new System.Drawing.Size(92, 17);
            this.lblPurchaseType.TabIndex = 146;
            this.lblPurchaseType.Text = "Purchase Type";
            // 
            // cmbPurchaseType
            // 
            this.cmbPurchaseType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPurchaseType.FormattingEnabled = true;
            this.cmbPurchaseType.Items.AddRange(new object[] {
            "",
            "IMPORT",
            "LOCAL",
            "LOC"});
            this.cmbPurchaseType.Location = new System.Drawing.Point(182, 42);
            this.cmbPurchaseType.Name = "cmbPurchaseType";
            this.cmbPurchaseType.Size = new System.Drawing.Size(239, 25);
            this.cmbPurchaseType.TabIndex = 147;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblItemCode.ForeColor = System.Drawing.Color.Black;
            this.lblItemCode.Location = new System.Drawing.Point(105, 106);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(71, 17);
            this.lblItemCode.TabIndex = 121;
            this.lblItemCode.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemCode.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCode.Location = new System.Drawing.Point(182, 101);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(79, 24);
            this.txtItemCode.TabIndex = 128;
            // 
            // btnproItemSearch
            // 
            this.btnproItemSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnproItemSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproItemSearch.FlatAppearance.BorderSize = 0;
            this.btnproItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproItemSearch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproItemSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnproItemSearch.Image")));
            this.btnproItemSearch.Location = new System.Drawing.Point(427, 102);
            this.btnproItemSearch.Name = "btnproItemSearch";
            this.btnproItemSearch.Size = new System.Drawing.Size(24, 23);
            this.btnproItemSearch.TabIndex = 125;
            this.btnproItemSearch.Tag = "SRCH";
            this.btnproItemSearch.UseVisualStyleBackColor = false;
            this.btnproItemSearch.Click += new System.EventHandler(this.btnproItemSearch_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(262, 101);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(159, 24);
            this.txtItemName.TabIndex = 130;
            // 
            // btnRemoveItemCode
            // 
            this.btnRemoveItemCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveItemCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveItemCode.BackgroundImage")));
            this.btnRemoveItemCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveItemCode.FlatAppearance.BorderSize = 0;
            this.btnRemoveItemCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItemCode.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItemCode.Location = new System.Drawing.Point(457, 102);
            this.btnRemoveItemCode.Name = "btnRemoveItemCode";
            this.btnRemoveItemCode.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveItemCode.TabIndex = 156;
            this.btnRemoveItemCode.Tag = "SRCH";
            this.btnRemoveItemCode.UseVisualStyleBackColor = false;
            this.btnRemoveItemCode.Click += new System.EventHandler(this.btnRemoveItemCode_Click);
            // 
            // rptItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "rptItemDetails";
            this.Text = "Item Details";
            this.Load += new System.EventHandler(this.rptItemDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtBranches;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDivison;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Button btnBrnLookup;
        private System.Windows.Forms.Button btnRemoveBranch;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.Button btnRemoveItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubCat;
        internal System.Windows.Forms.ComboBox cmbPurchaseType;
        private System.Windows.Forms.Label lblPurchaseType;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnproItemSearch;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
    }
}