using System.Collections.Generic;
using Jugadores;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arma arma1 = new Arma("Cañon Laser", 100 );
            Arma arma2 = new Arma("Misil", 100);
            Arma arma3 = new Arma("Pistola", 20);

            List<Arma> Armas = new List<Arma>() {arma1, arma2, arma3};

           Jugador jug1 = new Jugador("Elesito", 21, Armas, true);


           
        }
    }
}
