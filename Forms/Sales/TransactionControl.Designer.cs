using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Transactions
{
    partial class TransactionControl
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderDesc = new System.Windows.Forms.Label();

            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearchTransaction = new System.Windows.Forms.TextBox();
            this.btnSearchTransaction = new System.Windows.Forms.Button();

            this.lblFilterUserID = new System.Windows.Forms.Label();
            this.cmbUserIDFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterTransactionID = new System.Windows.Forms.Label();
            this.cmbTransactionIDFilter = new System.Windows.Forms.ComboBox();

            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();

            this.lblTransactionStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panelTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = Color.White;
            this.lblHeaderTitle.Location = new Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new Size(200, 41);
            this.lblHeaderTitle.Text = "Transactions";

            // 
            // lblHeaderDesc
            // 
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new Font("Segoe UI", 10F);
            this.lblHeaderDesc.ForeColor = Color.Silver;
            this.lblHeaderDesc.Location = new Point(25, 52);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.Size = new Size(400, 19);
            this.lblHeaderDesc.Text = "View and manage all transactions — search, filter, refresh.";

            // 
            // panelTop
            // 
            this.panelTop.BackColor = Color.FromArgb(40, 40, 60);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.pnlSearch);
            this.panelTop.Location = new Point(20, 75);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new Size(970, 60);

            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = Color.FromArgb(76, 175, 80);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(10, 10);
            this.btnRefresh.Size = new Size(120, 40);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;

            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = Color.FromArgb(50, 50, 70);
            this.pnlSearch.Controls.Add(this.txtSearchTransaction);
            this.pnlSearch.Controls.Add(this.btnSearchTransaction);
            this.pnlSearch.Location = new Point(650, 10);
            this.pnlSearch.Size = new Size(310, 40);

            // 
            // txtSearchTransaction
            // 
            this.txtSearchTransaction.BackColor = Color.FromArgb(50, 50, 70);
            this.txtSearchTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchTransaction.Font = new Font("Segoe UI", 12F);
            this.txtSearchTransaction.ForeColor = Color.Silver;
            this.txtSearchTransaction.Location = new Point(5, 8);
            this.txtSearchTransaction.Size = new Size(230, 22);
            this.txtSearchTransaction.Text = "Search Transaction...";

            // 
            // btnSearchTransaction
            // 
            this.btnSearchTransaction.BackColor = Color.FromArgb(33, 150, 243);
            this.btnSearchTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTransaction.FlatAppearance.BorderSize = 0;
            this.btnSearchTransaction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSearchTransaction.ForeColor = Color.White;
            this.btnSearchTransaction.Location = new Point(240, 0);
            this.btnSearchTransaction.Size = new Size(70, 40);
            this.btnSearchTransaction.Text = "🔍";
            this.btnSearchTransaction.UseVisualStyleBackColor = false;

            // 
            // lblFilterUserID
            // 
            this.lblFilterUserID.AutoSize = true;
            this.lblFilterUserID.ForeColor = Color.Silver;
            this.lblFilterUserID.Location = new Point(20, 145);
            this.lblFilterUserID.Text = "Filter by UserID:";

            // 
            // cmbUserIDFilter
            // 
            this.cmbUserIDFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserIDFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserIDFilter.Location = new Point(120, 140);
            this.cmbUserIDFilter.Size = new Size(140, 24);

            // 
            // lblFilterTransactionID
            // 
            this.lblFilterTransactionID.AutoSize = true;
            this.lblFilterTransactionID.ForeColor = Color.Silver;
            this.lblFilterTransactionID.Location = new Point(290, 145);
            this.lblFilterTransactionID.Text = "Filter by TransactionID:";

            // 
            // cmbTransactionIDFilter
            // 
            this.cmbTransactionIDFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransactionIDFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTransactionIDFilter.Location = new Point(440, 140);
            this.cmbTransactionIDFilter.Size = new Size(140, 24);

            // 
            // dgvTransactions
            // 
            this.dgvTransactions.BackgroundColor = Color.FromArgb(37, 37, 55);
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 28;
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.Location = new Point(20, 180);
            this.dgvTransactions.Size = new Size(970, 410);

            headerStyle.BackColor = Color.FromArgb(55, 55, 80);
            headerStyle.ForeColor = Color.White;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(6);
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = headerStyle;

            cellStyle.BackColor = Color.FromArgb(50, 50, 72);
            cellStyle.ForeColor = Color.White;
            cellStyle.SelectionBackColor = Color.FromArgb(70, 70, 100);
            cellStyle.Padding = new Padding(6);
            this.dgvTransactions.DefaultCellStyle = cellStyle;

            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.TransactionID,
                this.UserID,
                this.TotalAmmount,
                this.DateOfSale,
                this.Remarks,
                this.Action
            });

            // 
            // lblTransactionStatus
            // 
            this.lblTransactionStatus.AutoSize = true;
            this.lblTransactionStatus.ForeColor = Color.Lime;
            this.lblTransactionStatus.Location = new Point(20, 600);
            this.lblTransactionStatus.Text = "Status: Ready";

            // 
            // TransactionControl
            // 
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.Controls.Add(this.lblHeaderTitle);
            this.Controls.Add(this.lblHeaderDesc);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblFilterUserID);
            this.Controls.Add(this.cmbUserIDFilter);
            this.Controls.Add(this.lblFilterTransactionID);
            this.Controls.Add(this.cmbTransactionIDFilter);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.lblTransactionStatus);
            this.Name = "TransactionControl";
            this.Size = new Size(1012, 632);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderDesc;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearchTransaction;
        private System.Windows.Forms.Button btnSearchTransaction;
        private System.Windows.Forms.Label lblFilterUserID;
        private System.Windows.Forms.ComboBox cmbUserIDFilter;
        private System.Windows.Forms.Label lblFilterTransactionID;
        private System.Windows.Forms.ComboBox cmbTransactionIDFilter;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Label lblTransactionStatus;
    }
}
