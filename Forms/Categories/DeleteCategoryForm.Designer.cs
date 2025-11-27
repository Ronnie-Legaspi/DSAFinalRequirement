namespace DSAFinalRequirement.Forms.Categories
{
    partial class DeleteCategoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picCategoryImage;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
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
            this.picCategoryImage = new System.Windows.Forms.PictureBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picCategoryImage
            // 
            this.picCategoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCategoryImage.Location = new System.Drawing.Point(20, 20);
            this.picCategoryImage.Name = "picCategoryImage";
            this.picCategoryImage.Size = new System.Drawing.Size(120, 120);
            this.picCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategoryImage.TabIndex = 0;
            this.picCategoryImage.TabStop = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(160, 60);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(200, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(160, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
   // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(270, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
  // 
            // DeleteCategoryForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.picCategoryImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "DeleteCategoryForm";
            this.Text = "Delete Category";
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
