using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class AddUserForm : Form
    {
        private string selectedImageFile = "";

        public AddUserForm()
        {
            InitializeComponent();
            InitializeDropdowns();
            WireEvents();
        }

        private void WireEvents()
        {
            btnBrowseImage.Click += btnBrowseImage_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void InitializeDropdowns()
        {
            cbRole.Items.Clear();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Staff");
            cbRole.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.Items.Add("Active");
            cbStatus.Items.Add("Inactive");
            cbStatus.SelectedIndex = 0;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImageFile = Path.GetFileName(ofd.FileName);

                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                string targetPath = Path.Combine(projectRoot, "Assets", "Images", selectedImageFile);

                try
                {
                    File.Copy(ofd.FileName, targetPath, true);
                    pbUserImage.Image = Image.FromFile(targetPath);
                    pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error copying image:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cbRole.Text.Trim();
            string status = cbStatus.Text.Trim();

            // 1️⃣ Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(fullName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(role) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill up all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Validate email format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    // 4️⃣ Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @uname";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@uname", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 5️⃣ Insert user
                    string insertQuery = @"INSERT INTO Users (UserImage, Username, FullName, Email, [Password], Role, Status) 
                                           VALUES (@img, @uname, @fullname, @mail, @pass, @role, @status)";
                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@img", selectedImageFile);
                        cmd.Parameters.AddWithValue("@uname", username);
                        cmd.Parameters.AddWithValue("@fullname", fullName);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@status", status);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
