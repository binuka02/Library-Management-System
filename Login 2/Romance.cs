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
    public partial class Romance : Form
    {
        public Romance()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Categories().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataBiographiess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Romance_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "SELECT * FROM book WHERE Category='Romance'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataRomance.DataSource = set;
            con.Close();
        }
    }
}
