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
    public partial class formbusgarlibro : Form
    {
        public formbusgarlibro()
        {
            InitializeComponent();
            llenarcb();
            cargar_datos();


        }

        private void btnbusgar_Click(object sender, EventArgs e)
        {
            if (txttitulo.Text == "" && txtautor.Text == "" && cbcategoria.Text == "")
                errorProvider1.SetError(cbcategoria, "DEBE LLENAR ALMENOS UNO DE LOS CAMPOS");

            else
            {
                errorProvider1.Clear();

                using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col1 = db.GetCollection<prestar_libros>("prestamo");
                    col1.EnsureIndex(x => x.titulo);



                    col1.EnsureIndex(x => x.titulo);
                    var results = col1.Query()
               .Where(x => x.titulo == txttitulo.Text && x.autor == txtautor.Text || x.categoria == cbcategoria.Text || x.titulo == txttitulo.Text && x.autor == txtautor.Text && x.categoria == cbcategoria.Text)
                   .OrderBy(x => x.id)
                   .Select(x => new { x.id, x.autor, x.titulo, x.categoria, x.Estado })
                   .ToList();


                    if (results == null)
                        MessageBox.Show("NO SE PUEDO BUSGAR EL LIBRO");
                    else { dgvlibro.DataSource = results; }

                }
            }
            btneliminar.Visible = Visible;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            var idv = dgvlibro.CurrentRow.Cells[0].Value.ToString();


            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");
                try
                {
                    // Get a collection (or create, if doesn't exist)

                    col1.Delete(Convert.ToInt32(idv));
                    MessageBox.Show("LIBRO ELIMINADO CON EXITO");
                }
                catch { MessageBox.Show("NO SE PUDO ELIMINAR EL LIBRO,T INTENTELO DE NUEVO"); }

                var results = col1.Query()
        .Where(x => x.titulo == txttitulo.Text && x.autor == txtautor.Text || x.categoria == cbcategoria.Text)
        .OrderBy(x => x.id)
        .Select(x => new { x.id, x.autor, x.titulo, x.categoria, x.Estado })
        .ToList();

                dgvlibro.DataSource = results;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInicio form1 = new formInicio();
            this.Close();
            form1.Show();
        }
        private void llenarcb()
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                var results = col1.Query()
        .OrderBy(x => x.id)
        .Select(x => new { x.categoria, })
        .ToList();

                foreach (var d in results)
                {
                    cbcategoria.DataSource = results;
                    cbcategoria.DisplayMember = "categoria";
                    cbcategoria.ValueMember = "categoria";
                    cbcategoria.Text = "";
                }


            }
        }

        private void cargar_datos()
        {
            using (var db = new LiteDatabase(@"C:\Temp\prestarlibros.db"))
            {
                var col1 = db.GetCollection<prestar_libros>("prestamo");

                var results = col1.Query()
        .OrderBy(x => x.id)
        .Select(x => new { x.id, x.autor, x.titulo, x.categoria, x.Estado })
        .ToList();

                dgvlibro.DataSource = results;
            }

        }





    }
}
