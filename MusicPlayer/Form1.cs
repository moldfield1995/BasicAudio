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
            public override string ToString() { return name; }
        }
        private IWaveSource source;
        private WasapiOut audioOut;
        private KeyboardHook keybordHook;
        public MusicPlayer()
        {
            //trackerInit();
            InitializeComponent();
            source = null;
            audioOut = new WasapiOut();
            keybordHook = new KeyboardHook();
            keybordHook.KeyboardEvent += KeybordHook_KeyboardEvent;
            ChangeSong("");
        }

        private void KeybordHook_KeyboardEvent(KeyboardEvents kEvent, Keys key)
        {
            if(kEvent == KeyboardEvents.KeyDown)
            {
                if (key == Keys.MediaPlayPause)
                    PlayPause();
                
            }
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
            if (e.KeyCode == Keys.MediaPlayPause)
                PlayPause();
            else if (e.KeyCode == Keys.MediaStop)
                Stop();
            else if (e.KeyCode == Keys.VolumeDown || e.KeyCode == Keys.Subtract)
            {
                if (audioOut.Volume - 0.1f >= 0f)
                    audioOut.Volume -= 0.1f;
                else
                    audioOut.Volume = 0f;
            }
            else if (e.KeyCode == Keys.VolumeUp || e.KeyCode == Keys.Add)
            {
                if (audioOut.Volume + 0.1f <= 1f)
                    audioOut.Volume += 0.1f;
                else
                    audioOut.Volume = 1f;
            }
           
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
        public void Play() { audioOut.Play(); }
        public void Pause() { audioOut.Pause();}
        public void Stop() { audioOut.Stop(); }
        public void PlayPause() { if (audioOut.PlaybackState != PlaybackState.Playing) audioOut.Play(); else audioOut.Pause(); }
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
        }}
}
