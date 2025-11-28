using System.Drawing;

namespace DSAFinalRequirement.Forms.Reports
{
    partial class TransactionsControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLogged = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnSearchTransaction = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.lblTransactionStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvTransactions
            // 
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.LogID,
                this.UserID,
                this.ActionType,
                this.Description,
                this.DateLogged
            });
            this.dgvTransactions.Location = new System.Drawing.Point(20, 130);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.Size = new System.Drawing.Size(970, 500);
            this.dgvTransactions.BackgroundColor = Color.White;
            this.dgvTransactions.DefaultCellStyle.BackColor = Color.White;
            this.dgvTransactions.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvTransactions.GridColor = Color.Gray;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // 
            // Columns
            // 
            this.LogID.HeaderText = "LogID";
            this.LogID.ReadOnly = true;
            this.UserID.HeaderText = "UserID";
            this.UserID.ReadOnly = true;
            this.ActionType.HeaderText = "ActionType";
            this.ActionType.ReadOnly = true;
            this.Description.HeaderText = "Description";
            this.Description.ReadOnly = true;
            this.DateLogged.HeaderText = "DateLogged";
            this.DateLogged.ReadOnly = true;

            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.Location = new System.Drawing.Point(565, 27);
            this.txtSearchTransaction.Size = new System.Drawing.Size(330, 45);
            this.txtSearchTransaction.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtSearchTransaction.ForeColor = SystemColors.GrayText;
            this.txtSearchTransaction.Text = "Search Transaction...";

            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.Location = new System.Drawing.Point(905, 27);
            this.btnSearchTransaction.Size = new System.Drawing.Size(50, 45);
            this.btnSearchTransaction.Text = "🔍";
            this.btnSearchTransaction.BackColor = Color.FromArgb(33, 150, 243);
            this.btnSearchTransaction.ForeColor = Color.White;
            this.btnSearchTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTransaction.FlatAppearance.BorderSize = 0;
            this.btnSearchTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(430, 27);
            this.btnRefresh.Size = new System.Drawing.Size(120, 45);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(290, 27);
            this.btnDeleteTransaction.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteTransaction.Text = "Delete";
            this.btnDeleteTransaction.BackColor = Color.FromArgb(244, 67, 54);
            this.btnDeleteTransaction.ForeColor = Color.White;
            this.btnDeleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTransaction.FlatAppearance.BorderSize = 0;
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.Location = new System.Drawing.Point(20, 640);
            this.lblTransactionStatus.ForeColor = Color.Black;
            this.lblTransactionStatus.Text = "Status: Ready";

            // 
            // TransactionsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.txtSearchTransaction);
            this.Controls.Add(this.btnSearchTransaction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.lblTransactionStatus);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(1012, 700);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLogged;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Label lblTransactionStatus;
    }
}
