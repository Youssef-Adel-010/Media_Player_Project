using DesignTest;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace oop_gui_project
{
    public partial class MainForm : Form
    {

        /// Global declarations of all screens.
        public Base_screen base_scr = new Base_screen();
        public Player player = new Player();
        public Youtube_download_screen yt_download_scr = new Youtube_download_screen();
        public About_us_screen about_scr = new About_us_screen();
        public Speech_read_screen speech_scr = new Speech_read_screen();

        public MainForm()
        {
            InitializeComponent();
        }


        /// Title-Bar Buttons.
        public void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// Playlist

        private List<media> playlist = new List<media>();
        private int start_index = 0;

        public void PlayFile(int idx)
        {
            player.PlayFile(playlist[idx]);
            AddUserControl(player);
            string songName = playlist[idx].name();
            for (int i = songName.Length - 1; i >= 0; i--)
            {
                // Remove file types (.mp4, .mov, etc..).
                if (songName[i] != '.') continue;
                songName = songName.Substring(0, i);
                break;
            }
            SongNameLabel.Text = songName;
        }
        private void PlaylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            start_index = PlaylistBox.SelectedIndex;
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            PlayFile(start_index);
        }

        /// Left-Side Buttons.

        private void AddUserControl(UserControl user)
        {
            // This base function adds user controls, and displays the screen at the top.
            
            user.Dock = DockStyle.Fill;
            Container.Controls.Clear();
            Container.Controls.Add(user);
            user.BringToFront();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(base_scr);
        }

        private void PlayListBtn_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            Container.Controls.Add(PlaylistBox);
            Container.Controls.Add(PlayBtn);
            PlaylistBox.BringToFront();
            PlayBtn.BringToFront();
        }
        private void NowPlayingBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(player);
        }
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(yt_download_scr);
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(about_scr);
        }

        private void SpeechBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(speech_scr);
        }

        private void AudioSlider_ValueChanged(object sender, EventArgs e)
        {
            AudioLabel.Text = AudioSlider.Value.ToString();
        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            // add new media to playlist and plays the first one.

            start_index = playlist.Count;
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Select Media";
            OpenFile.Multiselect = true;
            OpenFile.Filter = "(mp3, wav, mp4, mov, wmv, mpg, avi, 3gp, flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;.mpg|all files|*.*";
            if (OpenFile.ShowDialog() != DialogResult.OK)
            {
                start_index--;
                return;
            }
            string[] FileName = OpenFile.SafeFileNames;
            string[] FilePath = OpenFile.FileNames;
            for (int i = 0; i < FileName.Length; i++)
            {
                media current = new media(FileName[i], FilePath[i]);
                playlist.Add(current);
                PlaylistBox.Items.Add(FileName[i]);
            }
            PlayFile(start_index);
        }

    }
}

