
namespace Yandere.Output.Components
{
    partial class ImageViewForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageContent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageContent
            // 
            this.ImageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageContent.Location = new System.Drawing.Point(12, 12);
            this.ImageContent.Name = "ImageContent";
            this.ImageContent.Size = new System.Drawing.Size(776, 402);
            this.ImageContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageContent.TabIndex = 0;
            this.ImageContent.TabStop = false;
            // 
            // ImageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImageViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageViewForm_FormClosed);
            this.Load += new System.EventHandler(this.ImageViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageContent;
    }
}