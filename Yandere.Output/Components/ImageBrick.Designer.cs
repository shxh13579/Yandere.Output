﻿
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
            this.ImageContent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.ImageContent.Size = new System.Drawing.Size(298, 298);
            this.ImageContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageContent.TabIndex = 0;
            this.ImageContent.TabStop = false;
            this.ImageContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageContent_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(0, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ImageBrick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageContent);
            this.Name = "ImageBrick";
            this.Size = new System.Drawing.Size(300, 330);
            this.Load += new System.EventHandler(this.ImageBrick_Load);
            this.SizeChanged += new System.EventHandler(this.ImageBrick_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ImageContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageContent;
    }
}
