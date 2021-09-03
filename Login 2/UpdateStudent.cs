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
    public partial class UpdateStudent : Form
    {
        int studentID;
        public UpdateStudent(int studentIDValue)
        {
            InitializeComponent();
            studentID = studentIDValue;

        }
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;
        private void buttonOk_Click(object sender, EventArgs e)
        {
            query = "UPDATE student SET StudentName='" + txtStudentName.Text + "',ContactNo=" + txtContactNo.Text + ",Email='" + txtEmail.Text + "',NIC='" + txtNIC.Text + "' WHERE StudentID=" + studentID + "";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");

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


        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM student where StudentID=" + studentID + "";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            txtStudentName.Text = set.Rows[0]["StudentName"].ToString();
            txtStudentID.Text = set.Rows[0]["StudentID"].ToString();
            txtContactNo.Text = set.Rows[0]["ContactNo"].ToString();
            txtEmail.Text = set.Rows[0]["Email"].ToString();
            txtNIC.Text = set.Rows[0]["NIC"].ToString();
            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Borrower().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
