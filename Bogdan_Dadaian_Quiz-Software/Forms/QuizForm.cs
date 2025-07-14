using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    public partial class QuizForm : Form
    {
        private string Fragen;
        private string Antworte;
        private List<Länder> länders = new List<Länder>();
        private Datenbank db = new Datenbank();
        private int count = 0;
        private int punkten = 0;
        private bool hauptstädteländer = false;
        private bool länderhauptstädte = false;
        private bool hauptstädteflagge = false;
        private bool flaggehauptstädte = false;
        private bool länderflagge = false;
        private bool flaggeländer = false;
        private string richtigeAntwort;
        private int rundeCount;

        private string imgWeg_1;
        private string imgWeg_2;
        private string imgWeg_3;
        private string imgWeg_4;

        private string spielerName;
        private string selectedContinent;


        string hauptstadt = "Hauptstädt";
        string land = "Länder";
        string flagge = "Flagge";

        private System.Windows.Forms.Timer feedbackTimer;


        //  Initialisiert das Quiz mit Spielername, Frage-/Antworttyp, Kontinent und Rundenanzahl
        public QuizForm(string spielerName, string fragen, string antworte, string kontinent, int rundeCount)
        {
            InitializeComponent();
            this.spielerName = spielerName;
            this.Fragen = fragen;
            this.Antworte = antworte;
            this.selectedContinent = kontinent;
            this.rundeCount = rundeCount;

            labelFeedback.Text = "";

            // Timer zur Anzeige von Feedback (z.B. "Richtig" oder "Falsch")
            feedbackTimer = new System.Windows.Forms.Timer();
            feedbackTimer.Interval = 1500; 
            feedbackTimer.Tick += FeedbackTimer_Tick;

            // Auswahl der Spielart (z. B. Land → Hauptstadt)
            Spielauswahl();

            // Länder nach Kontinent filtern oder alle laden
            länders = selectedContinent.Equals("Weltweit", StringComparison.OrdinalIgnoreCase)
            ? db.GetAlleLaender()
            : db.GetLaenderByContinent(selectedContinent);

            // Liste der Länder zufällig mischen
            länders = länders.OrderBy(x => Guid.NewGuid()).ToList();

            QuizMain();
        }


        // Timer läuft ab – Feedback zurücksetzen und nächste Frage starten
        private void FeedbackTimer_Tick(object sender, EventArgs e)
        {
            feedbackTimer.Stop();
            labelFeedback.Text = "";
            btnBestaetigen.Enabled = true;
            btnUeberspringen.Enabled = true;
            QuizMain(); // Zur nächsten Frage wechseln
        }


        // Methode zur Festlegung der Quizart anhand der Auswahl
        public void Spielauswahl()
        {
            if (Fragen == hauptstadt && Antworte == land)
            {
                hauptstädteländer = true;
            }
            else if (Fragen == land && Antworte == hauptstadt)
            {
                länderhauptstädte = true;
            }
            else if (Fragen == hauptstadt && Antworte == flagge)
            {
                hauptstädteflagge = true;
            }
            else if (Fragen == flagge && Antworte == hauptstadt)
            {
                flaggehauptstädte = true;
            }
            else if (Fragen == land && Antworte == flagge)
            {
                länderflagge = true;
            }
            else if (Fragen == flagge && Antworte == land)
            {
                flaggeländer = true;
            }

        }

        // Haupt-Logik für die Anzeige der Fragen und möglichen Antworten
        private void QuizMain()
        {

            // Wenn alle Runden gespielt sind, wird das Ergebnis gespeichert und FinalForm geöffnet
            if (count >= rundeCount || count >= länders.Count)
            {
                db.SpielErgebnisHinzufuegen(spielerName, punkten);
                int _punkten = db.HolePunkteVonSpieler(spielerName);
                
                if(punkten > _punkten)
                {
                    db.PunkteAktualisieren(spielerName, punkten);
                }

                FinalForm finalForm = new FinalForm(spielerName, punkten);
                finalForm.ShowDialog();
                this.Close();
                return;
            }

            // Abhängig vom Spielmodus: Darstellung der Fragen und Antworten
            if (hauptstädteländer)
            {
                pbFlagge.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                // Zeigt Hauptstadt - Welches Land?
                labelFrage_1.Text = hauptstadt;
                labelFrage_2.Text = länders[count].Name;
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }
            else if (länderhauptstädte)
            {
                // Zeigt Land - Welche Hauptstadt?
                pbFlagge.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                labelFrage_1.Text = "Land";
                labelFrage_2.Text = länders[count].Hauptstadt;
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }else if (hauptstädteflagge)
            {
                // Zeigt Hauptstadtб - Welche Flagge?
                label5.Visible = false;
                label3.Text = "Welche Flagge hat";
                labelFrage_1.Text = "das Land mit \n\nder Hauptstadt";
                labelFrage_2.Text = länders[count].Hauptstadt;
                pbFlagge.Visible = false;
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }
            else if (flaggehauptstädte)
            {
                // Zeigt Flagge - Welche Hauptstadt?
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                labelFrage_1.Visible = false;
                labelFrage_2.Visible = false;
                pbFlagge.Image = Image.FromFile(länders[count].FlaggeWeg);
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }
            else if (länderflagge)
            {
                // Zeigt Land - Welche Flagge?
                labelFrage_1.Text = "Flagge";
                labelFrage_2.Text = länders[count].Name;
                pbFlagge.Visible = false;
                //pbFlagge.Image = Image.FromFile(länders[count].FlaggeWeg);
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }
            else if (flaggeländer)
            {
                // Zeigt Flagge - Welches Land?
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                labelFrage_1.Visible = false;
                labelFrage_2.Visible = false;
                pbFlagge.Image = Image.FromFile(länders[count].FlaggeWeg);
                labelFrageCount.Text = (count + 1).ToString();
                LadeAntworten();
            }

            if (hauptstädteflagge)
            {
                // Zeigt Hauptstadt - Welche Flagge?
                string richtig = länders[count].FlaggeWeg;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.FlaggeWeg != richtig)
                    .Select(l => l.FlaggeWeg)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);
                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                rbAntwort_1.Text = "";
                rbAntwort_2.Text = "";
                rbAntwort_3.Text = "";
                rbAntwort_4.Text = "";

                pictureBox1.Image = Image.FromFile(alleAntworten[0]);
                imgWeg_1 = alleAntworten[0];
                pictureBox2.Image = Image.FromFile(alleAntworten[1]);
                imgWeg_2 = alleAntworten[1];
                pictureBox3.Image = Image.FromFile(alleAntworten[2]);
                imgWeg_3 = alleAntworten[2];
                pictureBox4.Image = Image.FromFile(alleAntworten[3]);
                imgWeg_4 = alleAntworten[3];
            }

            if (flaggehauptstädte)
            {
                // Zeigt Flagge - Welche Hauptstadt?
                string richtig = länders[count].Hauptstadt;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.Hauptstadt != richtig)
                    .Select(l => l.Hauptstadt)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);
                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                rbAntwort_1.Text = alleAntworten[0];
                rbAntwort_2.Text = alleAntworten[1];
                rbAntwort_3.Text = alleAntworten[2];
                rbAntwort_4.Text = alleAntworten[3];
            }

        }

        private void LadeAntworten()
        {
            // Für Fragen Hauptstadt - Land
            // richtige Hauptstadt holen und 3 falsche zufällig auswählen

            if (hauptstädteländer)
            {
                string richtig = länders[count].Hauptstadt;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.Hauptstadt != richtig)
                    .Select(l => l.Hauptstadt)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);

                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                // Antworten in die RadioButtons einfügen
                rbAntwort_1.Text = alleAntworten[0];
                rbAntwort_2.Text = alleAntworten[1];
                rbAntwort_3.Text = alleAntworten[2];
                rbAntwort_4.Text = alleAntworten[3];
            }

            // Für Fragen Land - Hauptstadt 
            if (länderhauptstädte)
            {
                string richtig = länders[count].Name;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.Name != richtig)
                    .Select(l => l.Name)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);

                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                rbAntwort_1.Text = alleAntworten[0];
                rbAntwort_2.Text = alleAntworten[1];
                rbAntwort_3.Text = alleAntworten[2];
                rbAntwort_4.Text = alleAntworten[3];
            }

            // Für Fragen Land - Flagge
            if (länderflagge)
            {
                string richtig = länders[count].FlaggeWeg;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.FlaggeWeg != richtig)
                    .Select(l => l.FlaggeWeg)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);

                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                rbAntwort_1.Text = "";
                rbAntwort_2.Text = "";
                rbAntwort_3.Text = "";
                rbAntwort_4.Text = "";

                pictureBox1.Image = Image.FromFile(alleAntworten[0]);
                imgWeg_1 = alleAntworten[0];
                pictureBox2.Image = Image.FromFile(alleAntworten[1]);
                imgWeg_2 = alleAntworten[1];
                pictureBox3.Image = Image.FromFile(alleAntworten[2]);
                imgWeg_3 = alleAntworten[2];
                pictureBox4.Image = Image.FromFile(alleAntworten[3]);
                imgWeg_4 = alleAntworten[3];
            }

            // Für Fragen Flagge - Land
            if (flaggeländer)
            {
                string richtig = länders[count].Name;

                Random rand = new Random();
                var falsch = länders
                    .Where(l => l.Name != richtig)
                    .Select(l => l.Name)
                    .Distinct()
                    .OrderBy(_ => rand.Next())
                    .Take(3)
                    .ToList();

                falsch.Add(richtig);

                var alleAntworten = falsch.OrderBy(_ => rand.Next()).ToList();

                rbAntwort_1.Text = alleAntworten[0];
                rbAntwort_2.Text = alleAntworten[1];
                rbAntwort_3.Text = alleAntworten[2];
                rbAntwort_4.Text = alleAntworten[3];
            }

            rbAntwort_1.Checked = false;
            rbAntwort_2.Checked = false;
            rbAntwort_3.Checked = false;
            rbAntwort_4.Checked = false;
        }

        // Verarbeitet, ob eine Antwort korrekt ist
        private void btnBestaetigen_Click(object sender, EventArgs e)
        {

            string gewaehlteAntwort = null;

            // Bestimme die ausgewählte Antwort
            if (rbAntwort_1.Checked) gewaehlteAntwort = rbAntwort_1.Text;
            if (rbAntwort_2.Checked) gewaehlteAntwort = rbAntwort_2.Text;
            if (rbAntwort_3.Checked) gewaehlteAntwort = rbAntwort_3.Text;
            if (rbAntwort_4.Checked) gewaehlteAntwort = rbAntwort_4.Text;

            if (länderflagge) 
            {
                if (rbAntwort_1.Checked) gewaehlteAntwort = imgWeg_1;
                if (rbAntwort_2.Checked) gewaehlteAntwort = imgWeg_2;
                if (rbAntwort_3.Checked) gewaehlteAntwort = imgWeg_3;
                if (rbAntwort_4.Checked) gewaehlteAntwort = imgWeg_4;
            }

            if (gewaehlteAntwort == null)
            {
                MessageBox.Show("Bitte wähle eine Antwort aus!");
                return;
            }

            // Bestimme die richtige Antwort
            if (hauptstädteländer)
            {
                richtigeAntwort = länders[count].Hauptstadt;
            }

            if (länderhauptstädte)
            {
                richtigeAntwort = länders[count].Name;
            }

            if (länderflagge)
            {
                richtigeAntwort = länders[count].FlaggeWeg;
            }

            if (flaggeländer)
            {
                richtigeAntwort = länders[count].Name;                   
            }

            if (hauptstädteflagge)
            {
                if (rbAntwort_1.Checked) gewaehlteAntwort = imgWeg_1;
                if (rbAntwort_2.Checked) gewaehlteAntwort = imgWeg_2;
                if (rbAntwort_3.Checked) gewaehlteAntwort = imgWeg_3;
                if (rbAntwort_4.Checked) gewaehlteAntwort = imgWeg_4;
            }

            if (flaggehauptstädte)
            {
                richtigeAntwort = länders[count].Hauptstadt;
            }

            if (hauptstädteflagge)
            {
                richtigeAntwort = länders[count].FlaggeWeg;
            }

            // Bestimme die richtige Antwort
            if (gewaehlteAntwort == richtigeAntwort)
            {
                labelFeedback.ForeColor = Color.Green;
                labelFeedback.Text = "Richtig";
                punkten++;
            }
            else
            {
                labelFeedback.ForeColor = Color.Red;
                labelFeedback.Text = "Falsch";
            }

            btnBestaetigen.Enabled = false;
            btnUeberspringen.Enabled = false;

            count++;

            feedbackTimer.Start(); 


        }

        // Wenn man die Frage überspringt
        private void btnUeberspringen_Click(object sender, EventArgs e)
        {
            btnBestaetigen.Enabled = false;
            btnUeberspringen.Enabled = false;
            count++;
            labelFeedback.ForeColor = Color.Gray;
            labelFeedback.Text = "Übersprungen";
            feedbackTimer.Start(); 
        }

        // Wenn das Quiz-Fenster geschlossen wird
        private void QuizForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Alles zurücksetzen für neues Spiel
            count = 0;
            punkten = 0;
            hauptstädteländer = false;
            länderhauptstädte = false;
            hauptstädteflagge = false;
            flaggehauptstädte = false;
            länderflagge = false;
            flaggeländer = false;
        }

    }

}