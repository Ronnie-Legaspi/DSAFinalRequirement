namespace DSAFinalRequirement.Forms.Categories
{
    partial class EditCategoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picCategoryImage;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picCategoryImage = new System.Windows.Forms.PictureBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picCategoryImage
            // 
            this.picCategoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCategoryImage.Location = new System.Drawing.Point(30, 40);
            this.picCategoryImage.Name = "picCategoryImage";
            this.picCategoryImage.Size = new System.Drawing.Size(150, 150);
            this.picCategoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategoryImage.TabIndex = 0;
            this.picCategoryImage.TabStop = false;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(220, 50);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(300, 22);
            this.txtCategoryName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(220, 110);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 80);
            this.txtDescription.TabIndex = 4;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(30, 200);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(150, 30);
            this.btnBrowseImage.TabIndex = 6;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(217, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Category Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(217, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(27, 20);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(106, 16);
            this.lblImage.TabIndex = 1;
            this.lblImage.Text = "Category Image:";
            // 
            // EditCategoryForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 270);
            this.Controls.Add(this.picCategoryImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Category";
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
