using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Login_2
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Romance().Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sports().Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Mysteries().Show();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Religion().Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Biographies().Show();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForm()
        {
            Application.Run(new Dashboard());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Business().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Comics().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Entertainment().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Health_and_Fitness().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_and_Garden().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Horror().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Kids().Show();
        }
    }
}
