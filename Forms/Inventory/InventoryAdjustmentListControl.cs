using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Categories;
using DSAFinalRequirement.Forms.Dashboard;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Inventory
{
    public partial class InventoryAdjustmentListControl : UserControl
    {
        public InventoryAdjustmentListControl()
        {
            InitializeComponent();
            LoadInventoryAdjustments();

            btnDeleteAdjustMent.Click += BtnDeleteAdjustment_Click;
        }

        /// ------------------------------
        /// Load Inventory Adjustments into dgv
        /// ------------------------------
        private void LoadInventoryAdjustments()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"SELECT AdjustmentID, ProductID, QuantityChanged, Reason, UserID, DateAdjusted 
                                     FROM InventoryAdjustments
                                     ORDER BY DateAdjusted DESC";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Clear previous data
                        dgvInventoryAdjustments.DataSource = null;
                        dgvInventoryAdjustments.Rows.Clear();
                        dgvInventoryAdjustments.Columns.Clear();

                        // Bind data
                        dgvInventoryAdjustments.DataSource = dt;

                        // Set column headers
                        dgvInventoryAdjustments.Columns["AdjustmentID"].HeaderText = "ID";
                        dgvInventoryAdjustments.Columns["ProductID"].HeaderText = "Product ID";
                        dgvInventoryAdjustments.Columns["QuantityChanged"].HeaderText = "Quantity Changed";
                        dgvInventoryAdjustments.Columns["Reason"].HeaderText = "Reason";
                        dgvInventoryAdjustments.Columns["UserID"].HeaderText = "User ID";
                        dgvInventoryAdjustments.Columns["DateAdjusted"].HeaderText = "Date Adjusted";

                        // Adjust column widths and row height
                        dgvInventoryAdjustments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvInventoryAdjustments.RowTemplate.Height = 50;

                        // Selection settings
                        dgvInventoryAdjustments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvInventoryAdjustments.MultiSelect = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory adjustments:\n" + ex.Message);
            }
        }
        /// _____________________________
        /// DELETE INVENTORY ADJUSMENT
        /// +____________________________
        private void BtnDeleteAdjustment_Click(object sender, EventArgs e)
        {
            int? adjustmentId = GetSelectedInventory();
            if (adjustmentId == null)
            {
                MessageBox.Show("No Adjusment selected. Please select a category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteAdjustmentForm delForm = new DeleteAdjustmentForm(adjustmentId.Value);
            if (delForm.ShowDialog() == DialogResult.OK)
            {
                LoadInventoryAdjustments();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Adjustment deleted successfully!");
            }
        }
        /// 
        /// 
        /// ------------------------------
        /// Get Selected Inventory Adjustment ID
        /// ------------------------------
        private int? GetSelectedInventory()
        {
            if (dgvInventoryAdjustments.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvInventoryAdjustments.SelectedRows[0].Cells["AdjustmentID"].Value);
            }
            catch
            {
                return null;
            }
        }
    }
}
