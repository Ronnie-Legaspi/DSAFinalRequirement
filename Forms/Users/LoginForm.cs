using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Database.Queries;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Users
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // LOGIN BUTTON
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        // MAIN LOGIN FUNCTION
        private void LoginUser()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // step 1 Basic Validation 

            if (username == "" || password == "")
            {
                ShowError("Please enter Username and Password");
                return;
            }

            // step 2 Query user by username 
            string query = "SELECT UserID, Username, [Password], Role, UserImage, Email FROM Users WHERE Username = ?";
            using (OleDbDataReader dr = QueryHelper.ExecuteReader(query,
                new OleDbParameter("@username", username)))
            {
                if (!dr.HasRows)
                {
                    ShowError("Invalid Credentials.");
                }

                dr.Read();

                // Database values 
                string dbPassword = dr["Password"].ToString();
                string dbRole = dr["Role"].ToString();

                // step 3 compare password 
                if (password != dbPassword)
                {
                    ShowError("Envalid Credentials");
                    return;
                }

                // Compare selected Role 
                string selectedRole = rbAdmin.Checked ? "Admin" : "Staff";
                if (!dbRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    ShowError("Invalid Credentials");
                    return;
                }

                int userID = Convert.ToInt32(dr["UserID"]);
                string userImage = dr["UserImage"].ToString();
                string email = dr["Email"].ToString();

                // step 6 Save Session
                SaveSession(userID, username, dbRole, userImage, email);

                OpenDashboard();
            }
        }

        // SAVES USER SESSION
        private void SaveSession(int id, string username, string role, string userImage, string email)
        {
            Session.UserID = id;
            Session.Username = username;
            Session.Role = role;
            Session.UserImage = userImage;
            Session.Email = email;
        }

        // OPEN MAIN DASHBOARD
        private void OpenDashboard()
        {
            this.Hide();
            var dash = new Forms.Dashboard.MainDashboardForm();
            dash.Show();
            dash.ShowStatus("Login Successful");
        }

        // SHOW ERROR MESSAGE
        private void ShowError(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            rbAdmin.Checked = true;
        }
    }
}
