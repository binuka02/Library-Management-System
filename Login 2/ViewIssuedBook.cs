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
    public partial class ViewIssuedBook : Form
    {
        public ViewIssuedBook()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;
        private void ViewIssuedBook_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM issueBook";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Issue_Book().Show();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBookID.Text, "BookID");
        }
        public void searchData(string search, string columnName)
        {
            query = "SELECT * FROM issueBook WHERE " + columnName + " LIKE '%" + search + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentID.Text, "StudentID");
        }
    }
}
