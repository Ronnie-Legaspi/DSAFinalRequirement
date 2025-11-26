using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Suppliers
{
    public partial class EditSupplierForm : Form
    {
        private int supplierId;
        private string selectedImageFile = "";
        private string existingImageFile = "";

        public EditSupplierForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            WireEvents();
            InitializeStatusComboBox();
            LoadSupplierData();
        }

        // --------------------------
        // Wire Events
        // --------------------------
        private void WireEvents()
        {
            btnBrowseImage.Click += BtnBrowseImage_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        // --------------------------
        // Initialize Status ComboBox
        // --------------------------
        private void InitializeStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
        }

        // --------------------------
        // Browse Image
        // --------------------------
        private void BtnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedImageFile = dlg.FileName;
                picSupplierImage.Image = Image.FromFile(selectedImageFile);
                picSupplierImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        // --------------------------
        // Load Supplier Data
        // --------------------------
        private void LoadSupplierData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Suppliers WHERE SupplierID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtSupplierName.Text = reader["SupplierName"].ToString();
                                txtContactNumber.Text = reader["ContactNumber"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                string status = reader["Status"].ToString();
                                cmbStatus.SelectedItem = status;

                                existingImageFile = reader["SupplierImage"].ToString();

                                // Load Image
                                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", existingImageFile);
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
                MessageBox.Show("Error loading supplier data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------
        // Validate Email
        // --------------------------
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // --------------------------
        // Save Changes
        // --------------------------
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";

            // Required fields
            if (string.IsNullOrWhiteSpace(supplierName) ||
                string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Contact number validation
            if (!long.TryParse(contactNumber, out _))
            {
                MessageBox.Show("Contact Number must contain numbers only.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Image check
            if (picSupplierImage.Image == null)
            {
                MessageBox.Show("Please select a supplier image.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    // Unique supplier name (excluding current supplier)
                    string checkQuery = "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = ? AND SupplierID <> ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        checkCmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Supplier Name already exists. Please use a unique name.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string imgFileName = existingImageFile;

                    // If user selected a new image, save it
                    if (!string.IsNullOrEmpty(selectedImageFile))
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                        string folderPath = Path.Combine(projectRoot, "Assets", "Images");

                        if (!Directory.Exists(folderPath))
                            Directory.CreateDirectory(folderPath);

                        imgFileName = $"{Guid.NewGuid()}{Path.GetExtension(selectedImageFile)}";
                        string finalImgPath = Path.Combine(folderPath, imgFileName);

                        File.Copy(selectedImageFile, finalImgPath, true);
                    }

                    // Update supplier in database
                    string updateQuery = @"UPDATE Suppliers
                                           SET SupplierName = ?, ContactNumber = ?, Email = ?, Address = ?, SupplierImage = ?, Status = ?
                                           WHERE SupplierID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@SupplierImage", imgFileName);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------
        // Cancel Button
        // --------------------------
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
