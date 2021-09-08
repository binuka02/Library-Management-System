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
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
        int delIssueID, issueID;
        public void searchData(string search, string columnName)
        {
            query = "select issuebook.IssueID, issuebook.BookID, book.BookName, issuebook.StudentID, student.StudentName, issuebook.IssuedDate from issuebook inner join book on book.BookID = issuebook.BookID inner join student on student.StudentID = issuebook.StudentID WHERE issuebook." + columnName + " LIKE '%" + search + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            
        }

        public void loadData()
        {
            query = "select issuebook.IssueID, issuebook.BookID, book.BookName, issuebook.StudentID, student.StudentName, issuebook.IssuedDate from issuebook inner join book on book.BookID = issuebook.BookID inner join student on student.StudentID = issuebook.StudentID;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {

            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            delIssueID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IssueID"].Value);
            txtSelectedIssueID.Text = delIssueID.ToString();
        }

        private void txtIssueID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtIssueID.Text, "IssueID");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentID.Text, "StudentID");
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBookID.Text, "BookID");
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            searchData(txtDate.Text, "IssuedDate");
        }
        int bookID,studentID;
        string date, status;
        private void btnReturn_Click(object sender, EventArgs e)
        {
            issueID = int.Parse(txtSelectedIssueID.Text);
            //get data from issuebook table
            query = "SELECT * FROM issuebook where IssueID=" + issueID  + "";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            bookID = int.Parse(set.Rows[0]["BookID"].ToString());
            studentID = int.Parse(set.Rows[0]["StudentID"].ToString());
            date = DateTime.Now.ToString("dd MMMM yyyy");

            //insert into bookstatus table
            query = "INSERT INTO bookstatus VALUES(" + bookID + "," + studentID + ",'"+date+"','Returned')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Return Successful");
                query = "UPDATE book SET BookQuantity=BookQuantity+1 WHERE BookID=" + bookID + "";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM issuebook WHERE IssueID=" + issueID + "";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "UPDATE student SET NoOfBorrowedBooks=NoOfBorrowedBooks-1 WHERE StudentID="+studentID+"" ;
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "UPDATE student SET NoOfReturnedBooks=NoOfReturnedBooks+1 WHERE StudentID=" + studentID + "";
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
                loadData();
            }
        }
    }
}
