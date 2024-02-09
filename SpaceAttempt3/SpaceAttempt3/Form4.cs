using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SpaceAttempt3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            buttonGotIt.Click += buttonGotIt_Click;
        }
        public void buttonGotIt_Click(object sender, EventArgs e)
        {
            Form5 call = new Form5();
            Play6();
            Thread.Sleep(2500);
            call.ShowDialog();
           
        }
        public void Play6()
        {
            System.Media.SoundPlayer player6 = new System.Media.SoundPlayer();
            player6.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\laughing.wav";
            player6.Play();
        }
    }
}
