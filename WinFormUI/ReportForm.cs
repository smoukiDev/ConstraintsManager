using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsOracleSysUser.ALL_CONSTRAINTS' table. You can move, or remove it, as needed.
            this.ALL_CONSTRAINTSTableAdapter.Fill(this.dsOracleSysUser.ALL_CONSTRAINTS);

            this.rvConstraints.RefreshReport();
        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.mainForm.Show();
        }
    }
}
