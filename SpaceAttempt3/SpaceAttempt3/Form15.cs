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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            buttonRadio.Click += buttonRadio_Click;
            buttonIntCommunication.Click += buttonIntCommunication_Click;
            buttonProbe.Click += buttonProbe_Click;
            buttonScan.Click += buttonScan_Click;
            buttonDestruction.Click += buttonDestruction_Click;
            buttonRunToShuttle.Click += buttonRunToShuttle_Click;
        }
        public void Play54()
        {
            System.Media.SoundPlayer player54 = new System.Media.SoundPlayer();
            player54.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\distress1.wav";
            player54.PlaySync();
        }
        public void Play55()
        {
            System.Media.SoundPlayer player55 = new System.Media.SoundPlayer();
            player55.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\radioNoize.wav";
            player55.PlaySync();
        }
        public void Play56()
        {
            System.Media.SoundPlayer player56 = new System.Media.SoundPlayer();
            player56.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\stillNothing.wav";
            player56.PlaySync();
        }
        public void Play57()
        {
            System.Media.SoundPlayer player57 = new System.Media.SoundPlayer();
            player57.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\wasteOfTime.wav";
            player57.PlaySync();
        }
        public void Play58()
        {
            System.Media.SoundPlayer player58 = new System.Media.SoundPlayer();
            player58.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\probeSound.wav";
            player58.PlaySync();
        }
        public void Play59()
        {
            System.Media.SoundPlayer player59 = new System.Media.SoundPlayer();
            player59.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\hope.wav";
            player59.PlaySync();
        }
        public void Play60()
        {
            System.Media.SoundPlayer player60 = new System.Media.SoundPlayer();
            player60.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\scanning.wav";
            player60.PlaySync();
        }
        public void Play61()
        {
            System.Media.SoundPlayer player61 = new System.Media.SoundPlayer();
            player61.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\significantIncrease.wav";
            player61.PlaySync();
        }
        public void Play62()
        {
            System.Media.SoundPlayer player62 = new System.Media.SoundPlayer();
            player62.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shit.wav";
            player62.PlaySync();
        }
        public void Play63()
        {
            System.Media.SoundPlayer player62 = new System.Media.SoundPlayer();
            player62.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\systemActivated.wav";
            player62.PlaySync();
        }
        public void Play64()
        {
            System.Media.SoundPlayer player62 = new System.Media.SoundPlayer();
            player62.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\biches.wav";
            player62.PlaySync();
        }
       
        private void buttonRadio_Click(object sender, EventArgs e)
        {
            Play54();
            Play55();
            Play56();
        }
        private void buttonIntCommunication_Click(object sender, EventArgs e)
        {
            Play57();
        }
        private void buttonProbe_Click(object sender, EventArgs e)
        {
            Play58();
            Play59();
        }
        private void buttonScan_Click(object sender, EventArgs e)
        {
            Play60();
            Play61();
            Play61();
            Thread.Sleep(500);
            Play62();


        }
        private void buttonDestruction_Click(object sender, EventArgs e)
        {
            Play63();
            Play63();
        }
        private void buttonRunToShuttle_Click(object sender, EventArgs e)
        {
            Form16 call = new Form16();
            Play64();
            Thread.Sleep(2500);
            call.ShowDialog();
        }
    }
}
