
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pos_Project1
{
    class Verwaltung
    {
        private List<Person> personen;
        private List<Fahrzeuge> fahrzeuge = new List<Fahrzeuge>();

        internal List<Person> Personen
        {
            get
            {
                return personen;
            }

            set
            {
                personen = value;
            }
        }

        internal List<Fahrzeuge> Fahrzeuge
        {
            get
            {
                return fahrzeuge;
            }

            set
            {
                fahrzeuge = value;
            }
        }

        public Verwaltung(List<Person> personen)
        {
            Personen = personen;
            readFahrzeuge();
            ;
        }
        public void readFahrzeuge()
        {
            StreamReader reader = new StreamReader(File.OpenRead("../../Fahrzeug.csv"));
            string line;

            int l = 0;
            while (l != 1000 && (line = reader.ReadLine()) != null)
            {

                Fahrzeuge fz = null;
                String[] arr = line.Split(',');
                DateTime dat = DateTime.ParseExact(arr[0], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                String name = arr[1];
                String seller = arr[2];
                String offerType = arr[3];
                int price = arr[4] == "" ? 0 : Convert.ToInt32(arr[4]);
                String abtest = arr[5];
                String vehicleType = arr[6];
                int yearOfReg = arr[7] == "" ? 0 : Convert.ToInt32(arr[7]);
                String gearBox = arr[8];
                int power = arr[9] == "" ? 0 : Convert.ToInt32(arr[9]);
                String model = arr[10];
                int kilometer = arr[11] == "" ? 0 : Convert.ToInt32(arr[11]);
                int monthOfReg = arr[12] == "" ? 0 : Convert.ToInt32(arr[12]);
                String fuelType = arr[13];
                String brand = arr[14];
                String notRepairedDamage = arr[15];
                DateTime dateCreated = DateTime.ParseExact(arr[16], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                int nrOfPictures = arr[17] == "" ? 0 : Convert.ToInt32(arr[17]);
                int postalCode = arr[18] == "" ? 0 : Convert.ToInt32(arr[18]);
                DateTime lastSeen = DateTime.ParseExact(arr[19], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                fz = new Fahrzeuge(dat, name, seller, offerType, price, abtest, vehicleType, yearOfReg, gearBox, power, model, kilometer, monthOfReg, fuelType, brand, notRepairedDamage, dateCreated, nrOfPictures, postalCode, lastSeen);

                Fahrzeuge.Add(fz);
                l++;
            }
            //dateCrawled,name,seller,offerType,price,abtest,vehicleType,yearOfRegistration,gearbox,powerPS,model,kilometer,monthOfRegistration,fuelType,brand,notRepairedDamage,dateCreated,nrOfPictures,postalCode,lastSeen

            /* // Kreariert die Fahrzeuge.xml -> Wird nur einmal ausgeführt
            var erg = new XElement("Fahrzeuge",
                from x in fahrzeuge
                group x by x.Brand into a
                select new XElement("Fahrzeug",
                    new XAttribute("Hersteller", a.Key),
                    from b in a
                    select new XElement("Wagen",
                        new XAttribute("Modell", b.Model),
                        new XElement("Ausstellungsdatum", b.DateCrawled),
                        new XElement("Name", b.Name),
                        new XElement("Verkäufer", b.Seller),
                        new XElement("Angebot", b.OfferType),
                        new XElement("Presi", b.Price),
                        new XElement("Fahrzeugtyp", b.VehicleType),
                        new XElement("Registrationsjahr", b.YearOfRegistration),
                        new XElement("Registrationsmonat", b.MonthOfRegistration),
                        new XElement("Getriebe", b.Gearbox),
                        new XElement("PS", b.Power),
                        new XElement("Kilometer", b.Kilometer),
                        new XElement("Brennstofftyp", b.FuelType),
                        new XElement("Schaden", b.NotRepairedDamage),
                        new XElement("Erstellungsdatum", b.DateCreated))));
            erg.Save("../../Fahrzeuge.xml");
            */
        }
    }

 
}
