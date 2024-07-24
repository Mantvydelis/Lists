using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listai.Models
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int Ivertinimas { get; set; }

        public Studentas(string vardas, int ivertinimas)
        {
            Vardas = vardas;
            Ivertinimas = ivertinimas;
        }
    }


}
