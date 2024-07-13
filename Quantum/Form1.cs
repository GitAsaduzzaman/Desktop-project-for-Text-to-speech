using System;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Quantum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Speechbutton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please Enter text", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                speechSynthesizer.Rate = SpeedtrackBar.Value;
                speechSynthesizer.Volume = VolumetrackBar.Value;

                if (voicomboBox.Text == "Male")
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
                }
                else if (voicomboBox.Text == "Female")
                {
                    speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                }

                speechSynthesizer.SpeakAsync(richTextBox1.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void voicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
