using DesignTest;
using System;
using System.Windows.Forms;

namespace oop_gui_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////
        // Here We Will Code The Title Bar Buttons.
        public void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MaxmizeBtn_Click(object sender, EventArgs e)
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
        // Here We Will Code The Left-Side Buttons.

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
            Base_screen bse = new Base_screen();
            AddUserControl(bse);
        }

        private void PlayListBtn_Click(object sender, EventArgs e)
        {
            PlayList_screen plylsc = new PlayList_screen();
            AddUserControl(plylsc);
        }
        private void nowplayingbtn_Click(object sender, EventArgs e)
        {
            Playing_now_screen plynwsc = new Playing_now_screen();
            AddUserControl(plynwsc);
        }
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            Youtupe_Download_screen ytpd = new Youtupe_Download_screen();
            AddUserControl(ytpd);
        }

        private void AboutUsbtn_Click(object sender, EventArgs e)
        {
            About_us abt = new About_us();
            AddUserControl(abt);
        }

        ///////////////////////////////////////////////////////////////////

    }

}

