using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DSAFinalRequirement.Database.Connections;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class EditUserForm : Form
    {
        private int _userId;
        private string selectedImageFile = "";
        private string oldImageFile = "";

        public EditUserForm(int userId)
        {
            InitializeComponent();
            

            btnBrowse.Click += btnBrowse_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            
            _userId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = "SELECT * FROM Users WHERE UserID = @id";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", _userId);

                    OleDbDataReader r = cmd.ExecuteReader();

                    if (r.Read())
                    {
                        txtUsername.Text = r["Username"].ToString();
                        txtFullName.Text = r["FullName"].ToString();
                        txtEmail.Text = r["Email"].ToString();
                        txtPassword.Text = r["Password"].ToString();
                        cboRole.Text = r["Role"].ToString();
                        cboStatus.Text = r["Status"].ToString();

                        oldImageFile = r["UserImage"].ToString();
                        selectedImageFile = oldImageFile;

                        string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                        string fullImagePath = Path.Combine(projectRoot, "Assets", "Images", oldImageFile);

                        if (File.Exists(fullImagePath))
                            picUser.Image = Image.FromFile(fullImagePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user:\n" + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string imgName = Path.GetFileName(dlg.FileName);
                selectedImageFile = imgName;

                string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\.."));
                string destPath = Path.Combine(projectRoot, "Assets", "Images", imgName);

                File.Copy(dlg.FileName, destPath, true);
                picUser.Image = Image.FromFile(destPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    string query = @"UPDATE Users SET 
                                        UserImage = @img,
                                        Username = @uname,
                                        FullName = @fname,
                                        Email = @mail,
                                        [Password] = @pass,
                                        Role = @role,
                                        Status = @status
                                     WHERE UserID = @id";

                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue("@img", selectedImageFile);
                    cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@fname", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@role", cboRole.Text);
                    cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                    cmd.Parameters.AddWithValue("@id", _userId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user:\n" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
