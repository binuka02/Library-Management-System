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
    public partial class Update_and_Delete_Book : Form
    {
        public Update_and_Delete_Book()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBook.Text = "";
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPublication.Text = "";
            txtDate.Text = "";
            txtBookCode.Text = "";
            txtBookQuantity.Text = "";
            txtCategory.Text = "";
            txtBook.Focus();
        }
    }
}
