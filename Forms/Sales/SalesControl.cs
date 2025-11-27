using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Classes.Helpers;

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
            btnRefresh.Click += BtnRefresh_Click;
            btnCompleteTransaction.Click += BtnCompleteTransaction_Click;
            btnNewSale.Click += BtnNewSale_Click;
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
        // LOAD PRODUCTS
        // -----------------------------
        private void LoadProducts()
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

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
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
        // REFRESH PRODUCTS
        // -----------------------------
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
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
        // COMPLETE TRANSACTION (ONLY Transactions)
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
                // Insert into Transactions
                InsertTransaction(currentUserID, grandTotal);

                MessageBox.Show("Transaction completed and saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving transaction:\n" + ex.Message);
            }

            // Reset sale
            BtnNewSale_Click(null, null);
        }

        private void InsertTransaction(int userId, decimal totalAmount)
        {
            // Assume DatabaseConnection.GetConnection() is already open
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
    }
}
