using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 999");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            
            int simt = skaicius / 100;
            int desim = (skaicius % 100) / 10;
            int vnt = skaicius % 10;

            Console.WriteLine(Simtai(simt) + Desimtys(desim)+ Vienetai(vnt));
        }

        private static string Vienetai(int vnt)
        {
            if (vnt == 4)
            {
                return "IV";
            }
            else if (vnt == 9)
            {
                return "IX";
            }
            else
            {
                int p = vnt / 5;
                int v = vnt % 5;
                string ats = "";
                if (p != 0)
                {
                    ats += "V";
                }
                for (int i = 0; i < v; i++)
                {
                    ats += "I";
                }
                return ats;
            }
        }
        private static string Desimtys(int desim)
        {
            if (desim == 4)
            {
                return "XL";
            }
            else if (desim == 9)
            {
                return "XC";
            }
            else
            {
                int p = desim / 5;
                int v = desim % 5;
                string ats1 = "";
                if (p != 0)
                {
                    ats1 += "L";
                }
                for (int i = 0; i < v; i++)
                {
                    ats1 += "X";
                }
                return ats1;
            }
        }
        private static string Simtai(int simt)
        {
            if (simt == 4)
            {
                return "CD";
            }
            else if (simt == 9)
            {
                return "CM";
            }
            else
            {
                int p = simt / 5;
                int v = simt % 5;
                string ats2 = "";
                if (p != 0)
                {
                    ats2 += "D";
                }
                for (int i = 0; i < v; i++)
                {
                    ats2 += "C";
                }
                return ats2;
            }
        }
    }
}
