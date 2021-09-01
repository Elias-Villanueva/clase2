using System;
using Jugadores;

namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
           Jugador jug1 = new Jugador("Elesito", 21, true);
           Jugador jug2 = new Jugador("Efesito", 28);
           Jugador jug3 = new Jugador("Enanito", 30, true);

           Console.WriteLine(jug2.IsActivo());
        }
    }
}
