public class Empleado : Persona
{
    private double _sueldo;

    public Empleado(double sueldo)
    {
        this._sueldo = sueldo;
    }

    public override string ToString()
    {

        return base.ToString() + $"\nSueldo: {this._sueldo}";

    }

}