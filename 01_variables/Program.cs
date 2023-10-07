using System;

namespace _01_variables{
    internal class _01_variables{
        static void Main(String[] args){
            int n1, altura;
            byte b1;
            float f1;
            double d1, d2;
            double suma, resta, mult, div, area;
            const double PI = 3.141692;
            String input;
            n1 = 2;
            //n3 = "2"; daria error ya que no es un entero 
            //f1 = 2.4;
            f1 = 3.4f;
            d1 = 0.00005;
            d2 = 30000000000;
            double radio = 3.4;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(f1);
            Console.WriteLine(n1);

            suma = d1 + d2;
            Console.WriteLine(suma);
            suma = n1 + d2;
            Console.WriteLine(suma);

            area = PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es: " + area);


            Console.WriteLine("Itroduce la altura: ");
            input = Console.ReadLine();
            try{
                altura = Int32.Parse(input);
                Console.WriteLine(altura);

            }
            catch(FormatException){
                Console.WriteLine($"Unable to parse '{input}'");
            }






        }
    }
}



// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
