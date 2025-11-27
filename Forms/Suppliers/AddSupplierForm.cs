using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Suppliers
{
    public partial class AddSupplierForm : Form
    {
        private string selectedImageFile = "";

        public AddSupplierForm()
        {
            InitializeComponent();
            WireEvents();
            InitializeStatusComboBox();
        }

        // --------------------------------------------------------------------
        // WIRE EVENTS
        // --------------------------------------------------------------------
        private void WireEvents()
        {
            btnBrowseImage.Click += btnBrowseImage_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        // --------------------------------------------------------------------
        // INITIALIZE STATUS COMBOBOX
        // --------------------------------------------------------------------
        private void InitializeStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0; // Default to Active
        }

        // --------------------------------------------------------------------
        // BROWSE IMAGE
        // --------------------------------------------------------------------
        private void btnBrowseImage_Click(object sender, EventArgs e)
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

        // --------------------------------------------------------------------
        // VALIDATE EMAIL FORMAT
        // --------------------------------------------------------------------
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // --------------------------------------------------------------------
        // SAVE SUPPLIER
        // --------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";

            // -----------------------
            // REQUIRED FIELD CHECK
            // -----------------------
            if (string.IsNullOrWhiteSpace(supplierName) ||
                string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -----------------------
            // CONTACT NUMBER VALIDATION
            // -----------------------
            if (!long.TryParse(contactNumber, out _))
            {
                MessageBox.Show("Contact Number must contain numbers only.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -----------------------
            // EMAIL FORMAT VALIDATION
            // -----------------------
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -----------------------
            // SUPPLIER IMAGE CHECK
            // -----------------------
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
                    // -----------------------
                    // UNIQUE SUPPLIER NAME CHECK
                    // -----------------------
                    string checkQuery = "SELECT COUNT(*) FROM Suppliers WHERE SupplierName = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Supplier Name already exists. Please use a unique name.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // -----------------------
                    // SAVE IMAGE TO PROJECT
                    // -----------------------
                    string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                    string folderPath = Path.Combine(projectRoot, "Assets", "Images", "SupplierImages");

                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    string imgFileName = $"{Guid.NewGuid()}{Path.GetExtension(selectedImageFile)}";
                    string finalImgPath = Path.Combine(folderPath, imgFileName);

                    File.Copy(selectedImageFile, finalImgPath, true);

                    // -----------------------
                    // INSERT SUPPLIER INTO DATABASE
                    // -----------------------
                    string insertQuery =
                        @"INSERT INTO Suppliers
                          (SupplierName, ContactNumber, Email, Address, SupplierImage, Status, DateAdded)
                          VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@SupplierImage", imgFileName);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier successfully added!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving supplier:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // CANCEL BUTTON
        // --------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
