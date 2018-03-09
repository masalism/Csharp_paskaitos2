using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a < 100)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra ir mazesnis uz 100");
            }
            if (b < 0 && b > a)
            {
                Console.WriteLine("Antras skaicius didesnis uz 0 ir didesnis uz pirma skaiciu");
            }
            if (a > b && a > c || a > 0)
            {
                Console.WriteLine("pirmas skaicius didesnis uz abu ar didesnis uz 0");
            }
            if (c <= 10 && c >= 5 || c > a || c > b)
            {
                Console.WriteLine("Trecias skaicius patenka tarp 5 ir 10 arba yra didesnis uz pirma arba yra didesnis uz antra");
                
            }
            

        }
    }
}
