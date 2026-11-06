namespace bol1ej10
{
    internal class Program
    {

        public static int pedirInt()
        {
            bool bandera;
            int n;
            do
            {
                bandera = int.TryParse(Console.ReadLine(), out n);
                if (!bandera)
                {
                    Console.WriteLine("Eso no es un n entero, vuelve a intentarlo");
                }
            } while (!bandera);
            return n;
        }

        public static double pedirDouble()
        {
            double n;
            bool bandera;
            do
            {
                bandera = double.TryParse(Console.ReadLine(), out n);
                if (!bandera)
                {
                    Console.WriteLine("Eso no es un n real, vuelve a intentarlo");
                }
            } while (!bandera);

            return n;
        }
        static void Main(string[] args)
        {
            GestorMatriz gm = new GestorMatriz();
            int opcion;

            do
            {



                Console.WriteLine("--MENU--");
                Console.WriteLine("1.-Mostrar tabla");
                Console.WriteLine("2.-Mostrar medias");
                Console.WriteLine("3.-Mostrar suma de una fila");
                Console.WriteLine("4.-Mostrar suma de una columna");
                Console.WriteLine("5.-Incremento aleatorio");
                Console.WriteLine("6.-Cambiar Matriz");
                Console.WriteLine("7.-Salir");

                opcion = pedirInt();

                switch (opcion)
                {
                    case 1:

                        gm.MostrarMatriz(gm.Matriz);
                        break;

                    case 2:
                        //TODO quede aqui
                        break;
                    default:
                        break;
                }
            }
            while (opcion != 7);
        }
    }
}
