namespace _05_struct;
public class Struct{
    static void Main(string[] args)
{
    Punto p1 = new Punto(4, 3);
    Punto p2 = new Punto(4, 5);
    Punto p3=p2;

    Console.WriteLine(p1);
    Console.WriteLine(p2);
    Console.WriteLine(p3);

    //p3.x= -7;
    //p3.y +=10;
    p3.SumaCoord(p2);


}
}

public struct Punto
//si se define como una struct se copian por valor, al modificar uno no modificas el otro
//si se define como una class, se copian por referencia, al modificar uno modificas otro
{
    public int x, y;
    public Punto(int X, int Y)
    {
        this.x = X;
        this.y = Y;
    }
    //suma las coordenadas del punto p al punto this
    public void SumaCoord (Punto p){
        this.x += p.x;
        this.y += p.y;
        //si pasamos por parametro un objeto vamos a modificar su valor, en el class
        //p.x++;
    }

    public override string ToString()
    {
        return string.Format("Coordenadas del punto ({0},{1})", this.x, this.y);
    }
}