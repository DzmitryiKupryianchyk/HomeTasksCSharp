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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            Play41();
            buttonRun.Click += buttonRun_Click;
            buttonFight.Click += buttonFight_Click;

        }
        public WMPLib.WindowsMediaPlayer WMP7 = new WMPLib.WindowsMediaPlayer();
        public WMPLib.WindowsMediaPlayer WMP8 = new WMPLib.WindowsMediaPlayer();
        public void Play41()
        {
            WMP7.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\rychanieСhujogo.wav";
            WMP7.settings.volume = 100;
            WMP7.settings.playCount = 1;
            WMP7.controls.play();
        }
        public void Play42()
        {
            System.Media.SoundPlayer player42 = new System.Media.SoundPlayer();
            player42.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\tisIsRipley.wav";
            player42.Play();
        }
        public void Play43()
        {
            
            WMP8.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatIsThat.mp3";
            WMP8.settings.volume = 100;
            WMP8.settings.playCount = 1;
            WMP8.controls.play();
        }
        public void Play44()
        {
            System.Media.SoundPlayer player44 = new System.Media.SoundPlayer();
            player44.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\scream.wav";
            player44.PlaySync();
        }
        public void Play45()
        {
            System.Media.SoundPlayer player45 = new System.Media.SoundPlayer();
            player45.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\finishHer.wav";
            player45.PlaySync();
        }
        public void Play46()
        {
            System.Media.SoundPlayer player46 = new System.Media.SoundPlayer();
            player46.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shortAlienScream.wav";
            player46.PlaySync();
        }
        private void buttonRun_Click(object? sender, EventArgs e)
        {
            Form12 call = new Form12();
            Play44();
            Thread.Sleep(100);
            call.ShowDialog();
        }
        private void buttonFight_Click(object? sender, EventArgs e)
        {
            Form13 call = new Form13();
            Play45();
            //Thread.Sleep(1000);
            Play46();
            Thread.Sleep(500);
            call.ShowDialog();
        }

    }
}
