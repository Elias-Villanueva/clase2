using System.Collections.Generic;
using System;
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

            Escudo escudo1 = new Escudo("Escudo Gris", 100);
            Escudo escudo2 = new Escudo("Escudo Azul", 100);
            Escudo escudo3 = new Escudo("Escudo Morado", 100);
            Escudo escudo4 = new Escudo("Escudo Dorado", 100);

            List<Escudo> Escudos = new List<Escudo>() {escudo1, escudo2, escudo3, escudo4};

           Jugador jug1 = new Jugador("Elesito", 21, Armas, Escudos, true);
           

           jug1.readEscudo(); 
          
        }
    }
}
