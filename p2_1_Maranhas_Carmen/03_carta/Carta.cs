using System; //se importan librerias
namespace _03_carta //nombre del proyecto
{
    internal class Carta
    {
        static void Main(string[] args)
        {
            //pedimos por teclado cada uno de los datos que vamos a necesitar para la redaccion de la carta

            Console.Write("Introduce el nombre: ");
            string nombre = Console.ReadLine().Trim();
            Console.Write("Introduce la localidad: ");
            string LOCALIDAD = Console.ReadLine().Trim();
            Console.Write("Introduce la fecha de inicio: ");
            string FECHA_INICIO = Console.ReadLine().Trim();
            Console.Write("Introduce la fecha de fin: ");
            string FECHA_FIN = Console.ReadLine().Trim();
            Console.Write("Introduce el curso: ");
            string curso = Console.ReadLine().Trim();

            //escribimos la carta con un raw string literal y las variables que vamos a introducir nosotros

            string informacion = $"""
            Estimado {nombre}
            Bienvenido al curso de {curso} que se celebrará en la localidad de {LOCALIDAD}
            entre las fechas {FECHA_INICIO} y {FECHA_FIN}. Espero que el curso se desarrolle según sus expectativas. Estaremos encantados de atenderle.
            Atentamente, La dirección
            """;
            //finalmente mostramos el texto por consola
            Console.WriteLine(informacion);
        }
    }
}