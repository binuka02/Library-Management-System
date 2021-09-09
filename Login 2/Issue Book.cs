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
            new SearchBook(int.Parse(txtBookID.Text)).Show();
            
        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
        public bool checkSameBook()
        {
            DataTable dt1 = new DataTable();
            query = "SELECT COUNT(BookID) FROM issuebook WHERE StudentID=" + txtStudentID.Text + " AND BookID="+txtBookID.Text+"" ;
            adapt = new MySqlDataAdapter(query, con);
            try
            {
                adapt.Fill(dt1);
                //MessageBox.Show(dt1.Rows[0]["BookID"].ToString());
                if (int.Parse(dt1.Rows[0][0].ToString()) >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                
                return false;
            }
            
            
        }

        string date,query;
        MySqlConnection con;
        MySqlDataAdapter adapt;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            date = DateTime.Now.ToString("yyyy-MM-dd");
            con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            query = "INSERT INTO issueBook(BookID,StudentID,IssuedDate) VALUES(" + txtBookID.Text + ","+txtStudentID.Text+",'"+date+"')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            string query1 = "SELECT NoOfBorrowedBooks FROM student WHERE StudentID=" + txtStudentID.Text + "";
            adapt = new MySqlDataAdapter(query1, con);
            DataTable dt = new DataTable();

            try
            {
                adapt.Fill(dt);
                if (int.Parse(dt.Rows[0]["NoOfBorrowedBooks"].ToString())== 3 && checkSameBook())
                {
                    MessageBox.Show("1. Can't Issue Same Book!\n2. Maximum Books Borrowed!", "Book Issue Failed!");
                }
                else if (checkSameBook())
                {
                    MessageBox.Show("Can't Issue Same Book!", "Book Issue Failed!");
                }
                else if(int.Parse(dt.Rows[0]["NoOfBorrowedBooks"].ToString()) >= 3)
                {
                    MessageBox.Show("Maximum Books Borrowed!", "Book Issue Failed!");
                }
                else
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
                    query = "UPDATE student SET NoOfBorrowedBooks=NoOfBorrowedBooks+1 WHERE StudentID=" + txtStudentID.Text + "";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                

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
