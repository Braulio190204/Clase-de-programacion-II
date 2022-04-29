using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agregar_y_eliminar_refresco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            var a = txtagregar.Text;
            listrefrescos.Items.Add(a);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            listrefrescos.Items.Remove(listrefrescos.SelectedItem);
        }
    }
}
