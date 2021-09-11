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
    public partial class SearchBook : Form
    {
        public SearchBook(int bookIDValue)
        {
            InitializeComponent();
            bookID = bookIDValue;
            this.Icon = Properties.Resources.hicon;
        }
        int bookID;
        string query;
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM book WHERE BookID="+bookID+"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }
    }
}
