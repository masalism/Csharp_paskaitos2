using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054
{
    class Program
    {
        static void Main(string[] args)
        {

            //pitagoro teorema

            Console.WriteLine("Iveskite pirma statino ilgi");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra statino ilgi");
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("Izambines reiksme yra {0:0.00}", c);

            //konvertuoja skaiciu {0:0.00}
        }
    }
}
