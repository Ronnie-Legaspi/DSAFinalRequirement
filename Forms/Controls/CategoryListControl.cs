using DSAFinalRequirement.Database.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class CategoryListControl : UserControl
    {
        public CategoryListControl()
        {
            InitializeComponent();
            LoadCategories();
        }

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
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..")); // check your folder

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
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "icons8-profile-48.png");
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

    }
}
