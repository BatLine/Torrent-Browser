using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Pirate_Bay;

namespace tor_browser
{
    public partial class frmSearchResults : Form
    {
        public List<Torrent> torrents;
        pages p;

        public frmSearchResults()
        { InitializeComponent(); }
        public frmSearchResults(List<Torrent> t) : this()
        { torrents = t; }

        private void FrmSearchResults_Load(object sender, EventArgs e)
        { displayTorrents(0); }

        async void displayTorrents(int page)
        {
            System.Threading.Thread.Sleep(1000);
            pnlItems.Controls.Clear();

            p = new pages(torrents);
            int lastYCordItem = 0;
            if ((page > p._pages.Count) || (p._pages.Count == 0))
            { MessageBox.Show("No torrents found on this page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); return; }
            List<Control> listItems = new List<Control>();
            foreach (pageItem pi in p._pages[page].items)
            {
                Control c = pi;
                c.Size = pi.Size;
                c.Location = new Point((pnlItems.Width / 2) - (c.Width / 2), lastYCordItem + pi.Height + 20);
                if (lastYCordItem <= 0) { c.Location = new Point(c.Location.X, 1); }
                lastYCordItem = c.Location.Y;
                c.Name = pi.name;
                c.Visible = false;
                pnlItems.Controls.Add(c);
                pnlItems.Height = lastYCordItem + pi.Height;
                listItems.Add(c);
            }

            if (p._pages.Count < 1) { btnPage1.Enabled = false; btnPage2.Enabled = false; }
            else if (p._pages.Count == 1) { btnPage2.Enabled = false; btnPage1.Enabled = true; }
            else { btnPage1.Enabled = true; btnPage2.Enabled = true; }
            pnlPages.Visible = false;
            await Task.Run(() => displayTorrents(listItems));
        }
        void displayTorrents(List<Control> cs)
        {
            foreach (Control c in cs)
            {
                bunifuTransition1.ShowSync(c);
                Thread.Sleep(5);
            }
            BeginInvoke((MethodInvoker)delegate ()
            {
                pnlPages.Location = new Point(this.Width / 2 - pnlPages.Width / 2, pnlItems.Location.X + pnlItems.Height + 60);
                this.Size = new Size(this.Width, this.Height + pnlPages.Height + 10);
                this.CenterToScreen();
                pnlPages.Visible = true;
            });
        }
        private void BtnPage1_Click(object sender, EventArgs e)
        { displayTorrents(0); }

        private void BtnPage2_Click(object sender, EventArgs e)
        { displayTorrents(1); }

        private void BtnClose_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
