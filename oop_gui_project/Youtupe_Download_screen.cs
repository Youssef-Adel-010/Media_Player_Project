using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using DesignTest;
using System.IO;
using System.Threading;

namespace DesignTest
{
    public partial class Youtube_Download_screen : UserControl
    {
        public Youtube_Download_screen()
        {
            InitializeComponent();
            ResDropDown.SelectedIndex = 0;
        }
        private void DownloadBut_Click_1(object sender, EventArgs e)
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txturl.Text);

            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(ResDropDown.Text));

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            VideoDownloader D = new VideoDownloader(video, Path.Combine(PathTxt.Text + "\\", video.Title + video.VideoExtension));

            int Downloader_DownLoadProgressChanged = 0;

            D.DownloadProgressChanged += Downloader_DownloadProgressChanged;

            Thread thread = new Thread(() => { D.Execute(); }) { IsBackground = true };

            thread.Start();
        }
        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                ProgBar.Value = (int)e.ProgressPercentage;

                PerLabel.Text = string.Format("{0:0.##}", e.ProgressPercentage) + " %";

                ProgBar.Update();
            }
          ));
        }

    }
}
