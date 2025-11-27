using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Categories;
using DSAFinalRequirement.Forms.Dashboard;
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
            btnAddProduct.Click += btnAddProduct_Click;
            btnEditProduct.Click += btnEditProduct_Click;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
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

        // -----------------------
        // Add PRODUCT BUTTON 
        // -----------------------
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Product Added Successfully!");
            }

        }

        // -----------------------
        // Edit PRODUCT BUTTON 
        // -----------------------
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductID();
            if (productId == null)
            {
                MessageBox.Show("No Product selected. Please select a Category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditProductForm editForm = new EditProductForm(productId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Product updated successfully!");
            }
        }

        // ______________________________
        // DELETE SELECTED PRODUCT 
        // _____________________________
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductID();
            if (productId == null)
            {
                MessageBox.Show("No Product selected. Please select a category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProductForm delForm = new DeleteProductForm(productId.Value);
            if (delForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Product deleted successfully!");
            }
        }

        // ------------------------------
        // Get Selected Category ID
        // ------------------------------
        private int? GetSelectedProductID()
        {
            if (dgvProducts.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            }
            catch
            {
                return null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
