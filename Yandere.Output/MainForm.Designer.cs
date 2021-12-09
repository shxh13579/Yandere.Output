
namespace Yandere.Output
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SelectTags = new System.Windows.Forms.ComboBox();
            this.PrePageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.SelectAllBtn = new System.Windows.Forms.Button();
            this.DownloadShownBtn = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.DownloadAllResultBtn = new System.Windows.Forms.Button();
            this.SkipPageBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.MarkDownloadBtn = new System.Windows.Forms.Button();
            this.MarkListBtn = new System.Windows.Forms.Button();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.Container = new Yandere.Output.Components.ImageContainer();
            this.AttributeList = new System.Windows.Forms.FlowLayoutPanel();
            this.IsNSFWCheck = new System.Windows.Forms.CheckBox();
            this.IsPNGCheck = new System.Windows.Forms.CheckBox();
            this.PageNumber = new System.Windows.Forms.TextBox();
            this.InfoMessage = new System.Windows.Forms.Label();
            this.AttributeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(349, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 30);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Location = new System.Drawing.Point(12, 6);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 30);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SelectTags
            // 
            this.SelectTags.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTags.FormattingEnabled = true;
            this.SelectTags.Location = new System.Drawing.Point(93, 7);
            this.SelectTags.MinimumSize = new System.Drawing.Size(150, 0);
            this.SelectTags.Name = "SelectTags";
            this.SelectTags.Size = new System.Drawing.Size(250, 29);
            this.SelectTags.TabIndex = 4;
            this.SelectTags.TextChanged += new System.EventHandler(this.SelectTags_TextChanged);
            // 
            // PrePageBtn
            // 
            this.PrePageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrePageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrePageBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrePageBtn.Location = new System.Drawing.Point(669, 6);
            this.PrePageBtn.Name = "PrePageBtn";
            this.PrePageBtn.Size = new System.Drawing.Size(28, 30);
            this.PrePageBtn.TabIndex = 6;
            this.PrePageBtn.Text = "<";
            this.PrePageBtn.UseVisualStyleBackColor = true;
            this.PrePageBtn.Click += new System.EventHandler(this.PrePageBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPageBtn.Location = new System.Drawing.Point(843, 6);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(28, 30);
            this.NextPageBtn.TabIndex = 7;
            this.NextPageBtn.Text = ">";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // SelectAllBtn
            // 
            this.SelectAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllBtn.Location = new System.Drawing.Point(877, 143);
            this.SelectAllBtn.Name = "SelectAllBtn";
            this.SelectAllBtn.Size = new System.Drawing.Size(123, 28);
            this.SelectAllBtn.TabIndex = 9;
            this.SelectAllBtn.Text = "Select All";
            this.SelectAllBtn.UseVisualStyleBackColor = true;
            // 
            // DownloadShownBtn
            // 
            this.DownloadShownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadShownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadShownBtn.Location = new System.Drawing.Point(877, 327);
            this.DownloadShownBtn.Name = "DownloadShownBtn";
            this.DownloadShownBtn.Size = new System.Drawing.Size(123, 28);
            this.DownloadShownBtn.TabIndex = 10;
            this.DownloadShownBtn.Text = "Download All";
            this.DownloadShownBtn.UseVisualStyleBackColor = true;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.Location = new System.Drawing.Point(877, 259);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(123, 28);
            this.DownloadBtn.TabIndex = 12;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            // 
            // DownloadAllResultBtn
            // 
            this.DownloadAllResultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadAllResultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadAllResultBtn.Location = new System.Drawing.Point(877, 361);
            this.DownloadAllResultBtn.Name = "DownloadAllResultBtn";
            this.DownloadAllResultBtn.Size = new System.Drawing.Size(123, 28);
            this.DownloadAllResultBtn.TabIndex = 13;
            this.DownloadAllResultBtn.Text = "Download All List";
            this.DownloadAllResultBtn.UseVisualStyleBackColor = true;
            // 
            // SkipPageBtn
            // 
            this.SkipPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SkipPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipPageBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SkipPageBtn.Location = new System.Drawing.Point(797, 6);
            this.SkipPageBtn.Name = "SkipPageBtn";
            this.SkipPageBtn.Size = new System.Drawing.Size(40, 30);
            this.SkipPageBtn.TabIndex = 14;
            this.SkipPageBtn.Text = "Go!";
            this.SkipPageBtn.UseVisualStyleBackColor = true;
            this.SkipPageBtn.Click += new System.EventHandler(this.SkipPageBtn_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(877, 177);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 28);
            this.button9.TabIndex = 15;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            // 
            // MarkDownloadBtn
            // 
            this.MarkDownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkDownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkDownloadBtn.Location = new System.Drawing.Point(877, 293);
            this.MarkDownloadBtn.Name = "MarkDownloadBtn";
            this.MarkDownloadBtn.Size = new System.Drawing.Size(123, 28);
            this.MarkDownloadBtn.TabIndex = 16;
            this.MarkDownloadBtn.Text = "Download Marks";
            this.MarkDownloadBtn.UseVisualStyleBackColor = true;
            // 
            // MarkListBtn
            // 
            this.MarkListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkListBtn.Location = new System.Drawing.Point(877, 75);
            this.MarkListBtn.Name = "MarkListBtn";
            this.MarkListBtn.Size = new System.Drawing.Size(123, 28);
            this.MarkListBtn.TabIndex = 17;
            this.MarkListBtn.Text = "View Mark List";
            this.MarkListBtn.UseVisualStyleBackColor = true;
            // 
            // MarkBtn
            // 
            this.MarkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkBtn.Location = new System.Drawing.Point(877, 41);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(123, 28);
            this.MarkBtn.TabIndex = 18;
            this.MarkBtn.Text = "Mark Selected";
            this.MarkBtn.UseVisualStyleBackColor = true;
            this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(877, 109);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 28);
            this.button13.TabIndex = 19;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // Container
            // 
            this.Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(12, 42);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(859, 507);
            this.Container.TabIndex = 20;
            // 
            // AttributeList
            // 
            this.AttributeList.Controls.Add(this.IsNSFWCheck);
            this.AttributeList.Location = new System.Drawing.Point(430, 6);
            this.AttributeList.Name = "AttributeList";
            this.AttributeList.Size = new System.Drawing.Size(233, 30);
            this.AttributeList.TabIndex = 21;
            this.AttributeList.WrapContents = false;
            // 
            // IsNSFWCheck
            // 
            this.IsNSFWCheck.AutoSize = true;
            this.IsNSFWCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsNSFWCheck.Location = new System.Drawing.Point(3, 3);
            this.IsNSFWCheck.Name = "IsNSFWCheck";
            this.IsNSFWCheck.Size = new System.Drawing.Size(65, 23);
            this.IsNSFWCheck.TabIndex = 0;
            this.IsNSFWCheck.Text = "NSFW";
            this.IsNSFWCheck.UseVisualStyleBackColor = true;
            this.IsNSFWCheck.CheckedChanged += new System.EventHandler(this.IsNSFWCheck_CheckedChanged);
            // 
            // IsPNGCheck
            // 
            this.IsPNGCheck.AutoSize = true;
            this.IsPNGCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsPNGCheck.Location = new System.Drawing.Point(878, 211);
            this.IsPNGCheck.Name = "IsPNGCheck";
            this.IsPNGCheck.Size = new System.Drawing.Size(122, 42);
            this.IsPNGCheck.TabIndex = 1;
            this.IsPNGCheck.Text = "Download PNG\r\n(If have)";
            this.IsPNGCheck.UseVisualStyleBackColor = true;
            // 
            // PageNumber
            // 
            this.PageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageNumber.Location = new System.Drawing.Point(703, 7);
            this.PageNumber.Name = "PageNumber";
            this.PageNumber.Size = new System.Drawing.Size(88, 28);
            this.PageNumber.TabIndex = 22;
            this.PageNumber.TextChanged += new System.EventHandler(this.PageNumber_TextChanged);
            // 
            // InfoMessage
            // 
            this.InfoMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoMessage.Location = new System.Drawing.Point(878, 6);
            this.InfoMessage.Name = "InfoMessage";
            this.InfoMessage.Size = new System.Drawing.Size(122, 30);
            this.InfoMessage.TabIndex = 23;
            this.InfoMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoMessage.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.InfoMessage);
            this.Controls.Add(this.PageNumber);
            this.Controls.Add(this.AttributeList);
            this.Controls.Add(this.IsPNGCheck);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.MarkBtn);
            this.Controls.Add(this.MarkListBtn);
            this.Controls.Add(this.MarkDownloadBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.SkipPageBtn);
            this.Controls.Add(this.DownloadAllResultBtn);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.DownloadShownBtn);
            this.Controls.Add(this.SelectAllBtn);
            this.Controls.Add(this.NextPageBtn);
            this.Controls.Add(this.PrePageBtn);
            this.Controls.Add(this.SelectTags);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SearchBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "Mark";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AttributeList.ResumeLayout(false);
            this.AttributeList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.ComboBox SelectTags;
        private System.Windows.Forms.Button PrePageBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Button SelectAllBtn;
        private System.Windows.Forms.Button DownloadShownBtn;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Button DownloadAllResultBtn;
        private System.Windows.Forms.Button SkipPageBtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button MarkDownloadBtn;
        private System.Windows.Forms.Button MarkListBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.Button button13;
        private Components.ImageContainer ImageContainer;
        private Components.ImageContainer MainContainer;
        private Components.ImageContainer Container;
        private System.Windows.Forms.FlowLayoutPanel AttributeList;
        private System.Windows.Forms.CheckBox IsNSFWCheck;
        private System.Windows.Forms.CheckBox IsPNGCheck;
        private System.Windows.Forms.TextBox PageNumber;
        private System.Windows.Forms.Label InfoMessage;
    }
}

