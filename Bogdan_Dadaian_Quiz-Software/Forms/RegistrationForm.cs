using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogdan_Dadaian_Quiz_Software.Forms;


namespace Bogdan_Dadaian_Quiz_Software
{
    public partial class RegistrationForm : Form
    {
        Datenbank db = new Datenbank();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Methode, die beim Klick auf den Registrieren-Button ausgeführt wird
        private void btnRegistaration_Click(object sender, EventArgs e)
        {
            string name = tbRegistration.Text;
            if(name != null)
            {
                Spieler spieler = new Spieler(name);

                // Prüfen, ob Spieler mit diesem Namen schon existiert
                if (db.SpielerUberpruefen(name) == null)
                {
                    db.SpielerRegister(spieler); // Spieler in der Datenbank speichern
                    MessageBox.Show($"Spieler mit dem Namen {spieler.Name} wurde erfolgreich registriert!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ein Spieler mit diesem Namen ist bereits registriert. Bitte versuchen Sie es erneut.");
                }
                             
            }
        }

        // Methode, die beim Klick auf den Abbrechen-Button ausgeführt wird
        private void btnAbbrechenRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
