using System; //se importan librerias
namespace _04_arrays //nombre del proyecto
{
    internal class _04_arrays
    {
        static void Main(string[] args)
        {
            int [] miArrayDeEnteros = new int[6] {1, 2, 3, 4, 5, 6};

            bool[] miArrayBool = new bool[4] {true, false, false, true};

            Console.WriteLine(miArrayDeEnteros[2]);

            for(int i=0 ; i < miArrayDeEnteros[i]; i++ ){
                Console.WriteLine(miArrayDeEnteros[i]);
            }

            //recorrer array de manera sencilla
            foreach(int valor in miArrayDeEnteros){
                Console.WriteLine(valor);
            }



            String[] strings = { "the", "quick", "brown", "fox", "jumps",
                     "over", "the", "lazy", "dog", "in", "the",
                     "barn" };
            
            string searchString = "the";
            int index = Array.IndexOf(strings, searchString);










        }
    }
}
