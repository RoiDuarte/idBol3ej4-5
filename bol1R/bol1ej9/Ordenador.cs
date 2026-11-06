using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace bol1ej9
{
    internal class Ordenador
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int memoriaRam;
        public int MemoriaRam
        {
            get { return  memoriaRam; }
            set {  memoriaRam = value; }
        }

        public Ordenador(string nombre, int memoriaRam)
        {
            this.Nombre = nombre;
            this.MemoriaRam= memoriaRam;
        }

        
        

        public  bool ipValida(string ip)
        {


            string[] partes = ip.Split('.');
            if (partes.Length==4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        



    }
}
