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
using System.Diagnostics;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        string connectionString = null;
        public MainForm()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.OracleSysUser;
            SetDataGridViewStyle();
            GetAllConstraints();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void butCleanSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }
        private void butRefresh_Click(object sender, EventArgs e)
        {
            GetAllConstraints();
        }
        private void butSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = tbSearch.Text.ToUpper().Replace(' ', '_');
            if(rbByOwner.Checked ==true)
            {
                GetConstraintsByOwner(tbSearch.Text);
            }


            if (rbByTable.Checked == true)
            {
                GetConstraintsByTable(tbSearch.Text);
            }


            if (rbByConstraint.Checked == true)
            {
                GetConstraintsByName(tbSearch.Text);
            }
        }
        private void butDropConstraint_Click(object sender, EventArgs e)
        {
            try
            {
                string targetOwner = dgvContraints.SelectedRows[0].Cells[0].Value.ToString();
                string targetTable = dgvContraints.SelectedRows[0].Cells[1].Value.ToString();
                string targetContraint = dgvContraints.SelectedRows[0].Cells[2].Value.ToString();
                DialogResult SaveOrNot = MessageBox.Show("Are you sure, you want to drop this constraint?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SaveOrNot == DialogResult.Yes)
                {
                    DropConstraint(targetOwner, targetTable, targetContraint);
                }
                if (SaveOrNot == DialogResult.No)
                {
                    string lucidMessage = "Dropping of constraint was discarded.";
                    MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                string lucidMessage = "Please choose whole line in table to drop an constraint";
                MessageBox.Show(lucidMessage, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                


        }
        private void butBuildReport_Click(object sender, EventArgs e)
        {
            Program.reportForm = new ReportForm();
            this.Hide();
            Program.reportForm.Show();
        }

        private void SetDataGridViewStyle()
        {
            dgvContraints.BorderStyle = BorderStyle.None;
            dgvContraints.AlternatingRowsDefaultCellStyle.BackColor = ColorPalette.Gray;
            dgvContraints.RowsDefaultCellStyle.BackColor = Color.White;
            dgvContraints.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvContraints.DefaultCellStyle.SelectionBackColor = ColorPalette.Yellow;
            dgvContraints.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvContraints.BackgroundColor = Color.White;

            dgvContraints.EnableHeadersVisualStyles = false;
            dgvContraints.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvContraints.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.Red;
            dgvContraints.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvContraints.RowHeadersDefaultCellStyle.BackColor = ColorPalette.Red;
            dgvContraints.RowHeadersDefaultCellStyle.SelectionBackColor = ColorPalette.Yellow;

        }

        private void SelectConstraints(string connectionString, string sql)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(sql, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvContraints.DataSource = ds.Tables[0];
                    }

                }
            }
            catch(Exception ex)
            {
                string lucidMessage = "Сan't access data or database. You can try to connect again." + Environment.NewLine + Environment.NewLine;
                MessageBox.Show(lucidMessage + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void GetAllConstraints()
        {
            string sql = "SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS";
            SelectConstraints(connectionString, sql);
        }
        private void GetConstraintsByOwner(string searchRequest)
        {
            string sql = $"SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS "
                       + $"WHERE OWNER='{searchRequest}'";
            SelectConstraints(connectionString, sql);

        }
        private void GetConstraintsByTable(string searchRequest)
        {
            string sql = $"SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS "
                       + $"WHERE TABLE_NAME='{searchRequest}'";
            SelectConstraints(connectionString, sql);

        }
        private void GetConstraintsByName(string searchRequest)
        {
            string sql = $"SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS "
                       + $"WHERE CONSTRAINT_NAME='{searchRequest}'";
            SelectConstraints(connectionString, sql);
        }
        private void DropConstraint(string owner, string table, string constraintName)
        {            
            try
            {
                string sqlExpression = $"ALTER TABLE {owner}.{table} DROP CONSTRAINT {constraintName}";
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(sqlExpression, connection))
                    {
                            command.ExecuteNonQuery();
                            string lucidMessage = "Constraint was successfully dropped.";
                            MessageBox.Show(lucidMessage, "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);                           
                    }



                }
            }
            catch(Exception ex)
            {
                string lucidMessage = "Dropping of constraint was aborted." + Environment.NewLine + Environment.NewLine;
                MessageBox.Show(lucidMessage + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
