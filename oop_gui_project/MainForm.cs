using DesignTest;
using System;
using System.Windows.Forms;

namespace oop_gui_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////
        // Here We Will Code The Title Bar Buttons.
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


        ///////////////////////////////////////////////////////////////////
        // Left-Side Buttons.

        private void AddUserControl(UserControl user)
        {
            // This Base Function Adds User Controls, And Display The Screen at The Top.

            user.Dock = DockStyle.Fill;
            Container.Controls.Clear();
            Container.Controls.Add(user);
            user.BringToFront();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Base_screen base_scr = new Base_screen();
            AddUserControl(base_scr);
        }

        private void PlayListBtn_Click(object sender, EventArgs e)
        {
            PlayList_screen playlist_scr = new PlayList_screen();
            AddUserControl(playlist_scr);
        }
        private void NowPlayingBtn_Click(object sender, EventArgs e)
        {
            Playing_now_screen now_playing_scr = new Playing_now_screen();
            AddUserControl(now_playing_scr);
        }
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            Youtube_Download_screen yt_download_scr = new Youtube_Download_screen();
            AddUserControl(yt_download_scr);
        }

        private void AboutUsbtn_Click(object sender, EventArgs e)
        {
            About_us about_scr = new About_us();
            AddUserControl(about_scr);
        }

        private void SpeechBtn_Click(object sender, EventArgs e)
        {
            Speech_read_screen speech_scr = new Speech_read_screen();
            AddUserControl(speech_scr);
        }

        private void AudioSlider_ValueChanged(object sender, EventArgs e)
        {
            AudioLabel.Text = AudioSlider.Value.ToString();
        }

        ///////////////////////////////////////////////////////////////////

    }

}

