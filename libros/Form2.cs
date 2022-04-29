using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace libros
{

    public partial class Formagregarlibros : Form
    {

        public Formagregarlibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            formInicio form1 = new formInicio();     
            this.Close();
            form1.Show();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;

            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                try
                {
                    prestar_libros B = new prestar_libros
                    {
                        autor = txtnombreautor.Text,
                        titulo = txtnombrelibro.Text,
                        categoria = cbcategoria.Text,
                        fecha = dtpFecha.Value,
                        Estado = "No",


                };
                    col1.Insert(B);
                    MessageBox.Show("LIBRO AGREGADO CORRECTAMENTE");
                }
                catch
                {
                    MessageBox.Show("NO SE PUDO AGREGAR EL LIBRO CORECTAMENTE");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbusgarlibro formbusgarlibro = new formbusgarlibro();
            formbusgarlibro.Show();
            this.Hide();
        }
    }
    }

