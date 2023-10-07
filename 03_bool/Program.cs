using System; //se importan librerias
namespace _03_bool //nombre del proyecto
{
    internal class _03_bool
    {
        static void Main(string[] args)
        {
            bool raining = false;
            bool busLate = true;

            Console.WriteLine($"It is raining: {raining}");
            Console.WriteLine($"the bus is late: {busLate}");


            Console.WriteLine("It is raining: {0}",
                              raining ? "Yes" : "No");
            Console.WriteLine("The bus is late: {0}",
                              busLate ? "Yes" : "No");



        }
    }
}



// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
