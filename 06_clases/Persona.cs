public class Persona{
    public required string Nombre {get; set;}
    public required string Apellido {get; set;}
    public override string ToString(){
        return $"Nombre: {this.Nombre} Apellido: {this.Apellido}";
    }
}