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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            buttonRadio.Click += buttonRadio_Click;
            buttonInternalCommunication.Click += buttonInternalCommunication_Click;
            buttonScan.Click += buttonScan_Click;
            buttonAlarmProbe.Click += buttonAlarmProbe_Click;
            buttonCheckAntenna.Click += buttonCheckAntenna_Click;
            buttonCheckEngine.Click += buttonCheckEngine_Click;
        }
        public void Play14()
        {
            System.Media.SoundPlayer player14 = new System.Media.SoundPlayer();
            player14.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\distress1.wav";
            player14.PlaySync();    
        }
        public void Play15()
        {
            System.Media.SoundPlayer player15 = new System.Media.SoundPlayer();
            player15.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\radioNoize.wav";
            player15.PlaySync();  
        }
        public void Play16()
        {
            System.Media.SoundPlayer player16 = new System.Media.SoundPlayer();
            player16.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\answerPlease.wav";
            player16.PlaySync();    
        }
        public void Play17()
        {
            System.Media.SoundPlayer player17 = new System.Media.SoundPlayer();
            player17.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\fuck.wav";
            player17.PlaySync();   
        }
        private void buttonRadio_Click (object sender, EventArgs e)
        {
            Play14();
            Play15();
            Play16();
            Play15();
            Play17();
        }
        public void Play18()
        {
            System.Media.SoundPlayer player18 = new System.Media.SoundPlayer();
            player18.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\ThisIsRipley.wav";
            player18.PlaySync();
        }
        public void Play19()
        {
            System.Media.SoundPlayer player19 = new System.Media.SoundPlayer();
            player19.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\signal.wav";
            player19.PlaySync();
        }
        public void Play20()
        {
            System.Media.SoundPlayer player20 = new System.Media.SoundPlayer();
            player20.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\guysPlease.wav";
            player20.PlaySync();
        }
        public void Play21()
        {
            System.Media.SoundPlayer player21 = new System.Media.SoundPlayer();
            player21.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\crewVanished.wav";
            player21.PlaySync();
        }
        private void buttonInternalCommunication_Click (object sender, EventArgs e)
        {
            Play18();
            Play19();
            Play20();
            Play19();
            Play21();

        }
        public void Play22()
        {
            System.Media.SoundPlayer player22 = new System.Media.SoundPlayer();
            player22.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\scanning.wav";
            player22.PlaySync();
        }
        public void Play23()
        {
            System.Media.SoundPlayer player23 = new System.Media.SoundPlayer();
            player23.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\noSigns.wav";
            player23.PlaySync();
        }
        public void Play24()
        {
            System.Media.SoundPlayer player24 = new System.Media.SoundPlayer();
            player24.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\signsOfAlien.wav";
            player24.PlaySync();
        }
        public void Play25()
        {
            System.Media.SoundPlayer player25 = new System.Media.SoundPlayer();
            player25.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\reproduceData.wav";
            player25.PlaySync();
        }
        public void Play26()
        {
            System.Media.SoundPlayer player26 = new System.Media.SoundPlayer();
            player26.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\alienVoice.wav";
            player26.PlaySync();
        }
        public void Play27()
        {
            System.Media.SoundPlayer player27 = new System.Media.SoundPlayer();
            player27.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\breathe.wav";
            player27.PlaySync();
        }
        public void Play28()
        {
            System.Media.SoundPlayer player28 = new System.Media.SoundPlayer();
            player28.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\whatKindOfCargo.wav";
            player28.PlaySync();
        }
        private void buttonScan_Click(object sender, EventArgs e) 
        {
            Play22();
            Thread.Sleep(2000);
            Play23();
            Thread.Sleep(2000);
            Play24();
            Play24();
            Thread.Sleep(1000);
            Play25();
            Play25();
            Thread.Sleep(500);
            Play26();
            Play27();
            Play28();
            

        }
        public void Play29()
        {
            System.Media.SoundPlayer player29 = new System.Media.SoundPlayer();
            player29.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\decisionToReleaseProbe.wav"; 
            player29.PlaySync();
        }
        public void Play30()
        {
            System.Media.SoundPlayer player30 = new System.Media.SoundPlayer();
            player30.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\releaseProbe.wav";
            player30.PlaySync();
        }
        public void Play31()
        {
            System.Media.SoundPlayer player31 = new System.Media.SoundPlayer();
            player31.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\probeSound.wav";
            player31.PlaySync();
        }
        public void Play32()
        {
            System.Media.SoundPlayer player32 = new System.Media.SoundPlayer();
            player32.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\releasedSuccessfully.wav";
            player32.PlaySync();
        }
        public void Play33()
        {
            System.Media.SoundPlayer player33 = new System.Media.SoundPlayer();
            player33.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\fortune.wav";
            player33.PlaySync();
        }
        private void buttonAlarmProbe_Click(object sender, EventArgs e) 
        {
            Play29();
            Thread.Sleep(500);
            Play30();
            Play30();
            Thread.Sleep(2000);
            Play31();
            Thread.Sleep(500);
            Play32();
            Play32();
            Thread.Sleep(1000);
            Play33();
        }
        public void Play34()
        {
            System.Media.SoundPlayer player34 = new System.Media.SoundPlayer();
            player34.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\seeAntenna.wav";
            player34.PlaySync();
        }
        public void Play35()
        {
            System.Media.SoundPlayer player35 = new System.Media.SoundPlayer();
            player35.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\checkEngine.wav";
            player35.PlaySync();
        }
        private void buttonCheckAntenna_Click(object sender, EventArgs e)
        {
            Form9 call = new Form9();
            Play34();
            Thread.Sleep(2000);
            call.ShowDialog();


        }
        private void buttonCheckEngine_Click(object sender, EventArgs e)
        {
            Form10 call = new Form10();
            Play35();
            Thread.Sleep(2000);
            call.ShowDialog();

        }
    }
}
