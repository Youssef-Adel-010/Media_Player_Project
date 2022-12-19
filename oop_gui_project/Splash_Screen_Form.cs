using oop_gui_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignTest
{
    public partial class Splash_Screen_Form : Form
    {

        public Splash_Screen_Form()
        {
            InitializeComponent();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ProgressBarSplash.Increment(2);
            if (ProgressBarSplash.Value == 100)
            {
                timer.Enabled = false;
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
