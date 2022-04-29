using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libros
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formagregarlibros Formagregarlibros = new Formagregarlibros();
            Formagregarlibros.Show();
            this.Hide();
        }

        private void btnbusgarlibro_Click(object sender, EventArgs e)
        {
            formbusgarlibro formbusgarlibro = new formbusgarlibro();
            formbusgarlibro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusgarPrestamo busgarPrestamo = new BusgarPrestamo();
            busgarPrestamo.Show();
            this.Hide();
        }
    }
}
