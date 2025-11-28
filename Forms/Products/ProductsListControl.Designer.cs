namespace DSAFinalRequirement.Forms.Products
{
    partial class ProductsListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Designer-only initialization. All controls are created here (static-only).
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderDesc = new System.Windows.Forms.Label();

            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();

            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterSupplier = new System.Windows.Forms.Label();
            this.cmbSupplierFilter = new System.Windows.Forms.ComboBox();

            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.lblStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(145, 41);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Products";

            // 
            // lblHeaderDesc
            // 
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.Silver;
            this.lblHeaderDesc.Location = new System.Drawing.Point(28, 52);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.Size = new System.Drawing.Size(338, 19);
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "Manage products in your inventory — view, add, edit, delete.";

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.panelTop.Controls.Add(this.btnAddProduct);
            this.panelTop.Controls.Add(this.btnEditProduct);
            this.panelTop.Controls.Add(this.btnDeleteProduct);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.pnlSearch);
            this.panelTop.Location = new System.Drawing.Point(33, 80);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(920, 58);
            this.panelTop.TabIndex = 2;

            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(0, 174, 114);
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(8, 10);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(110, 38);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;

            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(55, 115, 228);
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(126, 10);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(110, 38);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = false;

            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(244, 10);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(362, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.pnlSearch.Controls.Add(this.txtSearchProduct);
            this.pnlSearch.Controls.Add(this.btnSearchProduct);
            this.pnlSearch.Location = new System.Drawing.Point(490, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(418, 38);
            this.pnlSearch.TabIndex = 7;

            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProduct.Location = new System.Drawing.Point(8, 8);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(330, 22);
            this.txtSearchProduct.TabIndex = 8;
            this.txtSearchProduct.Text = "Search Product";

            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(55, 115, 228);
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(348, 0);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(70, 38);
            this.btnSearchProduct.TabIndex = 9;
            this.btnSearchProduct.Text = "🔍";
            this.btnSearchProduct.UseVisualStyleBackColor = false;

            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterCategory.ForeColor = System.Drawing.Color.Silver;
            this.lblFilterCategory.Location = new System.Drawing.Point(380, 150);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(96, 15);
            this.lblFilterCategory.TabIndex = 10;
            this.lblFilterCategory.Text = "Filter by Category:";

            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(482, 146);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(170, 23);
            this.cmbCategoryFilter.TabIndex = 11;

            // 
            // lblFilterSupplier
            // 
            this.lblFilterSupplier.AutoSize = true;
            this.lblFilterSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterSupplier.ForeColor = System.Drawing.Color.Silver;
            this.lblFilterSupplier.Location = new System.Drawing.Point(662, 150);
            this.lblFilterSupplier.Name = "lblFilterSupplier";
            this.lblFilterSupplier.Size = new System.Drawing.Size(86, 15);
            this.lblFilterSupplier.TabIndex = 12;
            this.lblFilterSupplier.Text = "Filter by Supplier:";

            // 
            // cmbSupplierFilter
            // 
            this.cmbSupplierFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplierFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSupplierFilter.FormattingEnabled = true;
            this.cmbSupplierFilter.Location = new System.Drawing.Point(754, 146);
            this.cmbSupplierFilter.Name = "cmbSupplierFilter";
            this.cmbSupplierFilter.Size = new System.Drawing.Size(199, 23);
            this.cmbSupplierFilter.TabIndex = 13;

            // 
            // dgvProducts
            // 
            this.dgvProducts.Location = new System.Drawing.Point(33, 180);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(920, 400);
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 55);
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.EnableHeadersVisualStyles = false;

            headerStyle.BackColor = System.Drawing.Color.FromArgb(55, 55, 80);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvProducts.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 72);
            cellStyle.ForeColor = System.Drawing.Color.White;
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 70, 100);
            cellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvProducts.DefaultCellStyle = cellStyle;

            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ProductID,
                this.ProductImage,
                this.ProductName,
                this.Category,
                this.Supplier,
                this.Price,
                this.Stock,
                this.Status
            });

            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 80;

            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "Image";
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Width = 90;
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;

            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 220;

            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 140;

            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 140;

            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 100;

            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 90;

            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 90;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(33, 590);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "lblStatus";
            this.lblStatus.Visible = false;

            // 
            // ProductsListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 47);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderDesc);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblFilterCategory);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.lblFilterSupplier);
            this.Controls.Add(this.cmbSupplierFilter);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblStatus);
            this.Name = "ProductsListControl";
            this.Size = new System.Drawing.Size(1012, 634);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderDesc;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Label lblFilterSupplier;
        private System.Windows.Forms.ComboBox cmbSupplierFilter;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblStatus;
    }
}
