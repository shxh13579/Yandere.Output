
namespace Yandere.Output.Components
{
    partial class ImageBrick
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageBrick));
            this.ImageContent = new System.Windows.Forms.PictureBox();
            this.SizeInfo = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.FavBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageContent
            // 
            this.ImageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageContent.BackColor = System.Drawing.Color.Transparent;
            this.ImageContent.Location = new System.Drawing.Point(0, 0);
            this.ImageContent.Name = "ImageContent";
            this.ImageContent.Size = new System.Drawing.Size(307, 307);
            this.ImageContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageContent.TabIndex = 0;
            this.ImageContent.TabStop = false;
            this.ImageContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageContent_MouseClick);
            // 
            // SizeInfo
            // 
            this.SizeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeInfo.Location = new System.Drawing.Point(0, 310);
            this.SizeInfo.Name = "SizeInfo";
            this.SizeInfo.Size = new System.Drawing.Size(247, 24);
            this.SizeInfo.TabIndex = 1;
            this.SizeInfo.Text = "[SizeInfo]";
            this.SizeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.Image")));
            this.DownloadBtn.Location = new System.Drawing.Point(283, 310);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(24, 24);
            this.DownloadBtn.TabIndex = 2;
            this.DownloadBtn.UseVisualStyleBackColor = true;
            // 
            // FavBtn
            // 
            this.FavBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FavBtn.Image = ((System.Drawing.Image)(resources.GetObject("FavBtn.Image")));
            this.FavBtn.Location = new System.Drawing.Point(253, 310);
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Size = new System.Drawing.Size(24, 24);
            this.FavBtn.TabIndex = 3;
            this.FavBtn.UseVisualStyleBackColor = true;
            // 
            // ImageBrick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FavBtn);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.SizeInfo);
            this.Controls.Add(this.ImageContent);
            this.Name = "ImageBrick";
            this.Size = new System.Drawing.Size(309, 335);
            this.Load += new System.EventHandler(this.ImageBrick_Load);
            this.SizeChanged += new System.EventHandler(this.ImageBrick_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SizeInfo;
        private System.Windows.Forms.PictureBox ImageContent;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button FavBtn;
    }
}
