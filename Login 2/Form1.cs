using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Binuka Silva\OneDrive\Documents\LibrarySystemDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            string login = "SELECT * FROM UserDetails WHERE username='"+txtUsername.Text+"' and password='"+txtPassword.Text+"'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read()==true)
            {
                new Dashboard().Show();
                this.Hide();
                //frvrevweqdcdsf
            }

            else 
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "LOGIN FAILED!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
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

        private void label5_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
