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
        private List<media> shuffledList = new List<media>();
        bool _playing = false;
        int _looping = 0;
        bool _shuffled = false;
        private int play_index = -1;

        private void PlaylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            play_index = PlaylistBox.SelectedIndex;
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            PlayFile(ref play_index);
        }

        private void Shuffle()
        {
            if (playlist.Count == 0) return;
            shuffledList.Clear();
            List<media> temp = new List<media>();
            for (int i = 0; i < playlist.Count; i++) temp.Add(playlist[i]);
            Random rnd = new Random();
            while (temp.Count > 0)
            {
                int rand = rnd.Next(0, temp.Count);
                shuffledList.Add(temp[rand]);
                temp.RemoveAt(rand);
            }
        }

        /// Player

        private void ShowPlayer()
        {
            Container.Controls.Clear();
            Container.Controls.Add(MediaPlayer);
            MediaPlayer.BringToFront();
        }

        public void Play()
        {
            MediaPlayer.Ctlcontrols.play();
            PlayPauseBtn.Image = DesignTest.Properties.Resources.pause_50px;
            _playing = true;
        }

        public void Pause()
        {
            MediaPlayer.Ctlcontrols.pause();
            PlayPauseBtn.Image = DesignTest.Properties.Resources.play_50px;
            _playing = false;
        }

        public void PlayFile(media media)
        {
            SongNameLabel.Text = media.name();
            MediaPlayer.URL = media.path();
            MediaPlayer.settings.autoStart = true;
            MediaPlayer.Ctlcontrols.next();
            Play();
            ShowPlayer();
        }

        public void PlayFile(ref int idx)
        {
            if (idx < 0 && _looping != 2) {
                idx = 0;
            }
            else if (idx < 0) 
            {
                idx = playlist.Count - 1;
            }
            if (idx >= playlist.Count)
            {
                if (_looping != 2) idx = playlist.Count - 1;
                else if (_looping == 0) return;
                else idx = 0;
            }
            if (_shuffled && shuffledList.Count != playlist.Count)
            {
                Shuffle();
            }
            if (_shuffled) PlayFile(shuffledList[idx]);
            else PlayFile(playlist[idx]);
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
            ShowPlayer();
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
            MediaPlayer.settings.volume = AudioSlider.Value;
            AudioLabel.Text = AudioSlider.Value.ToString();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            // add new media to playlist and plays the first one.

            play_index = playlist.Count;
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Title = "Select Media";
            OpenFile.Multiselect = true;
            OpenFile.Filter = "(mp3, wav, mp4, mov, wmv, mpg, avi, 3gp, flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;.mpg|all files|*.*";
            if (OpenFile.ShowDialog() != DialogResult.OK)
            {
                play_index--;
                return;
            }
            string[] FileName = OpenFile.SafeFileNames;
            for (int i = 0; i < FileName.Length; i++)
            {
                // Remove file types (.mp4, .mov, etc..) from the name.
                for (int j = FileName[i].Length - 1; j >= 0; j--)
                {
                    if (FileName[i][j] != '.') continue;
                    FileName[i] = FileName[i].Substring(0, j);
                    break;
                }
            }
            string[] FilePath = OpenFile.FileNames;
            for (int i = 0; i < FileName.Length; i++)
            {
                playlist.Add(new media(FileName[i], FilePath[i]));
                PlaylistBox.Items.Add(FileName[i]);
            }
            PlayFile(ref play_index);
        }
        
        /// Bottom Bar Buttons.
        
        private void PlayPauseBtn_Click(object sender, EventArgs e)
        {
            if (_playing) Pause();
            else Play();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (_looping != 1) play_index++;
            PlayFile(ref play_index);
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (_looping != 1) play_index--;
            PlayFile(ref play_index);
        }

        private void LoopBtn_Click(object sender, EventArgs e)
        {
            switch (_looping)
            {
                case 0: 
                    LoopBtn.Image = DesignTest.Properties.Resources.LoopBtn2_Image;
                    break;
                case 1:
                    LoopBtn.Image = DesignTest.Properties.Resources.LoopBtn3_Image;
                    break;
                default:
                    LoopBtn.Image = DesignTest.Properties.Resources.LoopBtn_Image;
                    break;
            }
            _looping = (_looping+1)%3;
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            if (_shuffled)
            {
                ShuffleBtn.Image = DesignTest.Properties.Resources.ShuffleBtn_Image;
                shuffledList.Clear();
            }
            else
            {
                ShuffleBtn.Image = DesignTest.Properties.Resources.ShuffleBtn2_Image;
                Shuffle();
            }
            _shuffled = !_shuffled;
        }

        private void SongProgressBar_progressChanged(object sender,EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                SongProgressBar.Maximum_Value = (int)MediaPlayer.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                SongProgressBar.Value = Math.Min(
                    (int)MediaPlayer.Ctlcontrols.currentPosition,
                    (int)MediaPlayer.Ctlcontrols.currentItem.duration
                    );
                LeftCounterLabel.Text = MediaPlayer.Ctlcontrols.currentPositionString;
                RightCounterLabel.Text = MediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
            }
            if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped && playlist.Count > 0)
            {
                if (play_index == playlist.Count - 1 && _looping != 1) return;
                if (_looping != 1) play_index++;
                PlayFile(ref play_index);
            }
        }

    }
}

 