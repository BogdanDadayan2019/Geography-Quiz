using Bogdan_Dadaian_Quiz_Software.Forms;

namespace Bogdan_Dadaian_Quiz_Software
{
    public partial class LoginForm : Form
    {
        // Verbindung zur Datenbank
        Datenbank db = new Datenbank();
        public LoginForm()
        {
            InitializeComponent();
        }

        // Öffnet das Registrierungsform
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        // Prüft den Spielernamen und öffnet das Startform
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string spielerName = tbLogin.Text;
            if(spielerName != null)
            {
                if (db.SpielerUberpruefen(spielerName) != null)
                {
                    StartForm startForm = new StartForm(spielerName);
                    this.Hide();
                    startForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Spieler nicht gefunden. Bitte versuchen Sie es erneut.");
                }
            }
            
        }
    }
}
