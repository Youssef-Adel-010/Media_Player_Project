using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace DesignTest
{
    public partial class Speech_read_screen : UserControl
    {
        SpeechSynthesizer ss;
        public Speech_read_screen()
        {
            InitializeComponent();
            ss = new SpeechSynthesizer();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "text files|*.txt";
            open.ShowDialog();
            string name = open.FileName;
            StreamReader sr = new StreamReader(name);
            SpeechTextBox.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void SaveAsRecBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Wave Files | *.wav";
            sv.ShowDialog();
            string name = sv.FileName;
            ss.Rate = SpeedSlider.Value;
            ss.Volume = VolumeSlider.Value;
            ss.SetOutputToWaveFile(name);
            ss.Speak(SpeechTextBox.Text);
            ss.SetOutputToDefaultAudioDevice();
            MessageBox.Show("The Text Record Successfully Saved.");

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (SpeechTextBox.Text != " ")
            {
                ss.Rate = SpeedSlider.Value;
                ss.Volume = VolumeSlider.Value;
                ss.SpeakAsync(SpeechTextBox.Text);
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (ss.State == SynthesizerState.Speaking)
            {
                ss.Pause();
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            if (ss.State == SynthesizerState.Paused)
            {
                ss.Resume();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SpeechTextBox.Text = " ";
            SpeedSlider.Value = 0;
            VolumeSlider.Value = 50;
        }
    }
}
