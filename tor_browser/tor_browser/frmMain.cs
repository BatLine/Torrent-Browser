using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Pirate_Bay;

namespace tor_browser
{
    public partial class frmMain : Form
    {
        frmSearchResults sr = new frmSearchResults();
        public frmMain()
        { InitializeComponent(); fillTypes(); txtSearchname.Text = Properties.Settings.Default.searchQuery; }
        private void fillTypes()
        {
            cboTypes.Items.Add("All");
            cboTypes.Items.Add("Applications");
            cboTypes.Items.Add("Audio");
            cboTypes.Items.Add("Games");
            cboTypes.Items.Add("Porn");
            cboTypes.Items.Add("Videos");
            cboTypes.Items.Add("Other");
            cboTypes.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchname.Text))
            {
                search(txtSearchname.Text, cboTypes.SelectedItem.ToString(), sPage.Value);
                Properties.Settings.Default.searchQuery = txtSearchname.Text;
            } else { MessageBox.Show("Invalid query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        async void search(string searchname, string category, int searchPage)
        {
            circle_progressbar cp = new circle_progressbar();
            Control c = cp;
            c.Size = btnSearch.Size;
            c.Location = btnSearch.Location;
            btnSearch.Visible = false;
            c.Name = "loading";
            Controls.Add(c);

            await Task.Run(() => SearchTorrents(searchname, category, searchPage));

            Controls.Remove(c);
            c.Dispose();
            btnSearch.Visible = true;
        }
        void SearchTorrents(string searchname, string category, int searchPage)
        {
            try
            {
                Query q = new Query(searchname.Trim(), searchPage, getTorrentCategory(category));
                Debug.WriteLine("URL: " + q.TranslateToUrl());
                sr = new frmSearchResults(Tpb.Search(q).ToList()); //sr.displayTorrents(0);
                sr.ShowDialog();
            } catch (WebException e)
            { MessageBox.Show("Network error: " + Environment.NewLine + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SPage_ValueChanged(object sender, EventArgs e)
        { lblPageNumber.Text = (sPage.Value + 1).ToString(); }
        int getTorrentCategory(string s)
        {
            int result;
            switch (s.ToLower())
            {
                case "all": result = TorrentCategory.All; break;
                case "applications": result = TorrentCategory.AllApplication; break;
                case "audio": result = TorrentCategory.AllAudio; break;
                case "games": result = TorrentCategory.AllGames; break;
                case "porn": result = TorrentCategory.AllPorn; break;
                case "videos": result = TorrentCategory.AllVideo; break;
                case "other": result = TorrentCategory.AllOther; break;
                default: result = TorrentCategory.All; break;
            }
            return result;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        { Application.Exit(); }
    }
}