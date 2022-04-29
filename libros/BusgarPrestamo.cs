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
    public partial class BusgarPrestamo : Form
    {
        public BusgarPrestamo()
        {
            InitializeComponent();
            cargar_datos();
        }

        private void btnbusgar_Click(object sender, EventArgs e)
        {

            if (txtmatricula.Text == "")
                errorProvider1.SetError(txtmatricula, "DEBE LLENAR EL CAMPO");

            else
            {
                errorProvider1.Clear();


                using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col1 = db.GetCollection<prestar_libros>("prestamo");
                    col1.EnsureIndex(x => x.titulo);
                    var results = col1.Query()
               .Where(x => x.matricula == Convert.ToInt32(txtmatricula.Text))
               .OrderBy(x => x.id)
               .Select(x => new { x.id, x.nombre_completo, x.titulo, x.autor, x.categoria, x.tipo_estudiante, x.uso_interno, x.uso_interno_prestamo, x.fecha, x.matricula })
               .ToList();

                    var d = 0;
                    foreach (var D in results)
                    {
                        d = D.matricula;
                    }
                    
                        if (d == Convert.ToInt32(txtmatricula.Text))
                        {
                        dgvprestamo.DataSource = results;
                        }
                        else
                        {
                        MessageBox.Show("NADIE CON ESA MATRICULA TIENE LIBROS PRESTADOS");
                    }
                        
                    
                  
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {

 var matriculag= dgvprestamo.CurrentRow.Cells[9].Value.ToString();

                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                var results = col1.Query()
    
           .Where(x => x.matricula==Convert.ToInt32(matriculag))
           .OrderBy(x => x.titulo)
            .Select(x => new { x.autor, x.titulo, x.id,x.categoria })
           .ToList();

                string autorq;
                string tituloq;
                int idq;
                string categoriaq;
                foreach (var d in results)
                {
                    autorq = d.autor;
                    tituloq = d.titulo;
                    idq = d.id;
                    categoriaq = d.categoria;
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
                    B.categoria = categoriaq;
                    B.Estado = "No";
                    try
                    {
                        col1.Update(B);

                        MessageBox.Show("PRESTAMO ELIMINADO CON EXITO");
                    }
                    catch
                    {
                        MessageBox.Show("NO SE PUEDO ELIMINAR EL PRESTAMO");
                    }
                    break;
                }
                var results1= col1.Query()
                    .Where(x => x.matricula == Convert.ToInt32(matriculag))
           .OrderBy(x => x.titulo)
            .Select(x => new { x.id, x.nombre_completo, x.titulo, x.autor, x.categoria, x.tipo_estudiante, x.uso_interno, x.uso_interno_prestamo, x.fecha, x.matricula })
                    .ToList();

      dgvprestamo.DataSource = results1;

            }


            txtmatricula.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInicio form1 = new formInicio();
            this.Close();
            form1.Show();
        }
        private void cargar_datos()
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                var results = col1.Query()
        .Where(x => x.Estado == "Prestado")
       .OrderBy(x => x.id)
       .Select(x => new { x.id, x.nombre_completo, x.titulo, x.autor, x.categoria, x.tipo_estudiante, x.uso_interno, x.uso_interno_prestamo, x.fecha, x.matricula })
       .ToList();
                dgvprestamo.DataSource = results;
            }

        }

    }
}
