namespace Bogdan_Dadaian_Quiz_Software
{
    public class Länder
    {
        // Name des Landes
        public string Name { get; set; }

        // Hauptstadt des Landes
        public string Hauptstadt { get; set; }

        // Pfad zum Bild der Flagge
        public string FlaggeWeg { get; set; }

        // Kontinent, zu dem das Land gehört
        public string Kontinent { get; set; }

        // Erstellt ein neues Land-Objekt
        public Länder(string name, string hauptstadt, string flaggeweg, string kontinent)
        {
            Name = name;
            Hauptstadt = hauptstadt;
            FlaggeWeg = flaggeweg;
            Kontinent = kontinent; 
        }
    }
}
