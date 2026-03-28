using NAudio;
using NAudio.Lame;
using NAudio.Wave;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;

namespace TtAC
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synth;

        public Form1()
        {
            InitializeComponent();

            synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice(); // вывод на динамики

            // Настройка голоса
            synth.Rate = 0;     // скорость (-10 до 10)
            synth.Volume = 50; // громкость (0-100)

            foreach (var v in synth.GetInstalledVoices())
            {
                comboBoxVoices.Items.Add(v.VoiceInfo.Name);
            }

            // Выбор русского голоса (если есть)
            try
            {
                comboBoxVoices.SelectedIndex = comboBoxVoices.Items.IndexOf("Microsoft Irina Desktop");
                synth.SelectVoice("Microsoft Irina Desktop");
            }
            catch { }
        }

        private void comboBoxVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            synth.SelectVoice(comboBoxVoices.Text);
        }

        private void tckBarVolume_Scroll(object sender, EventArgs e)
        {
            synth.Volume = trackBarVolume.Value;
            labelVolume.Text = $"Volume:\n{trackBarVolume.Value}";
        }
        private void tckBarRate_Scroll(object sender, EventArgs e)
        {
            synth.Rate = trackBarRate.Value;
            labelRate.Text = $"Rate:\n{trackBarRate.Value}";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTextToVoice.Text) && synth.State != SynthesizerState.Speaking)
            {
                synth.SpeakAsync(textBoxTextToVoice.Text); // асинхронно, не блокирует UI
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTextToVoice.Text))
            {
                MessageBox.Show("Введите текст для сохранения.");
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav";
                sfd.Title = "Сохранить как";
                sfd.FileName = "audio";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string text = textBoxTextToVoice.Text;

                    if (sfd.FilterIndex == 2) // WAV
                    {
                        SaveToWAV(sfd.FileName);
                    }
                    else // MP3
                    {
                        SaveToMP3(sfd.FileName);
                    }
                }
            }
        }

        private void SaveToMP3(string fileName)
        {
            string tempWav = Path.GetTempFileName() + ".wav";

            SaveToWAV(tempWav);

            using (var reader = new WaveFileReader(tempWav))
            using (var writer = new LameMP3FileWriter(fileName, reader.WaveFormat, 128))
            {
                reader.CopyTo(writer);
            }

            File.Delete(tempWav);
        }
        private void SaveToWAV(string fileName)
        {
            using (var synth = new SpeechSynthesizer())
            {
                synth.SetOutputToWaveFile(fileName);
                synth.Volume = trackBarVolume.Value;
                synth.Rate = trackBarRate.Value;
                synth.SelectVoice(comboBoxVoices.Text);
                synth.Speak(textBoxTextToVoice.Text);
            }
        }
    }
}
