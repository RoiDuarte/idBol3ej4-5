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
            lblInformativa1.Text = "En la lista 1 hay "+ lstLista1.Items.Count + " elementos";
            lblInformativa2.Text = "Indices seleccionados: Ninguno";
            indice=textoCompleto.Length - 1;
            toolTip1.SetToolTip(this.lstLista2, lstLista2.Items.Count.ToString());




        }

        private void BtnAnhadir_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtTexto.Text.Trim();

                if (!lstLista1.Items.Contains(nuevoElemento) && !string.IsNullOrEmpty(nuevoElemento))
                {
                    lstLista1.Items.Add(nuevoElemento);
                }
   
            lblInformativa1.Text = "En la lista 1 hay " + lstLista1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.lstLista2, lstLista2.Items.Count.ToString());

        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            
            if (rbListBox1.Checked && lstLista1.SelectedItem != null)
            {
                btnQuitar.Text = "Elimina de 1";
                for (int i = lstLista1.SelectedIndices.Count-1; i >=0 ; i--)
                {
                    lstLista1.Items.RemoveAt(lstLista1.SelectedIndices[i]);
                }
                
            }else if (rbListBox2.Checked && lstLista2.SelectedItem != null)
            {
                btnQuitar.Text = "Elimina de 2";

                for (int i = lstLista2.SelectedIndices.Count-1; i >=0 ; i--)
                {
                    lstLista2.Items.RemoveAt(lstLista2.SelectedIndices[i]);
                }

            }

            lblInformativa1.Text = "En la lista 1 hay " + lstLista1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.lstLista2, lstLista2.Items.Count.ToString());


        }

        private void BtnTraspasa_Click(object sender, EventArgs e)
        {
            if (rb1a2.Checked && lstLista1.SelectedItem!=null)
            {
                for (int i = lstLista1.SelectedIndices.Count-1; i >=0; i--)
                {
                    lstLista2.Items.Add(lstLista1.SelectedIndices[i]);
                    lstLista1.Items.RemoveAt(lstLista1.SelectedIndices[i]);
                }
                
            }else if (rb2a1.Checked && lstLista2.SelectedItem!=null)
            {
                for (int i = lstLista2.SelectedIndices.Count-1; i >=0 ; i--)
                {
                    lstLista1.Items.Add(lstLista2.SelectedIndices[i]);
                    lstLista2.Items.RemoveAt(lstLista2.SelectedIndices[i]);
                }
                
            }

            lblInformativa1.Text = "En la lista 1 hay " + lstLista1.Items.Count + " elementos";
            toolTip1.SetToolTip(this.lstLista2, lstLista2.Items.Count.ToString());



        }

        private void lstLista1_IndiceCambiado(object sender, EventArgs e)
        {

            string resultado = "Indices seleccionados: ";
            if (lstLista1.SelectedIndex != -1)
            {
                foreach (int indice in lstLista1.SelectedIndices)
                {
                    resultado += indice + " ";
                }
                lblInformativa2.Text = resultado;
            }
            else
            {
                lblInformativa2.Text = "Indices seleccionados: Ninguno";
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
