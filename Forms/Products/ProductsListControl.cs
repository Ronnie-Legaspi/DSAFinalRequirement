using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Products
{
    public partial class ProductsListControl : UserControl
    {
        public ProductsListControl()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();

            // Columns
            dgvProducts.Columns.Add("ProductID", "Product ID");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn
            {
                HeaderText = "Product Image",
                Name = "ProductImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvProducts.Columns.Add(imgCol);

            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("CategoryID", "Category ID");
            dgvProducts.Columns.Add("SupplierID", "Supplier ID");
            dgvProducts.Columns.Add("StockQuantity", "Stock Quantity");
            dgvProducts.Columns.Add("CostPrice", "Cost Price");
            dgvProducts.Columns.Add("SellingPrice", "Selling Price");
            dgvProducts.Columns.Add("Barcode", "Barcode");
            dgvProducts.Columns.Add("ReorderLevel", "Reorder Level");
            dgvProducts.Columns.Add("DateAdded", "Date Added");

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Products";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                        while (reader.Read())
                        {
                            int productId = Convert.ToInt32(reader["ProductID"]);
                            string imgFile = reader["ProductImage"]?.ToString() ?? "";
                            string productName = reader["ProductName"].ToString();
                            string categoryId = reader["CategoryID"].ToString();
                            string supplierId = reader["SupplierID"].ToString();
                            string stockQty = reader["StockQuantity"].ToString();
                            string costPrice = reader["CostPrice"].ToString();
                            string sellingPrice = reader["SellingPrice"].ToString();
                            string barcode = reader["Barcode"].ToString();
                            string reorderLevel = reader["ReorderLevel"].ToString();
                            string dateAdded = reader["DateAdded"].ToString();

                            // Load product image
                            Image productImage = null;
                            if (!string.IsNullOrEmpty(imgFile))
                            {
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", imgFile);
                                if (File.Exists(imgPath))
                                    productImage = Image.FromFile(imgPath);
                            }

                            // fallback image
                            if (productImage == null)
                            {
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "BrokenImage.png");
                                if (File.Exists(fallback))
                                    productImage = Image.FromFile(fallback);
                            }

                            dgvProducts.Rows.Add(
                                productId,
                                productImage,
                                productName,
                                categoryId,
                                supplierId,
                                stockQty,
                                costPrice,
                                sellingPrice,
                                barcode,
                                reorderLevel,
                                dateAdded
                            );
                        }
                    }
                }

                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvProducts.RowTemplate.Height = 60;
                foreach (DataGridViewRow row in dgvProducts.Rows)
                    row.Height = 60;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Products:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
