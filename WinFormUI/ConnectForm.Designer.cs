namespace WinFormUI
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.butConnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.butPasswordVisible = new System.Windows.Forms.Button();
            this.tsStatus = new System.Windows.Forms.ToolStrip();
            this.tsLabelLoading = new System.Windows.Forms.ToolStripLabel();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(15, 59);
            this.txtDataSource.Margin = new System.Windows.Forms.Padding(6);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(404, 29);
            this.txtDataSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(14, 144);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(404, 29);
            this.txtUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 234);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '⦁';
            this.txtPassword.Size = new System.Drawing.Size(403, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // butConnect
            // 
            this.butConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.butConnect.FlatAppearance.BorderSize = 0;
            this.butConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butConnect.Location = new System.Drawing.Point(16, 366);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(403, 68);
            this.butConnect.TabIndex = 6;
            this.butConnect.Text = "Connect";
            this.butConnect.UseVisualStyleBackColor = false;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(16, 289);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 28);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "As SYSDBA (automatic)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // butPasswordVisible
            // 
            this.butPasswordVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butPasswordVisible.BackgroundImage")));
            this.butPasswordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butPasswordVisible.FlatAppearance.BorderSize = 0;
            this.butPasswordVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPasswordVisible.Location = new System.Drawing.Point(373, 184);
            this.butPasswordVisible.Name = "butPasswordVisible";
            this.butPasswordVisible.Size = new System.Drawing.Size(45, 45);
            this.butPasswordVisible.TabIndex = 8;
            this.butPasswordVisible.UseVisualStyleBackColor = true;
            this.butPasswordVisible.Click += new System.EventHandler(this.butPasswordVisible_Click);
            // 
            // tsStatus
            // 
            this.tsStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelLoading});
            this.tsStatus.Location = new System.Drawing.Point(0, 450);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(434, 25);
            this.tsStatus.TabIndex = 10;
            this.tsStatus.Text = "toolStrip1";
            // 
            // tsLabelLoading
            // 
            this.tsLabelLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsLabelLoading.Name = "tsLabelLoading";
            this.tsLabelLoading.Size = new System.Drawing.Size(75, 22);
            this.tsLabelLoading.Text = "Loading...";
            this.tsLabelLoading.Visible = false;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 475);
            this.Controls.Add(this.tsStatus);
            this.Controls.Add(this.butPasswordVisible);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect DB as SYSDBA";
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button butPasswordVisible;
        private System.Windows.Forms.ToolStrip tsStatus;
        private System.Windows.Forms.ToolStripLabel tsLabelLoading;
    }
}

