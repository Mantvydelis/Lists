using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listai.Models
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public bool Isnuomota { get; set; }

        public Knyga(string pavadinimas, bool isnuomota)
        {
            Pavadinimas = pavadinimas;
            Isnuomota = isnuomota;
        }
    }
}
