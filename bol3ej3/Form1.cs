using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej3
{
    public partial class Form1 : Form
    {

        int segundos = 0;
        int minutos = 0;
        string tiempo = "";
        string nombreArchivo = "Visor de imagenes";
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;//TODO deseño
            timer1.Start();
            timer1.Enabled = true;
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Red;
            }
            else
            {
                checkBox1.ForeColor = SystemColors.ControlText;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.InitialDirectory = @"E:\DAM\segundo\ID";
                openFileDialog.Filter = "Archivos de imagen (*.png;*.jpg) |*.png;*.jpg| Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    Form2 f2 = new Form2(openFileDialog.FileName);

                    if (checkBox1.Checked)
                    {
                       f2.ShowDialog();
                        
                    }
                    else
                    {
                        
                        f2.Show();
                    }

                    

                }
            }
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }
            tiempo = $"{minutos:D2}:{segundos:D2}";
            this.Text = $"{nombreArchivo} - {tiempo}";
        }
    }
}
