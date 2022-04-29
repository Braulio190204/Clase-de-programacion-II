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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpfecha.Value = DateTime.Now;

            // using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            // {
            // Get a collection (or create, if doesn't exist)
            // var col1 = db.GetCollection<prestar_libros>("prestamo");

            // prestar_libros B = new prestar_libros
            // {
            // autor = txtautor.Text,
            // titulo = txttitulo.Text,
            //  fecha = dtpfecha.Value,
            // };
            // col1.Insert(B);
            //}
            Formagregarlibros form2 = new Formagregarlibros();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");
            }

        }

        private void prestar_Click(object sender, EventArgs e)
        {


            string cbs = " ";
            string cbu = " ";
            string cbup = " ";


            if (cbestudiante.Checked == true)
            {
                cbs = cbestudiante.Text;
            }
            if (cbempleado.Checked == true)
                cbs = cbempleado.Text;
            if (cbprofesor.Checked == true)
                cbs = cbprofesor.Text;

            if (cbotro.Checked == true)
                cbs = cbotro.Text;

            if (cbmañana.Checked == true)
                cbu = cbmañana.Text;
            if (cbtarde.Checked == true)
                cbu = cbtarde.Text;
            if (cbnoche.Checked == true)
                cbu = cbnoche.Text;
            if (cbsabado.Checked == true)
                cbu = cbsabado.Text;

            if (cbdomicilio.Checked == true)
                cbup = cbdomicilio.Text;
            if (cbsala.Checked == true)
                cbup = cbsala.Text;


            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                col1.EnsureIndex(x => x.titulo);

              

                    col1.EnsureIndex(x => x.titulo);
                    var results = col1.Query()
               .Where(x => x.titulo == txttitulo.Text && x.autor == txtautor.Text)
               .OrderBy(x => x.titulo)
               .Select(x => new { x.autor, x.titulo, x.id, x.categoria })
               .ToList();

                    string autorq;
                    string tituloq;
                    int idq;
                    string categoriaq;
                    foreach (var d in results)
                    {
                        try
                        {
                            idq = d.id;
                            autorq = d.autor;
                            tituloq = d.titulo;
                            categoriaq = d.categoria;
                            prestar_libros B = new prestar_libros();
                            B.autor = autorq;
                            B.titulo = tituloq;
                            B.id = idq;
                            B.matricula = Convert.ToInt32(txtmatricula.Text);
                            B.fecha = dtpfecha.Value;
                            B.nombre_completo = txtnombre.Text;
                            B.curso = txtcurso.Text;
                            B.tipo_estudiante = cbs;
                            B.uso_interno = cbu;
                            B.uso_interno_prestamo = cbup;
                            B.Estado = "Prestado";
                            B.categoria = categoriaq;


                            col1.Update(B);

                            MessageBox.Show("PRESTAMO AGREGADO CORRECTAMENTE");
                        }
                        catch
                        {
                            MessageBox.Show("NO SE PUDO AGREGAR EL PRESTAMO CORRECTAMENTE");
                        }
                        break;
                    }
                }
                txtnombre.Clear();
                txtcurso.Clear();
                txtmatricula.Clear();
                dtpfecha.Value = DateTime.Now;
                if (cbestudiante.Checked == true)
                {
                    cbestudiante.Checked = false;
                }
                if (cbempleado.Checked == true)
                    cbempleado.Checked = false;
                if (cbprofesor.Checked == true)
                    cbprofesor.Checked = false;
                if (cbotro.Checked == true)
                    cbotro.Checked = false;

                if (cbmañana.Checked == true)
                    cbmañana.Checked = false;
                if (cbtarde.Checked == true)
                    cbtarde.Checked = false;
                if (cbnoche.Checked == true)
                    cbnoche.Checked = false;
                if (cbsabado.Checked == true)
                    cbsabado.Checked = false;

                if (cbdomicilio.Checked == true)
                    cbdomicilio.Checked = false;
                if (cbsala.Checked == true)
                    cbsala.Checked = false;

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusgarPrestamo busgarPrestamo = new BusgarPrestamo();
            busgarPrestamo.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                var results = col1.Query()
           .Where(x => x.titulo == txttitulo.Text && x.autor == txtautor.Text)
           .OrderBy(x => x.titulo)
            .Select(x => new { x.autor, x.titulo,x.id })
           .ToList();

                string autorq;
                string tituloq;
                int idq ;
                foreach (var d in results)
                {
                    autorq = d.autor;
                    tituloq = d.titulo;
                    idq = d.id;
                    prestar_libros B = new prestar_libros();
                    B.autor = autorq;
                    B.titulo = tituloq;
                    B.id = idq;
                    B.matricula = 0;
                    B.fecha = DateTime.Now;
                    B.nombre_completo = null;
                    B.curso = null;
                    B.tipo_estudiante = null;
                    B.uso_interno = null;
                    B.uso_interno_prestamo = null;

                    try
                    {
                        col1.Update(B);

                        MessageBox.Show("LIBRO AGREGADO CORRECTAMENTE");
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUEDO AGREGAR CORECTAMENTE");
                    }
                    break;
                }
                txtnombre.Clear();
                txtcurso.Clear();
                txtmatricula.Clear();
                dtpfecha.Value = DateTime.Now;
                if (cbestudiante.Checked == true)
                {
                    cbestudiante.Checked = false;
                }
                if (cbempleado.Checked == true)
                    cbempleado.Checked = false;
                if (cbprofesor.Checked == true)
                    cbprofesor.Checked = false;
                if (cbotro.Checked == true)
                    cbotro.Checked = false;

                if (cbmañana.Checked == true)
                    cbmañana.Checked = false;
                if (cbtarde.Checked == true)
                    cbtarde.Checked = false;
                if (cbnoche.Checked == true)
                    cbnoche.Checked = false;
                if (cbsabado.Checked == true)
                    cbsabado.Checked = false;

                if (cbdomicilio.Checked == true)
                    cbdomicilio.Checked = false;
                if (cbsala.Checked == true)
                    cbsala.Checked = false;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formInicio form1 = new formInicio();
            this.Close();
            form1.Show();
        }
        
    }
     
    }
    

