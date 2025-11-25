namespace DSAFinalRequirement.Forms.Categories
{
    partial class CategoryListControl
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
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCategoryStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName,
            this.CategoryImage,
            this.Description,
            this.DateCreated});
            this.dataGridView1.Location = new System.Drawing.Point(34, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 510);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(903, 47);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(52, 48);
            this.btnSearchCategory.TabIndex = 18;
            this.btnSearchCategory.Text = "Search Icon";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCategory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchCategory.Location = new System.Drawing.Point(567, 47);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(330, 45);
            this.txtSearchCategory.TabIndex = 17;
            this.txtSearchCategory.Text = "Search Product";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(434, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(301, 43);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "btnDeleteCategory";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(168, 43);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(127, 48);
            this.btnEditCategory.TabIndex = 14;
            this.btnEditCategory.Text = "btnEditCategory";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(35, 43);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(127, 48);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "btnAddCategory";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filter by Category:";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(809, 109);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbCategoryFilter.TabIndex = 19;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Width = 125;
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 125;
            // 
            // CategoryImage
            // 
            this.CategoryImage.HeaderText = "CategoryImage";
            this.CategoryImage.MinimumWidth = 6;
            this.CategoryImage.Name = "CategoryImage";
            this.CategoryImage.ReadOnly = true;
            this.CategoryImage.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 125;
            // 
            // DateCreated
            // 
            this.DateCreated.HeaderText = "DateCreated";
            this.DateCreated.MinimumWidth = 6;
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.Width = 125;
            // 
            // lblCategoryStatus
            // 
            this.lblCategoryStatus.AutoSize = true;
            this.lblCategoryStatus.Location = new System.Drawing.Point(32, 652);
            this.lblCategoryStatus.Name = "lblCategoryStatus";
            this.lblCategoryStatus.Size = new System.Drawing.Size(113, 16);
            this.lblCategoryStatus.TabIndex = 21;
            this.lblCategoryStatus.Text = "lblCategoryStatus";
            this.lblCategoryStatus.Visible = false;
            // 
            // CategoryListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCategoryStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoryFilter);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.txtSearchCategory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryListControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewImageColumn CategoryImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.Label lblCategoryStatus;
    }
}
