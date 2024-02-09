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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AffirmativeButton.Click += AffirmativeButton_Click;
        }
        private void AffirmativeButton_Click(object? sender, EventArgs e)
        {
            Form4 call = new Form4();
            Play5();
            Thread.Sleep(1000);
            call.ShowDialog();

        }
        public void Play5()
        {

            System.Media.SoundPlayer player5 = new System.Media.SoundPlayer();
            player5.SoundLocation = @"C:\Users\Lenovo\source\repos\SpaceAttempt3\SpaceAttempt3\bin\Debug\excellent.wav";
            player5.Play();
            Thread.Sleep(1500);
            
        }


    }
}
