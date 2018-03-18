using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_uzduotis
{
    class Mokykla
    {
        public int KlasesSk { get; set; }
        public string KlasesR { get; set; }
        public int MokiniuSk { get; set; }
        public int MetaiPr { get; set; }

        public Mokykla(int klasesSk, string klasesR, int mokiniuSk, int metaiPr)
        {
            KlasesSk = klasesSk;
            KlasesR = klasesR;
            MokiniuSk = mokiniuSk;
            MetaiPr = metaiPr;
        }

        public int Kiek_Metu_mokosi()
        {
            int metai = DateTime.Today.Year - MetaiPr;
            return metai;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mokykla mok1 = new Mokykla(7, "A", 25, 2011);
            Mokykla mok2 = new Mokykla(9, "C", 19, 2009);
            Mokykla mok3 = new Mokykla(12, "A", 27, 2006);
            Mokykla mok4 = new Mokykla(3, "D", 23, 2015);
            Mokykla mok5 = new Mokykla(10, "B", 22, 2008);
            Console.WriteLine("{0} {1} klases mokiniai mokosi jau {2} m.", mok1.KlasesSk, mok1.KlasesR, mok1.Kiek_Metu_mokosi());
            Console.WriteLine("{0} {1} klases mokiniai mokosi jau {2} m.", mok2.KlasesSk, mok2.KlasesR, mok2.Kiek_Metu_mokosi());
            Console.WriteLine("{0} {1} klases mokiniai mokosi jau {2} m.", mok3.KlasesSk, mok3.KlasesR, mok3.Kiek_Metu_mokosi());
            Console.WriteLine("{0} {1} klases mokiniai mokosi jau {2} m.", mok4.KlasesSk, mok4.KlasesR, mok4.Kiek_Metu_mokosi());
            Console.WriteLine("{0} {1} klases mokiniai mokosi jau {2} m.", mok5.KlasesSk, mok5.KlasesR, mok5.Kiek_Metu_mokosi());
        }

    }
}
