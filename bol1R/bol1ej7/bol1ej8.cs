using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bol1ej7
{
    internal class bol1ej8
    {

        public static int pedirInt()
        {
            int n;
            bool bandera;
            do
            {
                Console.WriteLine("Dime un n");
                bandera = int.TryParse(Console.ReadLine(), out n);
                if (!bandera)
                {
                    Console.WriteLine("Eso no es un numero entero, vuelve a intentarlo");
                }

            } while (!bandera);

            return n;
        }

        public static double pedirReal()
        {
            double n;
            bool bandera;

            do
            {
                Console.WriteLine("Dime un numero real");
                bandera=double.TryParse(Console.ReadLine(),out n);
                if (!bandera)
                {
                    Console.WriteLine("Eso no es un numero real, vuelve a intentarlo");
                }


            }
            while (!bandera);

            return n;
        }

        public static string pedirString() {

            string cadena="";
            bool error = false;

            do
            {
                try
                {
                    error = false;
                    Console.WriteLine("Dame una cadena");
                    cadena = Console.ReadLine();

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

            List<Astro> astros = new List<Astro>();

             //public Planeta(string nombre, double radio, bool gaseoso, int satelites)
        //     public Cometa(string nombre, double radio)
        //: base(nombre, radio)
        //{

            string directory = Environment.GetEnvironmentVariable("APPDATA");
            string separator = "\\";
            string fullName = directory + separator + "testfile.txt";
            string line;
            

            if (File.Exists(fullName))
            {

                StreamReader sr;
                sr = new StreamReader(fullName);
                line = sr.ReadLine();

                while (line!=null)
                {
                    string nombreA;
                    double radioA;
                    bool gaseosoA;
                    int satelitesA;
                    string[] partes = line.Split(',');

                    if (partes.Length==4)
                    {
                        nombreA = partes[0];
                        radioA = double.Parse(partes[1]);
                        gaseosoA = bool.Parse(partes[2]);
                        satelitesA = int.Parse(partes[3]);

                        astros.Add(new Planeta(nombreA, radioA, gaseosoA, satelitesA));


                    }else if (partes.Length==2)
                    {
                        nombreA=partes[0];
                        radioA=double.Parse(partes[1]);

                        astros.Add(new Cometa(nombreA, radioA));
                    }

 
                    line = sr.ReadLine();
                }
                sr.Close();
            }




            

                int opcion = -1;
            bool gaseoso = false;
            string nombre;
            double radio;
            int satelites;
            //astros.Add(new Planeta("SATURNO", 3, true, 5));
            //astros.Add(new Planeta("FGF", 3, true, 5));

            //astros.Add(new Planeta("SATFGHHGFURNO", 3, false, 5));
            //astros.Add(new Planeta("FF", 5, true, 5));

            do
            {
                Console.WriteLine("-- Menu --");
                Console.WriteLine("1.-Anhade Planeta");
                Console.WriteLine("2.-Anhade Cometa");
                Console.WriteLine("3.-Mostrar datos");
                Console.WriteLine("4.-Incremeta/Decrementa nº de satelites");
                Console.WriteLine("5.-Eliminar no terraformables");
                Console.WriteLine("6.-Salir");

                Console.WriteLine("Escoge tu opcion");
                opcion = pedirInt();
                //TODO tryparse e trycatch
                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("Es gaseoso?");
                        Console.WriteLine("1.Si \n Outro.No");
                        int respuesta = pedirInt();
                        //if (respuesta == 1)//TODO expr lóxica
                        //{
                        //    gaseoso = true;
                        //}
                        //else  
                        //{
                        //    gaseoso = false;
                        //}

                        gaseoso = respuesta == 1;

//                        int a=0, b=0, c;

//                        if (a+b ==1)
//                            c=1
//                        if (a+b==2)
//                            c=2
//                                ..
//c=a+b

                        Console.WriteLine("Dime el nombre");
                        nombre = pedirString();
                        Console.WriteLine("Dime el radio");//TODO funcions de petición de datos con erros
                        radio = pedirReal();
                        Console.WriteLine("Dime el numero de lunas");
                        satelites = pedirInt();

                        astros.Add(new Planeta(nombre, radio, gaseoso, satelites));




                        break;

                    case 2:

                        Console.WriteLine("Dame el nombre");
                        nombre = pedirString();
                        Console.WriteLine("Dame su radio");
                        radio = pedirReal();
                        astros.Add(new Cometa(nombre, radio));

                        break;

                    case 3:

                        for (int i = 0; i < astros.Count; i++)
                        {
                            //TODO más claro para o usuario
                            if (astros[i] is Planeta)
                            {
                                Planeta p = (Planeta)astros[i];

                                //Console.WriteLine(p.ToString());
                                //Console.WriteLine(p.esHabitable());
                                Console.WriteLine("Los datos del planeta son: {0}. Es habitable?:{1}", p.ToString(), p.esHabitable()?"Si":"No");


                            }

                            if (astros[i] is Cometa)
                            {
                                Cometa c = (Cometa)astros[i];
                                //Console.WriteLine(c.Nombre);
                                //Console.WriteLine(c.esHabitable());
                                Console.WriteLine("El nombre del cometa es:{0}. Es habitable?:{1}", c.Nombre,c.esHabitable());

                            }

                        }
                        break;

                    case 4:

                        Console.WriteLine("Dime el nombre del astro");
                        nombre = pedirString();

                        //for (int i = 0; i < astros.Count; i++) //TODO non sigue
                        //{
                        //    if (astros[i].Nombre == nombre)
                        //    {
                        //        if (astros[i] is Planeta)
                        //        {
                        //            Planeta p = (Planeta)astros[i];

                        //            Console.WriteLine("Quieres incrementar o decrementar en 1 los satelites del astro?");

                        //            Console.WriteLine("1.-Incrementar");
                        //            Console.WriteLine("2.-Decrementar");
                        //            int subOpcion = Convert.ToInt32(Console.ReadLine());

                        //            switch (subOpcion)
                        //            {
                        //                case 1:
                        //                    p++;
                        //                    break;

                        //                case 2:
                        //                    p--;
                        //                    break;
                        //            }
                        //        }




                        //        break;
                        //    }
                        //}


                        int posicion = astros.IndexOf(new Planeta(nombre, 1, true, 0));


                        if (posicion!=-1)
                        {
                            if (astros[posicion] is Planeta)
                            {
                                Planeta p = (Planeta)astros[posicion];

                                Console.WriteLine("Quieres incrementar o decrementar en 1 los satelites del astro?");

                                Console.WriteLine("1.-Incrementar");
                                Console.WriteLine("2.-Decrementar");
                                int subOpcion = pedirInt();

                                switch (subOpcion)
                                {
                                    case 1:
                                        p++;
                                        break;

                                    case 2:
                                        p--;
                                        break;
                                }
                            }
  
                            break;
                        }


                        break;

                    case 5:

                        for (int i = astros.Count - 1; i >= 0; i--)
                        {
                            //TODO usar ITerraformable
                            if (astros[i] is ITerraformable t)
                            {
                                

                                if (!t.esHabitable() )//TODO eliminar o habitables
                                {
                                    astros.RemoveAt(i);
                                }
                            }
                        }

                        break;

                    case 6:

                        break;
                }

            } while (opcion != 6);

            StreamWriter s;
            s = new StreamWriter(fullName,false);

            for (int i = 0; i < astros.Count; i++)
            {

                s.WriteLine(astros[i]);
                
            }

            s.Close();
        }

        
    }

    
}