using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Data;

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
            string reg = "SELECT COUNT(*) FROM user WHERE Username = '" + txtUsername.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(reg, con);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Fields are Empty!");
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password Does Not Match", "REGISTRATION FAILED!");
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                    txtPassword.Focus();
                }
                else if (int.Parse(dt.Rows[0][0].ToString()) >= 1)
                {
                    MessageBox.Show("This Username is Already Registered!", "REGISTRATION FAILED!");
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }
                else if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You Have Registered Successfully", "REGISTRATION SUCCESS!");

                }    
            }            
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
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
