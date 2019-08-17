using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tor_browser
{
    public partial class pageItem : UserControl
    {
        public string name;
        public double health;
        public string category;
        public bool isTrusted;
        public string size;
        public string magnet;
        public string uploaded;
        public  string strHealth;
        int yLocPanel = 24;
        bool oneLapDone = false;
        bool halfLapDone = false;
        bool mouseLeft = false;

        public pageItem()
        { InitializeComponent(); }

        void setForm()
        {
            lblName.Text = name;
            pbHealth.Value = Convert.ToInt16(health * 100);
            if (pbHealth.Value <= 50) { pbHealth.ProgressColor = Color.Red; }
            else if (pbHealth.Value > 70) { pbHealth.ProgressColor = Color.Green; }
            else { pbHealth.ProgressColor = Color.Orange; }
            lblRatio.Text = strHealth;
            if (health >= 1) { lblRatio.ForeColor = Color.Green; }
            else if (health >= 0.5) { lblRatio.ForeColor = Color.Orange; }
            else { lblRatio.ForeColor = Color.Red; }
            lblCategory.Text += category;
            lblSize.Text += size;
            lblUploaded.Text += uploaded;
            if (isTrusted) { lblIsTrusted.Text = "Yes"; lblIsTrusted.ForeColor = Color.Green; }
            else { lblIsTrusted.Text = "No"; lblIsTrusted.ForeColor = Color.Orange; }

            if (pnlRatio.Width <= lblRatio.Location.X + lblRatio.Width)
            {
                pnlRatio.Size = new Size(lblRatio.Location.X + lblRatio.Width + 3, pnlRatio.Height);
                pnlRatio.Location = new Point(sepDownloadButton.Location.X - 5 - pnlRatio.Width , pnlRatio.Location.Y);
            }

            lblSize.Location = new Point(lblCategory.Location.X + lblCategory.Width + 10, lblCategory.Location.Y);
            lblUploaded.Location = new Point(lblSize.Location.X + lblSize.Width + 10, lblCategory.Location.Y);
            lblIsTrustedLabel.Location = new Point(lblUploaded.Location.X + lblUploaded.Width + 10, lblCategory.Location.Y);
            lblIsTrusted.Location = new Point(lblIsTrustedLabel.Location.X + lblIsTrustedLabel.Width - 5, lblCategory.Location.Y);
        }

        private void PageItem_Load(object sender, EventArgs e)
        { setForm(); this.Focus(); }

        private void BtnDownload_Click(object sender, EventArgs e)
        { System.Diagnostics.Process.Start(magnet); }

        private void PnlInfo_MouseHover(object sender, EventArgs e)
        {
            int x = lblIsTrusted.Location.X + lblIsTrusted.Width;
            System.Diagnostics.Debug.WriteLine(x);
            mouseLeft = false;
            if (x >= 355)
            {
                yLocPanel = pnlInfo.Location.Y;
                tmrMoveLeft.Start();
            }
        }

        private void TmrMoveLeft_Tick(object sender, EventArgs e)
        {
            pnlInfo.Location = new Point(pnlInfo.Location.X - 1, pnlInfo.Location.Y);
            int x = pnlInfo.Location.X + pnlInfo.Width;
            if ((pnlInfo.Location.X <= 0) && halfLapDone) { oneLapDone = true; }
            if (mouseLeft && oneLapDone) { pnlInfo.Location = new Point(0, 20); oneLapDone = false; halfLapDone = false; tmrMoveLeft.Stop(); return; }
            if (x <= 20)
            {
                pnlInfo.Location = new Point(pnlRatio.Location.X, pnlInfo.Location.Y); halfLapDone = true;
            }
        }

        private void PnlInfo_MouseLeave(object sender, EventArgs e)
        {
            if (oneLapDone)
            {
                tmrMoveLeft.Stop();
                pnlInfo.Location = new Point(0, 20);
                oneLapDone = false;
            }
            mouseLeft = true;
        }

        private void LblCategory_Click(object sender, EventArgs e)
        { PnlInfo_MouseHover(sender, e); }
        private void LblUploaded_Click(object sender, EventArgs e)
        { PnlInfo_MouseHover(sender, e); }
        private void LblSize_Click(object sender, EventArgs e)
        { PnlInfo_MouseHover(sender, e); }
        private void LblIsTrustedLabel_Click(object sender, EventArgs e)
        { PnlInfo_MouseHover(sender, e); }
        private void LblIsTrusted_Click(object sender, EventArgs e)
        { PnlInfo_MouseHover(sender, e); }
    }
}
