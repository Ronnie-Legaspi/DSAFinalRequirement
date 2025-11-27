namespace DSAFinalRequirement.Forms.Products
{
    partial class DeleteProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();

            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.Location = new System.Drawing.Point(20, 20);
            this.lblConfirm.Text = "Are you sure you want to delete this product?";

            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 60);
            this.lblProductName.Text = "Product Name";

            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(20, 90);
            this.lblBarcode.Text = "Barcode";

            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(300, 20);
            this.picProduct.Size = new System.Drawing.Size(150, 150);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(60, 150);
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;

            // 
            // DeleteProductForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 210);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Product";

            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
