﻿using System;
using System.Windows.Forms;
using System.IO;
using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        private IWaveSource source;
        private WasapiOut audioOut;

        public MusicPlayer()
        {
            //trackerInit();
            InitializeComponent();
            source = null;
            audioOut = new WasapiOut();
            audioOut.Stopped += songFinished;
        }

        private void songFinished(object sender, PlaybackStoppedEventArgs e)
        {
            if (e.Exception == null && !e.HasError && source.Position >= source.Length)
            {
                //check if out of bounds
                ListSongName.SetSelected(ListSongName.SelectedIndex++, true);

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
            if (File.Exists(file))
            {
                source = CodecFactory.Instance.GetCodec(file);
                tracker.Maximum = (int)source.Length;
                tracker.Value = 0;
                audioOut.Stop();
                audioOut.Initialize(source);
            }
            else
            {

            }

        }
        public void CreatePopupWait(string message)
        {
            ErrorPopUp popup = new ErrorPopUp();
            popup.SetString(message);
            this.ShowDialog(popup);
        }
        public void Play()
        {
            if (source != null)
                audioOut.Play();
        }
        public void Pause() { audioOut.Pause(); }
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
                FileData[] fileData = new FileData[files.Length];
                for (int i = 0, length = files.Length; i < length; i++)
                {
                    fileData[i].location = files[i];
                    fileData[i].name = Path.GetFileNameWithoutExtension(files[i]);
                }
                ListSongName.Items.AddRange(fileData);
            }
        }

        private void ListSongName_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
        }

        private void ListSongName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileData fd = (FileData)ListSongName.SelectedItem;
            ChangeSong(fd.location);
        }
    }
    public class FileData
    {
        public string name;
        public string location;
        public override string ToString() { return name; }
    }
}
