namespace DSAFinalRequirement.Forms.Reports
{
    partial class SalesReportControl
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
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.lblFrom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.lblTotalSalesAmount = new System.Windows.Forms.Label();
            this.lblTotalItemsSold = new System.Windows.Forms.Label();
            this.dgvProductResults = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductResults)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(275, 38);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(71, 20);
            this.rbDaily.TabIndex = 0;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "rbDaily";
            this.rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(413, 38);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(86, 20);
            this.rbWeekly.TabIndex = 1;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "rbWeekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(704, 38);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(85, 20);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "rbCustom";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(557, 38);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(86, 20);
            this.rbMonthly.TabIndex = 3;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "rbMonthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(42, 16);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 16);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "lblFrom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateReport);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Location = new System.Drawing.Point(61, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 257);
            this.panel1.TabIndex = 5;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(36, 55);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 22);
            this.dtFrom.TabIndex = 5;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(42, 119);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 16);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "lblTo";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(45, 138);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 22);
            this.dtTo.TabIndex = 7;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(36, 181);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(156, 46);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalItemsSold);
            this.panel2.Controls.Add(this.lblTotalSalesAmount);
            this.panel2.Controls.Add(this.lblTotalTransactions);
            this.panel2.Location = new System.Drawing.Point(577, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 257);
            this.panel2.TabIndex = 6;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Location = new System.Drawing.Point(27, 35);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(130, 16);
            this.lblTotalTransactions.TabIndex = 9;
            this.lblTotalTransactions.Text = "lblTotalTransactions";
            // 
            // lblTotalSalesAmount
            // 
            this.lblTotalSalesAmount.AutoSize = true;
            this.lblTotalSalesAmount.Location = new System.Drawing.Point(27, 81);
            this.lblTotalSalesAmount.Name = "lblTotalSalesAmount";
            this.lblTotalSalesAmount.Size = new System.Drawing.Size(132, 16);
            this.lblTotalSalesAmount.TabIndex = 10;
            this.lblTotalSalesAmount.Text = "lblTotalSalesAmount";
            // 
            // lblTotalItemsSold
            // 
            this.lblTotalItemsSold.AutoSize = true;
            this.lblTotalItemsSold.Location = new System.Drawing.Point(27, 138);
            this.lblTotalItemsSold.Name = "lblTotalItemsSold";
            this.lblTotalItemsSold.Size = new System.Drawing.Size(112, 16);
            this.lblTotalItemsSold.TabIndex = 11;
            this.lblTotalItemsSold.Text = "lblTotalItemsSold";
            // 
            // dgvProductResults
            // 
            this.dgvProductResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.DateOfSale,
            this.User,
            this.ItemsSold,
            this.TotalAmount,
            this.Remarks});
            this.dgvProductResults.Location = new System.Drawing.Point(61, 338);
            this.dgvProductResults.Name = "dgvProductResults";
            this.dgvProductResults.RowHeadersWidth = 51;
            this.dgvProductResults.RowTemplate.Height = 24;
            this.dgvProductResults.Size = new System.Drawing.Size(819, 236);
            this.dgvProductResults.TabIndex = 38;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.MinimumWidth = 6;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Width = 125;
            // 
            // DateOfSale
            // 
            this.DateOfSale.HeaderText = "DateOfSale";
            this.DateOfSale.MinimumWidth = 6;
            this.DateOfSale.Name = "DateOfSale";
            this.DateOfSale.ReadOnly = true;
            this.DateOfSale.Width = 125;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 125;
            // 
            // ItemsSold
            // 
            this.ItemsSold.HeaderText = "ItemsSold";
            this.ItemsSold.MinimumWidth = 6;
            this.ItemsSold.Name = "ItemsSold";
            this.ItemsSold.ReadOnly = true;
            this.ItemsSold.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 125;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 125;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Location = new System.Drawing.Point(562, 580);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(156, 46);
            this.btnExportPDF.TabIndex = 9;
            this.btnExportPDF.Text = "btnExportPDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(724, 580);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(156, 46);
            this.btnExportExcel.TabIndex = 39;
            this.btnExportExcel.Text = "btnExportExcel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // SalesReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.dgvProductResults);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbWeekly);
            this.Controls.Add(this.rbDaily);
            this.Name = "SalesReportControl";
            this.Size = new System.Drawing.Size(983, 683);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Label lblTotalItemsSold;
        private System.Windows.Forms.Label lblTotalSalesAmount;
        private System.Windows.Forms.DataGridView dgvProductResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
    }
}
