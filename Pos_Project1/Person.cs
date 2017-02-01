using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Project1
{
    public class Person
    {
        private int kundenNr = 1;
        private String vorname;
        private String nachname;
        private String telNr;
        private String anrede;
        private String adresse;

        public Person(String vorname, String nachname, String telNr, String anrede, String adresse)
        {
            ++KundenNr;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.TelNr = telNr;
            this.Anrede = anrede;
            this.Adresse = adresse;
        }
        public int KundenNr
        {
            get
            {
                return kundenNr;
            }

            set
            {
                kundenNr = value;
            }
        }



        public string TelNr
        {
            get
            {
                return telNr;
            }

            set
            {
                telNr = value;
            }
        }

        public string Anrede
        {
            get
            {
                return anrede;
            }

            set
            {
                anrede = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Vorname
        {
            get
            {
                return vorname;
            }

            set
            {
                if (vorname == null)
                {
                    throw new ArgumentException();
                }
                else
                {
                    vorname = value;
                }
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                if (nachname == null)
                {
                    throw new ArgumentException();
                }
                else
                {
                    nachname = value;
                }
            }
        }
    }
}