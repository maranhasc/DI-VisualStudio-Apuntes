
using System;

namespace _02_string
{
    internal class _02_string
    {
        static void Main(String[] args)
        {
            string cadena1, cadena2, cadena3;
            string cadena4 = """
            Esta cadena 
            es literal
            """;

            cadena1 = "Esto es unca cadena, ";
            cadena2 = "Esto es otra cadena";
            cadena3 = cadena1 + cadena2;
            Console.WriteLine(cadena3);
            Console.WriteLine(cadena4);

            //cadena introduciendo valores
            string nombre = "pepe";
            string apellido = "perez";
            double nota = 9.4;
            string cadena;
            string info = $"{nombre} {apellido} nota: {nota}";
            Console.WriteLine(info);




            string informacion = $"""
            nombre: {nombre}
            apellido: {apellido}
            nota: {nota}
            Edad:
            """;
            Console.WriteLine(informacion);
            string input = Console.ReadLine();


            string string1 = "This is a string created by assignment.";
            Console.WriteLine(string1);
            string string2a = "The path is C:\\PublicDocuments\\Report1.doc";
            Console.WriteLine(string2a);
            string string2b = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine(string2b);

            //tipo char 
            char opcion = 'a';

            char[] chars = { 'w', 'e', 'r', 't' };
            string string4 = new string(chars);

            Console.WriteLine(chars);
            Console.WriteLine(string4);

            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "fox";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                            s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",
                                  s2, index + 1);
            }


            //metodo trim
            Console.Write("introduce tu correo electronico: ");
            string? email = Console.ReadLine();
            if(email != ""){
                email = email.Trim();
                Console.WriteLine($"email: {email}");
                if(email.Contains("@")){
                    string [] subs = email.Split("@");
                    Console.WriteLine($"Username: {subs[0]}");
                    Console.WriteLine($"Servidor: {subs[1]}");
                }

            }
            else{
                Console.WriteLine("no se ha introducido ningun email");
            }








        }
    }
}

//introduces el nombre y el apellido, pides la edad

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
