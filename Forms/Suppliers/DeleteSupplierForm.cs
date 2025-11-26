using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Suppliers
{
    public partial class DeleteSupplierForm : Form
    {
        private int supplierId;
        private string supplierName;
        private string supplierImageFile = "";

        public DeleteSupplierForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            LoadSupplierData();
        }

        // -------------------------
        // Load Supplier Info
        // -------------------------
        private void LoadSupplierData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT SupplierName, SupplierImage FROM Suppliers WHERE SupplierID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                supplierName = reader["SupplierName"].ToString();
                                supplierImageFile = reader["SupplierImage"].ToString();

                                txtSupplierName.Text = supplierName;

                                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", supplierImageFile);
                                if (File.Exists(imgPath))
                                {
                                    picSupplierImage.Image = Image.FromFile(imgPath);
                                    picSupplierImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // Delete Supplier
        // -------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete supplier '{supplierName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = DatabaseConnection.GetConnection())
                    {
                        string query = "DELETE FROM Suppliers WHERE SupplierID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", supplierId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------
        // Cancel
        // -------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
