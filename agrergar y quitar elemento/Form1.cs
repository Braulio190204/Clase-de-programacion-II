using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agrergar_y_quitar_elemento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agrergarButton_Click(object sender, EventArgs e)
        {
            mostrarListBox.Items.Add(entradaTextBox.Text);
            entradaTextBox.Clear();
        }

        private void quitarButton_Click(object sender, EventArgs e)
        {
            if (mostrarListBox.SelectedIndex != -1)
 mostrarListBox.Items.RemoveAt(mostrarListBox.SelectedIndex);
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            mostrarListBox.Items.Clear();
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
