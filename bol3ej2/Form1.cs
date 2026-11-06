using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej2
{
    public partial class Form1 : Form// 
 
    {
        

        public Form1()
        {
            InitializeComponent();

        }

        private void a_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                boton.BackColor = SystemColors.Control;
            }

            
        }

        private void a_MouseEnter(object sender, EventArgs e)
        {
           
            if (sender is Button boton)
            {
                boton.BackColor = Color.Red;    
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)//TODO No excep generica
        {
            int r, b, g;
            try { 
             r= Convert.ToInt32( textBox1.Text);
             g= Convert.ToInt32(textBox2.Text);
             b= Convert.ToInt32(textBox3.Text);

                if (r > 255 || r <0 || g>255 || g<0 || b>255 || b<0)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Los valores RGB deben estar entre 0 y 255.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }


            this.BackColor = Color.FromArgb(r, g, b);
            this.AcceptButton = button2;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pathImagen = textBox4.Text;
            pictureBox1.ImageLocation = pathImagen.Trim('"');
            this.AcceptButton = button3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof (TextBox))
                {
                    if (c.Tag == null)
                    {
                        c.Text = "";
                    }
                    else
                    {
                        c.Text = c.Tag.ToString();
                    }
                }

                if (c.GetType() == typeof(PictureBox)) //TODO (c is PictureBox pb) ESTARÍA BEN?
                {
                    ((PictureBox)c).ImageLocation = "";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas salir?", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel= true;
            }

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            this.AcceptButton= button3;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
