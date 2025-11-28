namespace DSAFinalRequirement.Forms.Shared
{
    partial class LoadingScreenControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbLoaderImage;
        private System.Windows.Forms.Timer spinTimer;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                spinTimer.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbLoaderImage = new System.Windows.Forms.PictureBox();
            this.spinTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaderImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoaderImage
            // 
            this.pbLoaderImage.BackColor = System.Drawing.Color.Transparent;
            this.pbLoaderImage.Image = global::DSAFinalRequirement.Properties.Resources.LoaderImage;
            this.pbLoaderImage.Location = new System.Drawing.Point(448, 276);
            this.pbLoaderImage.Name = "pbLoaderImage";
            this.pbLoaderImage.Size = new System.Drawing.Size(80, 80);
            this.pbLoaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoaderImage.TabIndex = 0;
            this.pbLoaderImage.TabStop = false;
            this.pbLoaderImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLoaderImage_Paint);
            // 
            // spinTimer
            // 
            this.spinTimer.Tick += new System.EventHandler(this.spinTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(416, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading.....";
            // 
            // LoadingScreenControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLoaderImage);
            this.DoubleBuffered = true;
            this.Name = "LoadingScreenControl";
            this.Size = new System.Drawing.Size(1012, 632);
            this.Load += new System.EventHandler(this.LoadingScreenControl_Load);
            this.Resize += new System.EventHandler(this.LoadingScreenControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaderImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
