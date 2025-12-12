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
using System.Windows.Shapes;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for TilføjMedlemTilKursus.xaml
    /// </summary>
    public partial class TilfoejMedlemTilKursus : Window
    {
        private Kursuslisten kursuslisten;

        public TilfoejMedlemTilKursus(Kursuslisten liste2) 
        {
            InitializeComponent();
            kursuslisten = liste2; //Gemmer reference til kursuslisten

            KursusButton1.Content = kursuslisten.KursusListe[0].Titel; //Jeg viser (kun) Titel i kursusknappen
            KursusButton2.Content = kursuslisten.KursusListe[1].Titel;
            KursusButton3.Content = kursuslisten.KursusListe[2].Titel;
            KursusButton4.Content = kursuslisten.KursusListe[3].Titel;
            KursusButton5.Content = kursuslisten.KursusListe[4].Titel;
            KursusButton6.Content = kursuslisten.KursusListe[5].Titel;

        }
        private void TilmeldTilKursusMedIndex(int index)
        {
            Kursus kursus = kursuslisten.KursusListe[index]; //Sætter hvilket indexnummer der tilknyttes kurset
            int currentAntal = int.Parse(kursus.DeltagerAntal); //Konverter / parser string om til int
            int maxAntalDelt = int.Parse(kursus.MaxAntalDeltagere);
            //Nu kan jeg sammenligne deltagerantal med max deltagerantal, som var i string, nu er de i int

            if (currentAntal>=maxAntalDelt)
            {
                MessageBox.Show("Kurset er fyldt op..");
            }
            else
            {
                currentAntal = currentAntal + 1; //Jeg sætter den til at tilføje et medlem til deltagerantal, når kurset ikke er fyldt op
                kursus.DeltagerAntal = currentAntal.ToString(); //Sætter den tilbage til en string
                MessageBox.Show("Tilmeldingen er gennemført");
            }


            this.Close(); //Lukker vinduet
        }

        private void KursusButton1_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(0); //funktion så jeg bruger ()
        }

        private void KursusButton2_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(1); //funktion så jeg bruger ()
        }

        private void KursusButton3_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(2); //funktion så jeg bruger ()
        }

        private void KursusButton4_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(3); //funktion så jeg bruger ()
        }

        private void KursusButton5_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(4); //funktion så jeg bruger ()
        }

        private void KursusButton6_Click(object sender, RoutedEventArgs e)
        {
            TilmeldTilKursusMedIndex(5); //funktion så jeg bruger ()
        }
    }
}
