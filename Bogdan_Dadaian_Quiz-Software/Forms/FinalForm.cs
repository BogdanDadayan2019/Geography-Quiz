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
    public partial class FinalForm : Form
    {
        // Punktzahl des Spielers
        private int punkten;

        // Name des Spielers
        private string name;

        // Erhält Name und Punkte, zeigt sie an
        public FinalForm(string name, int punkten)
        {
            InitializeComponent();

            this.name = name;
            labelSpielerName.Text = name;
            lblPunkten.Text = punkten.ToString();
        }

        // Öffnet die allgemeine Bestenliste
        private void btnRating_Click(object sender, EventArgs e)
        {
            RatingForm ratingForm = new RatingForm(name, true);
            ratingForm.ShowDialog();
            return;
        }

        // Öffnet die persönliche Bewertung des Spielers
        private void btnPersönlichRaiting_Click(object sender, EventArgs e)
        {
            RatingForm ratingForm = new RatingForm(name, false);
            ratingForm.ShowDialog();
            return;
        }
    }
}
