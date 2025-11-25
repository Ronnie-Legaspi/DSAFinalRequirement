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

            // Step 1: Basic validation
            if (username == "" || password == "")
            {
                ShowError("Please enter username and password.");
                return;
            }

            // Step 2: Query user by username
            string query = "SELECT UserID, Username, [Password], Role, UserImage, Email FROM Users WHERE Username = ?";

            using (OleDbDataReader dr = QueryHelper.ExecuteReader(query,
                new OleDbParameter("@Username", username)))
            {
                if (!dr.HasRows)
                {
                    ShowError("Username does not exist.");
                    return;
                }

                dr.Read();

                // Step 3: Compare password 
                string dbPassword = dr["Password"].ToString();

                if (password != dbPassword)
                {
                    ShowError("Incorrect password.");
                    return;
                }

                // Step 4: Extract user data
                int userID = Convert.ToInt32(dr["UserID"]);
                string role = dr["Role"].ToString();
                string userImage = dr["UserImage"].ToString();
                string email = dr["Email"].ToString();

                // Step 5: Save session
                SaveSession(userID, username, role, userImage, email);

                // Step 6: Redirect
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
    }
}
