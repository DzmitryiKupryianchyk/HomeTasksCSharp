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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Play66();
            buttonOpen.Click += buttonOpen_Click;
            buttonPrecaution.Click += buttonPrecaution_Click;
        }
        public WMPLib.WindowsMediaPlayer WMP15 = new WMPLib.WindowsMediaPlayer();
        public void Play66()
        {
            WMP15.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\rychanieСhujogo.wav";
            WMP15.settings.volume = 100;
            WMP15.settings.playCount = 1;
            WMP15.controls.play();
        }
        public void Play67()
        {
            System.Media.SoundPlayer player67 = new System.Media.SoundPlayer();
            player67.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\comeIn.wav";
            player67.PlaySync();
        }
        public void Play68()
        {
            System.Media.SoundPlayer player68 = new System.Media.SoundPlayer();
            player68.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\strange.wav";
            player68.PlaySync();
        }
        private void buttonOpen_Click(object? sender, EventArgs e)
        {
            Form18 call = new Form18();
            Play67();
            Thread.Sleep(500);
            call.ShowDialog();
        }
        private void buttonPrecaution_Click(object? sender, EventArgs e)
        {
            Form19 call = new Form19();
            Play68();
            Thread.Sleep(500);
            call.ShowDialog();
        }
    }
}
