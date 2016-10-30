using System.IO;
using System;
using CSCore;
using CSCore.SoundOut;
using CSCore.Codecs;
namespace MusicPlayer
{
    //use CsCore
    class MusicHandler
    {
        private IWaveSource source;
        private WasapiOut audioOut;
        public System.Windows.Forms.TrackBar tracker { get; private set; }
        public MusicHandler()
        {
            source = null;
            audioOut = null;
            //tracker
            tracker = new System.Windows.Forms.TrackBar();
            tracker.CausesValidation = false;
            tracker.LargeChange = 0;
            tracker.Location = new System.Drawing.Point(197, 11);
            tracker.Maximum = 20000;
            tracker.Name = "Tracker";
            tracker.Size = new System.Drawing.Size(237, 45);
            tracker.SmallChange = 0;
            tracker.TabIndex = 3;
            tracker.MouseDown += Tracker_MouseDown;
            tracker.MouseUp += Tracker_MouseUp;
            audioOut = new WasapiOut(); 
        }

        private void Tracker_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            source.Position = tracker.Value;
            Play();
        }

        private void Tracker_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Pause();
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
            if(audioOut != null)
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
    }
}
