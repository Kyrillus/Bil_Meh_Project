using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    class Kunde : Person
    {
        private List<Fahrzeuge> interesse;
        private List<Fahrzeuge> list;

      

        public Kunde(string vorname, string nachname, string telNr, string anrede, string adresse, List<Fahrzeuge> interesse) : base(vorname, nachname, telNr, anrede, adresse)
        {
            Interesse = interesse;
        }

        internal List<Fahrzeuge> Interesse
        {
            get
            {
                return interesse;
            }

            set
            {
                interesse = value;
            }
        }
    }
}
