using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Bananai
            Console.WriteLine("Iveskite kiek pirma diena bezdzione gavo bananu");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kiek procentu maziau bus seriama kita diena");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kiek daugiau bananu duos kita diena");
            double s = Convert.ToDouble(Console.ReadLine());
            double dezeje = b * 2.5;
            int dienas = 0;
            while (dezeje > 0)
            {
                dezeje -= b;
                b = b - (b * (p / 100)) + s;
                dienas++;
            }
            Console.WriteLine(dienas);

        }
    }
}
