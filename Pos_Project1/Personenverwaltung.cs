using System;
using System.Collections.Generic;
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
