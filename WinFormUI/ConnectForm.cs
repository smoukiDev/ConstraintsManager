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
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void butConnect_Click(object sender, EventArgs e)
        {
            tsLabelLoading.Visible = true;
            Program.mainForm = new MainForm();
            Program.mainForm.Show();
        }

        private void butPasswordVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '⦁')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '⦁';
        }

    }
}
