using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    class Mitarbeiter : Person
    {
        private String spezialisierung;
        private float gehalt;
        
        public Mitarbeiter(int kundenNr, string vorname, string nachname, string telNr, string anrede, string adresse, string spezialisierung,float gehalt) : base(kundenNr, vorname, nachname, telNr, anrede, adresse)
        {
            Spezialisierung = spezialisierung;
            Gehalt = gehalt;
        }
        public string Spezialisierung
        {
            get
            {
                return spezialisierung;
            }

            set
            {
                spezialisierung = value;
            }
        }

        public float Gehalt
        {
            get
            {
                return gehalt;
            }

            set
            {
                gehalt = value;
            }
        }
    }
}
