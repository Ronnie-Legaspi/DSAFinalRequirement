namespace DSAFinalRequirement.Forms.Products
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.TextBox txtBarcode;

        private System.Windows.Forms.ComboBox cmbCategoryID;
        private System.Windows.Forms.ComboBox cmbSupplierID;

        private System.Windows.Forms.PictureBox picProduct;

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();

            this.cmbCategoryID = new System.Windows.Forms.ComboBox();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();

            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();

            // Product Name
            txtProductName.Location = new System.Drawing.Point(30, 30);
            txtProductName.Width = 250;
           

            // Category
            cmbCategoryID.Location = new System.Drawing.Point(30, 80);
            cmbCategoryID.Width = 250;

            // Supplier
            cmbSupplierID.Location = new System.Drawing.Point(30, 130);
            cmbSupplierID.Width = 250;

            // Stock Quantity
            txtStockQty.Location = new System.Drawing.Point(30, 180);
            txtStockQty.Width = 250;


            // Cost Price
            txtCostPrice.Location = new System.Drawing.Point(30, 230);
            txtCostPrice.Width = 250;
           

            // Selling Price
            txtSellingPrice.Location = new System.Drawing.Point(30, 280);
            txtSellingPrice.Width = 250;
          

            // Reorder Level
            txtReorderLevel.Location = new System.Drawing.Point(30, 330);
            txtReorderLevel.Width = 250;
            

            // Barcode
            txtBarcode.Location = new System.Drawing.Point(30, 380);
            txtBarcode.Width = 250;

            // Picture
            picProduct.Location = new System.Drawing.Point(320, 30);
            picProduct.Size = new System.Drawing.Size(200, 200);
            picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Browse button
            btnBrowse.Location = new System.Drawing.Point(320, 240);
            btnBrowse.Text = "Browse";
            

            // Save
            btnSave.Location = new System.Drawing.Point(320, 330);
            btnSave.Text = "Save";
           

            // Cancel
            btnCancel.Location = new System.Drawing.Point(420, 330);
            btnCancel.Text = "Cancel";
         

            // Form
            this.Controls.Add(txtProductName);
            this.Controls.Add(cmbCategoryID);
            this.Controls.Add(cmbSupplierID);
            this.Controls.Add(txtStockQty);
            this.Controls.Add(txtCostPrice);
            this.Controls.Add(txtSellingPrice);
            this.Controls.Add(txtReorderLevel);
            this.Controls.Add(txtBarcode);

            this.Controls.Add(picProduct);
            this.Controls.Add(btnBrowse);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);

            this.Text = "Add Product";
            this.ClientSize = new System.Drawing.Size(550, 450);

            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
