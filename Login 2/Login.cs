﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Login_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
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
    
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            //(SELECT COUNT(Column Name/All Columns=*) FROM user WHERE Username ='admin' AND Password='admin') if found output = '1'
            string query = "SELECT COUNT(*) FROM user WHERE Username = '" + txtUsername.Text + "' and Password ='" + txtPassword.Text + "'";
            //MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                //if found output
                //column index 0
                /*   +----------+
                     | COUNT(*) |    
                     +----------+
                     |        1 |    row index 0
                     +----------+    */
                //dt.Rows[row index][column index]
                if (int.Parse(dt.Rows[0][0].ToString()) >= 1)
                {
                    this.Close();
                    Thread th = new Thread(openForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                //if not found output
                //column index 0
                /*   +----------+
                     | COUNT(*) |    
                     +----------+
                     |        0 |    row index 0
                     +----------+    */
                {
                    MessageBox.Show("Invalid Username or Password, Please Try Again", "LOGIN FAILED!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void openForm()
        {
            Application.Run(new Dashboard());
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
            this.Close();
            Thread th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openForm1()
        {
            Application.Run(new Super_User());
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }
    }
}
