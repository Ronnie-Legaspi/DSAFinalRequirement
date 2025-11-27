using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Dashboard;
using DSAFinalRequirement.Forms.Users;
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

            btnAddSupplier.Click += BtnAddSupplier_Click;
            btnEditSupplier.Click += BtnEditSupplier_Click;
            btnDeleteSupplier.Click += BtnDeleteSupplier_Click;
            btnRefresh.Click += BtnRefresh_Click1;
            btnSearchSupplier.Click += btnSearchSupplier_Click;
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
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", "SupplierImages", imgFile);
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

        // __________________________
        // CRUD BUTTONS 
        // ___________________+___________

        // ADD SUPPLIER
        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm addForm = new AddSupplierForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
                // call mainDashboard.ShowStatus
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("Supplier Added Successfully");
                }
            }
        }

        // -------------------------
        // EDIT Supplier
        // -------------------------
        private void BtnEditSupplier_Click(object sender, EventArgs e)
        {
            int? supplierId = GetSelectedUserID();

            if (supplierId == null)
            {
                MessageBox.Show("No user selected. Please select a user first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditSupplierForm editForm = new EditSupplierForm(supplierId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();

                // Call MainDashboardForm.ShowStatus
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("Supplier updated successfully!");
                }
            }

        }

        // -------------------------
        // Delete Supplier
        // -------------------------
        private void BtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int? supplierId = GetSelectedUserID();

            if (supplierId == null)
            {
                MessageBox.Show("No Supplier selected. Please select a user first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteSupplierForm editForm = new DeleteSupplierForm(supplierId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();

                // Call MainDashboardForm.ShowStatus
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("Supplier Deleted successfully!");
                }
            }

        }


        // REFRESH SUUPLIERS DGV
        public void BtnRefresh_Click1(object sender, EventArgs e)
        {
            LoadSuppliers();

        }

        // Search button 
        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchSupplier.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadSuppliers();
                return;
            }

            foreach (DataGridViewRow row in dgvSuppliers.Rows)
            {
                // Skip the new row placeholder
                if (row.IsNewRow) continue;

                bool isVisible = false;

                string username = row.Cells["SupplierName"].Value?.ToString().ToLower() ?? "";
                string fullname = row.Cells["SupplierName"].Value?.ToString().ToLower() ?? "";
                string email = row.Cells["Email"].Value?.ToString().ToLower() ?? "";

                if (username.Contains(searchTerm) || fullname.Contains(searchTerm) || email.Contains(searchTerm))
                {
                    isVisible = true;
                }

                row.Visible = isVisible;
            }
        }

        // -------------------------
        // SELECTED USER ID HELPER
        // -------------------------
        private int? GetSelectedUserID()
        {
            if (dgvSuppliers.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["SupplierID"].Value);
            }
            catch
            {
                return null;
            }
        }
        
    }
}
