using System; //se importan librerias
namespace _02_hastamayoredad.csproj //nombre del proyecto
{
    internal class HastaMayorEdad
    {
        static void Main(string[] args)
        {
            //definimos el metodo main y las variables necesarias
            //variable numero para guardar el valor que entre por teclado
            //la variable input para poder parsear el valor 
            int numero;
            string? input;
            
            do
            {
                //creamos un bucle do-while para que siga repitiendose hasta que la condicion que hemos puesto
                //deje de cumplirse
                Console.Write("Introduce un numero: ");
                input = Console.ReadLine();
                numero = Int32.Parse(input);
            } while (numero < 18);


        }
    }
}
