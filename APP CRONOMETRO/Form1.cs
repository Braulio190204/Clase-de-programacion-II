using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_CRONOMETRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            tiempo.Start();//iniciando Cronometro
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            tiempo.Stop();//detener objeto "timer"
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            horas.Text = "00";//reiniciando//horas
            minuto.Text = "00";//reiniciando//minutos
            segundo.Text = "00";//reiniciando//segundos
            miliseg.Text = "00";//reiniciando//milisegundos

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(miliseg.Text);
            int aux1 = Convert.ToInt32(segundo.Text);
            int aux2 = Convert.ToInt32(minuto.Text);
            int aux3 = Convert.ToInt32(horas.Text);
            aux = aux + 1;
            miliseg.Text = aux.ToString();

            if (aux > 59)//para los milisegundos
            {
                aux1 = aux1 + 1;
                segundo.Text = aux1.ToString();
                aux = 0;
                miliseg.Text = aux.ToString();
            }
            if (aux1 > 3)//para los segundos
            {
                aux2 = aux2 + 1;
                minuto.Text = aux2.ToString();
                aux1 = 0;
                segundo.Text = aux1.ToString();
            }
            if (aux2 > 3)//para los minutos
            {
                aux3 = aux3 + 1;
                horas.Text = aux3.ToString();
                aux2 = 0;
                minuto.Text = aux2.ToString();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
