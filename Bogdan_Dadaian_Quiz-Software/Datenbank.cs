using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan_Dadaian_Quiz_Software
{

    public class Datenbank
    {
        private readonly string connstr = "SERVER=localhost;UID='root';PASSWORD='';DATABASE=quiz";

        // Prüft, ob ein Spieler mit diesem Namen existiert
        public Spieler SpielerUberpruefen(string name)
        {
            Spieler sp = null;

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "SELECT name FROM spieler WHERE name = @name";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sp = new Spieler(reader.GetString("name"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return sp;
        }

        // Holt alle Länder aus der Datenbank
        public List<Länder> GetAlleLaender()
        {
            List<Länder> laenderListe = new List<Länder>();

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "SELECT * FROM laender";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string flaggeImgWeg = reader.IsDBNull(reader.GetOrdinal("flagge_img_weg"))
                                    ? null : reader.GetString("flagge_img_weg");

                                string kontinent = reader.IsDBNull(reader.GetOrdinal("kontinent"))
                                    ? null : reader.GetString("kontinent");

                                Länder land = new Länder(
                                    reader.GetString("name"),
                                    reader.GetString("hauptstadt"),
                                    flaggeImgWeg,
                                    kontinent  
                                );

                                laenderListe.Add(land);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return laenderListe;
        }

        // Registriert einen neuen Spieler in der Datenbank
        public void SpielerRegister(Spieler spieler)
        {
            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "INSERT INTO spieler (name) VALUES (@name)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", spieler.Name);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Aktualisiert die maximale Punktzahl eines Spielers
        public void PunkteAktualisieren(string name, int punkte)
        {
            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "UPDATE spieler SET punkten_max = @punkte WHERE name = @name";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@punkte", punkte);
                        cmd.Parameters.AddWithValue("@name", name);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Holt alle Spieler mit ihren Punkten
        public List<Spieler> GetAlleSpieler()
        {
            List<Spieler> spielerListe = new List<Spieler>();

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "SELECT name, punkten_max FROM spieler";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Spieler sp = new Spieler(reader.GetString("name"))
                                {
                                    Punkten = reader.IsDBNull(reader.GetOrdinal("punkten_max")) ? 0 : reader.GetInt32("punkten_max")
                                };
                                spielerListe.Add(sp);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return spielerListe;
        }

        // Holt die Punkte eines bestimmten Spielers
        public int HolePunkteVonSpieler(string name)
        {
            int punkte = 0;

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "SELECT punkten_max FROM spieler WHERE name = @name";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                punkte = reader.IsDBNull(reader.GetOrdinal("punkten_max"))
                                    ? 0 : reader.GetInt32("punkten_max");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return punkte;
        }


        // Fügt ein neues Spielergebnis hinzu
        public void SpielErgebnisHinzufuegen(string spielerName, int punkte)
        {
            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "INSERT INTO spiel_ergebnisse (spieler_name, punkte, datum) VALUES (@name, @punkte, NOW())";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", spielerName);
                        cmd.Parameters.AddWithValue("@punkte", punkte);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        // Holt die letzten Spielergebnisse eines Spielers
        public List<SpielErgebnis> HoleLetzteSpieleVonSpieler(string name)
        {
            List<SpielErgebnis> ergebnisse = new List<SpielErgebnis>();

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                try
                {
                    string query = "SELECT punkte, datum FROM spiel_ergebnisse WHERE spieler_name = @name ORDER BY datum DESC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int punkte = reader.GetInt32("punkte");
                                DateTime datum = reader.GetDateTime("datum");

                                SpielErgebnis ergebnis = new SpielErgebnis(punkte, datum);
                                ergebnisse.Add(ergebnis);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return ergebnisse;
        }

        // Füllt die ComboBox mit allen Kontinenten
        public void FillComboBoxWithContinents(ComboBox comboBox)
        {
            List<string> continents = new List<string>();

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                string query = "SELECT DISTINCT kontinent FROM laender ORDER BY kontinent";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                continents.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }

            comboBox.Items.Clear();

          
            comboBox.Items.Add("Weltweit");

            comboBox.Items.AddRange(continents.ToArray());

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0; 
            }


        }

        // Holt alle Länder eines bestimmten Kontinents
        public List<Länder> GetLaenderByContinent(string continent)
        {
            List<Länder> laenderList = new List<Länder>();

            using (var conn = new MySqlConnection(connstr))
            {
                conn.Open();
                string query = "SELECT name, hauptstadt, flagge_img_weg, kontinent AS Kontinent FROM laender WHERE kontinent = @kontinent";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kontinent", continent);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            laenderList.Add(new Länder(
                            reader.GetString("name"),
                            reader.GetString("hauptstadt"),
                            reader.GetString("flagge_img_weg"),
                            reader.GetString("kontinent")
                            ));

                        }
                    }
                }
            }

            return laenderList;
        }

    }
}
