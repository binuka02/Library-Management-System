using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;

namespace Login_2
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "INSERT INTO user VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtUsername.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            if (txtFirstName.Text == "" && txtLastName.Text == "")
            {
                MessageBox.Show("First Name and Last Name fields are empty!");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username field is empty!");
            }
            else if (txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Password fiels are empty!");
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You Have Registered Successfully", "REGISTRATION SUCCESS!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Does Not Match", "REGISTRATION FAILED!");
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFirstName.Focus();

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void lblAlreadyHave_Click(object sender, EventArgs e)
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
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
