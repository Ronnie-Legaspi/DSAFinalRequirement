using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Users
{
    partial class UserManagementControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDescription;
        private DataGridView dgvUsers;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnDeleteUser;
        private Button btnRefresh;
        private TextBox txtSearchUser;
        private Button btnSearchUser;
        private Label lblUserStatus;

        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserUImage;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewImageColumn Status;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.dgvUsers = new DataGridView();
            this.btnAddUser = new Button();
            this.btnEditUser = new Button();
            this.btnDeleteUser = new Button();
            this.btnRefresh = new Button();
            this.txtSearchUser = new TextBox();
            this.btnSearchUser = new Button();
            this.lblUserStatus = new Label();

            this.UserID = new DataGridViewTextBoxColumn();
            this.UserUImage = new DataGridViewTextBoxColumn();
            this.Username = new DataGridViewTextBoxColumn();
            this.FullName = new DataGridViewTextBoxColumn();
            this.Email = new DataGridViewTextBoxColumn();
            this.Role = new DataGridViewTextBoxColumn();
            this.Status = new DataGridViewImageColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // =========================================
            // TITLE
            // =========================================
            this.lblTitle.Text = "USERS";
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(30, 10);
            this.lblTitle.AutoSize = true;

            // DESCRIPTION
            this.lblDescription.Text = "Manage your users, assign roles, and maintain system access efficiently.";
            this.lblDescription.Font = new Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = Color.LightGray;
            this.lblDescription.Location = new Point(32, 50);
            this.lblDescription.AutoSize = true;

            // =========================================
            // DATAGRIDVIEW
            // =========================================
            this.dgvUsers.Location = new Point(34, 160);
            this.dgvUsers.Size = new Size(940, 480);
            this.dgvUsers.BackgroundColor = Color.FromArgb(45, 45, 60);
            this.dgvUsers.BorderStyle = BorderStyle.None;
            this.dgvUsers.GridColor = Color.FromArgb(70, 70, 90);
            this.dgvUsers.EnableHeadersVisualStyles = false;

            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 80);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.dgvUsers.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 70);
            this.dgvUsers.DefaultCellStyle.ForeColor = Color.White;
            this.dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 160);

            this.dgvUsers.RowTemplate.Height = 45;
            this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.MultiSelect = false;

            this.dgvUsers.Columns.AddRange(new DataGridViewColumn[]
            {
                this.UserID,
                this.UserUImage,
                this.Username,
                this.FullName,
                this.Email,
                this.Role,
                this.Status
            });

            // Columns
            this.UserID.HeaderText = "User ID"; this.UserID.Width = 120;
            this.UserUImage.HeaderText = "Image"; this.UserUImage.Width = 110;
            this.Username.HeaderText = "Username"; this.Username.Width = 150;
            this.FullName.HeaderText = "Full Name"; this.FullName.Width = 150;
            this.Email.HeaderText = "Email"; this.Email.Width = 180;
            this.Role.HeaderText = "Role"; this.Role.Width = 120;
            this.Status.HeaderText = "Status"; this.Status.Width = 100;

            // =========================================
            // BUTTON STYLE HELPER
            // =========================================
            void StyleButton(Button btn, Color color)
            {
                btn.BackColor = color;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Size = new Size(140, 48);
                btn.Cursor = Cursors.Hand;
            }

            // BUTTONS
            this.btnAddUser.Text = "Add User"; StyleButton(this.btnAddUser, Color.FromArgb(50, 150, 80));
            this.btnAddUser.Location = new Point(35, 95);

            this.btnEditUser.Text = "Edit User"; StyleButton(this.btnEditUser, Color.FromArgb(60, 120, 200));
            this.btnEditUser.Location = new Point(185, 95);

            this.btnDeleteUser.Text = "Delete"; StyleButton(this.btnDeleteUser, Color.FromArgb(200, 50, 50));
            this.btnDeleteUser.Location = new Point(335, 95);

            this.btnRefresh.Text = "Refresh"; StyleButton(this.btnRefresh, Color.FromArgb(80, 80, 100));
            this.btnRefresh.Location = new Point(485, 95);

            // SEARCH
            this.txtSearchUser.Font = new Font("Segoe UI", 12F);
            this.txtSearchUser.ForeColor = Color.Gray;
            this.txtSearchUser.Text = "Search User";
            this.txtSearchUser.Location = new Point(630, 100);
            this.txtSearchUser.Size = new Size(260, 34);

            this.btnSearchUser.Text = "🔍";
            this.btnSearchUser.Location = new Point(900, 100);
            this.btnSearchUser.Size = new Size(50, 34);
            this.btnSearchUser.BackColor = Color.FromArgb(60, 60, 80);
            this.btnSearchUser.ForeColor = Color.White;
            this.btnSearchUser.FlatStyle = FlatStyle.Flat;
            this.btnSearchUser.FlatAppearance.BorderSize = 0;

            // STATUS LABEL
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.ForeColor = Color.White;
            this.lblUserStatus.Location = new Point(34, 655);
            this.lblUserStatus.Visible = false;

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.lblUserStatus);

            this.BackColor = Color.FromArgb(30, 30, 47);
            this.Size = new Size(1012, 700);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
