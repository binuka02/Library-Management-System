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
    public partial class View_Borrower : Form
    {
        public View_Borrower()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;

        public void loadData()
        {
            query = "SELECT * FROM student";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridView1.DataSource = set;
            con.Close();
        }
        private void View_Borrower_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForm()
        {
            Application.Run(new Dashboard());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (validationStudentID())
            {
                UpdateStudent updateStudent = new UpdateStudent(int.Parse(txtSelectedStudentID.Text));
                updateStudent.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect StudentID");
            }
            
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
            dataGridView1.DataSource = set;
            con.Close();
        }
        public bool validationStudentID()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string selectAll = "SELECT * FROM student where StudentID=" + txtSelectedStudentID.Text + "";
            MySqlDataAdapter adapterSelectAll = new MySqlDataAdapter(selectAll, con);
            DataTable dtSelectAll = new DataTable();

            try
            {
                adapterSelectAll.Fill(dtSelectAll);
                dtSelectAll.Rows[0]["StudentID"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            searchData(txtStudentName.Text, "StudentName");
        }
        int studentID;
        private void button1_Click(object sender, EventArgs e)
        {
            if (validationStudentID())
            {
                studentID = int.Parse(txtSelectedStudentID.Text);
                query = "DELETE FROM student WHERE StudentID=" + studentID + "";
                MySqlCommand cmd = new MySqlCommand(query, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion Successful");

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
            else
            {
                MessageBox.Show("Incorrect StudentID");
            }
            


        }
        

        int delstudentid;
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                delstudentid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value);
                txtSelectedStudentID.Text = delstudentid.ToString();
            }
            catch(Exception)
            {

            }
            
        }
    }
}
