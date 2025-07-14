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
    public partial class RatingForm : Form
    {
        List<Spieler> spielerList = new List<Spieler>();
        Datenbank db = new Datenbank();

        public RatingForm(string name, bool condition)
        {
            // Wenn 'condition' true ist, wird die Liste aller Spieler nach Punkten sortiert angezeigt.
            if (condition == true)
            {
                InitializeComponent();

                spielerList = db.GetAlleSpieler();

                var sortierteListe = spielerList.OrderByDescending(s => s.Punkten).ToList();

                lbRating.Items.Clear();

                int position = 1;
                foreach (var item in sortierteListe)
                {
                    lbRating.Items.Add($"{position}. {item.ToString()}");
                    position++;
                }
            }
            // Wenn 'condition' false ist, werden die letzten Spiele des angegebenen Spielers angezeigt.
            else
            {
                InitializeComponent();

                List<SpielErgebnis> spiele = db.HoleLetzteSpieleVonSpieler(name);

                lbRating.Items.Clear();

                int nummer = 1;
                foreach (var spiel in spiele)
                {
                    string eintrag = $"{nummer}. {spiel.Punkte} Punkte am {spiel.Datum.ToString("yyyy-MM-dd HH:mm")}";
                    lbRating.Items.Add(eintrag);
                    nummer++;
                }
            }

        }

    }
}
