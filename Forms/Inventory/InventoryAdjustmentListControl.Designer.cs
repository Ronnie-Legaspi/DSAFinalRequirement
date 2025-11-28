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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

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

            // -------------------------------
            //  HEADER TITLE
            // -------------------------------
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 15);
            this.lblHeaderTitle.Text = "Inventory Adjustments";

            // -------------------------------
            //  HEADER DESCRIPTION
            // -------------------------------
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderDesc.ForeColor = System.Drawing.Color.Silver;
            this.lblHeaderDesc.Location = new System.Drawing.Point(29, 60);
            this.lblHeaderDesc.Text = "View all stock adjustment activity performed inside your inventory.";

            // -------------------------------
            //  TOP PANEL (Buttons + Search)
            // -------------------------------
            this.panelTop.Controls.Add(this.txtSearchAdjustment);
            this.panelTop.Controls.Add(this.btnSearchAdjustment);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.btnDeleteAdjustMent);

            this.panelTop.Location = new System.Drawing.Point(33, 95);
            this.panelTop.Size = new System.Drawing.Size(920, 60);
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);

            // -------------------------------
            // Search Box
            // -------------------------------
            this.txtSearchAdjustment.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSearchAdjustment.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchAdjustment.Location = new System.Drawing.Point(400, 12);
            this.txtSearchAdjustment.Size = new System.Drawing.Size(330, 38);
            this.txtSearchAdjustment.Text = "Search Adjustment";

            // -------------------------------
            // Search Button
            // -------------------------------
            this.btnSearchAdjustment.Location = new System.Drawing.Point(735, 11);
            this.btnSearchAdjustment.Size = new System.Drawing.Size(45, 38);
            this.btnSearchAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAdjustment.FlatAppearance.BorderSize = 0;
            this.btnSearchAdjustment.Text = "🔍";
            this.btnSearchAdjustment.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSearchAdjustment.BackColor = System.Drawing.Color.FromArgb(55, 115, 228);
            this.btnSearchAdjustment.ForeColor = System.Drawing.Color.White;

            // -------------------------------
            // Refresh Button
            // -------------------------------
            this.btnRefresh.Location = new System.Drawing.Point(10, 11);
            this.btnRefresh.Size = new System.Drawing.Size(120, 38);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(0, 174, 114);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Text = "Refresh";

            // -------------------------------
            // Delete Button
            // -------------------------------
            this.btnDeleteAdjustMent.Location = new System.Drawing.Point(140, 11);
            this.btnDeleteAdjustMent.Size = new System.Drawing.Size(140, 38);
            this.btnDeleteAdjustMent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdjustMent.FlatAppearance.BorderSize = 0;
            this.btnDeleteAdjustMent.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteAdjustMent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAdjustMent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAdjustMent.Text = "Delete";

            // -------------------------------
            //  DATAGRIDVIEW
            // -------------------------------
            this.dgvInventoryAdjustments.Location = new System.Drawing.Point(33, 170);
            this.dgvInventoryAdjustments.Size = new System.Drawing.Size(920, 470);
            this.dgvInventoryAdjustments.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 55);
            this.dgvInventoryAdjustments.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.dgvInventoryAdjustments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryAdjustments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(55, 55, 80);
            this.dgvInventoryAdjustments.EnableHeadersVisualStyles = false;

            this.dgvInventoryAdjustments.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 72);
            this.dgvInventoryAdjustments.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryAdjustments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 70, 100);

            this.dgvInventoryAdjustments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.AdjustmentID,
                this.ProductID,
                this.QuantityChanged,
                this.UserID,
                this.DateAdjusted
            });

            // Columns
            this.AdjustmentID.HeaderText = "Adjustment ID";
            this.AdjustmentID.Width = 120;

            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Width = 120;

            this.QuantityChanged.HeaderText = "Qty Change";
            this.QuantityChanged.Width = 120;

            this.UserID.HeaderText = "User ID";
            this.UserID.Width = 120;

            this.DateAdjusted.HeaderText = "Date Adjusted";
            this.DateAdjusted.Width = 160;

            // -------------------------------
            // Status Label
            // -------------------------------
            this.lblAdkustmentsStatus.AutoSize = true;
            this.lblAdkustmentsStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdkustmentsStatus.ForeColor = System.Drawing.Color.White;
            this.lblAdkustmentsStatus.Location = new System.Drawing.Point(30, 645);
            this.lblAdkustmentsStatus.Visible = false;
            this.lblAdkustmentsStatus.Text = "lblAdjustmentStatus";

            // -------------------------------
            // Main Control
            // -------------------------------
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 47);
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
