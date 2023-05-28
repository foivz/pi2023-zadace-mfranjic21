using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk.Models
{
    public class Djelatnik : Object
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
