using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceAttempt3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Play75();
            buttonMoveOn.Click += buttonMoveOn_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP19 = new WMPLib.WindowsMediaPlayer();
        public void Play75()
        {
            WMP19.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\strangelyQuiete.wav";
            WMP19.settings.volume = 100;
            WMP19.settings.playCount = 1;
            WMP19.controls.play();
        }
        public void Play76()
        {
            System.Media.SoundPlayer player76 = new System.Media.SoundPlayer();
            player76.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\manScream.wav";
            player76.PlaySync();
        }
        public void Play77()
        {
            System.Media.SoundPlayer player77 = new System.Media.SoundPlayer();
            player77.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\iHear.wav";
            player77.PlaySync();
        }
        private void buttonMoveOn_Click(object? sender, EventArgs e)
        {
            Form23 call = new Form23();
            Play76();
            Play77();
            call.ShowDialog();
        }
    }
}
