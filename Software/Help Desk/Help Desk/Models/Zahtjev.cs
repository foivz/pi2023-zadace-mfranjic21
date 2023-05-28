using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk.Models
{
    internal class Zahtjev
    {
        public int ID_Zahtjev { get; set; }
        public int DjelatnikID { get; set; }
        public int Status { get; set; }
        public string Komentar { get; set; }
        public DateTime VrijemePrijave { get; set; }
        public int Prioritet { get; set; }
        public string Opis { get; set; }
        public string Lokacija { get; set; }
    }
}
