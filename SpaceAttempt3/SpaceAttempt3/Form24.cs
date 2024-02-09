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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
            Play82();
            buttonResist.Click += buttonResist_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP21 = new WMPLib.WindowsMediaPlayer();
        public void Play82()
        {
            WMP21.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\bastard.wav";
            WMP21.settings.volume = 100;
            WMP21.settings.playCount = 1;
            WMP21.controls.play();
        }
        public void Play83()
        {
            System.Media.SoundPlayer player83 = new System.Media.SoundPlayer();
            player83.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\make.wav";
            player83.PlaySync();
        }
        public void Play84()
        {
            System.Media.SoundPlayer player84 = new System.Media.SoundPlayer();
            player84.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shortAlienScream.wav";
            player84.PlaySync();
        }
        private void buttonResist_Click(object? sender, EventArgs e)
        {
            Form13 call = new Form13();
            Play83();
            Play84();
            call.ShowDialog();
        }
    }
}
