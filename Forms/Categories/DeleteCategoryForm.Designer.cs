using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Categories
{
    public partial class DeleteCategoryForm : Form
    {
        private PictureBox picCategoryImage;
        private TextBox txtCategoryName;
        private Label label1;
        private Label lblWarning;
        private Button btnDelete;
        private Button btnCancel;
        private Panel topBar;
        private Label lblTitle;

        public DeleteCategoryForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.picCategoryImage = new PictureBox();
            this.txtCategoryName = new TextBox();
            this.label1 = new Label();
            this.lblWarning = new Label();
            this.btnDelete = new Button();
            this.btnCancel = new Button();
            this.topBar = new Panel();
            this.lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).BeginInit();
            this.SuspendLayout();

            // ================================
            // FORM SETTINGS
            // ================================
            this.BackColor = Color.FromArgb(30, 30, 47);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ClientSize = new Size(600, 300);
            this.StartPosition = FormStartPosition.CenterParent;

            // ================================
            // TOP BAR (MOVABLE)
            // ================================
            this.topBar.Dock = DockStyle.Top;
            this.topBar.Height = 40;
            this.topBar.BackColor = Color.FromArgb(40, 40, 58);
            this.topBar.MouseDown += TopBar_MouseDown;

            // Title inside top bar
            this.lblTitle.Text = "Delete Category";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new Point(20, 10);
            this.topBar.Controls.Add(this.lblTitle);

            // ================================
            // CATEGORY IMAGE
            // ================================
            this.picCategoryImage.Location = new Point(40, 90);
            this.picCategoryImage.Size = new Size(140, 140);
            this.picCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.picCategoryImage.BackColor = Color.FromArgb(45, 45, 60);
            this.picCategoryImage.BorderStyle = BorderStyle.None;

            // ================================
            // LABEL: Category Name
            // ================================
            this.label1.Text = "Category Name";
            this.label1.ForeColor = Color.White;
            this.label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(210, 90);

            // ================================
            // TEXTBOX: Category Name
            // ================================
            this.txtCategoryName.Location = new Point(213, 115);
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.BorderStyle = BorderStyle.None;
            this.txtCategoryName.BackColor = Color.FromArgb(30, 30, 47);
            this.txtCategoryName.ForeColor = Color.Gainsboro;
            this.txtCategoryName.Font = new Font("Segoe UI", 11F);
            this.txtCategoryName.Size = new Size(330, 24);

            // ================================
            // WARNING MESSAGE
            // ================================
            this.lblWarning.Text =
                "Are you sure you want to delete this category?\n" +
                "This action is permanent and cannot be undone.";
            this.lblWarning.ForeColor = Color.FromArgb(230, 230, 230);
            this.lblWarning.Font = new Font("Segoe UI", 10F);
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new Point(210, 155);

            // ================================
            // DELETE BUTTON
            // ================================
            this.btnDelete.BackColor = Color.FromArgb(220, 50, 50);
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.Location = new Point(320, 220);
            this.btnDelete.Size = new Size(110, 45);
            this.btnDelete.Text = "Delete";

            // ================================
            // CANCEL BUTTON
            // ================================
            this.btnCancel.BackColor = Color.FromArgb(60, 60, 75);
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Location = new Point(440, 220);
            this.btnCancel.Size = new Size(110, 45);
            this.btnCancel.Text = "Cancel";

            // ================================
            // ADD CONTROLS
            // ================================
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.picCategoryImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.picCategoryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ======================================================
        // FORM MOVEMENT SUPPORT
        // ======================================================
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
    }
}
