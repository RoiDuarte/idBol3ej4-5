using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove); // no diseñador
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            

            for (int i = 0; i <= 19; i++)
            {
                Button btn = new Button();
                btn.Text = (i+1).ToString();
                int columna = i % 5;
                int fila = i / 5;
                int x = 10 + (columna * 110);
                int y = 10 + (fila * 30);
                btn.Location = new Point(x,y);
                btn.Size = new Size(100, 20);
                btn.Enabled = true;

                btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                btn.MouseUp += new MouseEventHandler(btn_MouseUp);
                btn.MouseMove += new MouseEventHandler(Form1_MouseMove);
                this.Controls.Add(btn);
            }

            button1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            button2.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.KeyPreview = true;



        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x;
            int y;


            if (sender is Button)
            {

                Button btnPulsado = (Button)sender;

                x = e.X + btnPulsado.Left;
                y = e.Y + btnPulsado.Top;

            }
            else
            {

                x = e.X;
                y = e.Y;
            }

            this.Text = "X: " + x + " Y: " + y;

        }


        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "MouseTester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            if (e.Button == MouseButtons.Left)
            {

                button1.BackColor = Color.FromArgb(r, g, b);

            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.FromArgb(r, g, b);
            }
            else
            {
                button1.BackColor = Color.FromArgb(r, g, b);
                button2.BackColor = Color.FromArgb(r, g, b);
            }


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
            }else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                button1.BackColor = Color.FromArgb(255,255,255);
                button2.BackColor =Color.FromArgb(255,255,255);
            }





        }

        

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {

            Button btnPulsado = (Button)sender;
            btnPulsado.ForeColor = Color.Red;

        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btnPulsado = (Button)sender;
            btnPulsado.ForeColor = Color.Black;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text= e.KeyCode.ToString();

            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "MouseTester";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que deseas salir?", "Mi aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

