using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiprimeraClase
{
    public partial class Form1 : Form
    {
       List<persona> personas = new List<persona>();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        persona persona1 = new persona();
     
        persona1.id = "1010";
        persona1.nombre = "Lady";
        persona1.apellidos = "gaga";
        persona1.correo = "ledygaga@gmail.com";
        persona1.fechanacimiento = new DateTime(1990,3,14);
        persona1.salario = 1200000;
            personas.Add(persona1);

            persona persona2 = new persona();
            persona2.id = "2020";
            persona2.nombre = "dady";
            persona2.apellidos = "yankie";
            persona2.correo = "dady@yahoo.es";
            persona2.fechanacimiento = new DateTime(1987, 7, 20);
            persona2.salario = 2560000;
            personas.Add(persona2);

            dgvdatos.DataSource = personas;
        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            if (!validarid()) return;
            if (!validarotroscampos()) return;

       
            persona mipersona = new persona();
            mipersona.id = txtid.Text;
            mipersona.nombre = txtnombre.Text;
            mipersona.apellidos = txtapellidos.Text;
            mipersona.correo = txtcorreo.Text;
            mipersona.fechanacimiento = dtpfeha.Value;
            mipersona.salario = Convert.ToDecimal(txtsalario.Text);
            personas.Add(mipersona);

            dgvdatos.DataSource = null;
            dgvdatos.DataSource = personas;

            txtid.Clear();
            txtnombre.Clear();
            txtapellidos.Clear();
            txtcorreo.Clear();
            txtsalario.Clear();
            txtid.Focus();
        }

        private bool validarotroscampos()
        {
            if (existe(txtid.Text))
            {
                errorProvider1.SetError(txtid, "ID de empleado ya a sido registrado");
                txtid.Focus();
                return false;
            }

            if (txtnombre.Text == "")
            {
                errorProvider1.SetError(txtnombre, "Debe ingresas un nombre de la persona, error");
                txtnombre.Focus();
                return false;
            }
            errorProvider1.SetError(txtnombre, "");

            if (txtapellidos.Text == "")
            {
                errorProvider1.SetError(txtapellidos, "Debe ingresas un apellidos de la persona, error");
                txtid.Focus();
                return false;
            }
            errorProvider1.SetError(txtapellidos, "");



            decimal salario;
            if (!Decimal.TryParse(txtsalario.Text, out salario))
            {
                errorProvider1.SetError(txtsalario, "Debe ingresas numeros en el campo salario");
                txtsalario.Focus();
                return false;
            }

            if (salario < 0)
            {
                errorProvider1.SetError(txtsalario, "Debe ingresas numeros en el campo salario");
                txtsalario.Focus();
                return false;
            }
        }

        private bool existe(string id)
        {
            foreach (persona persona in personas)
            {
                if (persona.id == id) return true;
            }
            return false ;
        }

        private void tsbbusgar_Click(object sender, EventArgs e)
        {
            if (!validarid()) return;
            persona mipersona = getpersona(txtid.Text);
            if (mipersona == null)
            {
                
                    errorProvider1.SetError(txtnombre , "debe llenar este cmapo");
                    txtnombre.Focus();
                return;
                   
            }
            errorProvider1.SetError(txtid, "");

            txtnombre.Text = mipersona.nombre;
            txtapellidos.Text = mipersona.apellidos;
            txtcorreo.Text = mipersona.correo;
            dtpfeha.Value = mipersona.fechanacimiento;
            txtsalario.Text = mipersona.salario.ToString();

        }

        private bool validarid()
        {
            if (txtid.Text == "") 
            {
                errorProvider1.SetError(txtid, "Debe ingresas un ID de la persona, error");
                txtid.Focus();
                return false;
            }
            else
                errorProvider1.SetError(txtid, "");
            return true;
        }      
        private persona getpersona(String id)
        {
            foreach(persona mipersona in personas)
            {
                if (mipersona.id == id) return mipersona;
           
            }
            return null;
        }

        private void tsbmodificar_Click(object sender, EventArgs e)
        {
            if (!validarid()) return;
            if(getpersona(txtid.Text) == null)
            {
                errorProvider1.SetError(txtid, "Persona no existe");
                txtid.Focus();
                return ;
            }
                errorProvider1.SetError(txtid, "");

            if (!validarotroscampos()) return;
             foreach(persona mipersona in personas)
            {
                if (mipersona.id == txtid.Text) 
                {
                   
                    mipersona.id = txtid.Text;
                    mipersona.nombre = txtnombre.Text;
                    mipersona.apellidos = txtapellidos.Text;
                    mipersona.correo = txtcorreo.Text;
                    mipersona.fechanacimiento = dtpfeha.Value;
                    mipersona.salario = Convert.ToDecimal(txtsalario.Text);
                    break;
                }

            }
            dgvdatos.DataSource = null;
            dgvdatos.DataSource = personas;
        }



    }
}
