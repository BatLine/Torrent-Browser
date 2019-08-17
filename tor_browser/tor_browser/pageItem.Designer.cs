namespace tor_browser
{
    partial class pageItem
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbHealth = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblRatio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sepDownloadButton = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCategory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUploaded = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSize = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIsTrustedLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIsTrusted = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlRatio = new System.Windows.Forms.Panel();
            this.btnDownload = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tmrMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.pnlRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 4);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(5, 40);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // pbHealth
            // 
            this.pbHealth.BackColor = System.Drawing.Color.Silver;
            this.pbHealth.BorderRadius = 5;
            this.pbHealth.Location = new System.Drawing.Point(14, 4);
            this.pbHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHealth.MaximumValue = 100;
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.ProgressColor = System.Drawing.Color.Red;
            this.pbHealth.Size = new System.Drawing.Size(102, 40);
            this.pbHealth.TabIndex = 2;
            this.pbHealth.Value = 0;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(118, 16);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(36, 17);
            this.lblRatio.TabIndex = 3;
            this.lblRatio.Text = "0.00";
            // 
            // sepDownloadButton
            // 
            this.sepDownloadButton.BackColor = System.Drawing.Color.Transparent;
            this.sepDownloadButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.sepDownloadButton.LineThickness = 1;
            this.sepDownloadButton.Location = new System.Drawing.Point(198, 5);
            this.sepDownloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sepDownloadButton.Name = "sepDownloadButton";
            this.sepDownloadButton.Size = new System.Drawing.Size(5, 40);
            this.sepDownloadButton.TabIndex = 4;
            this.sepDownloadButton.Transparency = 255;
            this.sepDownloadButton.Vertical = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category: ";
            this.lblCategory.Click += new System.EventHandler(this.LblCategory_Click);
            // 
            // lblUploaded
            // 
            this.lblUploaded.AutoSize = true;
            this.lblUploaded.Location = new System.Drawing.Point(144, 3);
            this.lblUploaded.Name = "lblUploaded";
            this.lblUploaded.Size = new System.Drawing.Size(77, 17);
            this.lblUploaded.TabIndex = 7;
            this.lblUploaded.Text = "Uploaded: ";
            this.lblUploaded.Click += new System.EventHandler(this.LblUploaded_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(227, 3);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 17);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size: ";
            this.lblSize.Click += new System.EventHandler(this.LblSize_Click);
            // 
            // lblIsTrustedLabel
            // 
            this.lblIsTrustedLabel.AutoSize = true;
            this.lblIsTrustedLabel.Location = new System.Drawing.Point(276, 3);
            this.lblIsTrustedLabel.Name = "lblIsTrustedLabel";
            this.lblIsTrustedLabel.Size = new System.Drawing.Size(61, 17);
            this.lblIsTrustedLabel.TabIndex = 9;
            this.lblIsTrustedLabel.Text = "Trusted:";
            this.lblIsTrustedLabel.Click += new System.EventHandler(this.LblIsTrustedLabel_Click);
            // 
            // lblIsTrusted
            // 
            this.lblIsTrusted.AutoSize = true;
            this.lblIsTrusted.Location = new System.Drawing.Point(343, 3);
            this.lblIsTrusted.Name = "lblIsTrusted";
            this.lblIsTrusted.Size = new System.Drawing.Size(26, 17);
            this.lblIsTrusted.TabIndex = 10;
            this.lblIsTrusted.Text = "No";
            this.lblIsTrusted.Click += new System.EventHandler(this.LblIsTrusted_Click);
            // 
            // pnlRatio
            // 
            this.pnlRatio.BackColor = System.Drawing.Color.Transparent;
            this.pnlRatio.Controls.Add(this.sepDownloadButton);
            this.pnlRatio.Controls.Add(this.btnDownload);
            this.pnlRatio.Controls.Add(this.bunifuSeparator1);
            this.pnlRatio.Controls.Add(this.pbHealth);
            this.pnlRatio.Controls.Add(this.lblRatio);
            this.pnlRatio.Location = new System.Drawing.Point(465, 0);
            this.pnlRatio.Name = "pnlRatio";
            this.pnlRatio.Size = new System.Drawing.Size(258, 48);
            this.pnlRatio.TabIndex = 11;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.Image = global::tor_browser.Properties.Resources.magnet;
            this.btnDownload.ImageActive = null;
            this.btnDownload.Location = new System.Drawing.Point(210, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(41, 41);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDownload.TabIndex = 5;
            this.btnDownload.TabStop = false;
            this.btnDownload.Zoom = 10;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblCategory);
            this.pnlInfo.Controls.Add(this.lblUploaded);
            this.pnlInfo.Controls.Add(this.lblSize);
            this.pnlInfo.Controls.Add(this.lblIsTrusted);
            this.pnlInfo.Controls.Add(this.lblIsTrustedLabel);
            this.pnlInfo.Location = new System.Drawing.Point(0, 24);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(505, 24);
            this.pnlInfo.TabIndex = 12;
            this.pnlInfo.MouseLeave += new System.EventHandler(this.PnlInfo_MouseLeave);
            this.pnlInfo.MouseHover += new System.EventHandler(this.PnlInfo_MouseHover);
            // 
            // tmrMoveLeft
            // 
            this.tmrMoveLeft.Interval = 5;
            this.tmrMoveLeft.Tick += new System.EventHandler(this.TmrMoveLeft_Tick);
            // 
            // pageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRatio);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlInfo);
            this.Name = "pageItem";
            this.Size = new System.Drawing.Size(723, 48);
            this.Load += new System.EventHandler(this.PageItem_Load);
            this.pnlRatio.ResumeLayout(false);
            this.pnlRatio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuProgressBar pbHealth;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRatio;
        private Bunifu.Framework.UI.BunifuImageButton btnDownload;
        private Bunifu.Framework.UI.BunifuSeparator sepDownloadButton;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIsTrusted;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIsTrustedLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSize;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUploaded;
        private System.Windows.Forms.Panel pnlRatio;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Timer tmrMoveLeft;
    }
}
