using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login_2
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //tfhyrhryhrhyhyryhd
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Binuka Silva\OneDrive\Documents\LibrarySystemDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

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
                con.Open();
                string register = "INSERT INTO UserDetails VALUES ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtUsername.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtConfirmPassword.Text + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();

                con.Close();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtUsername.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("You Have Registered Successfully","REGISTRATION SUCCESS!");
            }

            else
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
            new Form1().Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
