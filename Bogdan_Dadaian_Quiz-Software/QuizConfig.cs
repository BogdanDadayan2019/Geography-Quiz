using System.IO;

public class QuizConfig
{
    // Art der Frage (z. B. Hauptstadt oder Flagge)
    public string Fragetyp { get; set; }

    // Gewählter Kontinent (z. B. Europa, Asien)
    public string Kontinent { get; set; }

    // Anzahl der Fragen im Quiz
    public int AnzahlFragen { get; set; }

    // Lädt die Konfiguration aus einer Datei
    public static QuizConfig LadeKonfiguration(string pfad)
    {
        QuizConfig config = new QuizConfig();
        foreach (var line in File.ReadAllLines(pfad))
        {
            var parts = line.Split('=');
            if (parts.Length != 2) continue;

            var key = parts[0].Trim().ToLower();
            var value = parts[1].Trim().ToLower();

            switch (key)
            {
                case "fragetyp":
                    config.Fragetyp = value;
                    break;
                case "kontinent":
                    config.Kontinent = value;
                    break;
                case "anzahl_fragen":
                    config.AnzahlFragen = int.Parse(value);
                    break;
            }
        }
        return config;
    }
}
