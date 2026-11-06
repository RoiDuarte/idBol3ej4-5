using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1ej7
{
    public abstract class Astro
    {
        private string nombre;
        public string Nombre
        {
            get { return "\"" + nombre + "\""; }
            set { nombre=value.ToUpper(); }
        }
        private double radio;
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value > 0)
                {
                    radio = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }


        //public Astro(string nombre, double radio)
        //{
        //    this.nombre = "\"" + nombre.ToUpper() + "\"";

        //    if (radio >= 0)
        //    {
        //        this.radio = radio;
        //    }
        //    else
        //    {
        //        throw new ArgumentException();
        //    }

        //}

        public Astro(string nombre, double radio)
        {
            this.Nombre = nombre;
            this.Radio = radio;
        }

        public Astro()
            :this("Tierra",6378 )
        {
            //this.Nombre = "Tierra";
            //this.Radio = 6378;
        }

        public override bool Equals(object o) //se ponho a interrogacion do null, ponma en vermello


        {


            if (o is Astro)
            {
                Astro a = (Astro)o;
                if (this.nombre == a.nombre)
                {
                    return true;
                }

            }

            else if (o is string)
            {
                string a = (string)o;
                if (this.nombre == a)//Mayusculas
                {
                    return true;
                }
            }


            return false;







        }
    }
}
