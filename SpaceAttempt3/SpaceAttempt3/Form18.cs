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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            Play68();
            buttonShit.Click += buttonShit_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP16 = new WMPLib.WindowsMediaPlayer();
        public void Play68()
        {
            WMP16.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\treshetkiChujogo.mp3";
            WMP16.settings.volume = 100;
            WMP16.settings.playCount = 2;
            WMP16.controls.play();
        }
        public void Play69()
        {
            System.Media.SoundPlayer player69 = new System.Media.SoundPlayer();
            player69.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatAFuck.wav";
            player69.PlaySync();
        }
        public void Play70()
        {
            System.Media.SoundPlayer player70 = new System.Media.SoundPlayer();
            player70.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shortAlienScream.wav";
            player70.PlaySync();
        }
        private void buttonShit_Click(object? sender, EventArgs e)
        {
            Form20 call = new Form20();
            Play69();
            Play70();
            call.ShowDialog();
        }
    }
}
