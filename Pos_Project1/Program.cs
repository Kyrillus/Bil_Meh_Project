using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pos_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personen = new List<Person>();
            Verwaltung pv = new Verwaltung(personen);
            //Abfrage1();
            //Abfrage2();
            //Abfrage3();
            //Abfrage4();
            Abfrage6();

            //pv.readFahrzeuge();




        }

        public static void Abfrage1() // Der Kunde will ein Auto das mehr als 200PS hat und Unbeschädigt ist.
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg1 = from x in xe.Descendants("Wagen")
                       where Convert.ToInt32(x.Element("PS").Value) >= 200 && x.Element("Schaden").Value.Equals("nein")
                       select x;
            foreach (var item in erg1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

        public static void Abfrage2() // Der Kunde will alle Hersteller herausfinden
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg2 = from x in xe.DescendantsAndSelf("Fahrzeug")
                       select x.Attribute("Hersteller");
            foreach (var item in erg2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void Abfrage3() // Der Kunde will ein citroen der mehr als 230PS hat und weniger als 20000€ kosten.
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg3 = from x in xe.DescendantsAndSelf("Fahrzeug")
                       where x.Attribute("Hersteller").Value.Equals("citroen")
                       from y in x.Descendants("Wagen")
                       where Convert.ToInt32(y.Element("PS").Value) > 100 && Convert.ToInt32(y.Element("Preis").Value) < 20000
                       select y;
            foreach (var item in erg3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        public static void Abfrage4() // Der Kunde will den teuersten Golf haben
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg4 = (from x in xe.Descendants("Wagen")
                        where x.Attribute("Modell").Value.Equals("golf")
                        select x).Max(x => Convert.ToInt32(x.Element("Preis").Value));
            var erg5 = (from x in xe.Descendants("Wagen")
                        where x.Attribute("Modell").Value.Equals("golf") && Convert.ToInt32(x.Element("Preis").Value) == erg4
                        select x);

            foreach (var item in erg5)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void Abfrage5() // Der Kunde will ein Fahrzeug, dass unter 10.000 euro ist, ein manuelles Getriebe hat, keinen Schaden hat und über 120 PS besitzt
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg6 = (from x in xe.Descendants("Wagen")
                        where Convert.ToInt32(x.Element("Preis").Value) < 10000 && x.Element("Getriebe").Value == "manuell" && x.Element("Schaden").Value == "nein" && Convert.ToInt32(x.Element("PS").Value) > 120
                        select x);
            foreach (var item in erg6)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
        public static void Abfrage6()// Der Kunde will einen Audi a3
        {
            var xe = XElement.Load("../../Fahrzeuge.xml");
            var erg6 = (from x in xe.Descendants("Wagen")
                        where x.Attribute("Modell").Value.Contains("a3")
                        select x);
            foreach (var item in erg6)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}