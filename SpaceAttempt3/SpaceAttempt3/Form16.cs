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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            buttonLaunch.Click += new EventHandler(buttonLaunch_Click);
        }
        public void Play65()
        {
            System.Media.SoundPlayer player65 = new System.Media.SoundPlayer();
            player65.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\shuttleLaunch.wav";
            player65.PlaySync();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            Form17 call = new Form17();
            Play65();
            //Thread.Sleep(7000);
            call.ShowDialog();

        }
    }
}
