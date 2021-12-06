
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
            this.saveJpgBtn = new System.Windows.Forms.Button();
            this.savePngBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SizeInfo = new System.Windows.Forms.Label();
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
            // saveJpgBtn
            // 
            this.saveJpgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveJpgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveJpgBtn.Location = new System.Drawing.Point(12, 420);
            this.saveJpgBtn.Name = "saveJpgBtn";
            this.saveJpgBtn.Size = new System.Drawing.Size(79, 26);
            this.saveJpgBtn.TabIndex = 1;
            this.saveJpgBtn.Text = "SaveJPG";
            this.saveJpgBtn.UseVisualStyleBackColor = true;
            this.saveJpgBtn.Click += new System.EventHandler(this.saveJpgBtn_Click);
            // 
            // savePngBtn
            // 
            this.savePngBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.savePngBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePngBtn.Location = new System.Drawing.Point(97, 420);
            this.savePngBtn.Name = "savePngBtn";
            this.savePngBtn.Size = new System.Drawing.Size(79, 26);
            this.savePngBtn.TabIndex = 2;
            this.savePngBtn.Text = "SavePNG";
            this.savePngBtn.UseVisualStyleBackColor = true;
            this.savePngBtn.Click += new System.EventHandler(this.savePngBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Location = new System.Drawing.Point(709, 420);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(79, 26);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SizeInfo
            // 
            this.SizeInfo.AutoSize = true;
            this.SizeInfo.Location = new System.Drawing.Point(182, 425);
            this.SizeInfo.Name = "SizeInfo";
            this.SizeInfo.Size = new System.Drawing.Size(36, 17);
            this.SizeInfo.TabIndex = 4;
            this.SizeInfo.Text = "(0x0)";
            // 
            // ImageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SizeInfo);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.savePngBtn);
            this.Controls.Add(this.saveJpgBtn);
            this.Controls.Add(this.ImageContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ImageViewForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageViewForm_FormClosed);
            this.Load += new System.EventHandler(this.ImageViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageContent;
        private System.Windows.Forms.Button saveJpgBtn;
        private System.Windows.Forms.Button savePngBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label SizeInfo;
    }
}