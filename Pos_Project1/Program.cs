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
            List<Person> personen = new List<Person>();
            Kunde k = new Kunde("kyr","meh","020120120012", "herr","askkaskaks",new List<Fahrzeug>());
            personen.Add(k);
            Personenverwaltung pv = new Personenverwaltung(personen);
            
            
            pv.readFahrzeuge();
            /* 
             1. Methode, die CSV ausliest und in LIST<Fahrzeug> speichert.
             2. Methode, die LIST<Fahrzeuge> mit LINQ als XML speichert.
             3. Methode "Angebote" in Personenverwaltung, die Interessen und Angebote vergleicht.
             */
        }
    }
}
