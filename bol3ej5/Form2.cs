using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej5
{
    public partial class Form2 : Form
    {
        string numero;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string texto) {
            InitializeComponent();
            numero = texto;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(numero))
            {

                //textoActual += textoActual + "\n" + textBox1.Text ++ numero;
                String agenda = $"Nombre: {textBox1.Text} Numero: {numero}";
                

                string fullname= "D:\\DAM\\segundo\\ID\\ejercicio5.txt";
                StreamWriter s = new StreamWriter(fullname, true); 
                s.WriteLine(agenda);
                s.Close();


            }

            this.Close();
        }
    }
}
