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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            Play49();
            buttonMove.Click += new EventHandler(buttonMove_Click);
        }
        public WMPLib.WindowsMediaPlayer WMP10 = new WMPLib.WindowsMediaPlayer();
        public void Play49()
        {
            WMP10.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\questions.mp3";
            WMP10.settings.volume = 100;
            WMP10.settings.playCount = 1;
            WMP10.controls.play();
        }
        public void Play50()
        {
            System.Media.SoundPlayer player50 = new System.Media.SoundPlayer();
            player50.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\angryAlien.wav";
            player50.Play();
        }
        public void Play51()
        {
            System.Media.SoundPlayer player51 = new System.Media.SoundPlayer();
            player51.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\haveToRun.wav";
            player51.Play();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            Form14 call = new Form14();
            Play50();
            Thread.Sleep(1000);
            Play51();
            Thread.Sleep(3000);
            call.ShowDialog();

        }
    }
}
