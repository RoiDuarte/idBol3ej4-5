#define PRUEBA



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol1ej3
{


    public partial class Form1 : Form
    {



        int credito = 50;
        Random generador = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        (int nAleatorio1, int nAleatorio2, int nAleatorio3) numeroAleatorio(int minimo, int maximo)
        {
            
            int n1;
            n1 = generador.Next(minimo, maximo);
            int n2;
            n2 = generador.Next(minimo, maximo);
            int n3;
            n3 = generador.Next(minimo, maximo);
            return (n1, n2, n3);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credito > 1)
            {
                credito = credito - 2;





                (int nAleatorio1, int nAleatorio2, int nAleatorio3) = numeroAleatorio(1, 7);

                textBox1.Text = nAleatorio1.ToString();
                textBox2.Text = nAleatorio2.ToString();
                textBox3.Text = nAleatorio3.ToString();


                if (textBox1.Text == textBox2.Text && textBox1.Text == textBox3.Text)
                {

                    label1.Text = "Premio de 20 euros!";
                    credito = credito + 20;

                }else if (textBox1.Text==textBox2.Text|| textBox1.Text==textBox3.Text || textBox2.Text==textBox3.Text)
                {
                    
                

               


                    //label1.Text = "Premio de 5 euros!";
                    //credito = credito + 5;

#if PRUEBA
                    credito = credito - 5;
                    label1.Text = "Perdiste 5 euros!";

#else
                credito = credito + 5;
                label1.Text = "Premio de 5 euros!";
#endif

                }

                label2.Text = credito.ToString();
            }

            
            else
            {
                label1.Text = "Perdiste";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            credito = credito + 10;
            label2.Text=credito.ToString();
        }
    }
}
