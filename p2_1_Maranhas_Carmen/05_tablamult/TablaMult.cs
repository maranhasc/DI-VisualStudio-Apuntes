using System; //se importan librerias
namespace _05_tablamult //nombre del proyecto
{
    internal class TablaMult
    {
        static void Main(string[] args)
        {
            //definimos las variblaes necesarias 
            int numero;
            bool valido = false;
            string? input;
            //como queremos que, hasta que no introduzca un numero valido se siga repitiendo el bucle haremos un bucle do-while

            do
            {
                //pedimos el numero por teclado 
                Console.Write("Introduce el numero: ");
                input = Console.ReadLine();
                //probamos con un try-catch si se puede parsear el numero
                try
                {
                    numero = Int32.Parse(input);
                    //si se puede parsear vemos si es mayor y cambiamos la variable booleana del valido por la condicion true para que salga del bucle
                    if (numero>=0)
                {
                    valido = true;
                }else{
                    //si no es mayor que cero, volvemos al proceso anterior
                    Console.WriteLine("introduce un numero valido ");
                }
                }
                catch (System.Exception)
                {
                    //si el string no se puede parsear volveremos al paso anterior para introducir otro numero y que sea valido
                    Console.WriteLine("Numero no valido");
                }
                

                
            } while (!valido);
            //una vez que tenemos un numero valido volvemos a parsearlo, esta vez fuera del try-catch para que la variable quede recogida

            numero = Int32.Parse(input);

            //mediante un bucle for creamos la tabla de multiplicar del 1 al 10 
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{numero} x {i} = {numero * i} \n ");

            }

        }
    }
}