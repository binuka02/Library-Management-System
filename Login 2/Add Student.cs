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
using System.Threading;

namespace Login_2
{
    public partial class Add_Borrower : Form
    {
        public Add_Borrower()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Borrower_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBorrowerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBorrowerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBorrowerEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtBookCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "INSERT INTO student(StudentID,StudentName,ContactNo,Email,NIC) VALUES(" + txtStudentID.Text + ",'" + txtStudentName.Text + "'," + txtContactNo.Text + ",'" + txtEmail.Text + "','" + txtNIC.Text + "');";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Query Added Successful");

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
 
            txtStudentName.Text = "";
            txtStudentID.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            txtNIC.Text = "";
            txtStudentName.Focus();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        

        private void Add_Borrower_Shown(object sender, EventArgs e)
        {
            txtStudentName.Focus();
        }
    }
}
