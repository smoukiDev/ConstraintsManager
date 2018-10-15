using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            //Pass on MainForm Logic
            txtUser.Clear();
            txtDataSource.Clear();
            txtPassword.Clear();
            tsLabelLoading.Visible = false;
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
