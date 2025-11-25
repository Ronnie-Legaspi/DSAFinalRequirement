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
            this.dgvAdjustments = new System.Windows.Forms.DataGridView();
            this.AdjustmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdjusted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransationIDFilter = new System.Windows.Forms.ComboBox();
            this.cmbUserIDFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAdjustmentIDFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustments)).BeginInit();
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
            // dgvAdjustments
            // 
            this.dgvAdjustments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjustments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdjustmentID,
            this.ProductID,
            this.QuantityChanged,
            this.UserID,
            this.DateAdjusted});
            this.dgvAdjustments.Location = new System.Drawing.Point(33, 129);
            this.dgvAdjustments.Name = "dgvAdjustments";
            this.dgvAdjustments.RowHeadersWidth = 51;
            this.dgvAdjustments.RowTemplate.Height = 24;
            this.dgvAdjustments.Size = new System.Drawing.Size(920, 510);
            this.dgvAdjustments.TabIndex = 32;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filter by ProductID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filter by UserID:";
            // 
            // cmbTransationIDFilter
            // 
            this.cmbTransationIDFilter.FormattingEnabled = true;
            this.cmbTransationIDFilter.Location = new System.Drawing.Point(772, 91);
            this.cmbTransationIDFilter.Name = "cmbTransationIDFilter";
            this.cmbTransationIDFilter.Size = new System.Drawing.Size(179, 24);
            this.cmbTransationIDFilter.TabIndex = 41;
            // 
            // cmbUserIDFilter
            // 
            this.cmbUserIDFilter.FormattingEnabled = true;
            this.cmbUserIDFilter.Location = new System.Drawing.Point(456, 93);
            this.cmbUserIDFilter.Name = "cmbUserIDFilter";
            this.cmbUserIDFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbUserIDFilter.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Filter by AdjustmentID:";
            // 
            // cmbAdjustmentIDFilter
            // 
            this.cmbAdjustmentIDFilter.FormattingEnabled = true;
            this.cmbAdjustmentIDFilter.Location = new System.Drawing.Point(177, 93);
            this.cmbAdjustmentIDFilter.Name = "cmbAdjustmentIDFilter";
            this.cmbAdjustmentIDFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbAdjustmentIDFilter.TabIndex = 44;
            // 
            // InventoryAdjustmentListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAdjustmentIDFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTransationIDFilter);
            this.Controls.Add(this.cmbUserIDFilter);
            this.Controls.Add(this.lblAdkustmentsStatus);
            this.Controls.Add(this.btnSearchAdjustment);
            this.Controls.Add(this.txtSearchAdjustment);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteAdjustMent);
            this.Controls.Add(this.dgvAdjustments);
            this.Name = "InventoryAdjustmentListControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdkustmentsStatus;
        private System.Windows.Forms.Button btnSearchAdjustment;
        private System.Windows.Forms.TextBox txtSearchAdjustment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteAdjustMent;
        private System.Windows.Forms.DataGridView dgvAdjustments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdjusted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransationIDFilter;
        private System.Windows.Forms.ComboBox cmbUserIDFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAdjustmentIDFilter;
    }
}
