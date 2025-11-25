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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLogIDFilter = new System.Windows.Forms.ComboBox();
            this.cmbUserIDFilter = new System.Windows.Forms.ComboBox();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLogged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbActionTypeFilter = new System.Windows.Forms.ComboBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Filter by LogID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Filter by UserID:";
            // 
            // cmbLogIDFilter
            // 
            this.cmbLogIDFilter.FormattingEnabled = true;
            this.cmbLogIDFilter.Location = new System.Drawing.Point(774, 90);
            this.cmbLogIDFilter.Name = "cmbLogIDFilter";
            this.cmbLogIDFilter.Size = new System.Drawing.Size(179, 24);
            this.cmbLogIDFilter.TabIndex = 47;
            // 
            // cmbUserIDFilter
            // 
            this.cmbUserIDFilter.FormattingEnabled = true;
            this.cmbUserIDFilter.Location = new System.Drawing.Point(480, 92);
            this.cmbUserIDFilter.Name = "cmbUserIDFilter";
            this.cmbUserIDFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbUserIDFilter.TabIndex = 46;
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
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(288, 24);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(127, 48);
            this.btnDeleteSupplier.TabIndex = 42;
            this.btnDeleteSupplier.Text = "btnDeleteSupplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Filter by ActionType:";
            // 
            // cmbActionTypeFilter
            // 
            this.cmbActionTypeFilter.FormattingEnabled = true;
            this.cmbActionTypeFilter.Location = new System.Drawing.Point(181, 92);
            this.cmbActionTypeFilter.Name = "cmbActionTypeFilter";
            this.cmbActionTypeFilter.Size = new System.Drawing.Size(145, 24);
            this.cmbActionTypeFilter.TabIndex = 51;
            // 
            // AuditTrailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbActionTypeFilter);
            this.Controls.Add(this.lblTransactionStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLogIDFilter);
            this.Controls.Add(this.cmbUserIDFilter);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.txtSearchTransaction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.dgvTransactions);
            this.Name = "AuditTrailList";
            this.Size = new System.Drawing.Size(983, 683);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransactionStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLogIDFilter;
        private System.Windows.Forms.ComboBox cmbUserIDFilter;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLogged;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbActionTypeFilter;
    }
}
