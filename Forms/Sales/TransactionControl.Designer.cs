namespace DSAFinalRequirement.Forms.Transactions
{
    partial class TransactionControl
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
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransationIDFilter = new System.Windows.Forms.ComboBox();
            this.cmbUserIDFilter = new System.Windows.Forms.ComboBox();
            this.lblTransactionStatus = new System.Windows.Forms.Label();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.UserID,
            this.TotalAmmount,
            this.DateOfSale,
            this.Remarks,
            this.Action});
            this.dgvTransactions.Location = new System.Drawing.Point(35, 109);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(920, 510);
            this.dgvTransactions.TabIndex = 23;
            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.Location = new System.Drawing.Point(903, 16);
            this.btnSearchTransaction.Name = "btnSearchTransaction";
            this.btnSearchTransaction.Size = new System.Drawing.Size(52, 48);
            this.btnSearchTransaction.TabIndex = 34;
            this.btnSearchTransaction.Text = "Search Icon";
            this.btnSearchTransaction.UseVisualStyleBackColor = true;
            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTransaction.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchTransaction.Location = new System.Drawing.Point(567, 16);
            this.txtSearchTransaction.Name = "txtSearchTransaction";
            this.txtSearchTransaction.Size = new System.Drawing.Size(330, 45);
            this.txtSearchTransaction.TabIndex = 33;
            this.txtSearchTransaction.Text = "Search Supplier";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(434, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(290, 13);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteSupplier.TabIndex = 31;
            this.btnDeleteSupplier.Text = "btnDeleteSupplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Filter by TransactionID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Filter by UserID:";
            // 
            // cmbTransationIDFilter
            // 
            this.cmbTransationIDFilter.FormattingEnabled = true;
            this.cmbTransationIDFilter.Location = new System.Drawing.Point(776, 79);
            this.cmbTransationIDFilter.Name = "cmbTransationIDFilter";
            this.cmbTransationIDFilter.Size = new System.Drawing.Size(179, 24);
            this.cmbTransationIDFilter.TabIndex = 36;
            // 
            // cmbUserIDFilter
            // 
            this.cmbUserIDFilter.FormattingEnabled = true;
            this.cmbUserIDFilter.Location = new System.Drawing.Point(460, 78);
            this.cmbUserIDFilter.Name = "cmbUserIDFilter";
            this.cmbUserIDFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbUserIDFilter.TabIndex = 35;
            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.Location = new System.Drawing.Point(38, 650);
            this.lblTransactionStatus.Name = "lblTransactionStatus";
            this.lblTransactionStatus.Size = new System.Drawing.Size(113, 16);
            this.lblTransactionStatus.TabIndex = 40;
            this.lblTransactionStatus.Text = "lblCategoryStatus";
            this.lblTransactionStatus.Visible = false;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.MinimumWidth = 6;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Width = 125;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 125;
            // 
            // TotalAmmount
            // 
            this.TotalAmmount.HeaderText = "TotalAmmount";
            this.TotalAmmount.MinimumWidth = 6;
            this.TotalAmmount.Name = "TotalAmmount";
            this.TotalAmmount.ReadOnly = true;
            this.TotalAmmount.Width = 125;
            // 
            // DateOfSale
            // 
            this.DateOfSale.HeaderText = "DateOfSale";
            this.DateOfSale.MinimumWidth = 6;
            this.DateOfSale.Name = "DateOfSale";
            this.DateOfSale.ReadOnly = true;
            this.DateOfSale.Width = 125;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 125;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Text = "View";
            this.Action.Width = 125;
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTransactionStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTransationIDFilter);
            this.Controls.Add(this.cmbUserIDFilter);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.txtSearchTransaction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransationIDFilter;
        private System.Windows.Forms.ComboBox cmbUserIDFilter;
        private System.Windows.Forms.Label lblTransactionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}
