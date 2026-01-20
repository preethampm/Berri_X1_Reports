namespace Berri_X1_Reports.Reports
{
    partial class rptCancelledItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptCancelledItems));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnRemoveBranch = new System.Windows.Forms.Button();
            this.btnBrnLookup = new System.Windows.Forms.Button();
            this.lblBranch = new System.Windows.Forms.Label();
            this.txtBranches = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.lblFrom);
            this.pnlTop.Controls.Add(this.btnRemoveBranch);
            this.pnlTop.Controls.Add(this.btnBrnLookup);
            this.pnlTop.Controls.Add(this.lblBranch);
            this.pnlTop.Controls.Add(this.txtBranches);
            this.pnlTop.Controls.Add(this.comboBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(984, 47);
            this.pnlTop.TabIndex = 14;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(460, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 17);
            this.lblTo.TabIndex = 163;
            this.lblTo.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(506, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(122, 20);
            this.dtpFrom.TabIndex = 161;
            this.dtpFrom.Value = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(693, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(114, 20);
            this.dtpTo.TabIndex = 162;
            this.dtpTo.Value = new System.DateTime(2026, 1, 10, 0, 0, 0, 0);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(665, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(22, 17);
            this.lblFrom.TabIndex = 164;
            this.lblFrom.Text = "To";
            // 
            // btnRemoveBranch
            // 
            this.btnRemoveBranch.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveBranch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveBranch.BackgroundImage")));
            this.btnRemoveBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveBranch.FlatAppearance.BorderSize = 0;
            this.btnRemoveBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBranch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBranch.Location = new System.Drawing.Point(340, 10);
            this.btnRemoveBranch.Name = "btnRemoveBranch";
            this.btnRemoveBranch.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveBranch.TabIndex = 157;
            this.btnRemoveBranch.Tag = "SRCH";
            this.btnRemoveBranch.UseVisualStyleBackColor = false;
            // 
            // btnBrnLookup
            // 
            this.btnBrnLookup.BackColor = System.Drawing.Color.Transparent;
            this.btnBrnLookup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrnLookup.FlatAppearance.BorderSize = 0;
            this.btnBrnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrnLookup.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrnLookup.Image = ((System.Drawing.Image)(resources.GetObject("btnBrnLookup.Image")));
            this.btnBrnLookup.Location = new System.Drawing.Point(310, 11);
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
            this.lblBranch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.ForeColor = System.Drawing.Color.Black;
            this.lblBranch.Location = new System.Drawing.Point(10, 12);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(52, 17);
            this.lblBranch.TabIndex = 151;
            this.lblBranch.Text = "Branch";
            // 
            // txtBranches
            // 
            this.txtBranches.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranches.Location = new System.Drawing.Point(65, 11);
            this.txtBranches.Name = "txtBranches";
            this.txtBranches.ReadOnly = true;
            this.txtBranches.Size = new System.Drawing.Size(239, 22);
            this.txtBranches.TabIndex = 150;
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
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToOrderColumns = true;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 47);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.Size = new System.Drawing.Size(984, 714);
            this.grdData.TabIndex = 15;
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
            this.pnlBottom.TabIndex = 16;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilter.Location = new System.Drawing.Point(563, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 37);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Hide Filter";
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
            this.btnPrint.Location = new System.Drawing.Point(669, 5);
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
            this.btnView.Location = new System.Drawing.Point(775, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 37);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // rptCancelledItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.pnlTop);
            this.Name = "rptCancelledItems";
            this.Text = "Cancelled Items Report";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnRemoveBranch;
        private System.Windows.Forms.Button btnBrnLookup;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.TextBox txtBranches;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnView;
    }
}