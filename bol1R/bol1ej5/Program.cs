//#define PRUEBA

namespace bol1ej5
{
    internal class Program
    {

        static bool Nfactorial(int n, ref int f)
        {

            f = 1;

            if (n >= 0 && n <= 10)
            {     
                for (int i = n; i >= 1; i--)
                {

                    f = f * i;
                }

                return true;

            }
            else
            {
                return false;
                
            }

        }

        static void Paleatoria(int a = 10)
        {

            Random generador = new Random();

            int x;
            int y;
           

            for (int i = 0; i < a; i++)
            {

                x = generador.Next(1, 11);
                y = generador.Next(1, 21);
                Console.SetCursorPosition(x, y);
                Console.WriteLine("*");
            }


        }




            static void Main(string[] args)
            {

#if PRUEBA
            Paleatoria();
           
           
#else
            int f = 0;
            if (Nfactorial(7, ref f) )
            {
                Console.WriteLine(f);
            }
            else
            {
                Console.WriteLine("Numero no valido");
            }

#endif
        }
        }
    }

