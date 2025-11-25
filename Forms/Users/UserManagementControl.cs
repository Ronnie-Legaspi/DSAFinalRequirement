using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class UserManagementControl : UserControl
    {
        public UserManagementControl()
        {
            InitializeComponent();
            LoadUsers();
            btnAddUser.Click += BtnAddUser_Click;
        }
        /// Button Clicks Events
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }
        /// </summary>

        private void LoadUsers()
        {
            dgvUsers.Rows.Clear();
            dgvUsers.Columns.Clear();

            // Create columns
            dgvUsers.Columns.Add("UserID", "UserID");

            // User image column
            DataGridViewImageColumn userImgCol = new DataGridViewImageColumn
            {
                HeaderText = "User Image",
                Name = "UserImage",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvUsers.Columns.Add(userImgCol);

            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("FullName", "Full Name");
            dgvUsers.Columns.Add("Email", "Email");
            dgvUsers.Columns.Add("Role", "Role");

            // Make Status column an image column
            DataGridViewImageColumn statusImgCol = new DataGridViewImageColumn
            {
                HeaderText = "Status",
                Name = "Status",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvUsers.Columns.Add(statusImgCol);

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT UserID, UserImage, Username, FullName, Email, Role, Status FROM users";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));

                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string imgFile = reader["UserImage"] != DBNull.Value ? reader["UserImage"].ToString() : "";
                            string username = reader["Username"].ToString();
                            string fullName = reader["FullName"].ToString();
                            string email = reader["Email"].ToString();
                            string role = reader["Role"].ToString();
                            string status = reader["Status"].ToString();

                            // Load user image
                            Image userImage = null;
                            if (!string.IsNullOrEmpty(imgFile))
                            {
                                string fullImagePath = Path.Combine(projectRoot, "Assets", "Images", imgFile);
                                if (File.Exists(fullImagePath))
                                    userImage = Image.FromFile(fullImagePath);
                            }

                            // Fallback user image
                            if (userImage == null)
                            {
                                string fallback = Path.Combine(projectRoot, "Assets", "Icons", "icons8-profile-48.png");
                                if (File.Exists(fallback))
                                    userImage = Image.FromFile(fallback);
                            }

                            // Load status image based on Status field
                            string statusImageFile = status.Equals("Active", StringComparison.OrdinalIgnoreCase)
                                                     ? "GreenCircle.png"
                                                     : "RedCircle.png";
                            string statusImagePath = Path.Combine(projectRoot, "Assets", "Icons", statusImageFile);
                            Image statusImage = File.Exists(statusImagePath) ? Image.FromFile(statusImagePath) : null;

                            // Show message box with the path
                            //MessageBox.Show("Status image path: " + statusImagePath, "Debug Status Image");

                            // Add row: note the last column is statusImage
                            dgvUsers.Rows.Add(userId, userImage, username, fullName, email, role, statusImage);
                        }
                    }
                }

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUsers.RowTemplate.Height = 60;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
