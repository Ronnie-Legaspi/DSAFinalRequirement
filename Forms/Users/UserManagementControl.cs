using DSAFinalRequirement.Database.Connections;
using DSAFinalRequirement.Forms.Dashboard;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class UserManagementControl : UserControl
    {
        public UserManagementControl()
        {
            InitializeComponent();
            LoadUsers();

            btnAddUser.Click += BtnAddUser_Click;
            btnEditUser.Click += BtnEditUser_Click;
            btnDeleteUser.Click += BtnDeleteUser_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnSearchUser.Click += btnSearchUser_Click;
        }

        // -------------------------
        // ADD USER
        // -------------------------
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
                // Call MainDashboardForm.ShowStatus
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("User Added successfully!");
                }
            }
                
        }

        // -------------------------
        // EDIT USER
        // -------------------------
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            int? userId = GetSelectedUserID();

            if (userId == null)
            {
                MessageBox.Show("No user selected. Please select a user first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditUserForm editForm = new EditUserForm(userId.Value);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();

                // Call MainDashboardForm.ShowStatus
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("User updated successfully!");
                }
            }
                
        }

        // -------------------------
        // DELETE USER
        // -------------------------
        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            int? userId = GetSelectedUserID();

            if (userId == null)
            {
                MessageBox.Show("No user selected. Please select a user first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr != DialogResult.Yes) return;

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserID = @id";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();

                // Show status on MainDashboardForm
                var dash = (MainDashboardForm)Application.OpenForms["MainDashboardForm"];
                if (dash != null)
                {
                    dash.ShowStatus("User deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // REFRESH DATAGRIDVIEW
        public void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            
        }

        // Search button 
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchUser.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadUsers();
                return;
            }

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                // Skip the new row placeholder
                if (row.IsNewRow) continue;

                bool isVisible = false;

                string username = row.Cells["Username"].Value?.ToString().ToLower() ?? "";
                string fullname = row.Cells["FullName"].Value?.ToString().ToLower() ?? "";
                string email = row.Cells["Email"].Value?.ToString().ToLower() ?? "";

                if (username.Contains(searchTerm) || fullname.Contains(searchTerm) || email.Contains(searchTerm))
                {
                    isVisible = true;
                }

                row.Visible = isVisible;
            }
        }


        // -------------------------
        // LOAD USERS TO DATAGRIDVIEW
        // -------------------------
        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();

            dgvUsers.Columns.Add("UserID", "UserID");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn
            {
                HeaderText = "User Image",
                Name = "UserImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvUsers.Columns.Add(imgCol);

            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("FullName", "Full Name");
            dgvUsers.Columns.Add("Email", "Email");
            dgvUsers.Columns.Add("Role", "Role");

            DataGridViewImageColumn statusCol = new DataGridViewImageColumn
            {
                HeaderText = "Status",
                Name = "Status",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvUsers.Columns.Add(statusCol);

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT UserID, UserImage, Username, FullName, Email, Role, Status FROM Users";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string imgFile = reader["UserImage"]?.ToString() ?? "";
                            string username = reader["Username"].ToString();
                            string fullName = reader["FullName"].ToString();
                            string email = reader["Email"].ToString();
                            string role = reader["Role"].ToString();
                            string status = reader["Status"].ToString();

                            Image userImage = null;

                            if (!string.IsNullOrEmpty(imgFile))
                            {
                                string imgPath = Path.Combine(projectRoot, "Assets", "Images", imgFile);
                                if (File.Exists(imgPath))
                                    userImage = Image.FromFile(imgPath);
                            }

                            if (userImage == null)
                            {
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "icons8-profile-48.png");
                                if (File.Exists(fallback))
                                    userImage = Image.FromFile(fallback);
                            }

                            string statusImage = status.Equals("Active", StringComparison.OrdinalIgnoreCase)
                                ? "GreenCircle.png"
                                : "RedCircle.png";

                            string statusPath = Path.Combine(projectRoot, "Assets", "Icons", statusImage);
                            Image statusImg = File.Exists(statusPath) ? Image.FromFile(statusPath) : null;

                            dgvUsers.Rows.Add(userId, userImage, username, fullName, email, role, statusImg);
                        }
                    }
                }

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsers.RowTemplate.Height = 50;
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    row.Height = 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -------------------------
        // SELECTED USER ID HELPER
        // -------------------------
        private int? GetSelectedUserID()
        {
            if (dgvUsers.SelectedRows.Count == 0)
                return null;

            try
            {
                return Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            }
            catch
            {
                return null;
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            btnSearchUser_Click(sender, e);
        }
    }
}
