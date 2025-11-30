namespace DSAFinalRequirement.Forms.Inventory
{
    partial class InventoryAdjustmentListControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderDesc = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtSearchAdjustment = new System.Windows.Forms.TextBox();
            this.btnSearchAdjustment = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteAdjustMent = new System.Windows.Forms.Button();
            this.dgvInventoryAdjustments = new System.Windows.Forms.DataGridView();
            this.AdjustmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdjusted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAdkustmentsStatus = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdjustments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(419, 50);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Inventory Adjustments";
            // 
            // lblHeaderDesc
            // 
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.Silver;
            this.lblHeaderDesc.Location = new System.Drawing.Point(29, 60);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.Size = new System.Drawing.Size(569, 25);
            this.lblHeaderDesc.TabIndex = 1;
            this.lblHeaderDesc.Text = "View all stock adjustment activity performed inside your inventory.";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelTop.Controls.Add(this.txtSearchAdjustment);
            this.panelTop.Controls.Add(this.btnSearchAdjustment);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnDeleteAdjustMent);
            this.panelTop.Location = new System.Drawing.Point(33, 95);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(920, 60);
            this.panelTop.TabIndex = 2;
            // 
            // txtSearchAdjustment
            // 
            this.txtSearchAdjustment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchAdjustment.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchAdjustment.Location = new System.Drawing.Point(531, 11);
            this.txtSearchAdjustment.Name = "txtSearchAdjustment";
            this.txtSearchAdjustment.Size = new System.Drawing.Size(330, 39);
            this.txtSearchAdjustment.TabIndex = 0;
            this.txtSearchAdjustment.Text = "Search Adjustment";
            // 
            // btnSearchAdjustment
            // 
            this.btnSearchAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(115)))), ((int)(((byte)(228)))));
            this.btnSearchAdjustment.FlatAppearance.BorderSize = 0;
            this.btnSearchAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAdjustment.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSearchAdjustment.ForeColor = System.Drawing.Color.White;
            this.btnSearchAdjustment.Location = new System.Drawing.Point(866, 10);
            this.btnSearchAdjustment.Name = "btnSearchAdjustment";
            this.btnSearchAdjustment.Size = new System.Drawing.Size(45, 38);
            this.btnSearchAdjustment.TabIndex = 1;
            this.btnSearchAdjustment.Text = "🔍";
            this.btnSearchAdjustment.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(114)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(405, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 38);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAdjustMent
            // 
            this.btnDeleteAdjustMent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteAdjustMent.FlatAppearance.BorderSize = 0;
            this.btnDeleteAdjustMent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdjustMent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAdjustMent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAdjustMent.Location = new System.Drawing.Point(259, 10);
            this.btnDeleteAdjustMent.Name = "btnDeleteAdjustMent";
            this.btnDeleteAdjustMent.Size = new System.Drawing.Size(140, 38);
            this.btnDeleteAdjustMent.TabIndex = 3;
            this.btnDeleteAdjustMent.Text = "Delete";
            this.btnDeleteAdjustMent.UseVisualStyleBackColor = false;
            // 
            // dgvInventoryAdjustments
            // 
            this.dgvInventoryAdjustments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(55)))));
            this.dgvInventoryAdjustments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryAdjustments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryAdjustments.ColumnHeadersHeight = 29;
            this.dgvInventoryAdjustments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdjustmentID,
            this.ProductID,
            this.QuantityChanged,
            this.UserID,
            this.DateAdjusted});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryAdjustments.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInventoryAdjustments.EnableHeadersVisualStyles = false;
            this.dgvInventoryAdjustments.Location = new System.Drawing.Point(33, 170);
            this.dgvInventoryAdjustments.Name = "dgvInventoryAdjustments";
            this.dgvInventoryAdjustments.RowHeadersWidth = 51;
            this.dgvInventoryAdjustments.Size = new System.Drawing.Size(920, 470);
            this.dgvInventoryAdjustments.TabIndex = 3;
            // 
            // AdjustmentID
            // 
            this.AdjustmentID.HeaderText = "Adjustment ID";
            this.AdjustmentID.MinimumWidth = 6;
            this.AdjustmentID.Name = "AdjustmentID";
            this.AdjustmentID.Width = 120;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 120;
            // 
            // QuantityChanged
            // 
            this.QuantityChanged.HeaderText = "Qty Change";
            this.QuantityChanged.MinimumWidth = 6;
            this.QuantityChanged.Name = "QuantityChanged";
            this.QuantityChanged.Width = 120;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Width = 120;
            // 
            // DateAdjusted
            // 
            this.DateAdjusted.HeaderText = "Date Adjusted";
            this.DateAdjusted.MinimumWidth = 6;
            this.DateAdjusted.Name = "DateAdjusted";
            this.DateAdjusted.Width = 160;
            // 
            // lblAdkustmentsStatus
            // 
            this.lblAdkustmentsStatus.AutoSize = true;
            this.lblAdkustmentsStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdkustmentsStatus.ForeColor = System.Drawing.Color.White;
            this.lblAdkustmentsStatus.Location = new System.Drawing.Point(30, 645);
            this.lblAdkustmentsStatus.Name = "lblAdkustmentsStatus";
            this.lblAdkustmentsStatus.Size = new System.Drawing.Size(162, 23);
            this.lblAdkustmentsStatus.TabIndex = 4;
            this.lblAdkustmentsStatus.Text = "lblAdjustmentStatus";
            this.lblAdkustmentsStatus.Visible = false;
            // 
            // InventoryAdjustmentListControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderDesc);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvInventoryAdjustments);
            this.Controls.Add(this.lblAdkustmentsStatus);
            this.Name = "InventoryAdjustmentListControl";
            this.Size = new System.Drawing.Size(1012, 632);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryAdjustments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderDesc;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox txtSearchAdjustment;
        private System.Windows.Forms.Button btnSearchAdjustment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteAdjustMent;
        private System.Windows.Forms.DataGridView dgvInventoryAdjustments;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdjusted;
        private System.Windows.Forms.Label lblAdkustmentsStatus;
    }
}
