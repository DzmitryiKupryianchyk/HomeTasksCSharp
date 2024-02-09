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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
            Play72();
            buttonFail1.Click += buttonFail1_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP18 = new WMPLib.WindowsMediaPlayer();
        public void Play72()
        {
            WMP18.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\womanScream.wav";
            WMP18.settings.volume = 100;
            WMP18.settings.playCount = 1;
            WMP18.controls.play();
        }
        public void Play73()
        {
            System.Media.SoundPlayer player69 = new System.Media.SoundPlayer();
            player69.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\fatality.wav";
            player69.PlaySync();
        }
        private void buttonFail1_Click(object? sender, EventArgs e)
        {
            Play73();
            Application.Exit();
        }
    }
}
