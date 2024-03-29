﻿using System;
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
            this.Icon = Properties.Resources.hicon;
        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;
        private void ViewIssuedBook_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select issuebook.BookID, book.BookName, issuebook.StudentID, student.StudentName, issuebook.IssuedDate from issuebook inner join book on book.BookID = issuebook.BookID inner join student on student.StudentID = issuebook.StudentID;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable set = new DataTable();
                adapter.Fill(set);
                dataGridView1.DataSource = set;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtStudentID.Text = "";
            txtBookID.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
