using System.Drawing;

namespace DSAFinalRequirement.Forms.Shared
{
    partial class LoadingScreenControl
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
            this.pnlOverlay = new System.Windows.Forms.Panel();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOverlay
            // 
            this.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOverlay.Controls.Add(this.pictureBox1);
            this.pnlOverlay.Controls.Add(this.lblLoadingText);
            this.pnlOverlay.Location = new System.Drawing.Point(302, 220);
            this.pnlOverlay.Name = "pnlOverlay";
            this.pnlOverlay.Size = new System.Drawing.Size(305, 212);
            this.pnlOverlay.TabIndex = 0;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.AutoSize = true;
            this.lblLoadingText.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingText.Location = new System.Drawing.Point(90, 144);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(149, 29);
            this.lblLoadingText.TabIndex = 0;
            this.lblLoadingText.Text = "Loading......";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(95, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.pnlOverlay);
            this.Name = "LoadingScreenControl";
            this.Size = new System.Drawing.Size(983, 683);
            this.Load += new System.EventHandler(this.LoadingScreenControl_Load);
            this.pnlOverlay.ResumeLayout(false);
            this.pnlOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOverlay;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
