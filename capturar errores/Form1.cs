using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capturar_errores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salida.Text = ""; // borra control Label EtiquetaSalida

            // extrae entrada del usuario y calcula el cociente
            try
            {
                // Convert.ToInt32 genera excepción FormatException
                // si el argumento no es un entero
                int numerador = Convert.ToInt32(Numerador.Text);
                int denominador = Convert.ToInt32(Denominador.Text);

                // la división genera una excepción DivideByZeroException 
                // si el denominador es 0
                int resultado = numerador / denominador;

                // muestra el resultado en SalidaLabel
                Salida.Text = resultado.ToString();
            } // fin de try
            catch (FormatException)
            {
                MessageBox.Show("Debe escribir dos enteros.",
                "Formato de número inválido", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } // fin de catch
            catch (DivideByZeroException divideByZeroExceptionParameter)
            {
                 MessageBox.Show(divideByZeroExceptionParameter.Message,
                 "Intento de división por cero", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                 } // fin de catch
             } // fin del método DividirButton_Click

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Numerador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Denominador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salida_TextChanged(object sender, EventArgs e)
        {

        }
    } // fin de la clase FormDivisionEntreCero
 } // fin del espacio de nombres PruebaDivisionEntreCero
        

