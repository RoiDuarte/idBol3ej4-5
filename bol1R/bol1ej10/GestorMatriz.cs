using System;
using System.Collections.Generic;
using System.Text;

namespace bol1ej10
{
    internal class GestorMatriz
    {
        public int[,] Matriz { get; set; }
        Random random = new Random();



        public GestorMatriz(int filas, int columnas)
        {
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Matriz[i, j] = random.Next(-5, 21);
                }



            }
        }
        public GestorMatriz() : this(3, 4)
        {
        }

        public (int, bool) SumaFila(int entero)
        {
            int suma = 0;

            if (entero >= 0 && entero < Matriz.GetLength(0))
            {

                for (int i = 0; i < Matriz.GetLength(1); i++)
                {


                    suma += Matriz[entero, i];

                }
                return (suma, true);
            }
            else
            {
                return (0, false);
            }

        }

        public bool SumaColumna(int columna, out int suma)
        {
            suma = 0;
            if (columna >= 0 && columna < Matriz.GetLength(1))
            {
                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    suma += Matriz[i, columna];
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public double SumaMatriz(object p)
        {
            double suma = 0;
            if (p is int[,])
            {
                int[,] a = (int[,])p;

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        suma += a[i, j];
                    }
                }

                return suma;

            }
            else if (p is double[,])
            {
                double[,] b = (double[,])p;


                for (int i = 0; i < b.GetLength(0); i++)
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        suma += b[i, j];
                    }
                }

                return suma;

            }
            else if (p is GestorMatriz && ((GestorMatriz)p).Matriz.GetLength(0) == this.Matriz.GetLength(0) && ((GestorMatriz)p).Matriz.GetLength(1) == this.Matriz.GetLength(1))
            {
                GestorMatriz c = (GestorMatriz)p;

                for (int i = 0; i < c.Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < c.Matriz.GetLength(1); j++)
                    {
                        suma += c.Matriz[i, j];
                    }
                }
                return suma;
            }
            else
            {
                throw new MatrizException();
            }


        }


        public double[] medias(bool b)
        {
            if (b)
            {
                double[] mediaFilas = new double[Matriz.GetLength(0)];

                for (int i = 0; i < Matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < Matriz.GetLength(1); j++)
                    {
                        mediaFilas[i] += Matriz[i, j];
                    }

                    mediaFilas[i] = mediaFilas[i] / Matriz.GetLength(0);

                }

                return mediaFilas;

            }
            else
            {
                double[] mediaColumnas = new double[Matriz.GetLength(1)];

                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {

                        mediaColumnas[j] += Matriz[i, j];

                    }
                    mediaColumnas[j] = mediaColumnas[j] / Matriz.GetLength(1);


                }
                return mediaColumnas;

            }


        }

        public void MostrarMatriz <T> (T[,] arrayBi)
        {
            Console.Write("     ");
            for (int i = 0; i < arrayBi.GetLength(1); i++)
            {
                
                Console.Write("{0,5}", (i+1));

            }

            Console.WriteLine();

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.Write($"{(char)('\u0040' + (i + 1)),5}");
                for (int j = 0; j < arrayBi.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arrayBi[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
