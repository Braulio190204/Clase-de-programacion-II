using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_asignada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagegar_Click(object sender, EventArgs e)
        {
            Flores flor = new Flores();

            flor.nombre = txtnombre.Text;
            flor.clasificacion = txtclasificacion.Text;
            flor.descripcion = txtdescripcion.Text;
            flor.color = txtcolor.Text;

          
            listmostrar.Items.Add("NOMBRE:" + " " + flor.nombre );
            listmostrar.Items.Add("DESCRIPCION:" + " " + flor.descripcion );
            listmostrar.Items.Add( "CLASIFICACION:" + " " + flor.clasificacion);
            listmostrar.Items.Add("COLOR:" + " " + flor.color);
           
        }
    }
}
