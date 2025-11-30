using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Categories;
using DSAFinalRequirement.Forms.Dashboard;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Reports
{
    public partial class TransactionsControl : UserControl
    {
        public TransactionsControl()
        {
            InitializeComponent();
            RoleType();
            LoadTransactions();

            btnDeleteTransaction.Click += BtnDeleteTransaction_Click;
        }
        public void RoleType()
        {
            btnDeleteTransaction.Visible = RoleHelper.IsAdmin();
        }

        /// ------------------------------
        /// Load Transactions into dgv
        /// ------------------------------
        public void LoadTransactions()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT TransactionID, UserID, TotalAmount, DateOfSale, Remarks 
                                     FROM Transactions 
                                     ORDER BY DateOfSale DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Clear existing data to prevent doubling
                        dgvTransactions.DataSource = null;
                        dgvTransactions.Rows.Clear();
                        dgvTransactions.Columns.Clear();

                        // Bind new data
                        dgvTransactions.DataSource = dt;

                        // Set column headers
                        dgvTransactions.Columns["TransactionID"].HeaderText = "ID";
                        dgvTransactions.Columns["UserID"].HeaderText = "Staff / Seller ID";
                        dgvTransactions.Columns["TotalAmount"].HeaderText = "Total Amount";
                        dgvTransactions.Columns["DateOfSale"].HeaderText = "Date of Sale";
                        dgvTransactions.Columns["Remarks"].HeaderText = "Remarks";

                        // Adjust column widths and row height
                        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvTransactions.RowTemplate.Height = 50;

                        // Selection settings
                        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvTransactions.MultiSelect = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions:\n" + ex.Message);
            }
        }

        // ------------------------------
        // Delete Category
        // ------------------------------
        private void BtnDeleteTransaction_Click(object sender, EventArgs e)
        {
            int? transactionId = GetSelectedTransactionID();
            if (transactionId == null)
            {
                MessageBox.Show("No Transaction selected. Please select a category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteTransactionForm delForm = new DeleteTransactionForm(transactionId.Value);
            if (delForm.ShowDialog() == DialogResult.OK)
            {
                LoadTransactions();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Transaction deleted successfully!");
            }
        }

        /// ------------------------------
        /// Get Selected Transaction ID
        /// ------------------------------
        private int? GetSelectedTransactionID()
        {
            if (dgvTransactions.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["TransactionID"].Value);
            }
            catch
            {
                return null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
