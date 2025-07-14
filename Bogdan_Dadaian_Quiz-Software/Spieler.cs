using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan_Dadaian_Quiz_Software
{
    public class Spieler
    {

        // Name des Spielers
        public string Name { get; set; }

        // Punkte des Spielers
        public int Punkten { get; set; }

        // Erstellt einen Spieler mit Namen
        public Spieler(string name)
        {
            Name = name;
        }

        // Gibt den Spieler als Text zurück
        public override string ToString()
        {
            return $"{Name} - {Punkten} Punkte";
        }
    }
}
