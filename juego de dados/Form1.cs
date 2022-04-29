using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnjugar_Click(object sender, EventArgs e)
        {
            int dado1, dado2;
            Random alea = new Random();
            dado1 = alea.Next(1,6);
            dado2 = alea.Next(1,6);

            if (dado1 == 1)
            {
                pictureBox1.Image = Image.FromFile("cara1.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado1 == 2)
            {
                pictureBox1.Image = Image.FromFile("cara2.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado1 == 3)
            {
                pictureBox1.Image = Image.FromFile("cara3.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado1 == 4)
            {
                pictureBox1.Image = Image.FromFile("cara4.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado1 == 5)
            {
                pictureBox1.Image = Image.FromFile("cara5.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado1 == 6)
            {
                pictureBox1.Image = Image.FromFile("cara6.jpg");
                label1.Text = dado1.ToString();
            }
            if (dado2 == 1)
            {
                pictureBox2.Image = Image.FromFile("cara1.jpg");
                label1.Text = dado2.ToString();
            }
            if (dado2 == 2)
            {
                pictureBox1.Image = Image.FromFile("cara2.jpg");
                label1.Text = dado2.ToString();
            }
            if (dado2 == 3)
            {
                pictureBox1.Image = Image.FromFile("cara3.jpg");
                label1.Text = dado2.ToString();
            }
            if (dado2 == 4)
            {
                pictureBox1.Image = Image.FromFile("cara4.jpg");
                label1.Text = dado2.ToString();
            }
            if (dado2 == 5)
            {
                pictureBox1.Image = Image.FromFile("cara5.jpg");
                label1.Text = dado2.ToString();
            }
            if (dado2 == 6)
            {
                pictureBox1.Image = Image.FromFile("cara6.jpg");
                label1.Text = dado2.ToString();
            } if (dado1 == dado2)
            {
                label3.Text = "los dados son iguales";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
