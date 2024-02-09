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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
            buttonSuccess.Click += buttonSuccess_Click;
        }
        public void Play65()
            
        {
            System.Media.SoundPlayer player65 = new System.Media.SoundPlayer();
            player65.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\wellDone.wav";
            player65.PlaySync();
        }
        private void buttonSuccess_Click(object sender, EventArgs e)
        {
            Play65();
            Thread.Sleep(1000);
            Application.Exit();
        }
    }
}
