using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bol3ej4//TODO selección múltiple na lista 1 (teño que cambiar varias cousas). Separa grupos de radiobuttons. Revisar tooltips.
{//TODO nombres componentes. 

    //TODO: cousas feitas -> listbox1 multisimple, listbox1 multi arranxado, radiobutton en groupbox, taborder, tooltips, label2 arranxado
    public partial class bol3ej4 : Form
    {

        string textoCompleto = "Ejercicio 4";
        int indice;
        public bol3ej4()
        {
            InitializeComponent();
            label1.Text = "En la lista 1 hay "+ listBox1.Items.Count + " elementos";
            label2.Text = "Indices seleccionados: Ninguno";
            indice=textoCompleto.Length - 1;
            toolTip1.SetToolTip(this.listBox2, listBox2.Items.Count.ToString());




        }

        private void BtnAnhadir_Click(object sender, EventArgs e)
        {
            string nuevoElemento = textBox1.Text.Trim();

            if (rbListBox1.Checked)
            {
                if (!listBox1.Items.Contains(nuevoElemento) && !string.IsNullOrEmpty(nuevoElemento))
                {
                    listBox1.Items.Add(nuevoElemento);
                }
            }
            else if (rbListBox2.Checked) 
            {

                if (!listBox2.Items.Contains(nuevoElemento) && !string.IsNullOrEmpty(nuevoElemento))
                {
                    listBox2.Items.Add(nuevoElemento);
                }
            }



            label1.Text = "En la lista 1 hay " + listBox1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.listBox2, listBox2.Items.Count.ToString());

        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            
            if (rbListBox1.Checked && listBox1.SelectedItem != null)
            {
                btnQuitar.Text = "Elimina de 1";
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }else if (rbListBox2.Checked && listBox2.SelectedItem != null)
            {
                btnQuitar.Text = "Elimina de 2";

                for (int i = listBox2.SelectedIndices.Count-1; i >=0 ; i--)
                {
                    listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
                }

            }

            label1.Text = "En la lista 1 hay " + listBox1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.listBox2, listBox2.Items.Count.ToString());


        }

        private void BtnTraspasa_Click(object sender, EventArgs e)
        {
            if (rb1a2.Checked && listBox1.SelectedItem!=null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }else if (rb2a1.Checked && listBox2.SelectedItem!=null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }

            label1.Text = "En la lista 1 hay " + listBox1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.listBox2, listBox2.Items.Count.ToString());



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string resultado = "Indices seleccionados: ";
            if (listBox1.SelectedIndex != -1)
            {
                foreach (int indice in listBox1.SelectedIndices)
                {
                    resultado += indice + " ";
                }
                label2.Text = resultado;
            }
            else
            {
                label2.Text = "Indices seleccionados: Ninguno";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            this.Text = textoCompleto.Substring(indice);
            indice--;

            if (indice<0)
            {
                indice = textoCompleto.Length - 1;
                this.Icon = Properties.Resources.icono2;
            }
            else
            {
                this.Icon = Properties.Resources.icono;
            }





        }

       
    }
}
