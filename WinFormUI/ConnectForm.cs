using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            
            Program.mainForm = new MainForm();
            this.Hide();
            Program.mainForm.Show();
        }

        private void butPasswordVisible_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '⦁')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '⦁';
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
