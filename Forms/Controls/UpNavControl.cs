using DSAFinalRequirement.Classes.Helpers;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Dashboard.Controls
{
    public partial class UpNavControl : UserControl
    {
        public UpNavControl()
        {
            //InitializeComponent();
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            //lblUsername.Text = Session.Username;
            //lblEmail.Text = Session.Email;

            //// Load user image
            //string basePath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
            //string imgPath = Path.Combine(basePath, "Assets", "Images", Session.UserImage);

            //if (File.Exists(imgPath))
            //{
            //    pbUser.Image = Image.FromFile(imgPath);
            //}
            //else
            //{
            //    pbUser.Image = Image.FromFile(
            //        Path.Combine(basePath, "Assets", "Icons", "icons8-profile-48.png")
            //    );
            //}
        }
    }
}
