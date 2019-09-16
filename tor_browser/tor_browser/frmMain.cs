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
using System.IO;

namespace tor_browser
{
    public partial class frmMain : Form
    {
        frmSearchResults sr = new frmSearchResults();
        string version = "2.1";
        string programURL = "https://dl.dropbox.com/s/f0qjyvj2qzx14vs/tor_browser.exe?dl=0";
        double currentSearchTime = 0;

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
                Properties.Settings.Default.Save();
            } else { MessageBox.Show("Invalid query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        async void search(string searchname, string category, int searchPage)
        {
            if (pnlDelayed.Visible) { pnlDelayed.Visible = false; }
            circle_progressbar cp = new circle_progressbar();
            Control c = cp;
            c.Size = btnSearch.Size;
            c.Location = btnSearch.Location;
            btnSearch.Visible = false;
            c.Name = "loading";
            Controls.Add(c);
            txtSearchname.Enabled = false;
            currentSearchTime = 0;
            tmrTime.Start();
            
            await Task.Run(() => SearchTorrents(searchname, category, searchPage));

            this.Visible = true;
            tmrTime.Stop();
            if (pnlDelayed.Visible) { pnlDelayed.Visible = false; }
            Controls.Remove(c);
            c.Dispose();
            btnSearch.Visible = true;
            txtSearchname.Enabled = true;
        }
        void SearchTorrents(string searchname, string category, int searchPage)
        {
            int intRetryCounter = 0;
            startSearch:
            try
            {
                Query q = new Query(searchname.Trim(), searchPage, getTorrentCategory(category));
                Debug.WriteLine("URL: " + q.TranslateToUrl());
                writeToLog(DateTime.Now + ": Searching for torrent at: '" + q.TranslateToUrl() + "'");
                sr = new frmSearchResults(Tpb.Search(q).ToList());
                BeginInvoke((MethodInvoker)delegate () {
                    if (pnlDelayed.Visible) { pnlDelayed.Visible = false; }
                    this.Visible = false;
                    writeToLog("     Searching took " + currentSearchTime + " ms.");
                });
                sr.ShowDialog();
            } catch (WebException e)
            {
                intRetryCounter++;
                if (intRetryCounter < 3)
                {
                    BeginInvoke((MethodInvoker)delegate () { if (!pnlDelayed.Visible) { pnlDelayed.Visible = true; } });
                    goto startSearch;
                }
                writeToLog(Environment.NewLine + DateTime.Now + ":" + Environment.NewLine + "Network error while searching for torrent: " + Environment.NewLine + e.ToString() + Environment.NewLine);
                MessageBox.Show("Network error. " + Environment.NewLine + "Retrying 3 times failed." + Environment.NewLine + "Check the log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BeginInvoke((MethodInvoker)delegate () { if (pnlDelayed.Visible) { pnlDelayed.Visible = false; } });
            } catch (Exception ee)
            {
                writeToLog(Environment.NewLine + DateTime.Now + ":" + Environment.NewLine + "System error while searching for torrent: " + Environment.NewLine + ee.ToString() + Environment.NewLine);
                MessageBox.Show("System error. " + Environment.NewLine + "Check the log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BeginInvoke((MethodInvoker)delegate () { if (pnlDelayed.Visible) { pnlDelayed.Visible = false; } });
            }
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text += version;
            lblVersion.Location = new Point(this.Width - 12 - lblVersion.Width, lblVersion.Location.Y);
        }

        private void TmrTime_Tick(object sender, EventArgs e)
        {
            currentSearchTime += 100;
            if (currentSearchTime >= 8000)
            {
                BeginInvoke((MethodInvoker)delegate () { if (!pnlDelayed.Visible) { pnlDelayed.Visible = true; } });
                tmrTime.Stop();
            }
        }

        void writeToLog(string text)
        {
            string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (!File.Exists("log.txt")) { try { File.AppendAllText("log.txt", "=== Torrent Browser Log ===" + Environment.NewLine + "=== Created at " + DateTime.Now + " ===" + Environment.NewLine + Environment.NewLine); } catch (Exception) { } }
            try { File.AppendAllLines("log.txt", lines); } catch (Exception) { }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("This will try to update the application." + Environment.NewLine + "Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.No) { return; }
            else if (d == DialogResult.Yes)
            {
                byte[] bte = new System.Net.WebClient().DownloadData(programURL);
                UpdateSelf(bte);
            }
            else { return; }
        }

        public static void UpdateSelf(byte[] buffer)
        {
            var self = System.Reflection.Assembly.GetExecutingAssembly().Location;

            if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                File.WriteAllBytes(self, buffer);

                Process.Start(self);

                // Sleep for half a second to avoid an exception
                System.Threading.Thread.Sleep(500);
                Environment.Exit(0);
            } else
            {
                var selfFileName = Path.GetFileName(self);
                var selfWithoutExt = Path.Combine(Path.GetDirectoryName(self),
                                            Path.GetFileNameWithoutExtension(self));
                File.WriteAllBytes(selfWithoutExt + "Update.exe", buffer);

                using (var batFile = new StreamWriter(File.Create(selfWithoutExt + "Update.bat")))
                {
                    batFile.WriteLine("@ECHO OFF");
                    batFile.WriteLine("TIMEOUT /t 1 /nobreak > NUL");
                    batFile.WriteLine("TASKKILL /IM \"{0}\" > NUL", selfFileName);
                    batFile.WriteLine("MOVE \"{0}\" \"{1}\"", selfWithoutExt + "Update.exe", self);
                    batFile.WriteLine("DEL \"%~f0\" & START \"\" /B \"{0}\"", self);
                }

                ProcessStartInfo startInfo = new ProcessStartInfo(selfWithoutExt + "Update.bat");
                // Hide the terminal window
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.WorkingDirectory = Path.GetDirectoryName(self);
                Process.Start(startInfo);

                Environment.Exit(0);
            }
        }
    }
}