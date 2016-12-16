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
            Person p = new Person("Kyril","Mehanni","20130120302103","Herr","cockstraße 2132113");
            personen.Add(p);
            Personenverwaltung pv = new Personenverwaltung(personen);
            /* 
             1. Methode, die CSV ausliest und in LIST<Fahrzeug> speichert.
             2. Methode, die LIST<Fahrzeuge> mit LINQ als XML speichert.
             3. Methode "Angebote" in Personenverwaltung, die Interessen und Angebote vergleicht.
             */
        }
    }
}
