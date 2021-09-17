using System.Collections.Generic;
using System;
namespace Jugadores
{
    public class Jugador {
        public string Name { get; set;}
        public int Edad { get; set; }
        public bool Activo { get; set;}

        public List<Arma> Armas { get; set; }
        public List<Escudo> Escudos { get; set; }

        public Jugador(string Name, int Edad, List<Arma> Armas, List<Escudo> Escudos, bool Activo = false) {
            this.Name = Name;
            this.Edad = Edad;
            this.Activo = Activo;
            this.Armas = Armas;
            this.Escudos = Escudos;
        }
        public string IsActivo () {
            return Activo ? "Jugador Activo" : "Jugador necesita activar su cuenta";
        }


         public void readEscudo() {

            int escudoCount = 0;
            int escudoAmount = 0;

          Console.WriteLine("<Estado de Escudos>");

        for (int i1 = 0; i1 < Escudos.Count; i1++)
        {
          escudoCount = i1;
        }
        foreach (Escudo i2 in Escudos)
        {
          escudoAmount = i2.Amount;
          Console.WriteLine(i2.Name + " " + escudoAmount);
        }

     }
    }
    public class Arma {
        public string Name { get; set; }
        public int Balas { get; set; }

        public Arma( string Name, int Balas) {
            this.Name = Name;
            this.Balas = Balas;
        }
    }

    public class Escudo {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Escudo( string Name, int Amount) {
            this.Name = Name;
            this.Amount = Amount;
        }
    }
}