using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Inventory
{
    public partial class DeleteAdjustmentForm : Form
    {
        private int adjustmentId;
        private int productId;
        private int quantityChanged;
        private string reason;

        public DeleteAdjustmentForm(int adjustmentId)
        {
            InitializeComponent();
            this.adjustmentId = adjustmentId;

            LoadAdjustmentData();

            btnDelete.Click += BtnDelete_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        // -------------------------------
        // Load selected inventory adjustment details
        // -------------------------------
        private void LoadAdjustmentData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ProductID, QuantityChanged, Reason FROM InventoryAdjustments WHERE AdjustmentID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("AdjustmentID", adjustmentId);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        productId = Convert.ToInt32(reader["ProductID"]);
                        quantityChanged = Convert.ToInt32(reader["QuantityChanged"]);
                        reason = reader["Reason"].ToString();

                        lblAdjustmentInfo.Text = $"Product ID: {productId}\nQuantity Changed: {quantityChanged}\nReason: {reason}";
                    }
                    else
                    {
                        MessageBox.Show("Adjustment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading adjustment data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------
        // Delete adjustment
        // -------------------------------
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this inventory adjustment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM InventoryAdjustments WHERE AdjustmentID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("AdjustmentID", adjustmentId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Inventory adjustment deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting inventory adjustment:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------
        // Cancel button
        // -------------------------------
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
