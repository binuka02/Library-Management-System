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
    public partial class Mysteries : Form
    {
        public Mysteries()
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
    }
}
