using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine(a + " = " + b);
            }
            if (b == c)
            {
                Console.WriteLine(b + " = " + c);
            }
            if (a > b)
            {
                Console.WriteLine(a + " > " + b);
            }
            if (b > c * 2)
            {
                Console.WriteLine(b + " daugiau uz {0} skaiciaus dviguba reiksme", c);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} lyginis", a);
            }
            if (b % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} nelyginis", b);
            }
            if (c > 0)
            {
                Console.WriteLine("Skaicius {0} daugiau uz 0", c);
            }
            if (c < 0)
            {
                Console.WriteLine("Skaicius {0} maziau uz 0", c);
            }
        }
    }
}
