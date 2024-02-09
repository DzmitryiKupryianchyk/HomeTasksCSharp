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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            Play47();
            buttonFinish.Click += buttonFinish_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP9 = new WMPLib.WindowsMediaPlayer();
        public void Play47()
        {
            WMP9.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\womanScream.wav";
            //WMP8.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatIsThat.mp3";
            WMP9.settings.volume = 100;
            WMP9.settings.playCount = 1;
            WMP9.controls.play();
        }
        public void Play48()
        {
            System.Media.SoundPlayer player48 = new System.Media.SoundPlayer();
            player48.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\fatality.wav";
            player48.PlaySync();
        }
        private void buttonFinish_Click(object? sender, EventArgs e)
        {
            Play48();
            Thread.Sleep(1500);
            Application.Exit();
        }
    }
}
