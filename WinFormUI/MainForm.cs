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
        public MainForm()
        {
            InitializeComponent();
            SetDataGridViewStyle();
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

            // DATA SOURCE = PDBORTW; DBA PRIVILEGE = SYSDBA; PASSWORD = ultraLife31; USER ID = SYS
            string connectionString = @"DATA SOURCE = PDBORTW; DBA PRIVILEGE = SYSDBA; PASSWORD = ultraLife31; USER ID = SYS";
            string sql = "SELECT OWNER, TABLE_NAME, CONSTRAINT_NAME, CONSTRAINT_TYPE, STATUS FROM ALL_CONSTRAINTS";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                OracleDataAdapter adapter = new OracleDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dgvContraints.DataSource = ds.Tables[0];
            }

            
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
    }
}
