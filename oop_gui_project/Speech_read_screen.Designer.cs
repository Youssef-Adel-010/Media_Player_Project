namespace DesignTest
{
    partial class Speech_read_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speech_read_screen));
            this.SpeechLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.SaveAsRecBtn = new System.Windows.Forms.Button();
            this.SpeechTextBox = new System.Windows.Forms.TextBox();
            this.SpeedSlider = new System.Windows.Forms.TrackBar();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.Clear = new System.Windows.Forms.Button();
            this.SpeechReadingPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.SpeechReadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpeechLabel
            // 
            this.SpeechLabel.AutoSize = true;
            this.SpeechLabel.BackColor = System.Drawing.Color.Transparent;
            this.SpeechLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeechLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SpeechLabel.Location = new System.Drawing.Point(3, 9);
            this.SpeechLabel.Name = "SpeechLabel";
            this.SpeechLabel.Size = new System.Drawing.Size(152, 26);
            this.SpeechLabel.TabIndex = 3;
            this.SpeechLabel.Text = "Enter The Text : ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(104, 327);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 26);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Speed ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(104, 377);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(78, 26);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Tag = "";
            this.bunifuCustomLabel2.Text = "Volume";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.LightGray;
            this.BrowseBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.ForeColor = System.Drawing.Color.Black;
            this.BrowseBtn.Location = new System.Drawing.Point(387, 295);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(106, 41);
            this.BrowseBtn.TabIndex = 8;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.LightGray;
            this.PauseBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.ForeColor = System.Drawing.Color.Black;
            this.PauseBtn.Location = new System.Drawing.Point(387, 342);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(106, 41);
            this.PauseBtn.TabIndex = 10;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.LightGray;
            this.ReadBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBtn.ForeColor = System.Drawing.Color.Black;
            this.ReadBtn.Location = new System.Drawing.Point(499, 295);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(99, 41);
            this.ReadBtn.TabIndex = 11;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.BackColor = System.Drawing.Color.LightGray;
            this.ResumeBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeBtn.ForeColor = System.Drawing.Color.Black;
            this.ResumeBtn.Location = new System.Drawing.Point(499, 342);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(99, 41);
            this.ResumeBtn.TabIndex = 12;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = false;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // SaveAsRecBtn
            // 
            this.SaveAsRecBtn.BackColor = System.Drawing.Color.LightGray;
            this.SaveAsRecBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsRecBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveAsRecBtn.Location = new System.Drawing.Point(387, 389);
            this.SaveAsRecBtn.Name = "SaveAsRecBtn";
            this.SaveAsRecBtn.Size = new System.Drawing.Size(106, 41);
            this.SaveAsRecBtn.TabIndex = 13;
            this.SaveAsRecBtn.Text = "Save as wav";
            this.SaveAsRecBtn.UseVisualStyleBackColor = false;
            this.SaveAsRecBtn.Click += new System.EventHandler(this.SaveAsRecBtn_Click);
            // 
            // SpeechTextBox
            // 
            this.SpeechTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpeechTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.SpeechTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeechTextBox.Location = new System.Drawing.Point(3, 38);
            this.SpeechTextBox.Multiline = true;
            this.SpeechTextBox.Name = "SpeechTextBox";
            this.SpeechTextBox.Size = new System.Drawing.Size(634, 228);
            this.SpeechTextBox.TabIndex = 14;
            this.SpeechTextBox.WordWrap = false;
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(4)))), ((int)(((byte)(59)))));
            this.SpeedSlider.Location = new System.Drawing.Point(175, 307);
            this.SpeedSlider.Minimum = -10;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(106, 45);
            this.SpeedSlider.TabIndex = 15;
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(4)))), ((int)(((byte)(59)))));
            this.VolumeSlider.Location = new System.Drawing.Point(175, 358);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(106, 45);
            this.VolumeSlider.TabIndex = 16;
            this.VolumeSlider.Value = 50;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightGray;
            this.Clear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(499, 389);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 41);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SpeechReadingPanel
            // 
            this.SpeechReadingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpeechReadingPanel.BackgroundImage")));
            this.SpeechReadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpeechReadingPanel.Controls.Add(this.Clear);
            this.SpeechReadingPanel.Controls.Add(this.VolumeSlider);
            this.SpeechReadingPanel.Controls.Add(this.SpeedSlider);
            this.SpeechReadingPanel.Controls.Add(this.SpeechTextBox);
            this.SpeechReadingPanel.Controls.Add(this.SaveAsRecBtn);
            this.SpeechReadingPanel.Controls.Add(this.ResumeBtn);
            this.SpeechReadingPanel.Controls.Add(this.ReadBtn);
            this.SpeechReadingPanel.Controls.Add(this.PauseBtn);
            this.SpeechReadingPanel.Controls.Add(this.BrowseBtn);
            this.SpeechReadingPanel.Controls.Add(this.bunifuCustomLabel2);
            this.SpeechReadingPanel.Controls.Add(this.bunifuCustomLabel1);
            this.SpeechReadingPanel.Controls.Add(this.SpeechLabel);
            this.SpeechReadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeechReadingPanel.GradientBottomLeft = System.Drawing.Color.MediumBlue;
            this.SpeechReadingPanel.GradientBottomRight = System.Drawing.Color.DarkMagenta;
            this.SpeechReadingPanel.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.SpeechReadingPanel.GradientTopRight = System.Drawing.Color.Crimson;
            this.SpeechReadingPanel.Location = new System.Drawing.Point(0, 0);
            this.SpeechReadingPanel.Name = "SpeechReadingPanel";
            this.SpeechReadingPanel.Quality = 10;
            this.SpeechReadingPanel.Size = new System.Drawing.Size(640, 443);
            this.SpeechReadingPanel.TabIndex = 15;
            // 
            // Speech_read_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SpeechReadingPanel);
            this.Name = "Speech_read_screen";
            this.Size = new System.Drawing.Size(640, 443);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.SpeechReadingPanel.ResumeLayout(false);
            this.SpeechReadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel SpeechLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Button SaveAsRecBtn;
        private System.Windows.Forms.TextBox SpeechTextBox;
        private System.Windows.Forms.TrackBar SpeedSlider;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Button Clear;
        private Bunifu.Framework.UI.BunifuGradientPanel SpeechReadingPanel;
    }
}
