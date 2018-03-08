using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Pirmas skaicius didziausias");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Antras skaicius didziausias");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine("Trecias skaicius didziausias");
            }
            else
            {
                Console.WriteLine("Kazkurie is didesniu skaiciu lygus arba visi trys lygus");
            }
        }
    }
}
