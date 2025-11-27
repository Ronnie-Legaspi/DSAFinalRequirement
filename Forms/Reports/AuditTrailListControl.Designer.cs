namespace DSAFinalRequirement.Forms.Reports
{
    partial class AuditTrailListControl
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
            this.lblTransactionStatus = new System.Windows.Forms.Label();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLogged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.Location = new System.Drawing.Point(30, 644);
            this.lblTransactionStatus.Name = "lblTransactionStatus";
            this.lblTransactionStatus.Size = new System.Drawing.Size(113, 16);
            this.lblTransactionStatus.TabIndex = 50;
            this.lblTransactionStatus.Text = "lblCategoryStatus";
            this.lblTransactionStatus.Visible = false;
            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.Location = new System.Drawing.Point(901, 27);
            this.btnSearchTransaction.Name = "btnSearchTransaction";
            this.btnSearchTransaction.Size = new System.Drawing.Size(52, 48);
            this.btnSearchTransaction.TabIndex = 45;
            this.btnSearchTransaction.Text = "Search Icon";
            this.btnSearchTransaction.UseVisualStyleBackColor = true;
            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTransaction.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchTransaction.Location = new System.Drawing.Point(565, 27);
            this.txtSearchTransaction.Name = "txtSearchTransaction";
            this.txtSearchTransaction.Size = new System.Drawing.Size(330, 45);
            this.txtSearchTransaction.TabIndex = 44;
            this.txtSearchTransaction.Text = "Search Supplier";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(432, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(288, 24);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteTransaction.TabIndex = 42;
            this.btnDeleteTransaction.Text = "btnDeleteSupplier";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.UserID,
            this.ActionType,
            this.Description,
            this.DateLogged});
            this.dgvTransactions.Location = new System.Drawing.Point(33, 131);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(920, 510);
            this.dgvTransactions.TabIndex = 41;
            // 
            // LogID
            // 
            this.LogID.HeaderText = "LogID";
            this.LogID.MinimumWidth = 6;
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            this.LogID.Width = 125;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 125;
            // 
            // ActionType
            // 
            this.ActionType.HeaderText = "ActionType";
            this.ActionType.MinimumWidth = 6;
            this.ActionType.Name = "ActionType";
            this.ActionType.ReadOnly = true;
            this.ActionType.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // DateLogged
            // 
            this.DateLogged.HeaderText = "DateLogged";
            this.DateLogged.MinimumWidth = 6;
            this.DateLogged.Name = "DateLogged";
            this.DateLogged.ReadOnly = true;
            this.DateLogged.Width = 125;
            // 
            // AuditTrailListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTransactionStatus);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.txtSearchTransaction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "AuditTrailListControl";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionStatus;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLogged;
    }
}
