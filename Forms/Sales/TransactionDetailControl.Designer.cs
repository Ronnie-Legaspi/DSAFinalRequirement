namespace DSAFinalRequirement.Forms.Sales
{
    partial class TransactionDetailControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRewards = new System.Windows.Forms.Label();
            this.lblDateOfSale = new System.Windows.Forms.Label();
            this.lblTotalAmmount = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Details";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductImage,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.SubTotal});
            this.dgvTransactions.Location = new System.Drawing.Point(31, 314);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(920, 282);
            this.dgvTransactions.TabIndex = 24;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "ProductImage";
            this.ProductImage.MinimumWidth = 6;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRewards);
            this.panel1.Controls.Add(this.lblDateOfSale);
            this.panel1.Controls.Add(this.lblTotalAmmount);
            this.panel1.Controls.Add(this.lblUserID);
            this.panel1.Controls.Add(this.lblTransactionID);
            this.panel1.Location = new System.Drawing.Point(31, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 232);
            this.panel1.TabIndex = 25;
            // 
            // lblRewards
            // 
            this.lblRewards.AutoSize = true;
            this.lblRewards.Location = new System.Drawing.Point(29, 182);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(61, 16);
            this.lblRewards.TabIndex = 4;
            this.lblRewards.Text = "Rewards";
            // 
            // lblDateOfSale
            // 
            this.lblDateOfSale.AutoSize = true;
            this.lblDateOfSale.Location = new System.Drawing.Point(29, 139);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(86, 16);
            this.lblDateOfSale.TabIndex = 3;
            this.lblDateOfSale.Text = "Date Of Sale:";
            // 
            // lblTotalAmmount
            // 
            this.lblTotalAmmount.AutoSize = true;
            this.lblTotalAmmount.Location = new System.Drawing.Point(29, 102);
            this.lblTotalAmmount.Name = "lblTotalAmmount";
            this.lblTotalAmmount.Size = new System.Drawing.Size(100, 16);
            this.lblTotalAmmount.TabIndex = 2;
            this.lblTotalAmmount.Text = "Total Ammount:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(29, 67);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(55, 16);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID:";
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.Location = new System.Drawing.Point(29, 32);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(108, 16);
            this.lblTransactionID.TabIndex = 0;
            this.lblTransactionID.Text = "lblTransactionID:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 611);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 48);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // TransactionDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.label1);
            this.Name = "TransactionDetailControl";
            this.Size = new System.Drawing.Size(1012, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblTotalAmmount;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.Label lblRewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnClose;
    }
}
