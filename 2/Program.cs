using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Pirmas skaicius didziausias");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("Antras skaicius didziausias");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Trecias skaicius didziausias");
            }
            else
            {
                Console.WriteLine("Du skaiciai arba visi skaiciai lygus");
            }
        }
    }
}
