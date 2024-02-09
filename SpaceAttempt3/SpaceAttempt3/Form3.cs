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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            buttonFinish.Click += buttonFinish_Click;
            Play4();
        }
        public void buttonFinish_Click(object sender, EventArgs e)
        {
            Play4();
            Thread.Sleep(3500);
            Application.Exit();
        }
        public void Play4()
        {
            System.Media.SoundPlayer player4 = new System.Media.SoundPlayer();
            player4.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\laughing.wav";
            player4.Play();
        }
    }
}
