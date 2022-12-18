namespace DesignTest
{
    partial class Youtube_download_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youtube_download_screen));
            this.YoutubeDownloadPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.PerLabel = new System.Windows.Forms.Label();
            this.ResDropDown = new System.Windows.Forms.ComboBox();
            this.PathTxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.DownloadBut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProgBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.YoutubeDownloadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YoutubeDownloadPanel
            // 
            this.YoutubeDownloadPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YoutubeDownloadPanel.BackgroundImage")));
            this.YoutubeDownloadPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YoutubeDownloadPanel.Controls.Add(this.label4);
            this.YoutubeDownloadPanel.Controls.Add(this.label2);
            this.YoutubeDownloadPanel.Controls.Add(this.label3);
            this.YoutubeDownloadPanel.Controls.Add(this.label1);
            this.YoutubeDownloadPanel.Controls.Add(this.txturl);
            this.YoutubeDownloadPanel.Controls.Add(this.PerLabel);
            this.YoutubeDownloadPanel.Controls.Add(this.ResDropDown);
            this.YoutubeDownloadPanel.Controls.Add(this.PathTxt);
            this.YoutubeDownloadPanel.Controls.Add(this.DownloadBut);
            this.YoutubeDownloadPanel.Controls.Add(this.ProgBar);
            this.YoutubeDownloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YoutubeDownloadPanel.ForeColor = System.Drawing.Color.Silver;
            this.YoutubeDownloadPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.YoutubeDownloadPanel.GradientBottomRight = System.Drawing.Color.Blue;
            this.YoutubeDownloadPanel.GradientTopLeft = System.Drawing.Color.DarkViolet;
            this.YoutubeDownloadPanel.GradientTopRight = System.Drawing.Color.Aqua;
            this.YoutubeDownloadPanel.Location = new System.Drawing.Point(0, 0);
            this.YoutubeDownloadPanel.Name = "YoutubeDownloadPanel";
            this.YoutubeDownloadPanel.Quality = 10;
            this.YoutubeDownloadPanel.Size = new System.Drawing.Size(640, 443);
            this.YoutubeDownloadPanel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter The URL Here : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Progress";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(13, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select Path";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resolution";
            // 
            // txturl
            // 
            this.txturl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txturl.BackColor = System.Drawing.Color.Black;
            this.txturl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txturl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.ForeColor = System.Drawing.Color.White;
            this.txturl.Location = new System.Drawing.Point(3, 58);
            this.txturl.Multiline = true;
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(634, 57);
            this.txturl.TabIndex = 13;
            // 
            // PerLabel
            // 
            this.PerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PerLabel.AutoSize = true;
            this.PerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PerLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerLabel.Location = new System.Drawing.Point(597, 356);
            this.PerLabel.Name = "PerLabel";
            this.PerLabel.Size = new System.Drawing.Size(26, 15);
            this.PerLabel.TabIndex = 12;
            this.PerLabel.Text = "0 %";
            // 
            // ResDropDown
            // 
            this.ResDropDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ResDropDown.BackColor = System.Drawing.Color.White;
            this.ResDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResDropDown.FormattingEnabled = true;
            this.ResDropDown.Items.AddRange(new object[] {
            "360 p",
            "480 p",
            "720 p"});
            this.ResDropDown.Location = new System.Drawing.Point(94, 251);
            this.ResDropDown.Name = "ResDropDown";
            this.ResDropDown.Size = new System.Drawing.Size(121, 21);
            this.ResDropDown.TabIndex = 11;
            // 
            // PathTxt
            // 
            this.PathTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PathTxt.BorderColor = System.Drawing.Color.Transparent;
            this.PathTxt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathTxt.Location = new System.Drawing.Point(94, 292);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(176, 23);
            this.PathTxt.TabIndex = 9;
            // 
            // DownloadBut
            // 
            this.DownloadBut.Activecolor = System.Drawing.Color.Purple;
            this.DownloadBut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DownloadBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(150)))));
            this.DownloadBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownloadBut.BorderRadius = 0;
            this.DownloadBut.ButtonText = "Click Here To Download";
            this.DownloadBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadBut.DisabledColor = System.Drawing.Color.Gray;
            this.DownloadBut.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBut.Iconcolor = System.Drawing.Color.Transparent;
            this.DownloadBut.Iconimage = ((System.Drawing.Image)(resources.GetObject("DownloadBut.Iconimage")));
            this.DownloadBut.Iconimage_right = null;
            this.DownloadBut.Iconimage_right_Selected = null;
            this.DownloadBut.Iconimage_Selected = null;
            this.DownloadBut.IconMarginLeft = 0;
            this.DownloadBut.IconMarginRight = 0;
            this.DownloadBut.IconRightVisible = true;
            this.DownloadBut.IconRightZoom = 0D;
            this.DownloadBut.IconVisible = true;
            this.DownloadBut.IconZoom = 90D;
            this.DownloadBut.IsTab = false;
            this.DownloadBut.Location = new System.Drawing.Point(381, 275);
            this.DownloadBut.Name = "DownloadBut";
            this.DownloadBut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(150)))));
            this.DownloadBut.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.DownloadBut.OnHoverTextColor = System.Drawing.Color.White;
            this.DownloadBut.selected = false;
            this.DownloadBut.Size = new System.Drawing.Size(248, 37);
            this.DownloadBut.TabIndex = 6;
            this.DownloadBut.Text = "Click Here To Download";
            this.DownloadBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadBut.Textcolor = System.Drawing.Color.White;
            this.DownloadBut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBut.Click += new System.EventHandler(this.DownloadBut_Click_1);
            // 
            // ProgBar
            // 
            this.ProgBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgBar.BackColor = System.Drawing.Color.Silver;
            this.ProgBar.BorderRadius = 5;
            this.ProgBar.Location = new System.Drawing.Point(88, 360);
            this.ProgBar.MaximumValue = 100;
            this.ProgBar.Name = "ProgBar";
            this.ProgBar.ProgressColor = System.Drawing.Color.LimeGreen;
            this.ProgBar.Size = new System.Drawing.Size(503, 10);
            this.ProgBar.TabIndex = 4;
            this.ProgBar.Value = 0;
            // 
            // Youtube_download_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.YoutubeDownloadPanel);
            this.Name = "Youtube_download_screen";
            this.Size = new System.Drawing.Size(640, 443);
            this.YoutubeDownloadPanel.ResumeLayout(false);
            this.YoutubeDownloadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel YoutubeDownloadPanel;
        private Bunifu.Framework.UI.BunifuFlatButton DownloadBut;
        private Bunifu.Framework.UI.BunifuProgressBar ProgBar;
        private System.Windows.Forms.ComboBox ResDropDown;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PathTxt;
        private System.Windows.Forms.Label PerLabel;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
