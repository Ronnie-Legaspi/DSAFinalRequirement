using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    partial class AddCategoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel topBar;
        private Label lblTitle;
        private PictureBox picCategoryImage;
        private Label lblImage;
        private TextBox txtCategoryName;
        private Label lblName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnBrowseImage;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topBar = new Panel();
            this.lblTitle = new Label();
            this.picCategoryImage = new PictureBox();
            this.lblImage = new Label();
            this.txtCategoryName = new TextBox();
            this.lblName = new Label();
            this.txtDescription = new TextBox();
            this.lblDescription = new Label();
            this.btnBrowseImage = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();

            // ========================================
            // FORM SETTINGS
            // ========================================
            this.ClientSize = new Size(650, 360);
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;

            // ========================================
            // TOP BAR
            // ========================================
            this.topBar.Dock = DockStyle.Top;
            this.topBar.Height = 42;
            this.topBar.BackColor = Color.FromArgb(40, 40, 58);

            this.lblTitle.Text = "Add Category";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(20, 10);

            this.topBar.Controls.Add(this.lblTitle);

            // ========================================
            // CATEGORY IMAGE
            // ========================================
            this.lblImage.Text = "Category Image:";
            this.lblImage.ForeColor = Color.White;
            this.lblImage.Font = new Font("Segoe UI", 10F);
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new Point(40, 65);

            this.picCategoryImage.Location = new Point(40, 90);
            this.picCategoryImage.Size = new Size(160, 160);
            this.picCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.picCategoryImage.BackColor = Color.FromArgb(45, 45, 60);
            this.picCategoryImage.BorderStyle = BorderStyle.None;

            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.BackColor = Color.FromArgb(60, 60, 75);
            this.btnBrowseImage.FlatStyle = FlatStyle.Flat;
            this.btnBrowseImage.FlatAppearance.BorderSize = 0;
            this.btnBrowseImage.ForeColor = Color.White;
            this.btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnBrowseImage.Size = new Size(160, 40);
            this.btnBrowseImage.Location = new Point(40, 260);

            // ========================================
            // CATEGORY NAME
            // ========================================
            this.lblName.Text = "Category Name:";
            this.lblName.ForeColor = Color.White;
            this.lblName.Font = new Font("Segoe UI", 10F);
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(230, 90);

            this.txtCategoryName.Location = new Point(233, 115);
            this.txtCategoryName.Size = new Size(360, 26);
            this.txtCategoryName.Font = new Font("Segoe UI", 10.5F);
            this.txtCategoryName.BackColor = Color.FromArgb(40, 40, 55);
            this.txtCategoryName.ForeColor = Color.White;
            this.txtCategoryName.BorderStyle = BorderStyle.FixedSingle;

            // ========================================
            // DESCRIPTION
            // ========================================
            this.lblDescription.Text = "Description:";
            this.lblDescription.ForeColor = Color.White;
            this.lblDescription.Font = new Font("Segoe UI", 10F);
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(230, 150);

            this.txtDescription.Location = new Point(233, 175);
            this.txtDescription.Size = new Size(360, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Font = new Font("Segoe UI", 10.5F);
            this.txtDescription.BackColor = Color.FromArgb(40, 40, 55);
            this.txtDescription.ForeColor = Color.White;
            this.txtDescription.BorderStyle = BorderStyle.FixedSingle;

            // ========================================
            // SAVE BUTTON
            // ========================================
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = Color.FromArgb(50, 150, 80);
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = Color.White;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Size = new Size(150, 45);
            this.btnSave.Location = new Point(333, 300);

            // ========================================
            // CANCEL BUTTON
            // ========================================
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = Color.FromArgb(60, 60, 75);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Size = new Size(150, 45);
            this.btnCancel.Location = new Point(443, 300);

            // ========================================
            // ADD CONTROLS
            // ========================================
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.picCategoryImage);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
