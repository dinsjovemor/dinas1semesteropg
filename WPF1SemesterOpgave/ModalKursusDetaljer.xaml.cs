using System.Windows;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for ModalKursusDetaljer.xaml
    /// </summary>
    public partial class ModalKursusDetaljer : Window
    {
        // Felt til at gemme reference til det valgte kursus.
        private Kursus kursus;

        // Constructoren modtager det kursus, vi vil vise.
        public ModalKursusDetaljer(Kursus valgtKursus)
        {
            InitializeComponent();   // Indlæser XAML-indholdet.

            kursus = valgtKursus;    // Gemmer kursus til senere brug.

            // Sæt tekstboksene til kursets værdier.
            TitelBox.Text = kursus.Titel;
            BeskrivelseBox.Text = kursus.Beskrivelse;
            DeltagerAntalBox.Text = kursus.DeltagerAntal;
            MaxAntalDeltagerBox.Text = kursus.MaxAntalDeltagere;
        }

        // Kører når der trykkes på "Luk" knappen.
        private void LukButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Lukker vinduet.
        }
    }
}