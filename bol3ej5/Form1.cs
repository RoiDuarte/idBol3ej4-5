using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej5//Funcionamiento con teclas. Titulo icono. Taborder. Completar grabar/mostrar. Menu con ALT y atajos. Quitar los ifs innecesarios de comprobacion de tipo de sender.
{
    
    public partial class Form1 : Form
    {

        private Form2 frmGrabarNumero = null;
        private Form3 frmAgenda = null;

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
                }
                else
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
            Button btn = (Button)sender;

            if (btn.BackColor != Color.Yellow)
            {
                btn.BackColor = Color.White;
            }


        }

        private void btnMouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                btn.BackColor = Color.Red;
            }

        }


        private void btnClick(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            txtNumero.Text += btn.Text;
            btn.BackColor = Color.Yellow;



        }

        public void reset()
        {
            txtNumero.Text = "";

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

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                return;
            }
            if (frmGrabarNumero ==null || frmGrabarNumero.IsDisposed)
            {
                frmGrabarNumero = new Form2();

                frmGrabarNumero.btnAceptar.Click += BtnAceptarForm2_Click;
                
                frmGrabarNumero.Show();


            }
        }

        private void BtnAceptarForm2_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtNumero.Text) && !string.IsNullOrEmpty(frmGrabarNumero.txtNombre.Text))
                {
                    string directory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    // Environment.GetEnvironmentVariable("homepath") levame ao disco duro E: en vez de ao C:, entón non me funciona
                    string fullName = directory + "\\" + "contactos.txt";

                    using (StreamWriter sw = new StreamWriter(fullName, true))
                    {
                        sw.WriteLine($"{frmGrabarNumero.txtNombre.Text,-25}{txtNumero.Text,-15}");
                    }

                    frmGrabarNumero.Close();
                }
                else
                {
                    MessageBox.Show("La caja de texto de Nombre esta vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException a)
            {
                MessageBox.Show("No se pudo crear el archivo: "+a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgenda == null || frmAgenda.IsDisposed)
            {
                frmAgenda = new Form3();
                frmAgenda.Show();
            }  
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
