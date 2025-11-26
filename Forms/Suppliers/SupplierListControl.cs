using DSAFinalRequirement.Database.Connections;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Suppliers
{
    public partial class SupplierListControl : UserControl
    {
        public SupplierListControl()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        // -------------------------
        // LOAD SUPPLIERS TO DATAGRIDVIEW
        // -------------------------
        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.Rows.Clear();
                dgvSuppliers.Columns.Clear();

                // -------------------------
                // COLUMN SETUP
                //__________________________
                dgvSuppliers.Columns.Add("SupplierID", "Supplier ID");

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn
                {
                    HeaderText = "Supplier Image",
                    Name = "SupplierImage",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dgvSuppliers.Columns.Add(imgCol);

                dgvSuppliers.Columns.Add("SupplierName", "Supplier Name");
                dgvSuppliers.Columns.Add("ContactNumber", "Contact Number");
                dgvSuppliers.Columns.Add("Email", "Email");
                dgvSuppliers.Columns.Add("Address", "Address");

                // STATUS IMAGE COLUMN
                DataGridViewImageColumn statusCol = new DataGridViewImageColumn
                {
                    HeaderText = "Status",
                    Name = "StatusImage",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dgvSuppliers.Columns.Add(statusCol);

                dgvSuppliers.Columns.Add("DateAdded", "Date Added");

                // -------------------------
                // READ FROM DATABASE
                // -------------------------
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Suppliers";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                        while (reader.Read())
                        {
                            int supplierId = reader.GetInt32(0);
                            string imgFile = reader["SupplierImage"]?.ToString() ?? "";
                            string supplierName = reader["SupplierName"].ToString();
                            string contactNumber = reader["ContactNumber"].ToString();
                            string email = reader["Email"].ToString();
                            string address = reader["Address"].ToString();
                            string status = reader["Status"].ToString();
                            string dateAdded = reader["DateAdded"].ToString();

                            // -------------------------
                            // LOAD SUPPLIER IMAGE
                            // -------------------------
                            Image supplierImage = null;

                            if (!string.IsNullOrEmpty(imgFile))
                            {
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", imgFile);
                                if (File.Exists(imgPath))
                                    supplierImage = Image.FromFile(imgPath);
                            }

                            // fallback image
                            if (supplierImage == null)
                            {
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "icons8-profile-48.png");
                                if (File.Exists(fallback))
                                    supplierImage = Image.FromFile(fallback);
                            }

                            // -------------------------
                            // LOAD STATUS IMAGE
                            // -------------------------
                            string statusImageName =
                                status.Equals("Active", StringComparison.OrdinalIgnoreCase)
                                ? "GreenCircle.png"
                                : "RedCircle.png";

                            string statusPath = Path.Combine(projectRoot, "Assets", "Icons", statusImageName);

                            Image statusImg = File.Exists(statusPath)
                                ? Image.FromFile(statusPath)
                                : null;

                            // -------------------------
                            // ADD ROW
                            // -------------------------
                            dgvSuppliers.Rows.Add(
                                supplierId,
                                supplierImage,
                                supplierName,
                                contactNumber,
                                email,
                                address,
                                statusImg,
                                dateAdded
                            );
                        }
                    }
                    dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSuppliers.RowTemplate.Height = 50;
                    foreach (DataGridViewRow row in dgvSuppliers.Rows)
                    {
                        row.Height = 50;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
