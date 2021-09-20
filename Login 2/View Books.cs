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
    public partial class View_Books : Form
    {
        bool viewBooksInterface;
        public View_Books(bool viewBooks)
        {
            InitializeComponent();
            viewBooksInterface = viewBooks;
            this.Icon = Properties.Resources.hicon;

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForm()
        {
         
            if (viewBooksInterface)
            {
                Application.Run(new Dashboard());
            }
            else
            {
                Application.Run(new Issue_Book());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBookName.Text);
        }

        public void searchData(string search)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "SELECT * FROM book WHERE BookName LIKE '%"+search+"%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridBook.DataSource = set;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBookCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBookQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            txtBookName.Text = "";
            txtBookName.Focus();
        }
        int delbookid,bookid;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            delbookid = Convert.ToInt32(dataGridBook.Rows[e.RowIndex].Cells["BookID"].Value);
            txtSelectedBookID.Text = delbookid.ToString();
            

        }
        bool bookIDValidation = true;
        public bool validationBookID()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string selectAll = "SELECT * FROM book where BookID=" + txtSelectedBookID.Text + "";
            MySqlDataAdapter adapterSelectAll = new MySqlDataAdapter(selectAll, con);
            DataTable dtSelectAll = new DataTable();
            
            try
            {
                adapterSelectAll.Fill(dtSelectAll);
                dtSelectAll.Rows[0]["BookID"].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void View_Books_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "SELECT * FROM book";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataGridBook.DataSource = set;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validationBookID())
            {
                bookid = int.Parse(txtSelectedBookID.Text);
                MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
                string query = "DELETE FROM book WHERE BookID= " + bookid + ";";
                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion BookID = " + bookid + " Sucessful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                    query = "SELECT * FROM book";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                    DataTable set = new DataTable();
                    adapter.Fill(set);
                    dataGridBook.DataSource = set;

                }
            }
            else
            {
                MessageBox.Show("Incorrect BookID");
            }
            

        }

        private void txtSelectedBookID_TextChanged(object sender, EventArgs e)
        {

        }
        int selectedBookID;
        private void dataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedBookID = Convert.ToInt32(dataGridBook.Rows[e.RowIndex].Cells["BookID"].Value);
            txtSelectedBookID.Text = selectedBookID.ToString();

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (validationBookID())
            {
                bookid = Convert.ToInt32(txtSelectedBookID.Text);
                UpdateBook updateBook = new UpdateBook(bookid);
                updateBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect BookID");
            }
            

           
        }
    }
}
