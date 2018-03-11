using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas {0}, o amzius {1}", vardas, amzius);
        }
    }
}
