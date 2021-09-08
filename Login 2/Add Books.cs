using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_2
{
   
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBookCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "INSERT INTO book VALUES(" + txtBookID.Text + ",'" + txtBookName.Text + "','" + txtAuthor.Text + "','" + txtPublication.Text + "','" + txtDate.Text+ "'," + txtBookQuantity.Text + ",'" + txtCategory.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successful");

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
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublication.Text = "";
            txtDate.Text = "";
            txtBookID.Text = "";
            txtBookQuantity.Text = "";
            txtCategory.Text = "";
            txtBookName.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Add_Books_Shown(object sender, EventArgs e)
        {
            txtBookName.Focus();
        }
    }
}
