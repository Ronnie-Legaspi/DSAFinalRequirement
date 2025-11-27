using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class EditCategoryForm : Form
    {
        private int categoryId;
        private string currentImageFile = "";
        private string newSelectedImage = "";

        public EditCategoryForm(int categoryId)
        {
            InitializeComponent();

            this.categoryId = categoryId;

            // Only wire events if not already wired in designer
            btnBrowseImage.Click -= btnBrowseImage_Click;
            btnBrowseImage.Click += btnBrowseImage_Click;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;

            // Load current category data
            LoadCategoryData();
        }

        // -------------------------------
        // LOAD CATEGORY DATA
        // -------------------------------
        private void LoadCategoryData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Categories WHERE CategoryID = @id";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", categoryId);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCategoryName.Text = reader["CategoryName"].ToString();
                                txtDescription.Text = reader["Description"].ToString();
                                currentImageFile = reader["CategoryImage"].ToString();

                                // Display current image
                                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", "CategoryImages", currentImageFile);

                                if (!string.IsNullOrEmpty(currentImageFile) && File.Exists(imgPath))
                                    picCategoryImage.Image = Image.FromFile(imgPath);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------
        // BROWSE IMAGE
        // -------------------------------
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picCategoryImage.Image = Image.FromFile(ofd.FileName);
                newSelectedImage = Path.GetFileName(ofd.FileName);
            }
        }

        // -------------------------------
        // SAVE CHANGES
        // -------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate unique name except current record
            if (CategoryNameExists(categoryName, categoryId))
            {
                MessageBox.Show("Category name already exists. Please enter a unique name.",
                    "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"UPDATE Categories 
                                     SET CategoryName = @name, Description = @desc, CategoryImage = @img 
                                     WHERE CategoryID = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", categoryName);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@img", string.IsNullOrEmpty(newSelectedImage) ? currentImageFile : newSelectedImage);
                        cmd.Parameters.AddWithValue("@id", categoryId);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Save new image if changed
                if (!string.IsNullOrEmpty(newSelectedImage))
                {
                    string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                    string imgFolder = Path.Combine(projectRoot, "Assets", "Images", "CategoryImages");

                    if (!Directory.Exists(imgFolder))
                        Directory.CreateDirectory(imgFolder);

                    string destPath = Path.Combine(imgFolder, newSelectedImage);

                    if (!File.Exists(destPath) && picCategoryImage.Image != null)
                        picCategoryImage.Image.Save(destPath);
                }

                MessageBox.Show("Category updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------
        // CHECK UNIQUE CATEGORY NAME
        // -------------------------------
        private bool CategoryNameExists(string categoryName, int excludeId)
        {
            using (OleDbConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @name AND CategoryID <> @id";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", categoryName);
                    cmd.Parameters.AddWithValue("@id", excludeId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // -------------------------------
        // CANCEL BUTTON
        // -------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // closes current form
        }
    }
}
