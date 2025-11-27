using DSAFinalRequirement.Database.Connections;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class DeleteCategoryForm : Form
    {
        private int categoryId;
        private string categoryName;
        private string categoryImageFile = "";

        public DeleteCategoryForm(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            LoadCategoryData();

            btnDelete.Click += btnDelete_Click;
            btnCancel.Click += btnCancel_Click;

        }

        // -------------------------
        // Load Category Info
        // -------------------------
        private void LoadCategoryData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT CategoryName, CategoryImage FROM Categories WHERE CategoryID = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                categoryName = reader["CategoryName"].ToString();
                                categoryImageFile = reader["CategoryImage"].ToString();

                                txtCategoryName.Text = categoryName;

                                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", "CategoryImages", categoryImageFile);

                                if (File.Exists(imgPath))
                                {
                                    picCategoryImage.Image = Image.FromFile(imgPath);
                                    picCategoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // Delete Category
        // -------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete category '{categoryName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = DatabaseConnection.GetConnection())
                    {
                        string query = "DELETE FROM Categories WHERE CategoryID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------
        // Cancel
        // -------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
