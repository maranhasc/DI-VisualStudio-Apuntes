namespace _07_list;

public class Evento{
    protected DateTime _comienzo;
    protected TimeSpan _duracion;
    protected string? _titulo;
    protected string? _descripcion;

    public Evento(DateTime comienzo, TimeSpan duracion, string titulo, string descripcion){
        this._comienzo = comienzo;
        this._descripcion = descripcion;
        this._duracion = duracion;
        this._titulo = titulo;
    }

    public override string ToString(){
        return $"""
        ___________________
        Titulo: {this._titulo}
        Fecha y hora: {this._comienzo}
        Duracion  : {this._duracion}
        Descripcion: {this._descripcion}
        """;
    }
}