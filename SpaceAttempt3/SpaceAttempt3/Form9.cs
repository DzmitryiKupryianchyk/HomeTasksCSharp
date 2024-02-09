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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            buttonToEngine.Click += buttonToEngine_Click;
            Play37();
        }

        public WMPLib.WindowsMediaPlayer WMP3 = new WMPLib.WindowsMediaPlayer();
        public void Play37()
        {
            WMP3.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\antennaDestroyed.wav";
            WMP3.settings.volume = 100;
            WMP3.settings.playCount = 1;
            WMP3.controls.play();

            //WMP4.settings.setMode();
        }
        public void Play38()
        {
            System.Media.SoundPlayer player38 = new System.Media.SoundPlayer();
            player38.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\checkEngine1.wav";
            player38.PlaySync();
        }
        
        private void buttonToEngine_Click(object? sender, EventArgs e)
        {
            Form10 call1 = new Form10();
            //Play37();
            //Thread.Sleep(1000);
            Play38();
            Thread.Sleep(2000);
            call1.ShowDialog();
            

        }
    }
}
