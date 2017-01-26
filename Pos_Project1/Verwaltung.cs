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
        private List<Fahrzeuge> angebote = new List<Fahrzeuge>();

        public Verwaltung(List<Person> personen)
        {
            Personen = personen;
            readFahrzeuge();
        }

        public void readFahrzeuge()
        {
            StreamReader reader = new StreamReader(File.OpenRead("../../Fahrzeug.csv"));
            string line;
            int i = 0;
            while (i!=1000 && (line = reader.ReadLine()) != null)
            {
                
                Fahrzeuge fz=null;
                String[] arr = line.Split(',');
                DateTime dat = DateTime.ParseExact(arr[0], "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                String name = arr[1];
                String seller = arr[2];
                String offerType = arr[3];
                int price = arr[4] == "" ? 0 : Convert.ToInt32(arr[4]);
                //String abtest = arr[5]; 
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
                fz = new Fahrzeuge(dat,name,seller,offerType,price,vehicleType,yearOfReg,gearBox,power,model,kilometer,monthOfReg,fuelType,brand,notRepairedDamage,dateCreated,nrOfPictures,postalCode,lastSeen);
                //fz = new Fahrzeuge(null, "", "", "", 3, "", "", 3, "", 3, "", 3, 3, "", "", "", null, 3, 3, null);
                angebote.Add(fz);
                i++;
            }
            //dateCrawled,name,seller,offerType,price,abtest,vehicleType,yearOfRegistration,gearbox,powerPS,model,kilometer,monthOfRegistration,fuelType,brand,notRepairedDamage,dateCreated,nrOfPictures,postalCode,lastSeen
            var xe = XElement.Load("../../Xml_fahrzeuge.xml");

            //var help=

            /* var erg1 = new XElement("Termin",
                from ter in v.Ter
                select new XElement("Termin",
                    new XAttribute("Datum", ter.Datum.ToString("H:mm - dd/MMM/yy")),
                    new XElement("Kunde", ter.Kunde.Name)));
             Console.WriteLine(erg1);*/
        }

        public List<Person> Personen
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

        public List<Fahrzeuge> Angebote
        {
            get
            {
                return angebote;
            }

            set
            {
                angebote = value;
            }
        }
    }
}
