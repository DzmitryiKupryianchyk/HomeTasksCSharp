using System.Media;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
namespace SpaceAttempt3
    
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
            Play1();
            buttonAccept.Click += buttonAccept_Click;
            buttonDecline.Click += buttonDecline_Click;
            

        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        public void Play1() 
        {
            WMP.URL = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\ZeroTolerance.mp3";
            WMP.settings.volume = 100;
            WMP.settings.playCount = 100;
            WMP.controls.play();
            WMP.settings.volume = 30;
            //WMP.controls.stop();
            //WMP.close();

        }
        public void Play2()
        {
            
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
            player2.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\getOverHere.wav";
            player2.Play();
            Thread.Sleep(2000);
            
        }
        private void buttonAccept_Click(object? sender, EventArgs e)
        {
            Form2 call = new Form2();
            Play2();
            Thread.Sleep(1000);
            call.ShowDialog();
           
        }
        public void Play3()
        {
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
            player3.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\suck1.wav";
            player3.Play();
            

        }

        private void buttonDecline_Click(object? sender, EventArgs e)
        {
            Form3 call = new Form3();
            Play3();
            Thread.Sleep(3000);
            call.ShowDialog();
            
        }

       

        public void SetText()
        {
           

        }
       
    }
}
