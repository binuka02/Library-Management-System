using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_2
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublication.Text = "";
            txtStudentName.Text = "";
            txtStudentID.Text = "";
            txtReturnDate.Text = "";
            txtCategory.Text = "";
            txtBookName.Focus();
        }
    }
}
