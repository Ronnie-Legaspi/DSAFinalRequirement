namespace DSAFinalRequirement.Forms.Sales
{
    partial class SalesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSaleStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCashReceived = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnCompleteTransaction = new System.Windows.Forms.Button();
            this.lblCashReceived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblVatAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.btnRefreshs = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(931, 629);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 59;
            // 
            // lblSaleStatus
            // 
            this.lblSaleStatus.AutoSize = true;
            this.lblSaleStatus.Location = new System.Drawing.Point(73, 640);
            this.lblSaleStatus.Name = "lblSaleStatus";
            this.lblSaleStatus.Size = new System.Drawing.Size(86, 16);
            this.lblSaleStatus.TabIndex = 48;
            this.lblSaleStatus.Text = "lblSaleStatus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(761, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 1);
            this.panel2.TabIndex = 47;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(362, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 48);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(499, 333);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 48);
            this.btnRemove.TabIndex = 57;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCashReceived);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.btnCompleteTransaction);
            this.panel1.Controls.Add(this.lblCashReceived);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNewSale);
            this.panel1.Controls.Add(this.lblGrandTotal);
            this.panel1.Controls.Add(this.lblVatAmount);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.lblTotalItems);
            this.panel1.Location = new System.Drawing.Point(761, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 546);
            this.panel1.TabIndex = 56;
            // 
            // txtCashReceived
            // 
            this.txtCashReceived.Location = new System.Drawing.Point(141, 315);
            this.txtCashReceived.Name = "txtCashReceived";
            this.txtCashReceived.Size = new System.Drawing.Size(100, 22);
            this.txtCashReceived.TabIndex = 46;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(22, 349);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(57, 16);
            this.lblChange.TabIndex = 45;
            this.lblChange.Text = "Change:";
            // 
            // btnCompleteTransaction
            // 
            this.btnCompleteTransaction.Location = new System.Drawing.Point(16, 415);
            this.btnCompleteTransaction.Name = "btnCompleteTransaction";
            this.btnCompleteTransaction.Size = new System.Drawing.Size(202, 48);
            this.btnCompleteTransaction.TabIndex = 44;
            this.btnCompleteTransaction.Text = "btnCompleteTransaction";
            this.btnCompleteTransaction.UseVisualStyleBackColor = true;
            // 
            // lblCashReceived
            // 
            this.lblCashReceived.AutoSize = true;
            this.lblCashReceived.Location = new System.Drawing.Point(22, 315);
            this.lblCashReceived.Name = "lblCashReceived";
            this.lblCashReceived.Size = new System.Drawing.Size(103, 16);
            this.lblCashReceived.TabIndex = 6;
            this.lblCashReceived.Text = "Cash Recieved:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Payment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Summary";
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(16, 469);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(202, 48);
            this.btnNewSale.TabIndex = 43;
            this.btnNewSale.Text = "btnNewSale";
            this.btnNewSale.UseVisualStyleBackColor = true;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(22, 204);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(89, 16);
            this.lblGrandTotal.TabIndex = 3;
            this.lblGrandTotal.Text = "lblGrandTotal";
            // 
            // lblVatAmount
            // 
            this.lblVatAmount.AutoSize = true;
            this.lblVatAmount.Location = new System.Drawing.Point(22, 156);
            this.lblVatAmount.Name = "lblVatAmount";
            this.lblVatAmount.Size = new System.Drawing.Size(86, 16);
            this.lblVatAmount.TabIndex = 2;
            this.lblVatAmount.Text = "lblVatAmount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(22, 111);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(97, 16);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "lblTotalAmount";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(22, 76);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(84, 16);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "lblTotalItems";
            // 
            // btnRefreshs
            // 
            this.btnRefreshs.Location = new System.Drawing.Point(499, 37);
            this.btnRefreshs.Name = "btnRefreshs";
            this.btnRefreshs.Size = new System.Drawing.Size(127, 48);
            this.btnRefreshs.TabIndex = 55;
            this.btnRefreshs.Text = "Refresh";
            this.btnRefreshs.UseVisualStyleBackColor = true;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.ProductName,
            this.Quantity,
            this.UnitPrice,
            this.Subtotal});
            this.dgvCart.Location = new System.Drawing.Point(76, 389);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(679, 248);
            this.dgvCart.TabIndex = 54;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "ProductImage";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(234, 333);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(122, 48);
            this.btnAddToCart.TabIndex = 53;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(75, 347);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(153, 22);
            this.nudQuantity.TabIndex = 52;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductImage,
            this.Category,
            this.Price,
            this.Stock});
            this.dgvProducts.Location = new System.Drawing.Point(76, 91);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(679, 236);
            this.dgvProducts.TabIndex = 51;
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
            this.ProductImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductImage.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(968, 40);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(52, 48);
            this.btnSearchProduct.TabIndex = 50;
            this.btnSearchProduct.Text = "Search Icon";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProductSearch.Location = new System.Drawing.Point(632, 40);
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(330, 45);
            this.txtProductSearch.TabIndex = 49;
            this.txtProductSearch.Text = "Search Supplier";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1108, 722);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblSaleStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefreshs);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtProductSearch);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSaleStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCashReceived;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnCompleteTransaction;
        private System.Windows.Forms.Label lblCashReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblVatAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Button btnRefreshs;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtProductSearch;
    }
}