using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_uzduotis
{
    class Automobilis
    {
        /* KONSTRUKTORIUS SUSIDEDA IŠ:
        <Access Specifier><klases pavadinimas>(argumentai)
        {
        ....
        }*/

        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Pagaminimo_Metai { get; set; }
        public int Rida { get; set; }

        public Automobilis(string marke, string modelis, int pagaminimo_Metai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Pagaminimo_Metai = pagaminimo_Metai;
            Rida = rida;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
