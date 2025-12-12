using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4Kurser : Page
    {
        private Kursuslisten kursuslisten;

        public Page4Kurser()
        {
            InitializeComponent();
            kursuslisten = new Kursuslisten();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tilføjKursusButton_Click(object sender, RoutedEventArgs e)
        {
            ModalOpretKursus opretVindue = new ModalOpretKursus(kursuslisten);

            opretVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[0]; //Tildeler index 0 til det første kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue= new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[1]; //Tildeler index 1 til det andet kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue = new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[2]; //Tildeler index 2 til det tredje kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue = new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[3]; //Tildeler index 3 til det fjerde kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue = new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[4]; //Tildeler index 4 til det femte kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue = new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Kursus valgtKursus = kursuslisten.KursusListe[5]; //Tildeler index 5 til det sjette kursus
            //Jeg opretter et editor vindue, og så parser jeg valgtkursus der er valgt
            ModalKursusDetaljer detaljeVindue = new ModalKursusDetaljer(valgtKursus);

            detaljeVindue.ShowDialog(); //Vis vindue som en dialogboks
        }
    }
}
