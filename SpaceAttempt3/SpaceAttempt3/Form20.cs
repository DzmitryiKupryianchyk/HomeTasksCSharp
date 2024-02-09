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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
            Play71();
            buttonFail.Click += buttonFail_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP17 = new WMPLib.WindowsMediaPlayer();
        public void Play71()
        {
            WMP17.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\womanScream.wav";
            WMP17.settings.volume = 100;
            WMP17.settings.playCount = 1;
            WMP17.controls.play();
        }
        public void Play72()
        {
            System.Media.SoundPlayer player69 = new System.Media.SoundPlayer();
            player69.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\pathetic.wav";
            player69.PlaySync();
        }
        private void buttonFail_Click(object? sender, EventArgs e)
        {
            Play72();
            Application.Exit();
        }
    }
}
