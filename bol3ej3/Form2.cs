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

namespace bol3ej3
{
    public partial class Form2 : Form
    {
       
        
        public Form2()
        {
            InitializeComponent();
            
        }

        public Form2(string rutaImagen) : this()
        {
            
            
            pictureBox1.ImageLocation = rutaImagen;
            string nombreArchivo=Path.GetFileName(rutaImagen);
            this.Text = nombreArchivo;
            
        }

        private void ajustarAImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void noDeformarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.AutoSize;
        }

        
    }
}
