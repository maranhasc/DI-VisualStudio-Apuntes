using System; //se importan librerias
namespace _01_espar.cproj //nombre del proyecto
{
    internal class EsPar
    {
        static void Main(string[] args)
        {
            //definimos el metodo main y dentro las variables ecesarias, en este caso numero y el input
            double numero;
            string? input;
            //pedimos el numero por teclado y lo guardamos en la variable input
            Console.Write("Introduce un numero: ");
            input = Console.ReadLine();
            //creamos el primer bucle if, si el numero no es entero imprimera el primer bucle
            if(input.Contains(".")){
                Console.WriteLine("No es entero");
                    
            }else{
                //si el numero es entero, parseara el numero y lo dividira entre dosk, si es exacto podemos
                //definir que es par, si no, imprimirá que es impar
                numero = Int32.Parse(input);
                if (numero%2==0){
                Console.WriteLine("El numero es par");
                } else {
                Console.WriteLine("El numero es impar");

            }

            }


            

            



        }
    }
}
