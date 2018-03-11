using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivesktie teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Teigiama bl ivesti reikia!!!");
            }
            if (a > 0)
            {
                Console.WriteLine("Sveikiname");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius lyginis");
            }
            if (a % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            if (a > 10)
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }
        }
    }
}
