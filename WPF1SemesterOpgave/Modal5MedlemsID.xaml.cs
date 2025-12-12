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
    /// Interaction logic for Modal5MedlemsID.xaml
    /// </summary>
    public partial class Modal5MedlemsID : Window

    {
        private Medlem medlem; //privat accessor fordi jeg kun skal bruge det i denne class
        private Kursuslisten kursuslisten;

        //Parser valgt medlem fra listen, navngivet variablen valgtMedlem. Tilføjet så Tilmeld Kursus knappen fungerer
        public Modal5MedlemsID(Medlem valgtMedlem, Kursuslisten liste) 
        {
            InitializeComponent();

            medlem = valgtMedlem; //Gemmer i dette felt til senere brug
            kursuslisten = liste; 

            navnIndtastningsfelt.Text = medlem.Navn; //Henter Navnefeltet fra listen medlem
            adresseIndtastningsfelt.Text = medlem.Adresse; //Henter Adressefeltet fra listen medlem
            telefonIndtastningsfelt.Text = medlem.Telefonnummer; ////Henter Telefonnummerfeltet fra listen medlem
            mailndtastningsfelt.Text = medlem.Mailadresse; ////Henter Mailadressefeltet fra listen medlem

        }

        private void gemOgLukButton_Click(object sender, RoutedEventArgs e) //"Gem og Luk" knappen
        {
            medlem.Navn = navnIndtastningsfelt.Text; //Den tekstværdi, der er indtastet, sendes retur til medlemsobjektet
            medlem.Adresse = adresseIndtastningsfelt.Text; 
            medlem.Telefonnummer = telefonIndtastningsfelt.Text;
            medlem.Mailadresse = mailndtastningsfelt.Text;

            this.Close(); //Lukker vinduet

        }

        private void tilmeldKursusButton_Click(object sender, RoutedEventArgs e)
        {
            TilfoejMedlemTilKursus vindue3 = new TilfoejMedlemTilKursus(kursuslisten); //opret vindue3 til at tilføje medlem til et kursus
            vindue3.ShowDialog(); //Vis vinduet som dialog
        }
    }
}
