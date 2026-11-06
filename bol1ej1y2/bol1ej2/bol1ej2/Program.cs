namespace bol1ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad");
           // string edad=Console.ReadLine();
            int edadInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame tu peso");
            string peso = Console.ReadLine();
            int pesoInt = Convert.ToInt32(peso);

            Console.WriteLine("Nombre: {0,12}, Edad: {1,4}\n\tPeso: {2,5:.0}\n\"{0}\" \t\\{1}\\",nombre, edadInt, pesoInt);
            

        }
    }
}
