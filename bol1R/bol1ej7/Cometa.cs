using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1ej7
{
    internal class Cometa : Astro, ITerraformable
    {

        public Cometa(string nombre, double radio)
        :base(nombre,radio){
            
        }
        public bool esHabitable()
        {
            return false;
        }
    }
}
