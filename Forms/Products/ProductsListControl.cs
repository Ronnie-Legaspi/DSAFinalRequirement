using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Categories;
using DSAFinalRequirement.Forms.Dashboard;
using System;
using System.Data;
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
            RoleType(); // correct placement

            // Attach events only ONCE
            btnAddProduct.Click += btnAddProduct_Click;
            btnEditProduct.Click += btnEditProduct_Click;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;

            LoadCategories(); // populate the combo box
            LoadProducts();   // initial load
        }

        private void RoleType()
        {
            pnlCrudButtons.Visible = RoleHelper.IsAdmin();
        }

        // -------------------------------
        // Load products with optional search and category filter
        // -------------------------------
        private void LoadProducts(string searchKeyword = "", int categoryId = 0)
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
                    string query = "SELECT * FROM Products WHERE 1=1";

                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                        query += " AND ProductName LIKE ?";

                    if (categoryId > 0)
                        query += " AND CategoryID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        int paramIndex = 1;

                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {
                            cmd.Parameters.AddWithValue("@p" + paramIndex, "%" + searchKeyword + "%");
                            paramIndex++;
                        }

                        if (categoryId > 0)
                            cmd.Parameters.AddWithValue("@p" + paramIndex, categoryId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                            while (reader.Read())
                            {
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                string imgFile = reader["ProductImage"]?.ToString() ?? "";
                                string productName = reader["ProductName"].ToString();
                                string catId = reader["CategoryID"].ToString();
                                string supplierId = reader["SupplierID"].ToString();
                                string stockQty = reader["StockQuantity"].ToString();
                                string costPrice = reader["CostPrice"].ToString();
                                string sellingPrice = reader["SellingPrice"].ToString();
                                string barcode = reader["Barcode"].ToString();
                                string reorderLevel = reader["ReorderLevel"].ToString();
                                string dateAdded = reader["DateAdded"].ToString();

                                Image productImage = null;
                                if (!string.IsNullOrEmpty(imgFile))
                                {
                                    string imgPath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", imgFile);
                                    if (File.Exists(imgPath))
                                        productImage = Image.FromFile(imgPath);
                                }

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
                                    catId,
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

        // -------------------------------
        // Load categories into combobox
        // -------------------------------
        private void LoadCategories()
        {
            cmbCategories.Items.Clear();
            cmbCategories.Items.Add(new { Name = "All Categories", ID = 0 }); // optional "All"

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT CategoryID, CategoryName FROM Categories";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["CategoryID"]);
                            string name = reader["CategoryName"].ToString();
                            cmbCategories.Items.Add(new { Name = name, ID = id });
                        }
                    }
                }

                cmbCategories.DisplayMember = "Name";
                cmbCategories.ValueMember = "ID";
                cmbCategories.SelectedIndex = 0; // default: All
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories:\n" + ex.Message);
            }
        }

        // -------------------------------
        // Filter products when category changes
        // -------------------------------
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedItem == null)
                return;

            int categoryId = 0;

            try
            {
                var selected = cmbCategories.SelectedItem;
                categoryId = (int)selected.GetType().GetProperty("ID").GetValue(selected, null);
            }
            catch { }

            LoadProducts(txtSearch.ForeColor == Color.Gray ? "" : txtSearch.Text.Trim(), categoryId);
        }

        // -------------------------------
        // Search products
        // -------------------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            const string placeholder = "Search Product";

            // If placeholder is showing and user begins typing
            if (txtSearch.ForeColor == Color.Gray && txtSearch.Text != placeholder)
            {
                txtSearch.TextChanged -= txtSearch_TextChanged;
                txtSearch.Text = txtSearch.Text.Replace(placeholder, "");
                txtSearch.ForeColor = Color.Black;
                txtSearch.SelectionStart = txtSearch.Text.Length;
                txtSearch.TextChanged += txtSearch_TextChanged;
            }

            // Prevent searching placeholder text
            if (txtSearch.ForeColor == Color.Gray)
                return;

            // Get selected category ID
            int categoryId = 0;
            if (cmbCategories.SelectedItem != null)
            {
                var selected = cmbCategories.SelectedItem;
                categoryId = (int)selected.GetType().GetProperty("ID").GetValue(selected, null);
            }

            LoadProducts(txtSearch.Text.Trim(), categoryId);
        }

        // -------------------------------
        // Add, Edit, Delete buttons
        // -------------------------------
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                ((MainDashboardForm)Application.OpenForms["MainDashboardForm"])?.ShowStatus("Product Added Successfully!");
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductID();
            if (productId == null)
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditProductForm editForm = new EditProductForm(productId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                ((MainDashboardForm)Application.OpenForms["MainDashboardForm"])?.ShowStatus("Product updated successfully!");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductID();
            if (productId == null)
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteProductForm delForm = new DeleteProductForm(productId.Value);
            if (delForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                ((MainDashboardForm)Application.OpenForms["MainDashboardForm"])?.ShowStatus("Product deleted successfully!");
            }
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }
    }
}
