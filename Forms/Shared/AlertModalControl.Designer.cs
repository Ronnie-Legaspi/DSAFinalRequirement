namespace DSAFinalRequirement.Forms.Shared
{
    partial class AlertModalControl
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
            this.pnlAlert = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlert
            // 
            this.pnlAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAlert.Controls.Add(this.btnClose);
            this.pnlAlert.Controls.Add(this.lblMessage);
            this.pnlAlert.Controls.Add(this.pbIcon);
            this.pnlAlert.Location = new System.Drawing.Point(166, 112);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(507, 344);
            this.pnlAlert.TabIndex = 0;
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(193, 29);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 100);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(165, 161);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 16);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "label1";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(376, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertModalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAlert);
            this.Name = "AlertModalControl";
            this.Size = new System.Drawing.Size(983, 683);
            this.Load += new System.EventHandler(this.AlertModalControl_Load);
            this.pnlAlert.ResumeLayout(false);
            this.pnlAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlert;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnClose;
    }
}
