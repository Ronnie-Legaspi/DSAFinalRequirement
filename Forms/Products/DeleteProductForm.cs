using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Products
{
    public partial class DeleteProductForm : Form
    {
        private int productId;
        private string currentImageName = "";

        public DeleteProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;

            LoadProductData();

            btnDelete.Click += btnDelete_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void LoadProductData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT ProductName, ProductImage, Barcode FROM Products WHERE ProductID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("ProductID", productId);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblProductName.Text = reader["ProductName"].ToString();
                        lblBarcode.Text = reader["Barcode"].ToString();

                        currentImageName = reader["ProductImage"].ToString();
                        if (!string.IsNullOrEmpty(currentImageName))
                        {
                            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                            string imagePath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", currentImageName);
                            if (File.Exists(imagePath))
                                picProduct.Image = Image.FromFile(imagePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Products WHERE ProductID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("ProductID", productId);
                    cmd.ExecuteNonQuery();
                }

                // Optional: delete the image file
                if (!string.IsNullOrEmpty(currentImageName))
                {
                    string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                    string imagePath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", currentImageName);
                    if (File.Exists(imagePath))
                        File.Delete(imagePath);
                }

                MessageBox.Show("Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product:\n" + ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
