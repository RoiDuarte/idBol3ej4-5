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
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fullName = directory + "\\" + "contactos.txt";

            if (!File.Exists(fullName))
            {
                MessageBox.Show("Aun no hay contactos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                using (StreamReader sr = new StreamReader(fullName))
                {
                    string contenidoCompleto = sr.ReadToEnd();
                    txtAgenda.Text = contenidoCompleto;
                    
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer el archivo: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
