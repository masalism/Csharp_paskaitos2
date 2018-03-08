using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveika skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius lyginis");
            }
            if (a % 2 != 0)
            {
                Console.WriteLine("Skaicius nelyginis");
            }
        }
    }
}
