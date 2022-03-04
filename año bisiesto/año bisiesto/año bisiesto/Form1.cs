using System;
using System.Windows.Forms;

namespace año_bisiesto
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2022;
            for (int i = 1990; i <= a; i++)
            {
                if (i % 4 == 0 && (i % 400 == 0 || i % 100 != 0))
                    RESULTADO.Items.Add(i);
            
            }
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            if (x % 4 == 0 && (x % 400 == 0 || x % 100 != 0))
                textBox2.Text = (x + " " + "ES BISIESTO");
            else
            {
                textBox2.Text = (x + " " + "NO ES BISIESTO");
            }
        }
    }
}
