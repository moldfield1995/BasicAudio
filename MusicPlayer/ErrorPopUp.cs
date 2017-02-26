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
    public partial class ErrorPopUp : Form
    {
        public ErrorPopUp()
        {
            InitializeComponent();
        }

        public void SetString(string value)
        {
            ErrorText.Text = value;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
