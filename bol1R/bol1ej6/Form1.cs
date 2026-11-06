using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol1ej6
{
    public partial class Form1 : Form
    {

        string textoF;
        MessageBoxIcon icon;
        MessageBoxButtons buttons;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textoF = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            icon = MessageBoxIcon.Question;
            buttons = MessageBoxButtons.YesNo;
            DialogResult respuesta;

            respuesta = MessageBox.Show("Deseas poner ese texto como titulo del formulario principal?\n" + "\""+textoF+"\"", "Pregunta", buttons, icon);

            if (respuesta == DialogResult.Yes)
            {

                this.Text = textoF;
            }
        }
            
    }
}
