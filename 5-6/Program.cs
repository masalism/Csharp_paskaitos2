using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 savo pazymius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());
            var vid = (double)(a + b + c + d + e) / 5;

            if (vid >= 5)
            {
                Console.WriteLine("Jusu vidurkis {0} daugiau arba lygu 5", vid);
            }
        }
    }
}
