using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class DeleteUserForm : Form
    {
        private int _userId;
        private string imageFileName = "";

        public DeleteUserForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT Username, FullName, Email, Role, Status, UserImage FROM Users WHERE UserID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _userId);

                    OleDbDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        lblUsername.Text = r["Username"].ToString();
                        lblFullName.Text = r["FullName"].ToString();
                        lblEmail.Text = r["Email"].ToString();
                        lblRole.Text = r["Role"].ToString();
                        lblStatus.Text = r["Status"].ToString();

                        imageFileName = r["UserImage"].ToString();

                        // Load image
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                        string fullImagePath = Path.Combine(projectRoot, "Assets", "Images", imageFileName);

                        if (File.Exists(fullImagePath))
                        {
                            picUser.Image = Image.FromFile(fullImagePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _userId);
                    cmd.ExecuteNonQuery();
                }

                // Delete image file
                if (!string.IsNullOrEmpty(imageFileName))
                {
                    string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                    string imagePath = Path.Combine(projectRoot, "Assets", "Images", imageFileName);

                    if (File.Exists(imagePath))
                        File.Delete(imagePath);
                }

                MessageBox.Show("User deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting user failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
