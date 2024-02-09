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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            Play78();
            buttonHelp.Click += buttonHelp_Click;
            buttonRun1.Click += buttonRun1_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP20 = new WMPLib.WindowsMediaPlayer();
        public void Play78()
        {
            WMP20.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\angryAlien.wav";
            WMP20.settings.volume = 100;
            WMP20.settings.playCount = 1;
            WMP20.controls.play();
        }
        public void Play79()
        {
            System.Media.SoundPlayer player79 = new System.Media.SoundPlayer();
            player79.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\bitch.wav";
            player79.PlaySync();
        }
        public void Play80()
        {
            System.Media.SoundPlayer player80 = new System.Media.SoundPlayer();
            player80.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\scream.wav";
            player80.PlaySync();
        }
        public void Play81()
        {
            System.Media.SoundPlayer player81 = new System.Media.SoundPlayer();
            player81.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shortAlienScream.wav";
            player81.PlaySync();
        }
        private void buttonHelp_Click(object? sender, EventArgs e)
        {
            Form24 call = new Form24();
            Play79();
            Play81();
            call.ShowDialog();
        }
        private void buttonRun1_Click(object? sender, EventArgs e)
        {
            Form25 call = new Form25();
            Play80();
            call.ShowDialog();
        }
    }
}
