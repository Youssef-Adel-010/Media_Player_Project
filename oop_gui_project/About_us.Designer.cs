namespace DesignTest
{
    partial class About_us_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_us_screen));
            this.YoutubeDownloadPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // YoutubeDownloadPanel
            // 
            this.YoutubeDownloadPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YoutubeDownloadPanel.BackgroundImage")));
            this.YoutubeDownloadPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YoutubeDownloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YoutubeDownloadPanel.ForeColor = System.Drawing.Color.Silver;
            this.YoutubeDownloadPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.YoutubeDownloadPanel.GradientBottomRight = System.Drawing.Color.Blue;
            this.YoutubeDownloadPanel.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.YoutubeDownloadPanel.GradientTopRight = System.Drawing.Color.Aqua;
            this.YoutubeDownloadPanel.Location = new System.Drawing.Point(0, 0);
            this.YoutubeDownloadPanel.Name = "YoutubeDownloadPanel";
            this.YoutubeDownloadPanel.Quality = 10;
            this.YoutubeDownloadPanel.Size = new System.Drawing.Size(640, 443);
            this.YoutubeDownloadPanel.TabIndex = 14;
            // 
            // About_us_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YoutubeDownloadPanel);
            this.Name = "About_us_screen";
            this.Size = new System.Drawing.Size(640, 443);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel YoutubeDownloadPanel;
    }
}
