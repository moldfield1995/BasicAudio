using System.Media;
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
        public MusicHandler()
        {
            source = null;
            audioOut = null;
        }
        public void ChangeSong(string file)
        {
            file = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            file = Path.Combine(file, "Monstercat Podcast Ep. 121.m4a");
            source = CodecFactory.Instance.GetCodec(file);
            audioOut = new WasapiOut();
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
