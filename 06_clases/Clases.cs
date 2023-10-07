namespace _06_clases;

public class Clases
{
    static void Main(string[] args)
    {
        Container c1 = new Container(3);
        Container c2 = new Container(2);

        Console.WriteLine(c1);
        Console.WriteLine(c2);

        c1.SetCapacity(-3);
        Console.WriteLine(c1.GetCapacity());
        c2.SetCapacity(8);
        Console.WriteLine(c2.GetCapacity());

        Persona p1 = new Persona() { Nombre = "Alonso", Apellido = "Martin" };
        Console.WriteLine(p1);

        Empleado e1 = new Empleado(3000.0) { Nombre = "Jacobo", Apellido = "Garcia" };
        Console.WriteLine(e1);

        Cuadrado cuad1 = new Cuadrado(3.5);
        Console.WriteLine(cuad1.GetArea());


    }
}