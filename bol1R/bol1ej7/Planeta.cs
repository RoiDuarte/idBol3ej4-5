using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1ej7
{
    internal class Planeta : Astro, ITerraformable
    {
     //   private bool gaseoso;
        public bool Gaseoso {  get; set; }
        //{
        //    get { return gaseoso; }
        //    set { gaseoso = value; }
        //}

        private int satelites;
        public int Satelites
        {
            get { return satelites; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                satelites = value;

            }
        }

        public Planeta(string nombre, double radio, bool gaseoso, int satelites)
            : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.Satelites = satelites;

        }

        public Planeta()
            : this("", 1, false, 0)
        {


        }

        public bool esHabitable()
        {
            return (Gaseoso == false && (Radio >= 2000 && Radio <= 8000));
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public override string ToString()// TODO Usar ben o format
        {
            //return Nombre.PadRight(10) + Satelites.ToString().PadRight(4) + string.Format("{0,2}", Radio);
            return string.Format("{0,10}, {1,4}, {2:F2}",Nombre,Satelites, Radio);
        }

        public static Planeta operator ++(Planeta planeta)
        {

            planeta.satelites++;
            return planeta;
        }

        public static Planeta operator --(Planeta planeta)
        {

            planeta.satelites--;
            if (planeta.satelites < 0)
            {
                planeta.satelites = 0;
            }
            return planeta;
        }

    }

}


