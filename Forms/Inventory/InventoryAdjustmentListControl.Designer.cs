namespace DSAFinalRequirement.Forms.Inventory
{
    partial class InventoryAdjustmentListControl
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
            this.lblAdkustmentsStatus = new System.Windows.Forms.Label();
            this.btnSearchAdjustment = new System.Windows.Forms.Button();
            this.txtSearchAdjustment = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteAdjustMent = new System.Windows.Forms.Button();
            this.dgvInventoryAdjustments = new System.Windows.Forms.DataGridView();
            this.AdjustmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdjusted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdjustments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdkustmentsStatus
            // 
            this.lblAdkustmentsStatus.AutoSize = true;
            this.lblAdkustmentsStatus.Location = new System.Drawing.Point(30, 642);
            this.lblAdkustmentsStatus.Name = "lblAdkustmentsStatus";
            this.lblAdkustmentsStatus.Size = new System.Drawing.Size(113, 16);
            this.lblAdkustmentsStatus.TabIndex = 39;
            this.lblAdkustmentsStatus.Text = "lblCategoryStatus";
            this.lblAdkustmentsStatus.Visible = false;
            // 
            // btnSearchAdjustment
            // 
            this.btnSearchAdjustment.Location = new System.Drawing.Point(901, 29);
            this.btnSearchAdjustment.Name = "btnSearchAdjustment";
            this.btnSearchAdjustment.Size = new System.Drawing.Size(52, 48);
            this.btnSearchAdjustment.TabIndex = 38;
            this.btnSearchAdjustment.Text = "Search Icon";
            this.btnSearchAdjustment.UseVisualStyleBackColor = true;
            // 
            // txtSearchAdjustment
            // 
            this.txtSearchAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAdjustment.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchAdjustment.Location = new System.Drawing.Point(565, 29);
            this.txtSearchAdjustment.Name = "txtSearchAdjustment";
            this.txtSearchAdjustment.Size = new System.Drawing.Size(330, 45);
            this.txtSearchAdjustment.TabIndex = 37;
            this.txtSearchAdjustment.Text = "Search Supplier";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(432, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdjustMent
            // 
            this.btnDeleteAdjustMent.Location = new System.Drawing.Point(299, 25);
            this.btnDeleteAdjustMent.Name = "btnDeleteAdjustMent";
            this.btnDeleteAdjustMent.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteAdjustMent.TabIndex = 35;
            this.btnDeleteAdjustMent.Text = "btnDeleteSupplier";
            this.btnDeleteAdjustMent.UseVisualStyleBackColor = true;
            // 
            // dgvInventoryAdjustments
            // 
            this.dgvInventoryAdjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryAdjustments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdjustmentID,
            this.ProductID,
            this.QuantityChanged,
            this.UserID,
            this.DateAdjusted});
            this.dgvInventoryAdjustments.Location = new System.Drawing.Point(33, 129);
            this.dgvInventoryAdjustments.Name = "dgvInventoryAdjustments";
            this.dgvInventoryAdjustments.RowHeadersWidth = 51;
            this.dgvInventoryAdjustments.RowTemplate.Height = 24;
            this.dgvInventoryAdjustments.Size = new System.Drawing.Size(920, 510);
            this.dgvInventoryAdjustments.TabIndex = 32;
            // 
            // AdjustmentID
            // 
            this.AdjustmentID.HeaderText = "AdjustmentID";
            this.AdjustmentID.MinimumWidth = 6;
            this.AdjustmentID.Name = "AdjustmentID";
            this.AdjustmentID.ReadOnly = true;
            this.AdjustmentID.Width = 125;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // QuantityChanged
            // 
            this.QuantityChanged.HeaderText = "QuantityChanged";
            this.QuantityChanged.MinimumWidth = 6;
            this.QuantityChanged.Name = "QuantityChanged";
            this.QuantityChanged.ReadOnly = true;
            this.QuantityChanged.Width = 125;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 125;
            // 
            // DateAdjusted
            // 
            this.DateAdjusted.HeaderText = "DateAdjusted";
            this.DateAdjusted.MinimumWidth = 6;
            this.DateAdjusted.Name = "DateAdjusted";
            this.DateAdjusted.ReadOnly = true;
            this.DateAdjusted.Width = 125;
            // 
            // InventoryAdjustmentListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAdkustmentsStatus);
            this.Controls.Add(this.btnSearchAdjustment);
            this.Controls.Add(this.txtSearchAdjustment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteAdjustMent);
            this.Controls.Add(this.dgvInventoryAdjustments);
            this.Name = "InventoryAdjustmentListControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdjustments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdkustmentsStatus;
        private System.Windows.Forms.Button btnSearchAdjustment;
        private System.Windows.Forms.TextBox txtSearchAdjustment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteAdjustMent;
        private System.Windows.Forms.DataGridView dgvInventoryAdjustments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdjusted;
    }
}
