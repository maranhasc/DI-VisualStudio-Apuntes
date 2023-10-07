

//nombre_proyecto dotnet new console
using System; //se importan librerias
namespace web.csproj //nombre del proyecto
{
    class Consola
    {
        static void Main(string[] args)
        {

            string? lectura;


            Console.Write("Hola me llamo ");
            Console.WriteLine("Muzzy");

            Console.Write("Edad: ");
            lectura = Console.ReadLine();

            Console.WriteLine(lectura);


        }
    }
}




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
