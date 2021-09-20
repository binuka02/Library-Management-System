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
    public partial class UpdateBook : Form
    {
        int bookID;
        public UpdateBook(int bookIDValue)
        {
            InitializeComponent();
            bookID = bookIDValue;
            this.Icon = Properties.Resources.hicon;

        }

        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
        string query;

        private void UpdateBook_Load(object sender, EventArgs e)
        {

            query = "SELECT * FROM book where BookID=" + bookID + "";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            txtBookName.Text = set.Rows[0]["BookName"].ToString();
            txtBookID.Text = set.Rows[0]["BookID"].ToString();
            txtAuthor.Text = set.Rows[0]["Author"].ToString();
            txtCategory.Text = set.Rows[0]["Category"].ToString();
            txtDate.Text = set.Rows[0]["PurchaseDate"].ToString();
            txtPublication.Text = set.Rows[0]["Publication"].ToString();
            txtBookQuantity.Text = set.Rows[0]["BookQuantity"].ToString();

            





        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            query = "UPDATE book SET BookName='" + txtBookName.Text + "',Author='" + txtAuthor.Text + "',Publication='" + txtPublication.Text + "',PurchaseDate='" + txtDate.Text + "',BookQuantity=" + txtBookQuantity.Text + ",Category='" + txtCategory.Text + "' WHERE BookID="+bookID+"";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                new View_Books(true).Show();
                this.Close();

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

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Books(true).Show();
        }
    }
}
