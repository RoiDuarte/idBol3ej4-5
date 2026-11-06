namespace bol1ej4
{
    internal class Program
    {

        static bool AnhoBisiesto(int anho)
        {
            //while (anhoBisiesto <= 0 || anhoBisiesto >= 10000)
            //{
            //    Console.WriteLine("Dame un año bisiesto");
            //    anhoBisiesto = Convert.ToInt32(Console.ReadLine());
            //}

            //if ((anho % 4 == 0 && anho % 100 != 0) || anho % 400 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (anho % 4 == 0 && anho % 100 != 0) || anho % 400 == 0;
        }

        static int? sumaRango(int? minimo, int? maximo)
        {
            if (minimo == null || maximo==null)
            {
                return null;
                
            }else if (minimo > maximo)
            {
                return null;
                // Console.WriteLine("El numero minimo es mayor que el maximo");
            }
            else
            {
                int suma = 0;

                for (int i = minimo.Value; i <= maximo.Value; i++)
                {

                    suma = suma + i;

                }

                return suma;
            }


        }

        public static int? pedirDatos()
        { //TODO

            Console.WriteLine("Dame un numero");
            int numero =Convert.ToInt32(Console.ReadLine());

            if (numero==null)
            {
                return null;  
            }
            else
            {
                return numero;
            }


        }










        static void Main(string[] args)
        {

            int opcion = 0;
            do
            {

                Console.WriteLine("-- MENU --");
                Console.WriteLine("1.-Anho bisiesto");
                Console.WriteLine("2.-Suma de rangos de numeros");
                Console.WriteLine("3.-Todas las opciones");
                Console.WriteLine("4.-Salir");
                Console.WriteLine("------------------");
                Console.WriteLine("Escoge una opcion");

                opcion = Convert.ToInt32(Console.ReadLine());






                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("Dame un anho mayor que 0 y menor que 10000");
                        int anho = Convert.ToInt32(Console.ReadLine());
                        //AnhoBisiesto(anho);

                        if (AnhoBisiesto(anho))
                        {
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("No es bisiesto");
                        }

                        if (opcion == 3)
                        {
                            goto case 2;
                        }

                        break;

                    case 2://TODO fUNCION DE petición de datos e mostrar error  se e null
                        Console.WriteLine("Dame un numero positivo menor que 10000, el numero minimo");
                        int? minimo = pedirDatos();
                        Console.WriteLine("Dame un numero positivo menor que 10000, el numero maximo");
                        int? maximo = pedirDatos();

                        Console.WriteLine(sumaRango(minimo, maximo));

                        break;

                    case 3:

                        goto case 1;


                    case 4:

                        break;





                }

            } while (opcion != 4);




        }
    }
}
