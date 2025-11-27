using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class AddCategoryForm : Form
    {
        private string selectedImageFullPath = ""; // Full path of selected image

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        // -------------------------------
        //  BROWSE IMAGE
        // -------------------------------
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load image into PictureBox
                    using (var img = Image.FromFile(ofd.FileName))
                    {
                        picCategoryImage.Image = new Bitmap(img); // Clone to avoid file lock
                    }

                    // Store full path for later saving
                    selectedImageFullPath = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------------
        //  SAVE CATEGORY
        // -------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // -------------------------------
            // VALIDATIONS
            // -------------------------------
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Category Name is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CategoryExists(categoryName))
            {
                MessageBox.Show("Category name already exists. Please enter a unique name.",
                    "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (picCategoryImage.Image == null || string.IsNullOrEmpty(selectedImageFullPath))
            {
                MessageBox.Show("Please select a category image.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // -------------------------------
                // PREPARE IMAGE FILENAME & COPY
                // -------------------------------
                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                string imgFolder = Path.Combine(projectRoot, "Assets", "Images", "CategoryImages");

                if (!Directory.Exists(imgFolder))
                    Directory.CreateDirectory(imgFolder);

                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(selectedImageFullPath);
                string destPath = Path.Combine(imgFolder, uniqueFileName);

                // Copy image file safely
                File.Copy(selectedImageFullPath, destPath, true); // overwrite if exists

                // -------------------------------
                // INSERT INTO DATABASE
                // -------------------------------
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"INSERT INTO Categories 
                                     (CategoryImage, CategoryName, Description, DateCreated) 
                                     VALUES (@img, @name, @desc, @date)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@img", uniqueFileName);
                        cmd.Parameters.AddWithValue("@name", categoryName);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@date", dateCreated);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------------
        //  CHECK IF CATEGORY NAME EXISTS
        // -------------------------------
        private bool CategoryExists(string categoryName)
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @name";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", categoryName);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking category existence:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // -------------------------------
        //  CANCEL BUTTON
        // -------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
