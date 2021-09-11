using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Login_2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCatogories_Click(object sender, EventArgs e)
        {
            new Categories().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new InventoryReport().Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (panelStudents.Height == 120)
            {
                panelStudents.Height = 40;
            }
            else if (panelBooks.Height == 182)
            {
                panelBooks.Height = 40;
                panelStudents.Height = 120;
            }
            else
            {
                panelStudents.Height = 120;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelBooks.Height == 182)
            {
                panelBooks.Height = 40;
            }
            else if (panelStudents.Height == 120)
            {
                panelStudents.Height = 40;
                panelBooks.Height = 182;
            }
            else
            {
                panelBooks.Height = 182;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Add_Books().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new Add_Books());
            }
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new View_Books(true).Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new View_Books(true));
            }
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //new Issue_Book().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new Issue_Book());
            }
            //this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //new Return_Book().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new Return_Book());
            }
            //this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //new Update_and_Delete_Book().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new Update_and_Delete_Book());
            }
            //this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //new View_Borrower().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new View_Borrower());
            }
            //this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //new Add_Borrower().Show();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void openForm()
            {
                Application.Run(new Add_Borrower());
            }
            //this.Hide();
        }

        private void btnCategories_MouseHover(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.Black;
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.Black;
        }

        private void btnStudent_MouseLeave(object sender, EventArgs e)
        {
            btnStudent.BackColor = Color.Transparent;
        }

        private void btnCategories_MouseLeave(object sender, EventArgs e)
        {
            btnCategories.BackColor = Color.Transparent;
        }

        private void btnAddStudents_MouseHover(object sender, EventArgs e)
        {
            btnAddStudents.BackColor = Color.Black;
        }

        private void btnAddStudents_MouseLeave(object sender, EventArgs e)
        {
            btnAddStudents.BackColor = Color.Transparent;
        }

        private void btnViewStudents_MouseHover(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = Color.Black;
        }

        private void btnViewStudents_MouseLeave(object sender, EventArgs e)
        {
            btnViewStudents.BackColor = Color.Transparent;
        }

        private void btnBooks_MouseHover(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Black;
        }

        private void btnBooks_MouseLeave(object sender, EventArgs e)
        {
            btnBooks.BackColor = Color.Transparent;
        }

        private void btnAddBooks_MouseHover(object sender, EventArgs e)
        {
            btnAddBooks.BackColor = Color.Black;
        }
        private void btnAddBooks_MouseLeave(object sender, EventArgs e)
        {
            btnAddBooks.BackColor = Color.Transparent;
        }
        private void btnAddBooks_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        

        private void btnViewBooks_MouseHover(object sender, EventArgs e)
        {
            btnViewBooks.BackColor = Color.Black;
        }

        private void btnViewBooks_MouseLeave(object sender, EventArgs e)
        {
            btnViewBooks.BackColor = Color.Transparent;
        }

        private void btnIssueBooks_MouseHover(object sender, EventArgs e)
        {
            btnIssueBooks.BackColor = Color.Black;
        }

        private void btnIssueBooks_MouseLeave(object sender, EventArgs e)
        {
            btnIssueBooks.BackColor = Color.Transparent;
        }

        private void btnReturnBooks_MouseHover(object sender, EventArgs e)
        {
            btnReturnBooks.BackColor = Color.Black;
        }

        private void btnReturnBooks_MouseLeave(object sender, EventArgs e)
        {
            btnReturnBooks.BackColor = Color.Transparent;
        }

        private void btnViewandUpdate_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnViewandUpdate_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnTransaction_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnTransaction_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }
        
    }
}
