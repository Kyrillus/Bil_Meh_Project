using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    class Personenverwaltung
    {
        private List<Person> personen;
        private List<Fahrzeug> angebote;

        public Personenverwaltung(List<Person> personen)
        {
            Personen = personen;
            readFahrzeuge();
;        }

        public void readFahrzeuge()
        {
            StreamReader reader = new StreamReader(File.OpenRead("../Fahrzeug.csv"));
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                DateTime? dt = null;
                Fahrzeug fz;
                String[] arr = line.Split(',');
                DateTime? dat = arr[0] == null ?  dt : Convert.ToDateTime(arr[0]);
                String name = arr[1];
                String seller = arr[2];
                String offerType = arr[3];
                int price = Convert.ToInt32(arr[4]);
                String abtest = arr[5];
                String vehicleType = arr[6];
                int yearOfReg = Convert.ToInt32(arr[7]);
                String gearBox = arr[8];
                int power = Convert.ToInt32(arr[9]);
                String model = arr[10];
                int kilometer = Convert.ToInt32(arr[11]);
                int monthOfReg = Convert.ToInt32(arr[12]);
                String fuelType = arr[13];
                String brand = arr[14];
                String notRepairedDamage = arr[15];
                DateTime dateCreated = Convert.ToDateTime(arr[16]);
                int nrOfPictures = Convert.ToInt32(arr[17]);
                int postalCode = Convert.ToInt32(arr[18]);
                DateTime lastSeen = Convert.ToDateTime(arr[19]);
                fz = new Fahrzeug(dat,name,seller,offerType,price,abtest,vehicleType,yearOfReg,gearBox,power,model,kilometer,monthOfReg,fuelType,brand,notRepairedDamage,dateCreated,nrOfPictures,postalCode,lastSeen);
                angebote.Add(fz);
            }


        }

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

        internal List<Fahrzeug> Angebote
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
