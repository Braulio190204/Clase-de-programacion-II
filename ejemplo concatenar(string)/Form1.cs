using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_concatenar_string_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombre, apellido;
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            nombre = new string(nombre.ToCharArray());
            apellido = new string(apellido.ToCharArray());

            textBox3.Text = nombre + " " + apellido;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nombre, apellido;
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            nombre = new string(nombre.ToCharArray());
            apellido = new string(apellido.ToCharArray());

            textBox3.Text = nombre + " " + apellido;
        }
    }
}
