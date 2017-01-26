using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    class Fahrzeug
    {
        private DateTime? dateCrawled;
        private String name;
        private String seller;
        private String offerType;
        private int price;
        private String abtest;
        private String vehicleType;
        private int yearOfRegistration;
        private String gearbox;
        private int power;
        private String model;
        private int kilometer;
        private int monthOfRegistration;
        private String fuelType;
        private String brand;
        private String notRepairedDamage;
        private DateTime? dateCreated;
        private int nrOfPictures;
        private int postalCode;
        private DateTime? lastSeen;

        public Fahrzeug(DateTime? dateCrawled, string name, string seller, string offerType, int price, string abtest, string vehicleType, int yearOfRegistration, string gearbox, int power, string model, int kilometer, int monthOfRegistration, string fuelType, string brand, string notRepairedDamage, DateTime? dateCreated, int nrOfPictures, int postalCode, DateTime? lastSeen)
        {

            DateCrawled = dateCrawled;
            Name = name;
            Seller = seller;
            this.offerType = offerType;
            this.price = price;
            this.abtest = abtest;
            this.vehicleType = vehicleType;
            this.yearOfRegistration = yearOfRegistration;
            this.gearbox = gearbox;
            this.power = power;
            this.model = model;
            this.kilometer = kilometer;
            this.monthOfRegistration = monthOfRegistration;
            this.fuelType = fuelType;
            this.brand = brand;
            this.notRepairedDamage = notRepairedDamage;
            this.dateCreated = dateCreated;
            this.nrOfPictures = nrOfPictures;
            this.postalCode = postalCode;
            this.lastSeen = lastSeen;
        }

        public DateTime? DateCrawled
        {
            get
            {
                return dateCrawled;
            }

            set
            {
                dateCrawled = value;
            }
        }

        public string Seller
        {
            get
            {
                return seller;
            }

            set
            {
                seller = value;
            }
        }

        public string OfferType
        {
            get
            {
                return offerType;
            }

            set
            {
                offerType = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Abtest
        {
            get
            {
                return abtest;
            }

            set
            {
                abtest = value;
            }
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }

            set
            {
                vehicleType = value;
            }
        }

       

        public string Gearbox
        {
            get
            {
                return gearbox;
            }

            set
            {
                gearbox = value;
            }
        }

        public int Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Kilometer
        {
            get
            {
                return kilometer;
            }

            set
            {
                kilometer = value;
            }
        }

        public int MonthOfRegistration
        {
            get
            {
                return monthOfRegistration;
            }

            set
            {
                monthOfRegistration = value;
            }
        }

        public string FuelType
        {
            get
            {
                return fuelType;
            }

            set
            {
                fuelType = value;
            }
        }

        public int YearOfRegistration
        {
            get
            {
                return yearOfRegistration;
            }

            set
            {
                yearOfRegistration = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public string NotRepairedDamage
        {
            get
            {
                return notRepairedDamage;
            }

            set
            {
                notRepairedDamage = value;
            }
        }

        public DateTime? DateCreated
        {
            get
            {
                return dateCreated;
            }

            set
            {
                dateCreated = value;
            }
        }

        public int NrOfPictures
        {
            get
            {
                return nrOfPictures;
            }

            set
            {
                nrOfPictures = value;
            }
        }

        public int PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public DateTime? LastSeen
        {
            get
            {
                return lastSeen;
            }

            set
            {
                lastSeen = value;
            }
        }

        public override string ToString()
        {
            return "Fahrzeug[\nAustellungsdatum= "+dateCrawled+"\nName="+name+"\nVerkäufer"+seller+
                "\nAngebot="+offerType+"\nPreis="+price+"\nFahrzeugtyp"+vehicleType+"\nRegistrationsjahr="+yearOfRegistration+"\nRegistrationsmonat"+monthOfRegistration+
                "\nGetriebe="+gearbox+"\nPS="+power+"\nModell="+model+"\nKilometer="+kilometer+"\nBrennstofftyp="+fuelType+
                "\nHersteller="+brand+"\nSchaden="+notRepairedDamage+"\nErstellungsdatum"+dateCreated+"]";
        }
    }
}
