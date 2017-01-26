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
            Kunde k = new Kunde("kyr","mehzz","020120120012", "herr","askkaskaks",new List<Fahrzeuge>());
            personen.Add(k);
            Verwaltung pv = new Verwaltung(personen);
            foreach (var item in pv.Angebote)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            
            
            pv.readFahrzeuge();
            /* 
             1. Methode, die CSV ausliest und in LIST<Fahrzeug> speichert.
             2. Methode, die LIST<Fahrzeuge> mit LINQ als XML speichert.
             3. Methode "Angebote" in Personenverwaltung, die Interessen und Angebote vergleicht.
             */
        }
    }
}
