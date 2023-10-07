using System; //se importan librerias
namespace _06_Quijote //nombre del proyecto
{
    internal class Quijote
    {
        static void Main(string[] args)
        {

            string cadena = """
            En un lugar de la Mancha, de cuyo nombre no quiero acordarme, 
            no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, 
            adarga antigua, rocín flaco y galgo corredor. Una olla de algo más vaca que carnero, 
            salpicón las más noches, duelos y quebrantos los sábados, lantejas los viernes, 
            algún palomino de añadidura los domingos, consumían las tres partes de su hacienda. 
            El resto della concluían sayo de velarte, calzas de velludo para las fiestas, 
            con sus pantuflos de lo mesmo, y los días de entresemana se honraba con su vellorí de lo más fino. 
            Tenía en su casa una ama que pasaba de los cuarenta, y una sobrina que no llegaba a los veinte, 
            y un mozo de campo y plaza, que así ensillaba el rocín como tomaba la podadera. 
            Frisaba la edad de nuestro hidalgo con los cincuenta años; era de complexión recia, 
            seco de carnes, enjuto de rostro, gran madrugador y amigo de la caza. 
            Quieren decir que tenía el sobrenombre de Quijada, o Quesada, 
            que en esto hay alguna diferencia en los autores que deste caso escriben; 
            aunque por conjeturas verosímiles se deja entender que se llamaba Quijana. 
            Pero esto importa poco a nuestro cuento: basta que en la narración dél no se 
            salga un punto de la verdad.
            """;

            //definimos el texto con un string y pedimos por teclado la palabra que queremos buscar
            Console.Write("introduce la palabra a buscar: ");
            string busca = Console.ReadLine();
            //en un string guardamos cada una de las palabras que hay, las separamos por espacios, comas, puntos...
            string[] palabras = cadena.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' });
            //creamos un contador para ver cuantas veces aparece la palabra y definimos el bucle for que
            //Va a recorrer la longitud del array palabras viendo todas las que hay
            int contador = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].ToLower() == busca)
                //si la palabra que aparece en la posicion i coincide con la que buscamos, añadira un valor al contador
                //y mostrara por pantalla las veces que ha aparecido y la posicion en la que aparece, i +1, ya que 
                //los arrays comienzan a contar desde 0
                {
                    contador++;
                    Console.WriteLine($"Aparición #{contador}: Posición {i + 1}");
                }
            }
            //si el contador es igual a cero significa que la palabra no aparece en el texto
            if (contador == 0){
                Console.WriteLine("La palabra no aparece en el texto");
            }
        }
    }
}