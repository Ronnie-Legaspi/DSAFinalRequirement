using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Database.Connections;

using DSAFinalRequirement.Forms.Reports;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Sales
{
    public partial class SalesControl : UserControl
    {
        // Use actual logged-in UserID from Session
        private int currentUserID => Session.UserID;

        public SalesControl()
        {
            InitializeComponent();
            SetupTables();
            LoadProducts();

            dgvProducts.DataError += Dgv_DataError;
            dgvCart.DataError += Dgv_DataError;

            btnAddToCart.Click += BtnAddToCart_Click;
            btnRemove.Click += BtnRemove_Click;
            btnCompleteTransaction.Click += BtnCompleteTransaction_Click;
            btnNewSale.Click += BtnNewSale_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;

            // Set placeholder
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Product";
            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.ForeColor == Color.Gray)
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };
            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Search Product";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
        }

        // Prevent default crash dialog
        private void Dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }

        // -----------------------------
        // INITIALIZE CART TABLE
        // -----------------------------
        private void SetupTables()
        {
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("ProductID", "Product ID");

            DataGridViewImageColumn imgCart = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "ProductImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvCart.Columns.Add(imgCart);

            dgvCart.Columns.Add("ProductName", "Product Name");
            dgvCart.Columns.Add("Quantity", "Qty");
            dgvCart.Columns.Add("UnitPrice", "Unit Price");
            dgvCart.Columns.Add("Subtotal", "Subtotal");

            dgvCart.RowTemplate.Height = 60;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // -----------------------------
        // LOAD PRODUCTS (with optional search)
        // -----------------------------
        private void LoadProducts(string searchTerm = "")
        {
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();

            dgvProducts.Columns.Add("ProductID", "Product ID");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "ProductImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvProducts.Columns.Add(imgCol);

            dgvProducts.Columns.Add("ProductName", "Product Name");
            dgvProducts.Columns.Add("CategoryName", "Category");
            dgvProducts.Columns.Add("Price", "Price");
            dgvProducts.Columns.Add("StockQuantity", "Stock");

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"
                        SELECT 
                            P.ProductID,
                            P.ProductImage,
                            P.ProductName,
                            C.CategoryName,
                            P.SellingPrice,
                            P.StockQuantity
                        FROM Products AS P
                        INNER JOIN Categories AS C
                            ON P.CategoryID = C.CategoryID
                    ";

                    // Add search filter
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE P.ProductName LIKE @search OR C.CategoryName LIKE @search";
                    }

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                        }

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                            while (reader.Read())
                            {
                                int productId = Convert.ToInt32(reader["ProductID"]);
                                string imgFile = reader["ProductImage"]?.ToString() ?? "";
                                string name = reader["ProductName"].ToString();
                                string category = reader["CategoryName"].ToString();
                                decimal price = Convert.ToDecimal(reader["SellingPrice"]);
                                int stock = Convert.ToInt32(reader["StockQuantity"]);

                                Image productImage = null;

                                // Load image safely
                                if (!string.IsNullOrEmpty(imgFile))
                                {
                                    string imgPath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", imgFile);
                                    if (File.Exists(imgPath))
                                    {
                                        using (var temp = Image.FromFile(imgPath))
                                            productImage = new Bitmap(temp);
                                    }
                                }

                                // Fallback image
                                if (productImage == null)
                                {
                                    string fallback = Path.Combine(projectRoot, "Assets", "Icons", "BrokenImage.png");
                                    if (File.Exists(fallback))
                                    {
                                        using (var temp = Image.FromFile(fallback))
                                            productImage = new Bitmap(temp);
                                    }
                                }

                                dgvProducts.Rows.Add(productId, productImage, name, category, price, stock);
                            }
                        }
                    }
                }

                foreach (DataGridViewRow r in dgvProducts.Rows)
                    r.Height = 60;

                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Products:\n" + ex.Message);
            }
        }

        // -----------------------------
        // ADD TO CART
        // -----------------------------
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            DataGridViewRow row = dgvProducts.SelectedRows[0];

            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
            Image img = row.Cells["ProductImage"].Value as Image;
            string name = row.Cells["ProductName"].Value.ToString();
            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
            int stock = Convert.ToInt32(row.Cells["StockQuantity"].Value);

            int qty = (int)nudQuantity.Value;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            if (qty > stock)
            {
                MessageBox.Show("Not enough stock.");
                return;
            }

            decimal subtotal = price * qty;

            dgvCart.Rows.Add(productId, img, name, qty, price, subtotal);
            UpdateSummary();
        }

        // -----------------------------
        // REMOVE CART ITEM
        // -----------------------------
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select item to remove.");
                return;
            }

            dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
            UpdateSummary();
        }

        // -----------------------------
        // UPDATE SUMMARY
        // -----------------------------
        private void UpdateSummary()
        {
            int totalItems = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Quantity"].Value != null &&
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out int qty))
                {
                    totalItems += qty;
                }

                if (row.Cells["Subtotal"].Value != null &&
                    decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out decimal sub))
                {
                    totalAmount += sub;
                }
            }

            decimal vat = totalAmount * 0.12m;
            decimal grandTotal = totalAmount + vat;

            lblTotalItems.Text = totalItems.ToString();
            lblTotalAmount.Text = totalAmount.ToString("N2");
            lblVatAmount.Text = vat.ToString("N2");
            lblGrandTotal.Text = grandTotal.ToString("N2");
        }

        // -----------------------------
        // COMPLETE TRANSACTION
        // -----------------------------
        private void BtnCompleteTransaction_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            if (!decimal.TryParse(txtCashReceived.Text, out decimal cash))
            {
                MessageBox.Show("Invalid cash amount.");
                return;
            }

            decimal grandTotal = decimal.Parse(lblGrandTotal.Text);

            if (cash < grandTotal)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            decimal change = cash - grandTotal;
            lblChange.Text = change.ToString("N2");

            try
            {
                InsertTransaction(currentUserID, grandTotal);
                MessageBox.Show("Transaction completed and saved!");

                // Refresh Transactions DGV
                var transactionsControl = Application.OpenForms
                    .OfType<Form>()
                    .SelectMany(f => f.Controls.OfType<TransactionsControl>())
                    .FirstOrDefault();

                if (transactionsControl != null)
                {
                    transactionsControl.LoadTransactions(); // <-- This reloads the dgv immediately
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction:\n" + ex.Message);
            }

            BtnNewSale_Click(null, null);
        }


        private void InsertTransaction(int userId, decimal totalAmount)
        {
            OleDbConnection conn = DatabaseConnection.GetConnection();

            string query = @"
                INSERT INTO Transactions (UserID, TotalAmount, Remarks)
                VALUES (@UserID, @TotalAmount, @Remarks)
            ";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@Remarks", "Complete");

                cmd.ExecuteNonQuery();
            }
        }

        // -----------------------------
        // RESET SALE
        // -----------------------------
        private void BtnNewSale_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            txtCashReceived.Text = "";
            lblChange.Text = "0.00";
            lblTotalAmount.Text = "0.00";
            lblVatAmount.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblTotalItems.Text = "0";
        }

        // -----------------------------
        // PRODUCT SEARCH HANDLER
        // -----------------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.Gray)
                return;

            LoadProducts(txtSearch.Text.Trim());
        }
    }
}
