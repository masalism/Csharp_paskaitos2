using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Pirmas skaicius didesnis");
            }
            if (a < b)
            {
                Console.WriteLine("Antras skaicius didesnis");
            }
            if (a == b)
            {
                Console.WriteLine("Skaiciai lygus");
            }
            
        }
    }
}
