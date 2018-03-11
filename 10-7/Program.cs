using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());

            while (a % 9 != 0)
            {
                Console.WriteLine("Iveskite skaiciu");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Skaicius {0} dalijasi is 9", a);
        }
    }
}
