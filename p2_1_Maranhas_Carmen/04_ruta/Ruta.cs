using System; //se importan librerias
namespace _04_ruta //nombre del proyecto
{
    internal class Ruta
    {
        static void Main(string[] args)
        {
            //pedimos la ruta por teclado
            Console.Write("Introduce la ruta: ");
            string ruta = Console.ReadLine();
            //mostramos cual es la ruta completa
            Console.WriteLine($"la ruta completa es {ruta}");
            //guardamos en un array la ruta separandola cada vez que aparezca la barra
            string [] splits = ruta.Split("\\");
            //creamos el bucle que nos ira mostrando cada uno de los directorios
            for (int i = 0; i < splits.Length; i++)
            {
                //si la posicion es cero nos muestra la ruta en lugar del directorio y lo mostramos por pantalla
                if(i==0){
                    Console.WriteLine($"Ruta: {splits[0]}");
                }else{
                Console.WriteLine($"Directorio nivel {i}: {splits[i]}");

                }
                
            }




            
        }
    }
}