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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '●';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin123";
            if (UserTextBox.Text == user && PasswordTextBox.Text == pass)
            {
                Splash_Screen_Form splash = new Splash_Screen_Form();
                splash.Show();
                this.Hide();
            }
            else if (UserTextBox.Text != user && PasswordTextBox.Text == pass)
            {
                MessageBox.Show("Wrong Username.");
            }
            else if (UserTextBox.Text == user && PasswordTextBox.Text != pass)
            {
                MessageBox.Show("Wrong Password.");
            }
            else if (UserTextBox.Text == " " || PasswordTextBox.Text != " ")
            {
                MessageBox.Show("Empty Field.");
            }
            else
            {
                MessageBox.Show("Please Enter The Right Data.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
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

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
