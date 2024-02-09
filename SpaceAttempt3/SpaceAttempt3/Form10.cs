using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SpaceAttempt3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Play39();
            buttonHurry.Click += buttonHurry_Click;
            
        }

       
        public WMPLib.WindowsMediaPlayer WMP4 = new WMPLib.WindowsMediaPlayer();
        //public WMPLib.WindowsMediaPlayer WMP5 = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer WMP6 = new WMPLib.WindowsMediaPlayer();

        public void Play39()
        {
            WMP4.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\figureOut.wav";
            WMP4.settings.volume = 100;
            WMP4.settings.playCount = 1;
            WMP4.controls.play();
            
            

            
        }
        public void Play40()
        {
            System.Media.SoundPlayer player40 = new System.Media.SoundPlayer();
            player40.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\treshetkiChujogo1.wav";    
            player40.Play();
        }
       

        public void Play41()
        {
            System.Media.SoundPlayer player41 = new System.Media.SoundPlayer();
            player41.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatIsThat1.wav";
            player41.Play();
            
        }
        private void buttonHurry_Click(object? sender, EventArgs e)
        {
            Form11 call = new Form11();
            Thread.Sleep(1000);
            Play40();
            Thread.Sleep(3000);
            Play41();
            Thread.Sleep(2000);
            
            call.ShowDialog();
        }
   


    }
}
