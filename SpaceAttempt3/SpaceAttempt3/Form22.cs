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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
            Play73();
            buttonRun1.Click += buttonRun1_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP18 = new WMPLib.WindowsMediaPlayer();
        public void Play73()
        {
            WMP18.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\bigDaddy.wav";
            WMP18.settings.volume = 100;
            WMP18.settings.playCount = 1;
            WMP18.controls.play();
        }
        public void Play74()
        {
            System.Media.SoundPlayer player69 = new System.Media.SoundPlayer();
            player69.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shortAlienScream.wav";
            player69.PlaySync();
        }
        
        private void buttonRun1_Click(object? sender, EventArgs e)
        {
            Form20 call = new Form20();
            Play74();
            call.ShowDialog();
        }
    }
}
