using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listai.Models
{
    internal class Produktas
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }

        public Produktas(string pavadinimas, double kaina)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
        }
    }
}
