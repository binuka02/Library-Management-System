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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }
        string query;
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        private void InventoryReport_Load(object sender, EventArgs e)
        {
            query="select bookstatus.BookID, book.BookName, bookstatus.StudentID, student.StudentName, bookstatus.Date, bookstatus.Status from bookstatus inner join book on book.BookID = bookstatus.BookID inner join student on student.StudentID = bookstatus.StudentID";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void searchData(string search, string columnName)
        {
            query = "select bookstatus.BookID, book.BookName, bookstatus.StudentID, student.StudentName, bookstatus.Date, bookstatus.Status from bookstatus inner join book on book.BookID = bookstatus.BookID inner join student on student.StudentID = bookstatus.StudentID WHERE " + columnName + " LIKE '%" + search + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }
        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBookID.Text, "book.BookID");
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBookName.Text, "book.BookName");
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentID.Text, "student.StudentID");
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentName.Text, "student.StudentName");
        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            searchData(txtDate.Text, "Date");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
