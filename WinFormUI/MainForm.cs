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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.connectForm.Close();
        }

        private void butBuildReport_Click(object sender, EventArgs e)
        {
            Program.reportForm = new ReportForm();
            this.Hide();
            Program.reportForm.Show();
        }
    }
}
