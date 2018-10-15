namespace WinFormUI
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.ALL_CONSTRAINTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOracleSysUser = new WinFormUI.dsOracleSysUser();
            this.rvConstraints = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ALL_CONSTRAINTSTableAdapter = new WinFormUI.dsOracleSysUserTableAdapters.ALL_CONSTRAINTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ALL_CONSTRAINTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOracleSysUser)).BeginInit();
            this.SuspendLayout();
            // 
            // ALL_CONSTRAINTSBindingSource
            // 
            this.ALL_CONSTRAINTSBindingSource.DataMember = "ALL_CONSTRAINTS";
            this.ALL_CONSTRAINTSBindingSource.DataSource = this.dsOracleSysUser;
            // 
            // dsOracleSysUser
            // 
            this.dsOracleSysUser.DataSetName = "dsOracleSysUser";
            this.dsOracleSysUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvConstraints
            // 
            this.rvConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsAllConstraints";
            reportDataSource1.Value = this.ALL_CONSTRAINTSBindingSource;
            this.rvConstraints.LocalReport.DataSources.Add(reportDataSource1);
            this.rvConstraints.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.AllConstraints.rdlc";
            this.rvConstraints.Location = new System.Drawing.Point(0, 0);
            this.rvConstraints.Name = "rvConstraints";
            this.rvConstraints.ServerReport.BearerToken = null;
            this.rvConstraints.Size = new System.Drawing.Size(1008, 729);
            this.rvConstraints.TabIndex = 0;
            this.rvConstraints.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rvConstraints.ZoomPercent = 50;
            // 
            // ALL_CONSTRAINTSTableAdapter
            // 
            this.ALL_CONSTRAINTSTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.rvConstraints);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ALL_CONSTRAINTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOracleSysUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvConstraints;
        private System.Windows.Forms.BindingSource ALL_CONSTRAINTSBindingSource;
        private dsOracleSysUser dsOracleSysUser;
        private dsOracleSysUserTableAdapters.ALL_CONSTRAINTSTableAdapter ALL_CONSTRAINTSTableAdapter;
    }
}