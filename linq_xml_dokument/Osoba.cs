using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_xml_dokument
{
    internal class Osoba
    {
        string ime, prezime;
        int godina;

        public Osoba(string ime, string prezime, int godina)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Godina = godina;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Godina { get => godina; set => godina = value; }

        public override string ToString()
        {
            return "Ime:" + Ime + "\tPrezime" + Prezime + "\tGodina rođenja" + Godina;
        }
    }
}
