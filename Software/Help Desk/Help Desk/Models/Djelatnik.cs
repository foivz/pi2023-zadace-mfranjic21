using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk.Models
{
    public class Djelatnik
    {
        public int ID_djelatnik { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Zaporka { get; set; }

        public bool CheckPassword(string zaporka)
        {
            return Zaporka == zaporka;
        }
    }
}
