using System.Windows;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for ModalOpretKursus.xaml
    /// </summary>
    public partial class ModalOpretKursus : Window
    {
        // Her gemmer vi reference til kursuslisten,
        // så vi kan tilføje et nyt kursus direkte til den.
        private Kursuslisten kursuslisten;

        // Constructoren modtager en eksisterende kursusliste.
        public ModalOpretKursus(Kursuslisten liste)
        {
            InitializeComponent();  // Indlæser XAML'en.
            kursuslisten = liste;   // Gemmer listen til senere brug.
        }

        // Kører når der trykkes på "Gem og luk".
        private void GemOgLukButton_Click(object sender, RoutedEventArgs e)
        {
            // Opret et nyt kursus-objekt.
            Kursus nytKursus = new Kursus();

            // Læs værdier fra tekstfelterne.
            nytKursus.Titel = TitelInput.Text;
            nytKursus.Beskrivelse = BeskrivelseInput.Text;
            nytKursus.DeltagerAntal = DeltagerAntalInput.Text;

            // Tilføj det nye kursus til kursuslisten.
            kursuslisten.KursusListe.Add(nytKursus);

            // (Valgfrit) Vis en besked, så vi kan se at det virker.
            MessageBox.Show("Nyt kursus tilføjet: " + nytKursus.Titel);

            // Luk vinduet.
            this.Close();
        }
    }
}