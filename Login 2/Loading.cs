using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Login_2
{
    public partial class Loading : Form
    {
        
        public Loading()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
            ProgressBar1.Value = 0;
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Login_2.Properties.Resources.HarryPotter2);
            soundPlayer.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Value += 1;
            
            if(ProgressBar1.Value==100)
            {
                timer1.Enabled = false;
                new Login().Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
