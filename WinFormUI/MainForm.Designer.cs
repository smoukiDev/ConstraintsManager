namespace WinFormUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvContraints = new System.Windows.Forms.DataGridView();
            this.butDropConstraint = new System.Windows.Forms.Button();
            this.butBuildReport = new System.Windows.Forms.Button();
            this.rbByConstraint = new System.Windows.Forms.RadioButton();
            this.rbByTable = new System.Windows.Forms.RadioButton();
            this.rbByOwner = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.panFilter = new System.Windows.Forms.Panel();
            this.panDataGrid = new System.Windows.Forms.Panel();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.butCleanSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraints)).BeginInit();
            this.panFilter.SuspendLayout();
            this.panDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(534, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(538, 73);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(444, 29);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvContraints
            // 
            this.dgvContraints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContraints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContraints.Location = new System.Drawing.Point(13, 13);
            this.dgvContraints.MultiSelect = false;
            this.dgvContraints.Name = "dgvContraints";
            this.dgvContraints.Size = new System.Drawing.Size(957, 399);
            this.dgvContraints.TabIndex = 8;
            // 
            // butDropConstraint
            // 
            this.butDropConstraint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butDropConstraint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.butDropConstraint.FlatAppearance.BorderSize = 0;
            this.butDropConstraint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDropConstraint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butDropConstraint.Location = new System.Drawing.Point(755, 423);
            this.butDropConstraint.Name = "butDropConstraint";
            this.butDropConstraint.Size = new System.Drawing.Size(215, 55);
            this.butDropConstraint.TabIndex = 9;
            this.butDropConstraint.Text = "Drop";
            this.butDropConstraint.UseVisualStyleBackColor = false;
            this.butDropConstraint.Click += new System.EventHandler(this.butDropConstraint_Click);
            // 
            // butBuildReport
            // 
            this.butBuildReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butBuildReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(119)))));
            this.butBuildReport.FlatAppearance.BorderSize = 0;
            this.butBuildReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBuildReport.Location = new System.Drawing.Point(526, 423);
            this.butBuildReport.Name = "butBuildReport";
            this.butBuildReport.Size = new System.Drawing.Size(215, 56);
            this.butBuildReport.TabIndex = 10;
            this.butBuildReport.Text = "Report";
            this.butBuildReport.UseVisualStyleBackColor = false;
            this.butBuildReport.Click += new System.EventHandler(this.butBuildReport_Click);
            // 
            // rbByConstraint
            // 
            this.rbByConstraint.AutoSize = true;
            this.rbByConstraint.Location = new System.Drawing.Point(13, 131);
            this.rbByConstraint.Name = "rbByConstraint";
            this.rbByConstraint.Size = new System.Drawing.Size(193, 28);
            this.rbByConstraint.TabIndex = 3;
            this.rbByConstraint.TabStop = true;
            this.rbByConstraint.Text = "By Constraint Name";
            this.rbByConstraint.UseVisualStyleBackColor = true;
            // 
            // rbByTable
            // 
            this.rbByTable.AutoSize = true;
            this.rbByTable.Location = new System.Drawing.Point(13, 97);
            this.rbByTable.Name = "rbByTable";
            this.rbByTable.Size = new System.Drawing.Size(102, 28);
            this.rbByTable.TabIndex = 2;
            this.rbByTable.TabStop = true;
            this.rbByTable.Text = "By Table";
            this.rbByTable.UseVisualStyleBackColor = true;
            // 
            // rbByOwner
            // 
            this.rbByOwner.AutoSize = true;
            this.rbByOwner.Checked = true;
            this.rbByOwner.Location = new System.Drawing.Point(13, 61);
            this.rbByOwner.Name = "rbByOwner";
            this.rbByOwner.Size = new System.Drawing.Size(111, 28);
            this.rbByOwner.TabIndex = 1;
            this.rbByOwner.TabStop = true;
            this.rbByOwner.Text = "By Owner";
            this.rbByOwner.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(86, 19);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(51, 24);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            // 
            // panFilter
            // 
            this.panFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.panFilter.Controls.Add(this.pbFilter);
            this.panFilter.Controls.Add(this.lblFilter);
            this.panFilter.Controls.Add(this.rbByOwner);
            this.panFilter.Controls.Add(this.rbByTable);
            this.panFilter.Controls.Add(this.rbByConstraint);
            this.panFilter.Location = new System.Drawing.Point(12, 12);
            this.panFilter.Name = "panFilter";
            this.panFilter.Size = new System.Drawing.Size(215, 187);
            this.panFilter.TabIndex = 11;
            // 
            // panDataGrid
            // 
            this.panDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDataGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.panDataGrid.Controls.Add(this.dgvContraints);
            this.panDataGrid.Controls.Add(this.butDropConstraint);
            this.panDataGrid.Controls.Add(this.butBuildReport);
            this.panDataGrid.Location = new System.Drawing.Point(12, 228);
            this.panDataGrid.Name = "panDataGrid";
            this.panDataGrid.Size = new System.Drawing.Size(984, 489);
            this.panDataGrid.TabIndex = 12;
            // 
            // pbFilter
            // 
            this.pbFilter.Image = global::WinFormUI.Properties.Resources.Filter;
            this.pbFilter.Location = new System.Drawing.Point(-29, 3);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(100, 50);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilter.TabIndex = 4;
            this.pbFilter.TabStop = false;
            // 
            // butRefresh
            // 
            this.butRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRefresh.BackgroundImage = global::WinFormUI.Properties.Resources.Refresh;
            this.butRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRefresh.FlatAppearance.BorderSize = 0;
            this.butRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRefresh.Location = new System.Drawing.Point(886, 22);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(45, 45);
            this.butRefresh.TabIndex = 7;
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.BackgroundImage = global::WinFormUI.Properties.Resources.Search;
            this.butSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butSearch.FlatAppearance.BorderSize = 0;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSearch.Location = new System.Drawing.Point(835, 21);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(45, 45);
            this.butSearch.TabIndex = 6;
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butCleanSearch
            // 
            this.butCleanSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCleanSearch.BackgroundImage = global::WinFormUI.Properties.Resources.CleanField;
            this.butCleanSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCleanSearch.FlatAppearance.BorderSize = 0;
            this.butCleanSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCleanSearch.Location = new System.Drawing.Point(937, 22);
            this.butCleanSearch.Name = "butCleanSearch";
            this.butCleanSearch.Size = new System.Drawing.Size(45, 45);
            this.butCleanSearch.TabIndex = 5;
            this.butCleanSearch.UseVisualStyleBackColor = true;
            this.butCleanSearch.Click += new System.EventHandler(this.butCleanSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panDataGrid);
            this.Controls.Add(this.panFilter);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.butCleanSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle Constraints Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContraints)).EndInit();
            this.panFilter.ResumeLayout(false);
            this.panFilter.PerformLayout();
            this.panDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button butCleanSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.DataGridView dgvContraints;
        private System.Windows.Forms.Button butDropConstraint;
        private System.Windows.Forms.Button butBuildReport;
        private System.Windows.Forms.RadioButton rbByConstraint;
        private System.Windows.Forms.RadioButton rbByTable;
        private System.Windows.Forms.RadioButton rbByOwner;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.PictureBox pbFilter;
        private System.Windows.Forms.Panel panFilter;
        private System.Windows.Forms.Panel panDataGrid;
    }
}