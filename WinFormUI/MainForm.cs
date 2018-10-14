using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        string connectionString = @"DATA SOURCE = PDBORTW; DBA PRIVILEGE = SYSDBA; PASSWORD = ultraLife31; USER ID = SYS";
        public MainForm()
        {
            InitializeComponent();
            SetDataGridViewStyle();
            
        }

        private void GetAllConstraints()
        {          
            string sql = "SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS";
            SelectConstraints(connectionString, sql);
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

        private void butCleanSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            GetAllConstraints();
            Program.connectForm.Hide();        
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            GetAllConstraints();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = tbSearch.Text.Replace(' ', '_');
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
            catch (ArgumentNullException)
            {
                MessageBox.Show("Server is probably shut down. Please try again.", "Failure");
            }
            catch (ArgumentException ex)
            {
                string lucidMessage = "Incorrect credentials!";
                MessageBox.Show(lucidMessage + Environment.NewLine + ex.Message + ".", "Failure");
            }
            catch (OracleException ex)
            {
                string lucidMessage = "Can't access data on this server!";
                MessageBox.Show(lucidMessage + Environment.NewLine + ex.Message, "Failure");
            }
        }

        private void butDropConstraint_Click(object sender, EventArgs e)
        {
            string targetOwner = dgvContraints.SelectedRows[0].Cells[0].Value.ToString();
            string targetTable = dgvContraints.SelectedRows[0].Cells[1].Value.ToString();
            string targetContraint = dgvContraints.SelectedRows[0].Cells[2].Value.ToString();
            MessageBox.Show(targetTable + Environment.NewLine + targetContraint);
            DialogResult SaveOrNot = MessageBox.Show("Are you sure, you want to drop this constraint?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SaveOrNot == DialogResult.Yes)
            {
                DropConstraint(targetOwner,targetTable, targetContraint);
            }
            if (SaveOrNot == DialogResult.No)
            {
                MessageBox.Show("Dropping of constraint was discarded.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DropConstraint(string owner, string table, string constraintName)
        {
            string sqlExpression = $"ALTER TABLE {owner}.{table} DROP CONSTRAINT {constraintName}";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(sqlExpression, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Constraint was successfully dropped.", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message);
                    }
                }
                    


            }
        }
    }
}
