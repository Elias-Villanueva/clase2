namespace Jugadores
{
    public class Jugador {
        public string Nombre { get; set;}
        public int Edad { get; set; }
        public bool Activo { get; set;}

        public Jugador(string nombre, int edad, bool activo = false) {
            Nombre = nombre;
            Edad = edad;
            Activo = activo;
        }
        public string IsActivo () {
            return Activo ? "Jugador Activo" : "Jugador necesita activar su cuenta";
        }
    }
}