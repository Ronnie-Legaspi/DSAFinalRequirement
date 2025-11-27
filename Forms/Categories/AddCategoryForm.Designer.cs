using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    partial class AddCategoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private TextBox txtCategoryName;
        private Label label2;
        private TextBox txtDescription;
        private PictureBox picCategoryImage;
        private Button btnBrowseImage;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.txtCategoryName = new TextBox();
            this.label2 = new Label();
            this.txtDescription = new TextBox();
            this.picCategoryImage = new PictureBox();
            this.btnBrowseImage = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.Text = "Category Name:";
            this.label1.Location = new Point(20, 20);
            this.label1.Size = new Size(120, 25);

            // txtCategoryName
            this.txtCategoryName.Location = new Point(150, 20);
            this.txtCategoryName.Width = 250;

            // label2
            this.label2.Text = "Description:";
            this.label2.Location = new Point(20, 70);
            this.label2.Size = new Size(120, 25);

            // txtDescription
            this.txtDescription.Location = new Point(150, 70);
            this.txtDescription.Width = 250;
            this.txtDescription.Height = 80;
            this.txtDescription.Multiline = true;

            // picCategoryImage
            this.picCategoryImage.Location = new Point(150, 170);
            this.picCategoryImage.Size = new Size(150, 150);
            this.picCategoryImage.BorderStyle = BorderStyle.FixedSingle;

            // btnBrowseImage
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.Location = new Point(320, 170);
            this.btnBrowseImage.Click += new EventHandler(this.btnBrowseImage_Click);

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new Point(150, 350);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new Point(250, 350);
            //this.btnCancel.Click += (s, e) => this.Close();

            // AddCategoryForm
            this.ClientSize = new Size(430, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.picCategoryImage);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add Category";

            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
