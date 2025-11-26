namespace DSAFinalRequirement.Forms.Suppliers
{
    partial class SupplierListControl
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
            this.lblSupplierStatus = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplieImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplierStatus
            // 
            this.lblSupplierStatus.AutoSize = true;
            this.lblSupplierStatus.Location = new System.Drawing.Point(30, 638);
            this.lblSupplierStatus.Name = "lblSupplierStatus";
            this.lblSupplierStatus.Size = new System.Drawing.Size(113, 16);
            this.lblSupplierStatus.TabIndex = 31;
            this.lblSupplierStatus.Text = "lblCategoryStatus";
            this.lblSupplierStatus.Visible = false;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.Location = new System.Drawing.Point(901, 54);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(52, 48);
            this.btnSearchSupplier.TabIndex = 28;
            this.btnSearchSupplier.Text = "Search Icon";
            this.btnSearchSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplier.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchSupplier.Location = new System.Drawing.Point(565, 54);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(330, 45);
            this.txtSearchSupplier.TabIndex = 27;
            this.txtSearchSupplier.Text = "Search Supplier";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(432, 50);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(299, 50);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteSupplier.TabIndex = 25;
            this.btnDeleteSupplier.Text = "btnDeleteSupplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(166, 50);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(127, 48);
            this.btnEditSupplier.TabIndex = 24;
            this.btnEditSupplier.Text = "btnEditSupplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(33, 50);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 48);
            this.btnAddSupplier.TabIndex = 23;
            this.btnAddSupplier.Text = "btnAddSupplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.SupplieImage,
            this.SupplierName,
            this.ContactNumber,
            this.Email,
            this.Address,
            this.DateAdded});
            this.dgvSuppliers.Location = new System.Drawing.Point(32, 125);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersWidth = 51;
            this.dgvSuppliers.RowTemplate.Height = 24;
            this.dgvSuppliers.Size = new System.Drawing.Size(920, 510);
            this.dgvSuppliers.TabIndex = 22;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.MinimumWidth = 6;
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Width = 125;
            // 
            // SupplieImage
            // 
            this.SupplieImage.HeaderText = "SupplieImage";
            this.SupplieImage.MinimumWidth = 6;
            this.SupplieImage.Name = "SupplieImage";
            this.SupplieImage.ReadOnly = true;
            this.SupplieImage.Width = 125;
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 125;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // DateAdded
            // 
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.MinimumWidth = 6;
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 125;
            // 
            // SupplierListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblSupplierStatus);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "SupplierListControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupplierStatus;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewImageColumn SupplieImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
    }
}
