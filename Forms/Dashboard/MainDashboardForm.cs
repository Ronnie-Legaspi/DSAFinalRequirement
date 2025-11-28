using DSAFinalRequirement.Classes.Helpers;
using DSAFinalRequirement.Forms.Categories;
using DSAFinalRequirement.Forms.Inventory;
using DSAFinalRequirement.Forms.Products;
using DSAFinalRequirement.Forms.Reports;
using DSAFinalRequirement.Forms.Sales;
using DSAFinalRequirement.Forms.Suppliers;
using DSAFinalRequirement.Forms.Transactions;
using DSAFinalRequirement.Forms.Users;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Dashboard
{
    public partial class MainDashboardForm : Form
    {
        private Dictionary<Button, UserControl> navMap;

        public MainDashboardForm()
        {
            

            InitializeComponent();
            LoadUserSession();
        }

        // ----------------------------------------------------------
        // LOAD Logged-in User Data (Username, Email, Image)
        // ----------------------------------------------------------
        private void LoadUserSession()
        {
            lblUsername.Text = Session.Username;
            lblEmail.Text = Session.Email;

            // Build full path for user profile image
            if (!string.IsNullOrEmpty(Session.UserImage))
            {
                string projectPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                string fullImagePath = Path.Combine(projectPath, "Assets", "Images", Session.UserImage);

                if (File.Exists(fullImagePath))
                {
                    pbUserImage.Image = Image.FromFile(fullImagePath);
                    return;
                }
            }

            // Fallback image (default profile icon)
            string fallback = Path.Combine(Application.StartupPath, "Assets", "Icons", "icons8-profile-48.png");

            if (File.Exists(fallback))
                pbUserImage.Image = Image.FromFile(fallback);
        }

        // ----------------------------------------------------------
        // SHOW STATUS MESSAGE (Green label)
        // ----------------------------------------------------------
        public async void ShowStatus(string message)
        {
            string fullMessage = "✔ " + message;

            lblStatus.Text = "";
            lblStatus.Visible = true;

            // --- TYPEWRITER EFFECT ---
            for (int i = 0; i < fullMessage.Length; i++)
            {
                lblStatus.Text = fullMessage.Substring(0, i + 1);
                await Task.Delay(30);   // typing speed
            }

            // Wait 2 seconds before deleting
            await Task.Delay(2500);

            // --- REVERSE DELETE EFFECT ---
            for (int i = fullMessage.Length; i > 0; i--)
            {
                lblStatus.Text = fullMessage.Substring(0, i - 1);
                await Task.Delay(20);  // delete speed
            }

            lblStatus.Visible = false;
        }

        // ----------------------------------------------------------
        // FORM LOAD EVENT – Setup Side Navigation
        // ----------------------------------------------------------
        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            // Map SideNav Buttons -> UserControls
            navMap = new Dictionary<Button, UserControl>()
            {
                { btnDashboard, new DashboardControl() },
                { btnInventory, new InventoryAdjustmentListControl() },
                { btnProducts, new ProductsListControl() },
                { btnCategories, new CategoryListControl() },
                { btnSuppliers, new SupplierListControl() },
                { btnUsers, new UserManagementControl() },
                { btnSales, new SalesControl() },
                { btnTransactions, new TransactionsControl() }
            };

            // Attach ALL buttons to the same click handler
            foreach (var btn in navMap.Keys)
                btn.Click += NavClick;

            // Load DashboardControl by DEFAULT
            NavClick(btnDashboard, EventArgs.Empty);
        }

        // ----------------------------------------------------------
        // UNIVERSAL NAV CLICK EVENT
        // ----------------------------------------------------------
        private void NavClick(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            // Highlight selected button
            foreach (var btn in navMap.Keys)
                btn.BackColor = Color.Transparent;

            clicked.BackColor = Color.DodgerBlue;

            // Clear previous
            pnlMainContent.Controls.Clear();

            // Load control
            UserControl ctrl = navMap[clicked];

            // ---- IMPORTANT PART HERE ----
            // Make UserControl size dictate the panel
            pnlMainContent.Size = ctrl.Size;      // panel copies UC size
            ctrl.Dock = DockStyle.Fill;           // and UC fills it properly
                                                  // --------------------------------

            pnlMainContent.Controls.Add(ctrl);
        }

        public void TriggerNav(Button btn)
        {
            NavClick(btn, EventArgs.Empty);
        }



        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void pnlSideNav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
