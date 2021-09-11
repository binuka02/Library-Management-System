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
    public partial class Kids : Form
    {
        public Kids()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.hicon;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForm()
        {
            Application.Run(new Categories());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataBiographiess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kids_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=;database=lbms;SSL Mode=none;");
            string query = "SELECT * FROM book WHERE Category='Kids'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataTable set = new DataTable();
            adapter.Fill(set);
            dataKids.DataSource = set;
            con.Close();
        }
    }
}
