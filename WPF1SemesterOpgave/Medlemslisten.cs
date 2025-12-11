using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1SemesterOpgave
{
    public class Medlemslisten
    {
        public List<Medlem> Medlemmer; //Indeholder alle medlemmerne i en liste

        public Medlemslisten() //constructor
        {
            Medlemmer = new List<Medlem>(); //Opretter selve listen her

            Medlem m1 = new Medlem(); //Opretter et nyt medlem "m1"
            m1.Navn = "Medlem 1"; //Navngiver m1
            m1.Adresse = "Hovedgaden 1"; //Sætter adresse på m1
            m1.Telefonnummer = "10101010"; //Skriver tlf.nr. på m1
            m1.Mailadresse = "m1@daniadata.dk"; //Skriver mailadr. på m1
            Medlemmer.Add(m1); //Tilføjer "Medlem m1" til listen

            Medlem m2 = new Medlem(); //(Gentagelse medlem 1-10)
            m2.Navn = "Medlem 2";
            m2.Adresse = "Hovedgaden 2";
            m2.Telefonnummer = "20202020";
            m2.Mailadresse = "m2@daniadata.dk";
            Medlemmer.Add(m2);

            Medlem m3 = new Medlem(); //(Gentagelse medlem 1-10)
            m3.Navn = "Medlem 3";
            m3.Adresse = "Hovedgaden 3";
            m3.Telefonnummer = "30303030";
            m3.Mailadresse = "m3@daniadata.dk";
            Medlemmer.Add(m3);

            Medlem m4 = new Medlem(); //(Gentagelse medlem 1-10)
            m4.Navn = "Medlem 4";
            m4.Adresse = "Hovedgaden 4";
            m4.Telefonnummer = "40404040";
            m4.Mailadresse = "m4@daniadata.dk";
            Medlemmer.Add(m4);

            Medlem m5 = new Medlem(); //(Gentagelse medlem 1-10)
            m5.Navn = "Medlem 5";
            m5.Adresse = "Hovedgaden 5";
            m5.Telefonnummer = "50505050";
            m5.Mailadresse = "m5@daniadata.dk";
            Medlemmer.Add(m5);

            Medlem m6 = new Medlem(); //(Gentagelse medlem 1-10)
            m6.Navn = "Medlem 6";
            m6.Adresse = "Hovedgaden 6";
            m6.Telefonnummer = "60606060";
            m6.Mailadresse = "m6@daniadata.dk";
            Medlemmer.Add(m6);

            Medlem m7 = new Medlem(); //(Gentagelse medlem 1-10)
            m7.Navn = "Medlem 7";
            m7.Adresse = "Hovedgaden 7";
            m7.Telefonnummer = "70707070";
            m7.Mailadresse = "m7@daniadata.dk";
            Medlemmer.Add(m7);

            Medlem m8 = new Medlem(); //(Gentagelse medlem 1-10)
            m8.Navn = "Medlem 8";
            m8.Adresse = "Hovedgaden 8";
            m8.Telefonnummer = "80808080";
            m8.Mailadresse = "m8@daniadata.dk";
            Medlemmer.Add(m8);

            Medlem m9 = new Medlem(); //(Gentagelse medlem 1-10)
            m9.Navn = "Medlem 9";
            m9.Adresse = "Hovedgaden 9";
            m9.Telefonnummer = "90909090";
            m9.Mailadresse = "m9@daniadata.dk";
            Medlemmer.Add(m9);

            Medlem m10 = new Medlem(); //(Gentagelse medlem 1-10)
            m10.Navn = "Medlem 10";
            m10.Adresse = "Hovedgaden 10";
            m10.Telefonnummer = "10000000";
            m10.Mailadresse = "m10@daniadata.dk";
            Medlemmer.Add(m10);


        }


    }
}
