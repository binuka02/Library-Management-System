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
    public partial class Super_User : Form
    {
        public Super_User()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text=="admin")
            {
                this.Close();
                Thread th = new Thread(openForm1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else 
            {
                MessageBox.Show("Invalid Username or Password","SUPER USER LOGIN FAILED!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }
        private void openForm1()
        {
            Application.Run(new Registration());
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void openForm()
        {
            Application.Run(new Login());
        }
    }
}
