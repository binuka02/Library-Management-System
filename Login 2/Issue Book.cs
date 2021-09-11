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
    public partial class Issue_Book : Form
    {
        public Issue_Book()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
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
            new View_Books(false).Show();
            this.Hide();
            //new SearchBook(int.Parse(txtBookID.Text)).Show();
            
        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
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
        string expiredBookID,expiredBookName;
        public bool checkBookExpire()
        {
            try
            {
                DataTable dt2 = new DataTable();
                query = "select issuebook.BookId, book.BookName, datediff('"+dateNow+"',issuebook.issuedDate) from issuebook inner join book on book.bookid=issuebook.bookid where StudentID=" + txtStudentID.Text + "";
                adapt = new MySqlDataAdapter(query, con);
                adapt.Fill(dt2);
                query = "select NoOfBorrowedBooks from student where StudentID=" + txtStudentID.Text + "";
                DataTable dt3 = new DataTable();
                adapt = new MySqlDataAdapter(query, con);
                adapt.Fill(dt3);
                int NoOfBorrowedBooks = int.Parse(dt3.Rows[0][0].ToString());
                for (int i = 0; i < NoOfBorrowedBooks; i++)
                {
                    if (int.Parse(dt2.Rows[i][2].ToString()) > 14)
                    {
                        expiredBookID = dt2.Rows[i][0].ToString();
                        expiredBookName= dt2.Rows[i][1].ToString();
                        return true;
                    }
                    else
                        return false;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            
            
        }

        string dateNow,query;
        MySqlConnection con;
        MySqlDataAdapter adapt;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool found;
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            query = "select BookName,BookQuantity from book where BookID=" + txtBookID.Text + "";
            try
            {
                adapt = new MySqlDataAdapter(query, con);
                DataTable dt4 = new DataTable();
                adapt.Fill(dt4);
                txtBookName.Text = dt4.Rows[0][0].ToString();
                txtBookQuantity.Text = dt4.Rows[0][1].ToString();
                found = true;
            }
            catch(Exception)
            {
                found = false;
            }
            
            
            
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            query = "select StudentName,NoOfBorrowedBooks from student where StudentID=" + txtStudentID.Text + "";
            try
            {
                adapt = new MySqlDataAdapter(query, con);
                DataTable dt4 = new DataTable();
                adapt.Fill(dt4);
                txtStudentName.Text = dt4.Rows[0][0].ToString();
                txtNoOfBorrowedBooks.Text = dt4.Rows[0][1].ToString();
                found = true;
            }
            catch (Exception)
            {
                found = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (found)
            {
                dateNow = DateTime.Now.ToString("yyyy-MM-dd");
                con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
                query = "INSERT INTO issueBook(BookID,StudentID,IssuedDate) VALUES(" + txtBookID.Text + "," + txtStudentID.Text + ",'" + dateNow + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                string query1 = "SELECT NoOfBorrowedBooks FROM student WHERE StudentID=" + txtStudentID.Text + "";
                adapt = new MySqlDataAdapter(query1, con);
                DataTable dt = new DataTable();

                try
                {
                    adapt.Fill(dt);
                    if (int.Parse(dt.Rows[0]["NoOfBorrowedBooks"].ToString()) == 3 && checkSameBook() && checkBookExpire())
                    {
                        MessageBox.Show("1. Can't Issue Same Book!\n2. Maximum Books Borrowed!\n\t3.A Book has been Expired! Please Return BookID=" + expiredBookID + ", BookName=" + expiredBookName + "", "Book Issue Failed!");
                    }
                    else if (checkSameBook())
                    {
                        MessageBox.Show("Can't Issue Same Book!", "Book Issue Failed!");
                    }
                    else if (int.Parse(dt.Rows[0]["NoOfBorrowedBooks"].ToString()) >= 3)
                    {
                        MessageBox.Show("Maximum Books Borrowed!", "Book Issue Failed!");
                    }
                    else if (checkBookExpire())
                    {
                        MessageBox.Show("A Book has been Expired! Please Return BookID=" + expiredBookID + ", BookName = " + expiredBookName + "");
                    }
                    else
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book Issue Successful");
                        query = "UPDATE book SET BookQuantity=BookQuantity-1 WHERE BookID=" + txtBookID.Text + "";
                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        query = "INSERT INTO bookstatus VALUES(" + txtBookID.Text + "," + txtStudentID.Text + ",'" + dateNow + "','Issued')";
                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        query = "UPDATE student SET NoOfBorrowedBooks=NoOfBorrowedBooks+1 WHERE StudentID=" + txtStudentID.Text + "";
                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Entered Details Incorrect");
                }

                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Entered Details Incorrect");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ViewIssuedBook().Show();
            this.Hide();

        }
    }
}
