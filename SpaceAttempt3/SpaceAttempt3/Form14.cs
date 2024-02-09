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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            Play52();
            buttonGoToControll.Click += buttonGoToControll_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP11 = new WMPLib.WindowsMediaPlayer();
        public void Play52()
        {
            WMP11.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\FuckingHell.mp3";
            WMP11.settings.volume = 100;
            WMP11.settings.playCount = 1;
            WMP11.controls.play();
        }
        public void Play53()
        {
            System.Media.SoundPlayer player53 = new System.Media.SoundPlayer();
            player53.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\duty.wav";
            player53.Play();
        }
        private void buttonGoToControll_Click(object sender, EventArgs e)
        {
            Form15 call = new Form15();
            Play53();
            Thread.Sleep(5000);
            call.ShowDialog();
        }
 
    }
}
