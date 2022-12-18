namespace DesignTest
{
    partial class Splash_Screen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen_Form));
            this.SplashScreen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SplashPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ProgressBarSplash = new System.Windows.Forms.ProgressBar();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SplashLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SplashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashScreen
            // 
            this.SplashScreen.ElipseRadius = 5;
            this.SplashScreen.TargetControl = this;
            // 
            // SplashPanel
            // 
            this.SplashPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplashPanel.BackgroundImage")));
            this.SplashPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplashPanel.Controls.Add(this.ProgressBarSplash);
            this.SplashPanel.Controls.Add(this.bunifuCustomLabel5);
            this.SplashPanel.Controls.Add(this.bunifuCustomLabel4);
            this.SplashPanel.Controls.Add(this.bunifuCustomLabel3);
            this.SplashPanel.Controls.Add(this.bunifuCustomLabel2);
            this.SplashPanel.Controls.Add(this.bunifuCustomLabel1);
            this.SplashPanel.Controls.Add(this.SplashLabel);
            this.SplashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplashPanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.SplashPanel.GradientBottomRight = System.Drawing.Color.Blue;
            this.SplashPanel.GradientTopLeft = System.Drawing.Color.Aquamarine;
            this.SplashPanel.GradientTopRight = System.Drawing.Color.DarkViolet;
            this.SplashPanel.Location = new System.Drawing.Point(0, 0);
            this.SplashPanel.Name = "SplashPanel";
            this.SplashPanel.Quality = 10;
            this.SplashPanel.Size = new System.Drawing.Size(820, 550);
            this.SplashPanel.TabIndex = 1;
            // 
            // ProgressBarSplash
            // 
            this.ProgressBarSplash.BackColor = System.Drawing.Color.SkyBlue;
            this.ProgressBarSplash.ForeColor = System.Drawing.Color.MediumBlue;
            this.ProgressBarSplash.Location = new System.Drawing.Point(0, 540);
            this.ProgressBarSplash.Name = "ProgressBarSplash";
            this.ProgressBarSplash.Size = new System.Drawing.Size(841, 10);
            this.ProgressBarSplash.TabIndex = 7;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(60, 207);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(460, 23);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Story Teller Provided With Speech Synthesizing  Technology.";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(60, 183);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(372, 23);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Best Downloader For Youtube Video and Audio.";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(60, 158);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(583, 23);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "The Professionl Player for Your Songs, Movies and your Favourite Moments.\r\n";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(60, 230);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(171, 19);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Your Journey Is Starting...";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(64, 107);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(283, 23);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "We Think.. We Code.. We Develope.";
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.BackColor = System.Drawing.Color.Transparent;
            this.SplashLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashLabel.ForeColor = System.Drawing.Color.White;
            this.SplashLabel.Location = new System.Drawing.Point(54, 55);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(373, 59);
            this.SplashLabel.TabIndex = 0;
            this.SplashLabel.Text = "The Media Player";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Splash_Screen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 550);
            this.Controls.Add(this.SplashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash_Screen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_Screen_Form";
            this.SplashPanel.ResumeLayout(false);
            this.SplashPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse SplashScreen;
        private Bunifu.Framework.UI.BunifuGradientPanel SplashPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel SplashLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar ProgressBarSplash;
    }
}