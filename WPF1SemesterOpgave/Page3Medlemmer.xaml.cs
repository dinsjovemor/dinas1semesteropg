using System.Windows;
using System.Windows.Controls;

namespace WPF1SemesterOpgave
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3Medlemmer : Page
    {
        private Medlemslisten medlemslisten;


        public Page3Medlemmer()

        {
            InitializeComponent();

            medlemslisten = new Medlemslisten(); //Laver en ny medlemslisten

        }

        private void medlem1Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[0]; //Tildeler index 0 til det første medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks

        }

        private void medlem2Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[1]; //Tildeler index 1 til det andet medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem3Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[2]; //Tildeler index 2 til det tredje medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem4Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[3]; //Tildeler index 3 til det fjerde medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem5Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[4]; //Tildeler index 4 til det femte medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem6Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[5]; //Tildeler index 5 til det sjette medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem7Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[6]; //Tildeler index 6 til det syvende medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }

        private void medlem8Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[7]; //Tildeler index 7 til det ottende medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks

        }

        private void medlem9Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[8]; //Tildeler index 7 til det niende medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks

        }

        private void medlem10Button_Click(object sender, RoutedEventArgs e)
        {
            Medlem valgtMedlem = medlemslisten.Medlemmer[9]; //Tildeler index 8 til det tiende medlem
            //Jeg opretter et editor vindue, og så parser jeg valgtmedlem der er valgt
            Modal5MedlemsID editor = new Modal5MedlemsID(valgtMedlem);

            editor.ShowDialog(); //Vis vindue som en dialogboks
        }
    }
}
