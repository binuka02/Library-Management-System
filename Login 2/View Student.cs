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
    public partial class View_Borrower : Form
    {
        public View_Borrower()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;

        private void View_Borrower_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM student";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridViewStudent.DataSource = set;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent(int.Parse(txtSelectedStudentID.Text));
            updateStudent.Show();
            this.Hide();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentID.Text, "StudentID");
        }

        public void searchData(string search,string columnName)
        {
            query = "SELECT * FROM student WHERE "+columnName+" LIKE '%" + search + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridViewStudent.DataSource = set;
            con.Close();
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentName.Text, "StudentName");
        }
        int studentID;
        private void button1_Click(object sender, EventArgs e)
        {
            studentID = int.Parse(txtSelectedStudentID.Text);

        }

        int delstudentid;
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            delstudentid = Convert.ToInt32(dataGridViewStudent.Rows[e.RowIndex].Cells["StudentID"].Value);
            txtSelectedStudentID.Text = delstudentid.ToString();
        }
    }
}
