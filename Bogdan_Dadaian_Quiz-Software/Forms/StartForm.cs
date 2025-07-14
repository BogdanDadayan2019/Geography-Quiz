using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogdan_Dadaian_Quiz_Software.Forms
{
    public partial class StartForm : Form
    {
        string spielerName;
        int rundeCount = 10; 

        Datenbank db = new Datenbank();
        public StartForm(string spielerName)
        {
            this.spielerName = spielerName;

            InitializeComponent();

            db.FillComboBoxWithContinents(cbContinenten);
        }

        // Wird aufgerufen, wenn der Bestätigen-Button geklickt wird
        private void btnBestaetigen_Click(object sender, EventArgs e)
        {
            RadioButton selectedFrage = null;
            RadioButton selectedAntwort = null;

            // Überprüfen, welcher Frage-Radiobutton ausgewählt ist
            if (rbFragenLaender.Checked)
            {
                selectedFrage = rbFragenLaender;
            }
            else if (rbFragenFlagge.Checked)
            {
                selectedFrage = rbFragenFlagge;
            }
            else if (rgFragenHauptstaedt.Checked)
            {
                selectedFrage = rgFragenHauptstaedt;
            }

            // Überprüfen, welcher Antwort-Radiobutton ausgewählt ist
            if (rbAntwortenLaender.Checked)
            {
                selectedAntwort = rbAntwortenLaender;
            }
            else if (rbAntwortenFlagge.Checked)
            {
                selectedAntwort = rbAntwortenFlagge;
            }
            else if (rbAntwortenHauptstaedt.Checked)
            {
                selectedAntwort = rbAntwortenHauptstaedt;
            }

            // Prüfen, ob beide Gruppen eine Auswahl haben
            if (selectedFrage == null || selectedAntwort == null)
            {
                MessageBox.Show("Bitte wählen Sie jeweils eine Option aus jeder Gruppe aus!");
                return; // Funktion abbrechen, wenn Auswahl fehlt
            }

            MessageBox.Show($"Sie haben ausgewählt:\nFrage: {selectedFrage.Text}\nAntwort: {selectedAntwort.Text}");

            // Zum Quiz-Formular wechseln mit den gewählten Einstellungen
            QuizStarten(spielerName, selectedFrage.Text, selectedAntwort.Text, cbContinenten.Text, rundeCount);

        }

        // Methode zum Öffnen des Quiz-Formulars
        private void QuizStarten(string spielerName, string selectedFrage, string selectedAntwort, string cbContinenten, int rundeCount)
        {
            this.Hide(); 
            using (QuizForm quiz = new QuizForm(spielerName, selectedFrage, selectedAntwort, cbContinenten, rundeCount))
            {
                quiz.ShowDialog();  // QuizForm als modales Fenster zeigen
            }
            this.Show(); 
        }


        // Ereignis, wenn sich eine Frage-Radiobutton-Auswahl ändert
        private void FragenRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (rbFragenLaender.Checked)
            {
                rbAntwortenLaender.Checked = false;
            }
            else if (rbFragenFlagge.Checked)
            {
                rbAntwortenFlagge.Checked = false;
            }
            else if (rgFragenHauptstaedt.Checked)
            {
                rbAntwortenHauptstaedt.Checked = false;
            }
        }

        // Ereignis, wenn sich eine Antwort-Radiobutton-Auswahl ändert
        private void AntwortenRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAntwortenLaender.Checked)
            {
                rbFragenLaender.Checked = false;
            }
            else if (rbAntwortenFlagge.Checked)
            {
                rbFragenFlagge.Checked = false;
            }
            else if (rbAntwortenHauptstaedt.Checked)
            {
                rgFragenHauptstaedt.Checked = false;
            }
        }

        // Button zum Laden der Einstellungen aus einer INI-Datei
        private void btnQuizIni_Click(object sender, EventArgs e)
        {
            string pfad = "quiz.ini";
            QuizConfig quizConfig = QuizConfig.LadeKonfiguration(pfad);


            int _rundeCount = quizConfig.AnzahlFragen;
            string kontinent = quizConfig.Kontinent;
            if (quizConfig.Fragetyp == "hauptstadt_zu_land")
            {
                rgFragenHauptstaedt.Checked = true;
                rbAntwortenLaender.Checked = true;
                QuizStarten(spielerName, rgFragenHauptstaedt.Text, rbAntwortenLaender.Text, kontinent, _rundeCount);
                return;
            }
            else if (quizConfig.Fragetyp == "land_zu_hauptstadt")
            {
                rbFragenLaender.Checked = true;
                rbAntwortenHauptstaedt.Checked = true;
                QuizStarten(spielerName, rbFragenLaender.Text, rbAntwortenHauptstaedt.Text, kontinent, _rundeCount);
                return;
            }
            else if (quizConfig.Fragetyp == "hauptstadt_zu_flagge")
            {
                rgFragenHauptstaedt.Checked = true;
                rbAntwortenFlagge.Checked = true;
                QuizStarten(spielerName, rgFragenHauptstaedt.Text, rbAntwortenFlagge.Text, kontinent, _rundeCount);
                return;
            }
            else if (quizConfig.Fragetyp == "flagge_zu_hauptstadt")
            {
                rbFragenFlagge.Checked = true;
                rbAntwortenHauptstaedt.Checked = true;
                QuizStarten(spielerName, rbFragenFlagge.Text, rbAntwortenHauptstaedt.Text, kontinent, _rundeCount);
                return;
            }
            else if (quizConfig.Fragetyp == "land_zu_flagge")
            {
                rbFragenLaender.Checked = true;
                rbAntwortenFlagge.Checked = true;
                QuizStarten(spielerName, rbFragenLaender.Text, rbAntwortenFlagge.Text, kontinent, _rundeCount);
                return;
            }
            else if (quizConfig.Fragetyp == "flagge_zu_land")
            {
                rbFragenFlagge.Checked = true;
                rbAntwortenLaender.Checked = true;
                QuizStarten(spielerName, rbFragenFlagge.Text, rbAntwortenLaender.Text, kontinent, _rundeCount);
                return;
            }
        }
    }
}
