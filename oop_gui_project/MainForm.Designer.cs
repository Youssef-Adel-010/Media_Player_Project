namespace oop_gui_project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WelcomeScreen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LeftSidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SpeechBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AboutUsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FavoritesBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DownloadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MaxmizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.BrowseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NowPlayingBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlayListBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ControlPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.NextBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PreviousBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayPtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.StopBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PauseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AudioLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AudioSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.SongNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RightCounterLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LeftCounterLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SongProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Container = new System.Windows.Forms.Panel();
            this.base_screen1 = new DesignTest.Base_screen();
            this.PlaylistBox = new System.Windows.Forms.ListBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxmizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBtn)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).BeginInit();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeScreen
            // 
            this.WelcomeScreen.ElipseRadius = 5;
            this.WelcomeScreen.TargetControl = this;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftSidePanel.BackgroundImage")));
            this.LeftSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftSidePanel.Controls.Add(this.SpeechBtn);
            this.LeftSidePanel.Controls.Add(this.Home);
            this.LeftSidePanel.Controls.Add(this.AboutUsbtn);
            this.LeftSidePanel.Controls.Add(this.FavoritesBtn);
            this.LeftSidePanel.Controls.Add(this.MinimizeBtn);
            this.LeftSidePanel.Controls.Add(this.DownloadBtn);
            this.LeftSidePanel.Controls.Add(this.MaxmizeBtn);
            this.LeftSidePanel.Controls.Add(this.CloseBtn);
            this.LeftSidePanel.Controls.Add(this.BrowseBtn);
            this.LeftSidePanel.Controls.Add(this.NowPlayingBtn);
            this.LeftSidePanel.Controls.Add(this.PlayListBtn);
            this.LeftSidePanel.Controls.Add(this.LogoBtn);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.LeftSidePanel.GradientBottomRight = System.Drawing.Color.DeepSkyBlue;
            this.LeftSidePanel.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.LeftSidePanel.GradientTopRight = System.Drawing.Color.DarkViolet;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Quality = 10;
            this.LeftSidePanel.Size = new System.Drawing.Size(180, 550);
            this.LeftSidePanel.TabIndex = 0;
            // 
            // SpeechBtn
            // 
            this.SpeechBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.SpeechBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpeechBtn.BackColor = System.Drawing.Color.Transparent;
            this.SpeechBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpeechBtn.BorderRadius = 0;
            this.SpeechBtn.ButtonText = "Speech Reader";
            this.SpeechBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeechBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SpeechBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeechBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SpeechBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SpeechBtn.Iconimage")));
            this.SpeechBtn.Iconimage_right = null;
            this.SpeechBtn.Iconimage_right_Selected = null;
            this.SpeechBtn.Iconimage_Selected = null;
            this.SpeechBtn.IconMarginLeft = 0;
            this.SpeechBtn.IconMarginRight = 0;
            this.SpeechBtn.IconRightVisible = true;
            this.SpeechBtn.IconRightZoom = 0D;
            this.SpeechBtn.IconVisible = true;
            this.SpeechBtn.IconZoom = 48D;
            this.SpeechBtn.IsTab = false;
            this.SpeechBtn.Location = new System.Drawing.Point(0, 450);
            this.SpeechBtn.Margin = new System.Windows.Forms.Padding(20);
            this.SpeechBtn.Name = "SpeechBtn";
            this.SpeechBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.SpeechBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.SpeechBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SpeechBtn.Padding = new System.Windows.Forms.Padding(20);
            this.SpeechBtn.selected = false;
            this.SpeechBtn.Size = new System.Drawing.Size(180, 50);
            this.SpeechBtn.TabIndex = 12;
            this.SpeechBtn.Text = "Speech Reader";
            this.SpeechBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpeechBtn.Textcolor = System.Drawing.Color.White;
            this.SpeechBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeechBtn.Click += new System.EventHandler(this.SpeechBtn_Click);
            // 
            // Home
            // 
            this.Home.Activecolor = System.Drawing.Color.RoyalBlue;
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.BorderRadius = 0;
            this.Home.ButtonText = "Home";
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.DisabledColor = System.Drawing.Color.Gray;
            this.Home.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Iconcolor = System.Drawing.Color.Transparent;
            this.Home.Iconimage = ((System.Drawing.Image)(resources.GetObject("Home.Iconimage")));
            this.Home.Iconimage_right = null;
            this.Home.Iconimage_right_Selected = null;
            this.Home.Iconimage_Selected = null;
            this.Home.IconMarginLeft = 0;
            this.Home.IconMarginRight = 0;
            this.Home.IconRightVisible = true;
            this.Home.IconRightZoom = 0D;
            this.Home.IconVisible = true;
            this.Home.IconZoom = 48D;
            this.Home.IsTab = false;
            this.Home.Location = new System.Drawing.Point(0, 150);
            this.Home.Margin = new System.Windows.Forms.Padding(20);
            this.Home.Name = "Home";
            this.Home.Normalcolor = System.Drawing.Color.Transparent;
            this.Home.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Home.Padding = new System.Windows.Forms.Padding(20);
            this.Home.selected = false;
            this.Home.Size = new System.Drawing.Size(180, 50);
            this.Home.TabIndex = 10;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.Textcolor = System.Drawing.Color.White;
            this.Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // AboutUsbtn
            // 
            this.AboutUsbtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.AboutUsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutUsbtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutUsbtn.BorderRadius = 0;
            this.AboutUsbtn.ButtonText = "About Us";
            this.AboutUsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.AboutUsbtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.AboutUsbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("AboutUsbtn.Iconimage")));
            this.AboutUsbtn.Iconimage_right = null;
            this.AboutUsbtn.Iconimage_right_Selected = null;
            this.AboutUsbtn.Iconimage_Selected = null;
            this.AboutUsbtn.IconMarginLeft = 0;
            this.AboutUsbtn.IconMarginRight = 0;
            this.AboutUsbtn.IconRightVisible = true;
            this.AboutUsbtn.IconRightZoom = 0D;
            this.AboutUsbtn.IconVisible = true;
            this.AboutUsbtn.IconZoom = 45D;
            this.AboutUsbtn.IsTab = false;
            this.AboutUsbtn.Location = new System.Drawing.Point(0, 500);
            this.AboutUsbtn.Margin = new System.Windows.Forms.Padding(20);
            this.AboutUsbtn.Name = "AboutUsbtn";
            this.AboutUsbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.AboutUsbtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.AboutUsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AboutUsbtn.Padding = new System.Windows.Forms.Padding(20);
            this.AboutUsbtn.selected = false;
            this.AboutUsbtn.Size = new System.Drawing.Size(180, 50);
            this.AboutUsbtn.TabIndex = 9;
            this.AboutUsbtn.Text = "About Us";
            this.AboutUsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutUsbtn.Textcolor = System.Drawing.Color.White;
            this.AboutUsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsbtn.Click += new System.EventHandler(this.AboutUsBtn_Click);
            // 
            // FavoritesBtn
            // 
            this.FavoritesBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.FavoritesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FavoritesBtn.BackColor = System.Drawing.Color.Transparent;
            this.FavoritesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavoritesBtn.BorderRadius = 0;
            this.FavoritesBtn.ButtonText = "Add To Favorites";
            this.FavoritesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoritesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.FavoritesBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoritesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.FavoritesBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("FavoritesBtn.Iconimage")));
            this.FavoritesBtn.Iconimage_right = null;
            this.FavoritesBtn.Iconimage_right_Selected = null;
            this.FavoritesBtn.Iconimage_Selected = null;
            this.FavoritesBtn.IconMarginLeft = 0;
            this.FavoritesBtn.IconMarginRight = 0;
            this.FavoritesBtn.IconRightVisible = true;
            this.FavoritesBtn.IconRightZoom = 0D;
            this.FavoritesBtn.IconVisible = true;
            this.FavoritesBtn.IconZoom = 40D;
            this.FavoritesBtn.IsTab = false;
            this.FavoritesBtn.Location = new System.Drawing.Point(0, 350);
            this.FavoritesBtn.Margin = new System.Windows.Forms.Padding(20);
            this.FavoritesBtn.Name = "FavoritesBtn";
            this.FavoritesBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.FavoritesBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.FavoritesBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.FavoritesBtn.Padding = new System.Windows.Forms.Padding(20);
            this.FavoritesBtn.selected = false;
            this.FavoritesBtn.Size = new System.Drawing.Size(180, 50);
            this.FavoritesBtn.TabIndex = 5;
            this.FavoritesBtn.Text = "Add To Favorites";
            this.FavoritesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FavoritesBtn.Textcolor = System.Drawing.Color.White;
            this.FavoritesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.ImageActive = null;
            this.MinimizeBtn.Location = new System.Drawing.Point(45, 6);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(26, 17);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 8;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Zoom = 10;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.DownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownloadBtn.BorderRadius = 0;
            this.DownloadBtn.ButtonText = "Youtube Download";
            this.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DownloadBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DownloadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.Iconimage")));
            this.DownloadBtn.Iconimage_right = null;
            this.DownloadBtn.Iconimage_right_Selected = null;
            this.DownloadBtn.Iconimage_Selected = null;
            this.DownloadBtn.IconMarginLeft = 0;
            this.DownloadBtn.IconMarginRight = 0;
            this.DownloadBtn.IconRightVisible = true;
            this.DownloadBtn.IconRightZoom = 0D;
            this.DownloadBtn.IconVisible = true;
            this.DownloadBtn.IconZoom = 40D;
            this.DownloadBtn.IsTab = false;
            this.DownloadBtn.Location = new System.Drawing.Point(0, 400);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(20);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.DownloadBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.DownloadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DownloadBtn.Padding = new System.Windows.Forms.Padding(20);
            this.DownloadBtn.selected = false;
            this.DownloadBtn.Size = new System.Drawing.Size(180, 50);
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.Text = "Youtube Download";
            this.DownloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadBtn.Textcolor = System.Drawing.Color.White;
            this.DownloadBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // MaxmizeBtn
            // 
            this.MaxmizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaxmizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MaxmizeBtn.Image")));
            this.MaxmizeBtn.ImageActive = null;
            this.MaxmizeBtn.Location = new System.Drawing.Point(26, 6);
            this.MaxmizeBtn.Name = "MaxmizeBtn";
            this.MaxmizeBtn.Size = new System.Drawing.Size(23, 17);
            this.MaxmizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxmizeBtn.TabIndex = 7;
            this.MaxmizeBtn.TabStop = false;
            this.MaxmizeBtn.Zoom = 10;
            this.MaxmizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(6, 6);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(21, 17);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseBtn.BorderRadius = 0;
            this.BrowseBtn.ButtonText = "Browse";
            this.BrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.BrowseBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.BrowseBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BrowseBtn.Iconimage")));
            this.BrowseBtn.Iconimage_right = null;
            this.BrowseBtn.Iconimage_right_Selected = null;
            this.BrowseBtn.Iconimage_Selected = null;
            this.BrowseBtn.IconMarginLeft = 0;
            this.BrowseBtn.IconMarginRight = 0;
            this.BrowseBtn.IconRightVisible = true;
            this.BrowseBtn.IconRightZoom = 0D;
            this.BrowseBtn.IconVisible = true;
            this.BrowseBtn.IconZoom = 40D;
            this.BrowseBtn.IsTab = false;
            this.BrowseBtn.Location = new System.Drawing.Point(0, 300);
            this.BrowseBtn.Margin = new System.Windows.Forms.Padding(20);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.BrowseBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.BrowseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BrowseBtn.Padding = new System.Windows.Forms.Padding(20);
            this.BrowseBtn.selected = false;
            this.BrowseBtn.Size = new System.Drawing.Size(180, 50);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseBtn.Textcolor = System.Drawing.Color.White;
            this.BrowseBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // NowPlayingBtn
            // 
            this.NowPlayingBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.NowPlayingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NowPlayingBtn.BackColor = System.Drawing.Color.Transparent;
            this.NowPlayingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NowPlayingBtn.BorderRadius = 0;
            this.NowPlayingBtn.ButtonText = "Playing Now";
            this.NowPlayingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NowPlayingBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NowPlayingBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NowPlayingBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("NowPlayingBtn.Iconimage")));
            this.NowPlayingBtn.Iconimage_right = null;
            this.NowPlayingBtn.Iconimage_right_Selected = null;
            this.NowPlayingBtn.Iconimage_Selected = null;
            this.NowPlayingBtn.IconMarginLeft = 0;
            this.NowPlayingBtn.IconMarginRight = 0;
            this.NowPlayingBtn.IconRightVisible = true;
            this.NowPlayingBtn.IconRightZoom = 0D;
            this.NowPlayingBtn.IconVisible = true;
            this.NowPlayingBtn.IconZoom = 40D;
            this.NowPlayingBtn.IsTab = false;
            this.NowPlayingBtn.Location = new System.Drawing.Point(0, 250);
            this.NowPlayingBtn.Margin = new System.Windows.Forms.Padding(20);
            this.NowPlayingBtn.Name = "NowPlayingBtn";
            this.NowPlayingBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.NowPlayingBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.NowPlayingBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NowPlayingBtn.Padding = new System.Windows.Forms.Padding(20);
            this.NowPlayingBtn.selected = false;
            this.NowPlayingBtn.Size = new System.Drawing.Size(180, 50);
            this.NowPlayingBtn.TabIndex = 2;
            this.NowPlayingBtn.Text = "Playing Now";
            this.NowPlayingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NowPlayingBtn.Textcolor = System.Drawing.Color.White;
            this.NowPlayingBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingBtn.Click += new System.EventHandler(this.NowPlayingBtn_Click);
            // 
            // PlayListBtn
            // 
            this.PlayListBtn.Activecolor = System.Drawing.Color.RoyalBlue;
            this.PlayListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayListBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayListBtn.BorderRadius = 0;
            this.PlayListBtn.ButtonText = "Playlist";
            this.PlayListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayListBtn.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.PlayListBtn.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayListBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PlayListBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("PlayListBtn.Iconimage")));
            this.PlayListBtn.Iconimage_right = null;
            this.PlayListBtn.Iconimage_right_Selected = null;
            this.PlayListBtn.Iconimage_Selected = null;
            this.PlayListBtn.IconMarginLeft = 0;
            this.PlayListBtn.IconMarginRight = 0;
            this.PlayListBtn.IconRightVisible = true;
            this.PlayListBtn.IconRightZoom = 0D;
            this.PlayListBtn.IconVisible = true;
            this.PlayListBtn.IconZoom = 40D;
            this.PlayListBtn.IsTab = false;
            this.PlayListBtn.Location = new System.Drawing.Point(0, 200);
            this.PlayListBtn.Margin = new System.Windows.Forms.Padding(20);
            this.PlayListBtn.Name = "PlayListBtn";
            this.PlayListBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.PlayListBtn.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.PlayListBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayListBtn.Padding = new System.Windows.Forms.Padding(20);
            this.PlayListBtn.selected = false;
            this.PlayListBtn.Size = new System.Drawing.Size(180, 50);
            this.PlayListBtn.TabIndex = 1;
            this.PlayListBtn.Text = "Playlist";
            this.PlayListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayListBtn.Textcolor = System.Drawing.Color.White;
            this.PlayListBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayListBtn.Click += new System.EventHandler(this.PlayListBtn_Click);
            // 
            // LogoBtn
            // 
            this.LogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoBtn.Enabled = false;
            this.LogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoBtn.Image")));
            this.LogoBtn.ImageActive = null;
            this.LogoBtn.Location = new System.Drawing.Point(10, 26);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Size = new System.Drawing.Size(159, 61);
            this.LogoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.TabStop = false;
            this.LogoBtn.Zoom = 10;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlPanel.BackgroundImage")));
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.Controls.Add(this.bunifuImageButton1);
            this.ControlPanel.Controls.Add(this.NextBtn);
            this.ControlPanel.Controls.Add(this.PreviousBtn);
            this.ControlPanel.Controls.Add(this.PlayPtn);
            this.ControlPanel.Controls.Add(this.StopBtn);
            this.ControlPanel.Controls.Add(this.bunifuImageButton5);
            this.ControlPanel.Controls.Add(this.PauseBtn);
            this.ControlPanel.Controls.Add(this.AudioLabel);
            this.ControlPanel.Controls.Add(this.AudioSlider);
            this.ControlPanel.Controls.Add(this.SongNameLabel);
            this.ControlPanel.Controls.Add(this.RightCounterLabel);
            this.ControlPanel.Controls.Add(this.LeftCounterLabel);
            this.ControlPanel.Controls.Add(this.SongProgressBar);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.ControlPanel.GradientBottomRight = System.Drawing.Color.Blue;
            this.ControlPanel.GradientTopLeft = System.Drawing.Color.Cyan;
            this.ControlPanel.GradientTopRight = System.Drawing.Color.DarkViolet;
            this.ControlPanel.Location = new System.Drawing.Point(180, 483);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Quality = 10;
            this.ControlPanel.Size = new System.Drawing.Size(640, 67);
            this.ControlPanel.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(206, 19);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 19;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.ImageActive = null;
            this.NextBtn.Location = new System.Drawing.Point(321, 19);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(32, 33);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextBtn.TabIndex = 18;
            this.NextBtn.TabStop = false;
            this.NextBtn.Zoom = 10;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PreviousBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.Image")));
            this.PreviousBtn.ImageActive = null;
            this.PreviousBtn.Location = new System.Drawing.Point(246, 19);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(32, 33);
            this.PreviousBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousBtn.TabIndex = 17;
            this.PreviousBtn.TabStop = false;
            this.PreviousBtn.Zoom = 10;
            // 
            // PlayPtn
            // 
            this.PlayPtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayPtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayPtn.Image")));
            this.PlayPtn.ImageActive = null;
            this.PlayPtn.Location = new System.Drawing.Point(284, 19);
            this.PlayPtn.Name = "PlayPtn";
            this.PlayPtn.Size = new System.Drawing.Size(32, 33);
            this.PlayPtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayPtn.TabIndex = 14;
            this.PlayPtn.TabStop = false;
            this.PlayPtn.Zoom = 10;
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageActive = null;
            this.StopBtn.Location = new System.Drawing.Point(359, 21);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(33, 29);
            this.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBtn.TabIndex = 16;
            this.StopBtn.TabStop = false;
            this.StopBtn.Zoom = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(494, 32);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(28, 22);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 13;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("PauseBtn.Image")));
            this.PauseBtn.ImageActive = null;
            this.PauseBtn.Location = new System.Drawing.Point(284, 19);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(32, 33);
            this.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseBtn.TabIndex = 15;
            this.PauseBtn.TabStop = false;
            this.PauseBtn.Zoom = 10;
            // 
            // AudioLabel
            // 
            this.AudioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.BackColor = System.Drawing.Color.Transparent;
            this.AudioLabel.Location = new System.Drawing.Point(610, 37);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(25, 13);
            this.AudioLabel.TabIndex = 12;
            this.AudioLabel.Text = "100";
            this.AudioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AudioSlider
            // 
            this.AudioSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AudioSlider.BackColor = System.Drawing.Color.Transparent;
            this.AudioSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.AudioSlider.BorderRadius = 0;
            this.AudioSlider.IndicatorColor = System.Drawing.Color.RoyalBlue;
            this.AudioSlider.Location = new System.Drawing.Point(527, 30);
            this.AudioSlider.MaximumValue = 100;
            this.AudioSlider.Name = "AudioSlider";
            this.AudioSlider.Size = new System.Drawing.Size(82, 30);
            this.AudioSlider.TabIndex = 9;
            this.AudioSlider.Value = 100;
            this.AudioSlider.ValueChanged += new System.EventHandler(this.AudioSlider_ValueChanged);
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SongNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNameLabel.Location = new System.Drawing.Point(2, 26);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(0, 26);
            this.SongNameLabel.TabIndex = 11;
            this.SongNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightCounterLabel
            // 
            this.RightCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightCounterLabel.AutoSize = true;
            this.RightCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RightCounterLabel.Location = new System.Drawing.Point(603, 14);
            this.RightCounterLabel.Name = "RightCounterLabel";
            this.RightCounterLabel.Size = new System.Drawing.Size(34, 13);
            this.RightCounterLabel.TabIndex = 10;
            this.RightCounterLabel.Text = "00:00";
            this.RightCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftCounterLabel
            // 
            this.LeftCounterLabel.AutoSize = true;
            this.LeftCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftCounterLabel.Location = new System.Drawing.Point(5, 14);
            this.LeftCounterLabel.Name = "LeftCounterLabel";
            this.LeftCounterLabel.Size = new System.Drawing.Size(34, 13);
            this.LeftCounterLabel.TabIndex = 9;
            this.LeftCounterLabel.Text = "00:00";
            this.LeftCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SongProgressBar
            // 
            this.SongProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongProgressBar.BackColor = System.Drawing.Color.Silver;
            this.SongProgressBar.BorderRadius = 5;
            this.SongProgressBar.Location = new System.Drawing.Point(6, 3);
            this.SongProgressBar.MaximumValue = 100;
            this.SongProgressBar.Name = "SongProgressBar";
            this.SongProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.SongProgressBar.Size = new System.Drawing.Size(628, 10);
            this.SongProgressBar.TabIndex = 0;
            this.SongProgressBar.Value = 0;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.DarkBlue;
            this.Container.Controls.Add(this.base_screen1);
            this.Container.Controls.Add(this.PlaylistBox);
            this.Container.Controls.Add(this.PlayBtn);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(180, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(640, 550);
            this.Container.TabIndex = 24;
            // 
            // base_screen1
            // 
            this.base_screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.base_screen1.Location = new System.Drawing.Point(0, 0);
            this.base_screen1.Name = "base_screen1";
            this.base_screen1.Size = new System.Drawing.Size(640, 550);
            this.base_screen1.TabIndex = 29;
            // 
            // PlaylistBox
            // 
            this.PlaylistBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlaylistBox.BackColor = System.Drawing.Color.Navy;
            this.PlaylistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaylistBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.PlaylistBox.FormattingEnabled = true;
            this.PlaylistBox.ItemHeight = 26;
            this.PlaylistBox.Location = new System.Drawing.Point(8, 14);
            this.PlaylistBox.Name = "PlaylistBox";
            this.PlaylistBox.Size = new System.Drawing.Size(620, 390);
            this.PlaylistBox.TabIndex = 19;
            this.PlaylistBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistBox_SelectedIndexChanged);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.PlayBtn.Location = new System.Drawing.Point(30, 421);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(150, 50);
            this.PlayBtn.TabIndex = 20;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.LeftSidePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxmizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBtn)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).EndInit();
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse WelcomeScreen;
        private Bunifu.Framework.UI.BunifuGradientPanel LeftSidePanel;
        private Bunifu.Framework.UI.BunifuImageButton LogoBtn;
        private Bunifu.Framework.UI.BunifuFlatButton FavoritesBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DownloadBtn;
        private Bunifu.Framework.UI.BunifuFlatButton BrowseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton NowPlayingBtn;
        private Bunifu.Framework.UI.BunifuFlatButton PlayListBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel ControlPanel;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MaxmizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel AudioLabel;
        private Bunifu.Framework.UI.BunifuSlider AudioSlider;
        private Bunifu.Framework.UI.BunifuCustomLabel SongNameLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel RightCounterLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel LeftCounterLabel;
        private Bunifu.Framework.UI.BunifuProgressBar SongProgressBar;
        private Bunifu.Framework.UI.BunifuImageButton StopBtn;
        private Bunifu.Framework.UI.BunifuImageButton PauseBtn;
        private Bunifu.Framework.UI.BunifuImageButton PlayPtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton NextBtn;
        private Bunifu.Framework.UI.BunifuImageButton PreviousBtn;
        private Bunifu.Framework.UI.BunifuFlatButton Home;
        private Bunifu.Framework.UI.BunifuFlatButton SpeechBtn;
        private Bunifu.Framework.UI.BunifuFlatButton AboutUsbtn;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.ListBox PlaylistBox;
        private System.Windows.Forms.Button PlayBtn;
        private DesignTest.Base_screen base_screen1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

