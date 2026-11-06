using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej5//Funcionamiento con teclas. Titulo icono. Taborder. Completar grabar/mostrar. Menu con ALT y atajos. Quitar los ifs innecesarios de comprobacion de tipo de sender.
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();



            for (int i = 0; i < 12; i++)
            {

                Button btn = new Button();

                if (i < 9)
                {
                    btn.Text = (i + 1).ToString();
                }
                else if (i == 9)
                {
                    btn.Text = "*";
                }
                else if (i == 10)
                {
                    btn.Text = "0";
                }else
                {
                    btn.Text = "#";
                }

                btn.Size = new Size(100, 25);

                int fila = i / 3; //TODO non o acabo de entender a diferenza entre / e %
                int columna = i % 3;

                int posX = 10 + columna * (100 + 10);
                int posY = 45 + fila * (25 + 15); //TODO 10 + fila/columna * ancho/alto + espacio


                btn.Location = new Point(posX, posY);

                btn.Click += new System.EventHandler(this.btnClick);
                btn.MouseEnter += new System.EventHandler(this.btnMouseEnter);
                btn.MouseLeave += new System.EventHandler(this.btnMouseLeave);
                
                this.Controls.Add(btn);
                
            }
        }

       


        private void btnMouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor!=Color.Yellow)
                {
                    btn.BackColor = Color.White;
                }
                
            }
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor!=Color.Yellow)
                {
                    btn.BackColor = Color.Red;
                }
                
            }
        }

        private void btnClick(object sender, EventArgs e)
        {

            if (sender is Button btn)
            {
                textBox1.Text += btn.Text;
                btn.BackColor = Color.Yellow;

            }
            
        }

        public void reset()
        {
            textBox1.Text = "";

            foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = Color.White;
                }
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicacion es el ejercicio 5", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grabarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this.textBox1.Text);
            f.ShowDialog();
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tecla = e.KeyChar.ToString();

            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Text == tecla)
                {
                    btn.PerformClick();
                   // e.Handled = true; //mirar ben como vai isto

                }
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
