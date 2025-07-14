using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan_Dadaian_Quiz_Software
{
    public class SpielErgebnis
    {
        // Erreichte Punkte im Spiel
        public int Punkte { get; set; }
        // Datum des Spiels
        public DateTime Datum { get; set; }

        // Erstellt ein neues Spielergebnis
        public SpielErgebnis(int punkte, DateTime datum)
        {
            Punkte = punkte;
            Datum = datum;
        }
    }

}
