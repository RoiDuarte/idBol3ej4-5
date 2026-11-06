using System;
using System.Collections.Generic;
using System.Text;

namespace bol1ej10
{
    internal class MatrizException:Exception
    {
        public MatrizException() :base() {  }

        public MatrizException(string message) : base(message) { }

    }
}
