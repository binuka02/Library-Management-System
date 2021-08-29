﻿using System;
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
    public partial class Issue_Book : Form
    {
        public Issue_Book()
        {
            InitializeComponent();
        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublication.Text = "";
            txtStudentName.Text = "";
            txtStudentID.Text = "";
            txtIssueDate.Text = "";
            txtCategory.Text = "";
            txtBookName.Focus();
        }
    }
}