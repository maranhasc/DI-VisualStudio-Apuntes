namespace _07_list;

public class ListaObjetos{
    public static void Main(string[] args){


        List<Evento> lista_eventos =new List<Evento>();
        Evento ev1 = new Evento(new DateTime(2023,11,14,14,0,0), new TimeSpan(1,0,0), "Cumpleaños de Cuchi", "Es el cumpleaños de tu perro");
        Console.WriteLine(ev1);


        lista_eventos.Add(ev1);
        lista_eventos.Add(new Evento(new DateTime(2023,11,14,14,0,0), new TimeSpan(2,0,0), "Bolera", "Jugar a los bolos"));
        lista_eventos.Add(new Evento(new DateTime(2024,11,14,14,0,0), new TimeSpan(2,0,0), "Bolera", "Jugar a los bolos"));


        foreach(Evento ev in lista_eventos){
            Console.WriteLine(ev);
        }
        
    }
}