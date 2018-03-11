using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite egzamino rezulata [0-100]");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 100)
            {
                Console.WriteLine("Jusu rezultatas 100");
            }
            else if (a >= 80)
            {
                Console.WriteLine("jus gavote 80 ir daugiau");
            }
            else if (a >= 50)
            {
                Console.WriteLine("jums reikia dar pasimokyti");
            }
            else if (a >= 20)
            {
                Console.WriteLine("jums reikia labai pasimokyti");
            }
            else if (a < 20)
            {
                Console.WriteLine("tu esi beviltiskas!!");
            }
        }
    }
}
