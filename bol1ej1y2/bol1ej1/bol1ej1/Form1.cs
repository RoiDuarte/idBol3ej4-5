using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol1ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            try
            {





                int operador1 = Convert.ToInt32(textBox1.Text);
                int operador2 = Convert.ToInt32(textBox2.Text);

                int resultado = operador1 + operador2;

                label3.Text = resultado.ToString();
                
            }
            catch (FormatException a)
            {

                label3.Text = "Pon numeros enteros y no decimales";



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
