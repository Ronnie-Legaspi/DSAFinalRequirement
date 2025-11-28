using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Suppliers
{
    partial class SupplierListControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblSupplierStatus;
        private Button btnSearchSupplier;
        private TextBox txtSearchSupplier;
        private Button btnRefresh;
        private Button btnDeleteSupplier;
        private Button btnEditSupplier;
        private Button btnAddSupplier;
        private DataGridView dgvSuppliers;

        private Label lblTitle;
        private Label lblDescription;

        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewImageColumn SupplierImage;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn DateAdded;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSupplierStatus = new Label();
            this.btnSearchSupplier = new Button();
            this.txtSearchSupplier = new TextBox();
            this.btnRefresh = new Button();
            this.btnDeleteSupplier = new Button();
            this.btnEditSupplier = new Button();
            this.btnAddSupplier = new Button();
            this.dgvSuppliers = new DataGridView();

            this.lblTitle = new Label();
            this.lblDescription = new Label();

            this.SupplierID = new DataGridViewTextBoxColumn();
            this.SupplierImage = new DataGridViewImageColumn();
            this.SupplierName = new DataGridViewTextBoxColumn();
            this.ContactNumber = new DataGridViewTextBoxColumn();
            this.Email = new DataGridViewTextBoxColumn();
            this.Address = new DataGridViewTextBoxColumn();
            this.DateAdded = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();

            // MAIN CONTAINER
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.Size = new Size(1012, 700);
            this.Margin = new Padding(0);

            // ==========================================================
            // TITLE LABEL
            // ==========================================================
            this.lblTitle.Text = "SUPPLIERS";
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(30, 10);
            this.lblTitle.AutoSize = true;

            // DESCRIPTION LABEL
            this.lblDescription.Text = "Manage your suppliers, update information, and maintain your supply chain efficiently.";
            this.lblDescription.Font = new Font("Segoe UI", 11F);
            this.lblDescription.ForeColor = Color.LightGray;
            this.lblDescription.Location = new Point(32, 50);
            this.lblDescription.AutoSize = true;

            // ==========================================================
            // DATAGRIDVIEW
            // ==========================================================
            this.dgvSuppliers.Location = new Point(34, 170);
            this.dgvSuppliers.Size = new Size(940, 460);
            this.dgvSuppliers.BackgroundColor = Color.FromArgb(45, 45, 60);
            this.dgvSuppliers.BorderStyle = BorderStyle.None;
            this.dgvSuppliers.GridColor = Color.FromArgb(70, 70, 90);

            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 80);
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            this.dgvSuppliers.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 70);
            this.dgvSuppliers.DefaultCellStyle.ForeColor = Color.White;
            this.dgvSuppliers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 160);

            this.dgvSuppliers.RowTemplate.Height = 45;
            this.dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.MultiSelect = false;

            this.dgvSuppliers.Columns.AddRange(new DataGridViewColumn[]
            {
                this.SupplierID,
                this.SupplierImage,
                this.SupplierName,
                this.ContactNumber,
                this.Email,
                this.Address,
                this.DateAdded
            });

            // Columns
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.Width = 120;

            this.SupplierImage.HeaderText = "Image";
            this.SupplierImage.Width = 110;

            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Width = 180;

            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Width = 140;

            this.Email.HeaderText = "Email";
            this.Email.Width = 160;

            this.Address.HeaderText = "Address";
            this.Address.Width = 180;

            this.DateAdded.HeaderText = "Date Added";
            this.DateAdded.Width = 150;

            // ==========================================================
            // BUTTON STYLE HELPER
            // ==========================================================
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
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.Location = new Point(35, 95);
            StyleButton(this.btnAddSupplier, Color.FromArgb(50, 150, 80));

            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.Location = new Point(185, 95);
            StyleButton(this.btnEditSupplier, Color.FromArgb(60, 120, 200));

            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.Location = new Point(335, 95);
            StyleButton(this.btnDeleteSupplier, Color.FromArgb(200, 50, 50));

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new Point(485, 95);
            StyleButton(this.btnRefresh, Color.FromArgb(80, 80, 100));

            // SEARCH BAR
            this.txtSearchSupplier.Font = new Font("Segoe UI", 12F);
            this.txtSearchSupplier.ForeColor = Color.Gray;
            this.txtSearchSupplier.Text = "Search Supplier";
            this.txtSearchSupplier.Location = new Point(630, 100);
            this.txtSearchSupplier.Size = new Size(260, 34);

            this.btnSearchSupplier.Text = "🔍";
            this.btnSearchSupplier.Location = new Point(900, 100);
            this.btnSearchSupplier.Size = new Size(50, 34);
            this.btnSearchSupplier.BackColor = Color.FromArgb(60, 60, 80);
            this.btnSearchSupplier.ForeColor = Color.White;
            this.btnSearchSupplier.FlatStyle = FlatStyle.Flat;
            this.btnSearchSupplier.FlatAppearance.BorderSize = 0;

            // STATUS LABEL
            this.lblSupplierStatus.AutoSize = true;
            this.lblSupplierStatus.ForeColor = Color.White;
            this.lblSupplierStatus.Location = new Point(34, 640);
            this.lblSupplierStatus.Visible = false;

            // ADD CONTROLS
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.lblSupplierStatus);

            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
