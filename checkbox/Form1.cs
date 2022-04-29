using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
      
        private void negritaCheackbox_CheckedChanged(object sender, EventArgs e)
        {
            salidaLabel.Font = new Font(salidaLabel.Font.Name, salidaLabel.Font.Size, salidaLabel.Font.Style ^ FontStyle.Bold);
        }

        private void cursivaCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            salidaLabel.Font = new Font(salidaLabel.Font.Name, salidaLabel.Font.Size, salidaLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
