using DSAFinalRequirement.Database.Connections;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Products
{
    public partial class AddProductForm : Form
    {
        private string selectedImageFile = "";

        public AddProductForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadSuppliers();
            txtBarcode.Text = GenerateBarcode();

            txtStockQty.KeyPress += NumericOnly_KeyPress;
            txtReorderLevel.KeyPress += NumericOnly_KeyPress;
            txtCostPrice.KeyPress += DecimalOnly_KeyPress;
            txtSellingPrice.KeyPress += DecimalOnly_KeyPress;

            btnBrowse.Click += btnBrowse_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // ============================================================
        // VALIDATIONS
        // ============================================================
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void DecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txt.Text.Contains("."))
                e.Handled = true;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is required.");
                return false;
            }

            if (cmbCategoryID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category.");
                return false;
            }

            if (cmbSupplierID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Supplier.");
                return false;
            }

            if (!int.TryParse(txtStockQty.Text, out int stockQty) || stockQty < 0)
            {
                MessageBox.Show("Invalid Stock Quantity.");
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text, out int reorderLevel) || reorderLevel < 0)
            {
                MessageBox.Show("Invalid Reorder Level.");
                return false;
            }

            if (!decimal.TryParse(txtCostPrice.Text, out decimal costPrice) || costPrice < 0)
            {
                MessageBox.Show("Invalid Cost Price.");
                return false;
            }

            if (!decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice) || sellingPrice < 0)
            {
                MessageBox.Show("Invalid Selling Price.");
                return false;
            }

            if (sellingPrice < costPrice)
            {
                MessageBox.Show("Selling Price cannot be lower than Cost Price.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(selectedImageFile))
            {
                MessageBox.Show("Please select an image.");
                return false;
            }

            return true;
        }

        // ============================================================
        // LOAD CATEGORY & SUPPLIER
        // ============================================================
        private void LoadCategories()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT CategoryID, CategoryName FROM Categories";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dt.Columns.Add("Display");
                    foreach (DataRow row in dt.Rows)
                        row["Display"] = $"{row["CategoryID"]} - {row["CategoryName"]}";

                    cmbCategoryID.DataSource = dt;
                    cmbCategoryID.DisplayMember = "Display";
                    cmbCategoryID.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories:\n" + ex.Message);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT SupplierID, SupplierName FROM Suppliers";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dt.Columns.Add("Display");
                    foreach (DataRow row in dt.Rows)
                        row["Display"] = $"{row["SupplierID"]} - {row["SupplierName"]}";

                    cmbSupplierID.DataSource = dt;
                    cmbSupplierID.DisplayMember = "Display";
                    cmbSupplierID.ValueMember = "SupplierID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers:\n" + ex.Message);
            }
        }

        // ============================================================
        // BARCODE GENERATOR
        // ============================================================
        private string GenerateBarcode()
        {
            Random rnd = new Random();
            return rnd.Next(100000000, 999999999).ToString();
        }

        // ============================================================
        // SELECT IMAGE
        // ============================================================
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImageFile = ofd.FileName;
                picProduct.Image = Image.FromFile(selectedImageFile);
            }
        }

        // ============================================================
        // SAVE PRODUCT
        // ============================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            int categoryId = Convert.ToInt32(cmbCategoryID.SelectedValue);
            int supplierId = Convert.ToInt32(cmbSupplierID.SelectedValue);

            string imageName = Guid.NewGuid() + Path.GetExtension(selectedImageFile);

            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
            string savePath = Path.Combine(projectRoot, "Assets", "Images", "ProductImages", imageName);

            Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            File.Copy(selectedImageFile, savePath, true);

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query =
                        @"INSERT INTO Products 
                        (ProductName, ProductImage, CategoryID, SupplierID, StockQuantity, CostPrice, SellingPrice, Barcode, ReorderLevel)
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    // ORDER OF PARAMETERS MUST MATCH QUERY EXACTLY (IMPORTANT)
                    cmd.Parameters.AddWithValue("ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("ProductImage", imageName);
                    cmd.Parameters.AddWithValue("CategoryID", categoryId);
                    cmd.Parameters.AddWithValue("SupplierID", supplierId);
                    cmd.Parameters.AddWithValue("StockQuantity", Convert.ToInt32(txtStockQty.Text));
                    cmd.Parameters.AddWithValue("CostPrice", Convert.ToDecimal(txtCostPrice.Text));
                    cmd.Parameters.AddWithValue("SellingPrice", Convert.ToDecimal(txtSellingPrice.Text));
                    cmd.Parameters.AddWithValue("Barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("ReorderLevel", Convert.ToInt32(txtReorderLevel.Text));

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product:\n" + ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
