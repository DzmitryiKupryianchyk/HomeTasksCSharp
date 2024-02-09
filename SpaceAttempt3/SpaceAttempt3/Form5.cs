using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceAttempt3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Play7();
            //Play8();
            buttonAlarm.Click += buttonAlarm_Click;
            buttonSOS.Click += buttonSOS_Click;
            buttonFindCrew.Click += buttonFindCrew_Click;
            buttonCheckCargo.Click += buttonCheckCargo_Click;

        }
        public WMPLib.WindowsMediaPlayer WMP2 = new WMPLib.WindowsMediaPlayer();
        public void Play7()
        {
            WMP2.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\alarm1.mp3";
            WMP2.settings.volume = 100;
            WMP2.settings.playCount = 100;
            WMP2.controls.play();
        }
        public WMPLib.WindowsMediaPlayer WMP3 = new WMPLib.WindowsMediaPlayer();
        public void Play8()
        {
            System.Media.SoundPlayer player8 = new System.Media.SoundPlayer();
            player8.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatIsGoingOn.wav";
            player8.Play();
        }
        public void Play9()
        {
            System.Media.SoundPlayer player9 = new System.Media.SoundPlayer();
            player9.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shutUp.wav";
            player9.Play();
        }
        public void Play10()
        {
            System.Media.SoundPlayer player10 = new System.Media.SoundPlayer();
            player10.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\WhatShoulIDo.wav";

            player10.Play();
        }
        private void buttonAlarm_Click(object? sender, EventArgs e)
        {

            WMP2.controls.stop();
            WMP2.close();
            Thread.Sleep(500);
            Play9();
            Thread.Sleep(3000);
            Play10();
        }
        public void Play11()
        {
            System.Media.SoundPlayer player11 = new System.Media.SoundPlayer();
            player11.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\distressSignal.wav";
            player11.Play();
        }
        private void buttonSOS_Click(object? sender, EventArgs e)
        {
            Form6 call = new Form6();
            Play11();
            Thread.Sleep(3500);
            call.ShowDialog();
        }
        public void Play12()
        {
            System.Media.SoundPlayer player12 = new System.Media.SoundPlayer();
            player12.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\findComrades.wav";
            player12.Play();
        }
        private void buttonFindCrew_Click(object? sender, EventArgs e)
        {
            Form7 call = new Form7();
            Play12();
            Thread.Sleep(3500);
            call.ShowDialog();
        }
        public void Play13()
        {
            System.Media.SoundPlayer player13 = new System.Media.SoundPlayer();
            player13.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\checkTheCargo.wav";
            player13.Play();
        }
        private void buttonCheckCargo_Click(object? sender, EventArgs e)
        {
            Form8 call = new Form8();
            Play13();
            Thread.Sleep(3500);
            call.ShowDialog();
        }

        private void buttonFindCrew_Click_1(object sender, EventArgs e)
        {

        }
    }
}
