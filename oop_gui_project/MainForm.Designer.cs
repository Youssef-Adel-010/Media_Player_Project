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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LeftSidePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AboutUsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FavouritsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MinimizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DownloadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MaxmizeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.BrouseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nowplayingbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlayListBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.ControlPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.NextBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PreviousBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayPtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.StopBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.PauseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.VoiceRateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VoiceSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.SongNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RightCounterLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LeftCounterLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SongProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.Container = new System.Windows.Forms.Panel();
            this.base_screen1 = new DesignTest.Base_screen();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxmizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBtn)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).BeginInit();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftSidePanel.BackgroundImage")));
            this.LeftSidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftSidePanel.Controls.Add(this.Home);
            this.LeftSidePanel.Controls.Add(this.AboutUsbtn);
            this.LeftSidePanel.Controls.Add(this.FavouritsBtn);
            this.LeftSidePanel.Controls.Add(this.MinimizeBtn);
            this.LeftSidePanel.Controls.Add(this.DownloadBtn);
            this.LeftSidePanel.Controls.Add(this.MaxmizeBtn);
            this.LeftSidePanel.Controls.Add(this.CloseBtn);
            this.LeftSidePanel.Controls.Add(this.BrouseBtn);
            this.LeftSidePanel.Controls.Add(this.nowplayingbtn);
            this.LeftSidePanel.Controls.Add(this.PlayListBtn);
            this.LeftSidePanel.Controls.Add(this.LogoBtn);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidePanel.GradientBottomLeft = System.Drawing.Color.Red;
            this.LeftSidePanel.GradientBottomRight = System.Drawing.Color.Purple;
            this.LeftSidePanel.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.LeftSidePanel.GradientTopRight = System.Drawing.Color.Blue;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Quality = 10;
            this.LeftSidePanel.Size = new System.Drawing.Size(177, 510);
            this.LeftSidePanel.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Activecolor = System.Drawing.Color.Magenta;
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.BorderRadius = 0;
            this.Home.ButtonText = "Home";
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.DisabledColor = System.Drawing.Color.Gray;
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
            this.Home.Name = "Home";
            this.Home.Normalcolor = System.Drawing.Color.Transparent;
            this.Home.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Home.selected = false;
            this.Home.Size = new System.Drawing.Size(175, 50);
            this.Home.TabIndex = 10;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Home.Textcolor = System.Drawing.Color.White;
            this.Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // AboutUsbtn
            // 
            this.AboutUsbtn.Activecolor = System.Drawing.Color.Magenta;
            this.AboutUsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutUsbtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AboutUsbtn.BorderRadius = 0;
            this.AboutUsbtn.ButtonText = "About Us";
            this.AboutUsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutUsbtn.DisabledColor = System.Drawing.Color.Gray;
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
            this.AboutUsbtn.Location = new System.Drawing.Point(0, 450);
            this.AboutUsbtn.Name = "AboutUsbtn";
            this.AboutUsbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.AboutUsbtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.AboutUsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AboutUsbtn.selected = false;
            this.AboutUsbtn.Size = new System.Drawing.Size(175, 50);
            this.AboutUsbtn.TabIndex = 9;
            this.AboutUsbtn.Text = "About Us";
            this.AboutUsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutUsbtn.Textcolor = System.Drawing.Color.White;
            this.AboutUsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsbtn.Click += new System.EventHandler(this.AboutUsbtn_Click);
            // 
            // FavouritsBtn
            // 
            this.FavouritsBtn.Activecolor = System.Drawing.Color.Magenta;
            this.FavouritsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FavouritsBtn.BackColor = System.Drawing.Color.Transparent;
            this.FavouritsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavouritsBtn.BorderRadius = 0;
            this.FavouritsBtn.ButtonText = "Add To Favourits";
            this.FavouritsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavouritsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.FavouritsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.FavouritsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("FavouritsBtn.Iconimage")));
            this.FavouritsBtn.Iconimage_right = null;
            this.FavouritsBtn.Iconimage_right_Selected = null;
            this.FavouritsBtn.Iconimage_Selected = null;
            this.FavouritsBtn.IconMarginLeft = 0;
            this.FavouritsBtn.IconMarginRight = 0;
            this.FavouritsBtn.IconRightVisible = true;
            this.FavouritsBtn.IconRightZoom = 0D;
            this.FavouritsBtn.IconVisible = true;
            this.FavouritsBtn.IconZoom = 40D;
            this.FavouritsBtn.IsTab = false;
            this.FavouritsBtn.Location = new System.Drawing.Point(0, 350);
            this.FavouritsBtn.Name = "FavouritsBtn";
            this.FavouritsBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.FavouritsBtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.FavouritsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.FavouritsBtn.selected = false;
            this.FavouritsBtn.Size = new System.Drawing.Size(175, 50);
            this.FavouritsBtn.TabIndex = 5;
            this.FavouritsBtn.Text = "Add To Favourits";
            this.FavouritsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FavouritsBtn.Textcolor = System.Drawing.Color.White;
            this.FavouritsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DownloadBtn.Activecolor = System.Drawing.Color.Magenta;
            this.DownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownloadBtn.BorderRadius = 0;
            this.DownloadBtn.ButtonText = "Youtube Download";
            this.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.DownloadBtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.DownloadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DownloadBtn.selected = false;
            this.DownloadBtn.Size = new System.Drawing.Size(175, 50);
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
            // BrouseBtn
            // 
            this.BrouseBtn.Activecolor = System.Drawing.Color.Magenta;
            this.BrouseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrouseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrouseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrouseBtn.BorderRadius = 0;
            this.BrouseBtn.ButtonText = "Browse";
            this.BrouseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrouseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.BrouseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.BrouseBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BrouseBtn.Iconimage")));
            this.BrouseBtn.Iconimage_right = null;
            this.BrouseBtn.Iconimage_right_Selected = null;
            this.BrouseBtn.Iconimage_Selected = null;
            this.BrouseBtn.IconMarginLeft = 0;
            this.BrouseBtn.IconMarginRight = 0;
            this.BrouseBtn.IconRightVisible = true;
            this.BrouseBtn.IconRightZoom = 0D;
            this.BrouseBtn.IconVisible = true;
            this.BrouseBtn.IconZoom = 40D;
            this.BrouseBtn.IsTab = false;
            this.BrouseBtn.Location = new System.Drawing.Point(0, 300);
            this.BrouseBtn.Name = "BrouseBtn";
            this.BrouseBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.BrouseBtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.BrouseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BrouseBtn.selected = false;
            this.BrouseBtn.Size = new System.Drawing.Size(175, 50);
            this.BrouseBtn.TabIndex = 3;
            this.BrouseBtn.Text = "Browse";
            this.BrouseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrouseBtn.Textcolor = System.Drawing.Color.White;
            this.BrouseBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nowplayingbtn
            // 
            this.nowplayingbtn.Activecolor = System.Drawing.Color.Magenta;
            this.nowplayingbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nowplayingbtn.BackColor = System.Drawing.Color.Transparent;
            this.nowplayingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nowplayingbtn.BorderRadius = 0;
            this.nowplayingbtn.ButtonText = "Playing Now";
            this.nowplayingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nowplayingbtn.DisabledColor = System.Drawing.Color.Gray;
            this.nowplayingbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nowplayingbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("nowplayingbtn.Iconimage")));
            this.nowplayingbtn.Iconimage_right = null;
            this.nowplayingbtn.Iconimage_right_Selected = null;
            this.nowplayingbtn.Iconimage_Selected = null;
            this.nowplayingbtn.IconMarginLeft = 0;
            this.nowplayingbtn.IconMarginRight = 0;
            this.nowplayingbtn.IconRightVisible = true;
            this.nowplayingbtn.IconRightZoom = 0D;
            this.nowplayingbtn.IconVisible = true;
            this.nowplayingbtn.IconZoom = 40D;
            this.nowplayingbtn.IsTab = false;
            this.nowplayingbtn.Location = new System.Drawing.Point(0, 250);
            this.nowplayingbtn.Name = "nowplayingbtn";
            this.nowplayingbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.nowplayingbtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.nowplayingbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nowplayingbtn.selected = false;
            this.nowplayingbtn.Size = new System.Drawing.Size(175, 50);
            this.nowplayingbtn.TabIndex = 2;
            this.nowplayingbtn.Text = "Playing Now";
            this.nowplayingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nowplayingbtn.Textcolor = System.Drawing.Color.White;
            this.nowplayingbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowplayingbtn.Click += new System.EventHandler(this.NowPlayingBtn_Click);
            // 
            // PlayListBtn
            // 
            this.PlayListBtn.Activecolor = System.Drawing.Color.Magenta;
            this.PlayListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayListBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayListBtn.BorderRadius = 0;
            this.PlayListBtn.ButtonText = "Playlist";
            this.PlayListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayListBtn.DisabledColor = System.Drawing.SystemColors.GrayText;
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
            this.PlayListBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PlayListBtn.Name = "PlayListBtn";
            this.PlayListBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.PlayListBtn.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.PlayListBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayListBtn.selected = false;
            this.PlayListBtn.Size = new System.Drawing.Size(175, 50);
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
            this.ControlPanel.Controls.Add(this.NextBtn);
            this.ControlPanel.Controls.Add(this.PreviousBtn);
            this.ControlPanel.Controls.Add(this.PlayPtn);
            this.ControlPanel.Controls.Add(this.StopBtn);
            this.ControlPanel.Controls.Add(this.bunifuImageButton5);
            this.ControlPanel.Controls.Add(this.PauseBtn);
            this.ControlPanel.Controls.Add(this.VoiceRateLabel);
            this.ControlPanel.Controls.Add(this.VoiceSlider);
            this.ControlPanel.Controls.Add(this.SongNameLabel);
            this.ControlPanel.Controls.Add(this.RightCounterLabel);
            this.ControlPanel.Controls.Add(this.LeftCounterLabel);
            this.ControlPanel.Controls.Add(this.SongProgressBar);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPanel.GradientBottomLeft = System.Drawing.Color.Red;
            this.ControlPanel.GradientBottomRight = System.Drawing.Color.DarkOrchid;
            this.ControlPanel.GradientTopLeft = System.Drawing.Color.MediumBlue;
            this.ControlPanel.GradientTopRight = System.Drawing.Color.RoyalBlue;
            this.ControlPanel.Location = new System.Drawing.Point(177, 443);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Quality = 10;
            this.ControlPanel.Size = new System.Drawing.Size(640, 67);
            this.ControlPanel.TabIndex = 1;
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.ImageActive = null;
            this.NextBtn.Location = new System.Drawing.Point(363, 19);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(32, 33);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextBtn.TabIndex = 18;
            this.NextBtn.TabStop = false;
            this.NextBtn.Zoom = 10;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreviousBtn.Image = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.Image")));
            this.PreviousBtn.ImageActive = null;
            this.PreviousBtn.Location = new System.Drawing.Point(227, 19);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(32, 33);
            this.PreviousBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviousBtn.TabIndex = 17;
            this.PreviousBtn.TabStop = false;
            this.PreviousBtn.Zoom = 10;
            // 
            // PlayPtn
            // 
            this.PlayPtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayPtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayPtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayPtn.Image")));
            this.PlayPtn.ImageActive = null;
            this.PlayPtn.Location = new System.Drawing.Point(261, 19);
            this.PlayPtn.Name = "PlayPtn";
            this.PlayPtn.Size = new System.Drawing.Size(32, 33);
            this.PlayPtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayPtn.TabIndex = 14;
            this.PlayPtn.TabStop = false;
            this.PlayPtn.Zoom = 10;
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.Image = ((System.Drawing.Image)(resources.GetObject("StopBtn.Image")));
            this.StopBtn.ImageActive = null;
            this.StopBtn.Location = new System.Drawing.Point(329, 19);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(32, 33);
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
            this.bunifuImageButton5.Location = new System.Drawing.Point(494, 33);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(28, 22);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 13;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("PauseBtn.Image")));
            this.PauseBtn.ImageActive = null;
            this.PauseBtn.Location = new System.Drawing.Point(295, 19);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(32, 33);
            this.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseBtn.TabIndex = 15;
            this.PauseBtn.TabStop = false;
            this.PauseBtn.Zoom = 10;
            // 
            // VoiceRateLabel
            // 
            this.VoiceRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoiceRateLabel.AutoSize = true;
            this.VoiceRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.VoiceRateLabel.Location = new System.Drawing.Point(610, 37);
            this.VoiceRateLabel.Name = "VoiceRateLabel";
            this.VoiceRateLabel.Size = new System.Drawing.Size(25, 26);
            this.VoiceRateLabel.TabIndex = 12;
            this.VoiceRateLabel.Text = "100\r\n\r\n";
            this.VoiceRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VoiceSlider
            // 
            this.VoiceSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoiceSlider.BackColor = System.Drawing.Color.Transparent;
            this.VoiceSlider.BackgroudColor = System.Drawing.Color.DarkGray;
            this.VoiceSlider.BorderRadius = 0;
            this.VoiceSlider.IndicatorColor = System.Drawing.Color.MediumOrchid;
            this.VoiceSlider.Location = new System.Drawing.Point(527, 32);
            this.VoiceSlider.MaximumValue = 100;
            this.VoiceSlider.Name = "VoiceSlider";
            this.VoiceSlider.Size = new System.Drawing.Size(82, 30);
            this.VoiceSlider.TabIndex = 9;
            this.VoiceSlider.Value = 0;
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SongNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongNameLabel.Location = new System.Drawing.Point(2, 26);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(110, 26);
            this.SongNameLabel.TabIndex = 11;
            this.SongNameLabel.Text = "Song Name";
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
            this.Container.Controls.Add(this.base_screen1);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(177, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(640, 443);
            this.Container.TabIndex = 2;
            // 
            // base_screen1
            // 
            this.base_screen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.base_screen1.Location = new System.Drawing.Point(0, 0);
            this.base_screen1.Name = "base_screen1";
            this.base_screen1.Size = new System.Drawing.Size(640, 443);
            this.base_screen1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 510);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.ControlPanel);
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

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel LeftSidePanel;
        private Bunifu.Framework.UI.BunifuImageButton LogoBtn;
        private Bunifu.Framework.UI.BunifuFlatButton FavouritsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DownloadBtn;
        private Bunifu.Framework.UI.BunifuFlatButton BrouseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton nowplayingbtn;
        private Bunifu.Framework.UI.BunifuFlatButton PlayListBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel ControlPanel;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MaxmizeBtn;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel VoiceRateLabel;
        private Bunifu.Framework.UI.BunifuSlider VoiceSlider;
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
        private Bunifu.Framework.UI.BunifuFlatButton AboutUsbtn;
        private Bunifu.Framework.UI.BunifuFlatButton Home;
        private System.Windows.Forms.Panel Container;
        private DesignTest.Base_screen base_screen1;
    }
}

