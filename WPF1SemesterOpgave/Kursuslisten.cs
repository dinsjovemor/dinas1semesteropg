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
            k3.Beskrivelse = "Kurset er et must-have"; //Sætter beskrivelsen
            k3.DeltagerAntal = "1"; //Skriver deltagerantal
            k3.MaxAntalDeltagere = "10"; //Skriver max antal her
            KursusListe.Add(k3); //Tilføjer "Kursus k2" til listen

        }
    }
}
