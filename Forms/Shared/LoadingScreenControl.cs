using System;
using System.Drawing;
using System.Windows.Forms;

namespace DSAFinalRequirement.Forms.Shared
{
    public partial class LoadingScreenControl : UserControl
    {
        private Image loaderImage;
        private float angle = 0;

        public LoadingScreenControl()
        {
            InitializeComponent();
        }

        private void LoadingScreenControl_Load(object sender, EventArgs e)
        {
            // Save the original image
            loaderImage = pbLoaderImage.Image;

            // Prevent PictureBox from drawing the image automatically
            pbLoaderImage.Image = null;

            CenterLoader();

            // Smooth + slower spin
            spinTimer.Interval = 25;
            spinTimer.Start();
        }

        private void LoadingScreenControl_Resize(object sender, EventArgs e)
        {
            CenterLoader();
        }

        private void CenterLoader()
        {
            pbLoaderImage.Left = (this.Width - pbLoaderImage.Width) / 2;
            pbLoaderImage.Top = (this.Height - pbLoaderImage.Height) / 2;
        }

        private void spinTimer_Tick(object sender, EventArgs e)
        {
            angle += 5f; // slower rotation
            if (angle >= 360) angle = 0;

            pbLoaderImage.Invalidate(); // redraw rotated image
        }

        private void pbLoaderImage_Paint(object sender, PaintEventArgs e)
        {
            if (loaderImage == null) return;

            // Move center point of rotation to the image center
            e.Graphics.TranslateTransform(pbLoaderImage.Width / 2, pbLoaderImage.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-pbLoaderImage.Width / 2, -pbLoaderImage.Height / 2);

            // Draw the rotated loader image
            e.Graphics.DrawImage(loaderImage, 0, 0, pbLoaderImage.Width, pbLoaderImage.Height);
        }
    }
}
