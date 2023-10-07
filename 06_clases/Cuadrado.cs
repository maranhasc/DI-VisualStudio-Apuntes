namespace _06_clases;

public class Cuadrado : Figura{
    protected double _lado;

    public Cuadrado( double lado) => this._lado = lado;

    public override double GetArea(){
        return this._lado * this._lado;
    }
}