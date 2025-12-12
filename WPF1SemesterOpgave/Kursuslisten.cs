using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1SemesterOpgave
{
    public class Kursuslisten
    {
        public List<Kursus> KursusListe; //Indeholder alle kurserne i en liste

        public Kursuslisten() //constructor
        {
            KursusListe = new List<Kursus>(); //Opretter selve listen her

            Kursus k1 = new Kursus(); //Opretter et nyt kursus "k1"
            k1.Titel = "Basis Git-kursus"; //Navngiver k1
            k1.Beskrivelse = "Kurset er fedt"; //Sætter beskrivelsen
            k1.DeltagerAntal = "10"; //Skriver deltagerantal
            k1.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k1); //Tilføjer "Kursus k1" til listen


            Kursus k2 = new Kursus(); //Opretter et nyt kursus "k2"
            k2.Titel = "Basis Visual Studio-kursus"; //Navngiver k2
            k2.Beskrivelse = "Kurset er et must-have"; //Sætter beskrivelsen
            k2.DeltagerAntal = "1"; //Skriver deltagerantal
            k2.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k2); //Tilføjer "Kursus k2" til listen

            Kursus k3 = new Kursus(); //Opretter et nyt kursus "k3"
            k3.Titel = "Front-End HTML-kursus"; //Navngiver k2
            k3.Beskrivelse = "Kurset er til dem der vil foran"; //Sætter beskrivelsen
            k3.DeltagerAntal = "0"; //Skriver deltagerantal
            k3.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k3); //Tilføjer "Kursus k2" til listen

            Kursus k4 = new Kursus(); //Opretter et nyt kursus "k4"
            k4.Titel = "Front-End CSS-kursus"; //Navngiver k4
            k4.Beskrivelse = "Det ender ikke her, faktisk begynder det med dette kursus"; //Sætter beskrivelsen
            k4.DeltagerAntal = "4"; //Skriver deltagerantal
            k4.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k4); //Tilføjer "Kursus k4" til listen

            Kursus k5 = new Kursus(); //Opretter et nyt kursus "k5"
            k5.Titel = "Back-End Node-kursus"; //Navngiver k5
            k5.Beskrivelse = "Det her kursus kommer til at komme bag på dig"; //Sætter beskrivelsen
            k5.DeltagerAntal = "3"; //Skriver deltagerantal
            k5.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k5); //Tilføjer "Kursus k5" til listen

            Kursus k6 = new Kursus(); //Opretter et nyt kursus "k6"
            k6.Titel = "Back-End Django-kursus"; //Navngiver k6
            k6.Beskrivelse = "Unchain my heart med dette kursus"; //Sætter beskrivelsen
            k6.DeltagerAntal = "2"; //Skriver deltagerantal
            k6.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k6); //Tilføjer "Kursus k6" til listen

        }
    }
}
