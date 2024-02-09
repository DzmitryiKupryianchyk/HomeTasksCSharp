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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
            Play85();
            buttonBad.Click += buttonBad_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP22 = new WMPLib.WindowsMediaPlayer();
        public void Play85()
        {
            WMP22.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\holyCrap.wav";
            WMP22.settings.volume = 100;
            WMP22.settings.playCount = 1;
            WMP22.controls.play();
        }
        public void Play86()
        {
            System.Media.SoundPlayer player86 = new System.Media.SoundPlayer();
            player86.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\licehvat.wav";
            player86.PlaySync();
        }
        public void Play87()
        {
            System.Media.SoundPlayer player87 = new System.Media.SoundPlayer();
            player87.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\laughing.wav";
            player87.PlaySync();
        }
        private void buttonBad_Click(object? sender, EventArgs e)
        {
            Form21 call = new Form21();
            Play86();
            Play87();
            call.ShowDialog();
        }
    }
}
