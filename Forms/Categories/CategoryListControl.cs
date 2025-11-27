using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Dashboard;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class CategoryListControl : UserControl
    {
        public CategoryListControl()
        {
            InitializeComponent();
            LoadCategories();

            // Wire events
            btnDeleteCategory.Click += BtnDeleteCategory_Click;
            btnAddCategory.Click += btnAddCategory_Click;
            btnEditCategory.Click += btnEditCategory_Click;
        }

        /// ------------------------------
        /// Load categories dgv
        /// ------------------------------
        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();
            dgvCategories.Columns.Clear();

            // Columns
            dgvCategories.Columns.Add("CategoryID", "Category ID");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn
            {
                HeaderText = "Category Image",
                Name = "CategoryImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvCategories.Columns.Add(imgCol);

            dgvCategories.Columns.Add("CategoryName", "Category Name");
            dgvCategories.Columns.Add("Description", "Description");
            dgvCategories.Columns.Add("DateCreated", "Date Created");

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Categories";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                        while (reader.Read())
                        {
                            int categoryId = Convert.ToInt32(reader["CategoryID"]);
                            string imgFile = reader["CategoryImage"]?.ToString() ?? "";
                            string categoryName = reader["CategoryName"].ToString();
                            string description = reader["Description"].ToString();
                            string dateCreated = reader["DateCreated"].ToString();

                            // Load image
                            Image categoryImage = null;
                            if (!string.IsNullOrEmpty(imgFile))
                            {
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", "CategoryImages", imgFile);
                                if (File.Exists(imgPath))
                                    categoryImage = Image.FromFile(imgPath);
                            }

                            // fallback image
                            if (categoryImage == null)
                            {
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "BrokenImage.png");
                                if (File.Exists(fallback))
                                    categoryImage = Image.FromFile(fallback);
                            }

                            dgvCategories.Rows.Add(categoryId, categoryImage, categoryName, description, dateCreated);
                        }
                    }
                }

                dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategories.RowTemplate.Height = 50;
                foreach (DataGridViewRow row in dgvCategories.Rows)
                    row.Height = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Categories:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------------------
        // Add Category
        // ------------------------------
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addForm = new AddCategoryForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Category Added Successfully!");
            }
        }

        // ------------------------------
        // Edit Category
        // ------------------------------
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int? categoryId = GetSelectedCategoryID();
            if (categoryId == null)
            {
                MessageBox.Show("No Category selected. Please select a Category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditCategoryForm editForm = new EditCategoryForm(categoryId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Category updated successfully!");
            }
        }

        // ------------------------------
        // Delete Category
        // ------------------------------
        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            int? categoryId = GetSelectedCategoryID();
            if (categoryId == null)
            {
                MessageBox.Show("No category selected. Please select a category first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteCategoryForm delForm = new DeleteCategoryForm(categoryId.Value);
            if (delForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                    dash.ShowStatus("Category deleted successfully!");
            }
        }

        // ------------------------------
        // Get Selected Category ID
        // ------------------------------
        private int? GetSelectedCategoryID()
        {
            if (dgvCategories.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvCategories.SelectedRows[0].Cells["CategoryID"].Value);
            }
            catch
            {
                return null;
            }
        }
    }
}
