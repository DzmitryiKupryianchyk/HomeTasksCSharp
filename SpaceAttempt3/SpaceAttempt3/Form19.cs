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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            Play73();
            buttonLook.Click += buttonLook_Click;
            buttonGetOut.Click += buttonGetOut_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP18 = new WMPLib.WindowsMediaPlayer();
        public void Play73()
        {
            WMP18.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\eggs.wav";
            WMP18.settings.volume = 100;
            WMP18.settings.playCount = 1;
            WMP18.controls.play();
        }
        public void Play74()
        {
            System.Media.SoundPlayer player74 = new System.Media.SoundPlayer();
            player74.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\interesting.wav";
            player74.PlaySync();
        }
        public void Play75()
        {
            System.Media.SoundPlayer player75 = new System.Media.SoundPlayer();
            player75.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\licehvat.wav";
            player75.PlaySync();
        }
        public void Play76()
        {
            System.Media.SoundPlayer player76 = new System.Media.SoundPlayer();
            player76.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\needToLeave.wav";
            player76.PlaySync();
        }
        private void buttonLook_Click(object? sender, EventArgs e)
        {
            Form21 call = new Form21();
            Play74();
            Thread.Sleep(500);
            Play75();
            call.ShowDialog();
        }
        private void buttonGetOut_Click(object? sender, EventArgs e)
        {
            Form22 call = new Form22();
            Play76();
            Thread.Sleep(500);
            call.ShowDialog();
        }
    }
}
