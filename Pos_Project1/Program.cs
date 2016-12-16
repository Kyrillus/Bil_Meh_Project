using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lp = new List<Person>();
            Kunde p1 = new Kunde(1,"dawdwa", "nahfckwjnfkw", "+93786213873621", "asdfljas", "cook :D", new List<Fahrzeug>());
            Kunde p2= new Kunde(1, "dawdwa", "nahfckwjnfkw", "+93786213873621", "asdfljas", "cook :D", new List<Fahrzeug>());
            Kunde p3= new Kunde(1, "dawdwa", "nahfckwjnfkw", "+93786213873621", "asdfljas", "cook :D", new List<Fahrzeug>());
            Kunde p4 = new Kunde(1, "dawdwa", "nahfckwjnfkw", "+93786213873621", "asdfljas", "cook :D", new List<Fahrzeug>());
            lp.Add(p1);
            lp.Add(p2);
            lp.Add(p3);
            lp.Add(p4);
            Personenverwaltung pv = new Personenverwaltung();
            /* 
             1. Methode, die CSV ausliest und in LIST<Fahrzeug> speichert.
             2. Methode, die LIST<Fahrzeuge> mit LINQ als XML speichert.
             3. Methode "Angebote" in Personenverwaltung, die Interessen und Angebote vergleicht.
             */
        }
    }
}
