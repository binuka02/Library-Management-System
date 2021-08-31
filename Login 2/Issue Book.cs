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
    public partial class Issue_Book : Form
    {
        public Issue_Book()
        {
            InitializeComponent();
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
        string date;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("dd MMMM yyyy");
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "INSERT INTO issueBook(BookID,StudentID,IssuedDate) VALUES(" + txtBookID.Text + ","+txtStudentID.Text+",'"+date+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Issue Successful");
                query = "UPDATE book SET BookQuantity=BookQuantity-1 WHERE BookID=" + txtBookID.Text + "";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "INSERT INTO bookstatus VALUES(" + txtBookID.Text + "," + txtStudentID.Text + ",'" + date + "','Issued')";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

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

        private void button1_Click(object sender, EventArgs e)
        {
            new ViewIssuedBook().Show();
            this.Hide();

        }
    }
}
