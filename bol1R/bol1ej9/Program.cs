using System.Collections;

namespace bol1ej9
{
    internal class Program
    {
        public static int pedirEntero() {

            int n;
            bool bandera;
            do
            {
                Console.WriteLine("Dime un n");
                bandera = int.TryParse(Console.ReadLine(), out n);
                if (!bandera)
                {
                    Console.WriteLine("Eso no es un n entero, vuelve a intentarlo");
                }
            } while (!bandera);
            return n;
        
        }

        //public static double pedirReal()
        //{
        //    double n;
        //    bool bandera;
        //    do
        //    {
        //        Console.WriteLine("Dime un numero real");
        //        bandera= double.TryParse(Console.ReadLine(),out n);
        //        if (!bandera)
        //        {
        //            Console.WriteLine("Eso no es un numero real, vuelve a intentarlo");
                    
        //        }
        //    }while(!bandera);
        //    return n;
        //}

        public static string pedirString() {

            string cadena="";
            bool error=false;

            do
            {

                try { 
                error = false;
                Console.WriteLine("Introduce una cadena");
                cadena= Console.ReadLine();
                

                }
                catch (IOException)
                {
                    Console.WriteLine("Has introducido algo que no es una cadena");
                    error = true;
                }

            }

            while (error);

            return cadena;


        }
        static void Main(string[] args)
        {
            Hashtable ordenadoresRed = new Hashtable();
            Ordenador ordenador1 = new Ordenador("",0);

            Ordenador prueba = new Ordenador("prueba", 8);

            ordenadoresRed.Add("192.168.1.1", prueba);


            //Introducir elementos
            //ordenadoresRed.Add();
            int opcion = -1;

            do
            {

                Console.WriteLine("-- Menu --");
                Console.WriteLine("1.-Anhadir nuevo equipo");
                Console.WriteLine("2.-Anhadir varios equipos");
                Console.WriteLine("3.-Eliminar un dato");
                Console.WriteLine("4.-Muestra la colección entera");
                Console.WriteLine("5.-Muestra un elemento de la coleccion");
                Console.WriteLine("6.-Salir");

                opcion = pedirEntero();

                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Dime una ip");

                        string ip = pedirString();

                        if (ordenador1.ipValida(ip))
                        {
                            Console.WriteLine("Cuanta RAM tiene el equipo?");
                            int memoriaRam = pedirEntero();
                            Console.WriteLine("Que nombre le quieres dar al equipo?");
                            string nombre = pedirString();
                            ordenador1 = new Ordenador(nombre, memoriaRam);

                            if (ordenador1.MemoriaRam>0)
                            {   
                            ordenadoresRed.Add(ip, ordenador1);
                            }
                            else
                            {
                                Console.WriteLine("RAM invalida");
                            }


                        }
                        else
                        {
                            Console.WriteLine("ip invalida");
                        }



                        break;

                    case 2:

                        Console.WriteLine("Cuantos ordenadores quieres introducir?");

                        int numeroOrdenadores=pedirEntero();

                        Ordenador[] ordenadores = new Ordenador[numeroOrdenadores];

                        for (int i = 0; i < ordenadores.Length; i++)
                        {
                            
                            Console.WriteLine("Dime la ip del ordenador");
                            ip=pedirString();

                            if (ordenador1.ipValida(ip))
                            {
                                Console.WriteLine("Dime cuanta RAM tiene el equipo");
                                int memoriaRam= pedirEntero();
                                Console.WriteLine("Dime el nombre del equipo");
                                string nombre = pedirString();
                                ordenadores[i] = new Ordenador(ip, memoriaRam);
                                ordenadoresRed.Add(ip,ordenadores[i]);
                            }
                            else
                            {
                                Console.WriteLine("ip invalida");
                            }





                        }

                        break;

                    case 3:

                        Console.WriteLine("Dime la ip del ordenador que quieres borrar");
                        ip = pedirString();

                        ordenadoresRed.Remove(ip);

                        break;

                    case 4:

                        

                        foreach (object key in ordenadoresRed.Keys) 
                        {

                            Console.WriteLine(key);
                            
                        }

                        break;

                    case 5:

                        Console.WriteLine("Dime la ip del equipo");

                        ip = pedirString();

                        if (ordenadoresRed.ContainsKey(ip))
                        {
                            Ordenador pc = (Ordenador)ordenadoresRed[ip];
                            Console.WriteLine("Tiene "+pc.MemoriaRam+" de RAM");
                        }
                        else
                        {
                            Console.WriteLine("No existe un equipo con esa ip");
                        }

                        break;
                }


            } while (opcion != 6);
        }
    }
}
