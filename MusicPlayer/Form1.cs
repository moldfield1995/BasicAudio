using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        private MusicHandler musicHandler;
        public MusicPlayer()
        {
            //trackerInit();
            InitializeComponent();
            musicHandler.ChangeSong("");
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            musicHandler.Play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            musicHandler.Pause();
        }

        private void MusicPlayer_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
