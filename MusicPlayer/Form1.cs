using System;
using System.Windows.Forms;
using System.IO;
using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        private struct FileData {
            public string name;
            public string location;
        }



        private IWaveSource source;
        private WasapiOut audioOut;
        public MusicPlayer()
        {
            //trackerInit();
            InitializeComponent();
            source = null;
            audioOut = new WasapiOut();
            ChangeSong("");
        }

        private void Tracker_MouseUp(object sender, MouseEventArgs e)
        {
            if (source.Position != tracker.Value)
            {
                source.Position = tracker.Value;
                Play();
            }
        }

        private void Tracker_MouseDown(object sender, MouseEventArgs e)
        {
            Pause();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void MusicPlayer_KeyDown(object sender, KeyEventArgs e)
        {

        }
        public void ChangeSong(string file)
        {
            file = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            file = Path.Combine(file, "Monstercat Podcast Ep. 121.m4a");
            source = CodecFactory.Instance.GetCodec(file);
            tracker.Maximum = (int)source.Length;
            tracker.Value = 0;
            audioOut.Stop();
            audioOut.Initialize(source);
        }
        public void Play()
        {
            if (audioOut != null)
                audioOut.Play();

        }
        public void Pause()
        {
            if (audioOut != null)
                audioOut.Pause();
        }
        public void Destroy()
        {
            audioOut.Stop();
            audioOut.Dispose();
        }

        private void ListSongName_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                ListSongName.Items.AddRange(files);
            }
        }

        private void ListSongName_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }
    }
}
