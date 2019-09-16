namespace tor_browser
{
    partial class frmSearchResults
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchResults));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.btnPage2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnPage1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuTransition1.SetDecoration(this.pnlItems, BunifuAnimatorNS.DecorationType.None);
            this.pnlItems.Location = new System.Drawing.Point(9, 57);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(582, 567);
            this.pnlItems.TabIndex = 4;
            // 
            // pnlPages
            // 
            this.pnlPages.Controls.Add(this.btnPage2);
            this.pnlPages.Controls.Add(this.btnPage1);
            this.bunifuTransition1.SetDecoration(this.pnlPages, BunifuAnimatorNS.DecorationType.None);
            this.pnlPages.Location = new System.Drawing.Point(166, 11);
            this.pnlPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(126, 69);
            this.pnlPages.TabIndex = 5;
            // 
            // btnPage2
            // 
            this.btnPage2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnPage2, BunifuAnimatorNS.DecorationType.None);
            this.btnPage2.Image = global::tor_browser.Properties.Resources._2;
            this.btnPage2.ImageActive = null;
            this.btnPage2.Location = new System.Drawing.Point(67, 7);
            this.btnPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPage2.Name = "btnPage2";
            this.btnPage2.Size = new System.Drawing.Size(48, 52);
            this.btnPage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPage2.TabIndex = 1;
            this.btnPage2.TabStop = false;
            this.btnPage2.Zoom = 15;
            this.btnPage2.Click += new System.EventHandler(this.BtnPage2_Click);
            // 
            // btnPage1
            // 
            this.btnPage1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnPage1, BunifuAnimatorNS.DecorationType.None);
            this.btnPage1.Image = global::tor_browser.Properties.Resources._1;
            this.btnPage1.ImageActive = null;
            this.btnPage1.Location = new System.Drawing.Point(15, 7);
            this.btnPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPage1.Name = "btnPage1";
            this.btnPage1.Size = new System.Drawing.Size(48, 52);
            this.btnPage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPage1.TabIndex = 0;
            this.btnPage1.TabStop = false;
            this.btnPage1.Zoom = 15;
            this.btnPage1.Click += new System.EventHandler(this.BtnPage1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::tor_browser.Properties.Resources.close;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(550, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 52);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-2, 51);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(600, 3);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 7);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(137, 20);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Torrent Browser";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.MaxAnimationTime = 200;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 636);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlItems);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchResults";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Results";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSearchResults_Load);
            this.pnlPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlPages;
        private Bunifu.Framework.UI.BunifuImageButton btnPage2;
        private Bunifu.Framework.UI.BunifuImageButton btnPage1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}