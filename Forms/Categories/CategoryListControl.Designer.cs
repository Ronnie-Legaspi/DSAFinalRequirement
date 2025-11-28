using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    partial class CategoryListControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblHeaderTitle;
        private Label lblHeaderDesc;
        private Panel panelTop;
        private Button btnAddCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnRefresh;
        private TextBox txtSearchCategory;
        private Button btnSearchCategory;

        private DataGridView dgvCategories;
        private Label lblCategoryStatus;

        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewImageColumn CategoryImage;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DateCreated;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblHeaderTitle = new Label();
            this.lblHeaderDesc = new Label();
            this.panelTop = new Panel();

            this.btnAddCategory = new Button();
            this.btnEditCategory = new Button();
            this.btnDeleteCategory = new Button();
            this.btnRefresh = new Button();
            this.txtSearchCategory = new TextBox();
            this.btnSearchCategory = new Button();

            this.dgvCategories = new DataGridView();
            this.CategoryID = new DataGridViewTextBoxColumn();
            this.CategoryName = new DataGridViewTextBoxColumn();
            this.CategoryImage = new DataGridViewImageColumn();
            this.Description = new DataGridViewTextBoxColumn();
            this.DateCreated = new DataGridViewTextBoxColumn();

            this.lblCategoryStatus = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // HEADER TITLE
            // =========================================================
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = Color.White;
            this.lblHeaderTitle.Location = new Point(25, 15);
            this.lblHeaderTitle.Text = "Categories";

            // =========================================================
            // HEADER DESCRIPTION
            // =========================================================
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new Font("Segoe UI", 11F);
            this.lblHeaderDesc.ForeColor = Color.Silver;
            this.lblHeaderDesc.Location = new Point(28, 60);
            this.lblHeaderDesc.Text = "Manage all product categories used in the system.";

            // =========================================================
            // TOP PANEL
            // =========================================================
            this.panelTop.BackColor = Color.FromArgb(40, 40, 60);
            this.panelTop.Location = new Point(30, 95);
            this.panelTop.Size = new Size(920, 60);

            this.panelTop.Controls.Add(this.btnAddCategory);
            this.panelTop.Controls.Add(this.btnEditCategory);
            this.panelTop.Controls.Add(this.btnDeleteCategory);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.txtSearchCategory);
            this.panelTop.Controls.Add(this.btnSearchCategory);

            // =========================================================
            // BUTTON: ADD
            // =========================================================
            this.btnAddCategory.Text = "+ Add";
            this.btnAddCategory.BackColor = Color.FromArgb(0, 174, 114);
            this.btnAddCategory.ForeColor = Color.White;
            this.btnAddCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnAddCategory.FlatStyle = FlatStyle.Flat;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.Location = new Point(10, 11);
            this.btnAddCategory.Size = new Size(120, 38);

            // =========================================================
            // BUTTON: EDIT
            // =========================================================
            this.btnEditCategory.Text = "✎ Edit";
            this.btnEditCategory.BackColor = Color.FromArgb(55, 115, 228);
            this.btnEditCategory.ForeColor = Color.White;
            this.btnEditCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnEditCategory.FlatStyle = FlatStyle.Flat;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.Location = new Point(140, 11);
            this.btnEditCategory.Size = new Size(120, 38);

            // =========================================================
            // BUTTON: DELETE
            // =========================================================
            this.btnDeleteCategory.Text = "🗑 Delete";
            this.btnDeleteCategory.BackColor = Color.FromArgb(220, 53, 69);
            this.btnDeleteCategory.ForeColor = Color.White;
            this.btnDeleteCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnDeleteCategory.FlatStyle = FlatStyle.Flat;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.Location = new Point(270, 11);
            this.btnDeleteCategory.Size = new Size(120, 38);

            // =========================================================
            // BUTTON: REFRESH
            // =========================================================
            this.btnRefresh.Text = "↻ Refresh";
            this.btnRefresh.BackColor = Color.FromArgb(80, 80, 100);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Location = new Point(400, 11);
            this.btnRefresh.Size = new Size(120, 38);

            // =========================================================
            // SEARCH BOX
            // =========================================================
            this.txtSearchCategory.Font = new Font("Segoe UI", 14F);
            this.txtSearchCategory.ForeColor = Color.Gray;
            this.txtSearchCategory.Text = "Search Category";
            this.txtSearchCategory.Location = new Point(530, 12);
            this.txtSearchCategory.Size = new Size(300, 35);

            // =========================================================
            // SEARCH BUTTON
            // =========================================================
            this.btnSearchCategory.Text = "🔍";
            this.btnSearchCategory.Font = new Font("Segoe UI", 14F);
            this.btnSearchCategory.BackColor = Color.FromArgb(55, 55, 80);
            this.btnSearchCategory.ForeColor = Color.White;
            this.btnSearchCategory.FlatStyle = FlatStyle.Flat;
            this.btnSearchCategory.FlatAppearance.BorderSize = 0;
            this.btnSearchCategory.Size = new Size(45, 35);
            this.btnSearchCategory.Location = new Point(835, 12);

            // =========================================================
            // DATAGRIDVIEW
            // =========================================================
            this.dgvCategories.Location = new Point(30, 170);
            this.dgvCategories.Size = new Size(920, 460);
            this.dgvCategories.BackgroundColor = Color.FromArgb(37, 37, 55);
            this.dgvCategories.BorderStyle = BorderStyle.None;

            headerStyle.BackColor = Color.FromArgb(55, 55, 80);
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvCategories.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvCategories.EnableHeadersVisualStyles = false;

            cellStyle.BackColor = Color.FromArgb(50, 50, 72);
            cellStyle.ForeColor = Color.White;
            cellStyle.SelectionBackColor = Color.FromArgb(70, 70, 100);
            this.dgvCategories.DefaultCellStyle = cellStyle;

            this.dgvCategories.RowTemplate.Height = 60;
            this.dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dgvCategories.Columns.AddRange(new DataGridViewColumn[]
            {
                this.CategoryID,
                this.CategoryName,
                this.CategoryImage,
                this.Description,
                this.DateCreated
            });

            // Grid Columns
            this.CategoryID.HeaderText = "ID";
            this.CategoryID.Width = 80;

            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Width = 180;

            this.CategoryImage.HeaderText = "Image";
            this.CategoryImage.Width = 120;
            this.CategoryImage.ImageLayout = DataGridViewImageCellLayout.Zoom;

            this.Description.HeaderText = "Description";
            this.Description.Width = 250;

            this.DateCreated.HeaderText = "Date Created";
            this.DateCreated.Width = 150;

            // =========================================================
            // STATUS LABEL
            // =========================================================
            this.lblCategoryStatus.AutoSize = true;
            this.lblCategoryStatus.ForeColor = Color.White;
            this.lblCategoryStatus.Location = new Point(30, 650);
            this.lblCategoryStatus.Visible = false;

            // =========================================================
            // MAIN CONTROL
            // =========================================================
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderDesc);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.lblCategoryStatus);

            this.Name = "CategoryListControl";
            this.Size = new Size(1012, 700);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
