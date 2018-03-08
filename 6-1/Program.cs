using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite studento amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirma skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            var b = Convert.ToInt32(Console.ReadLine());

            
            if (amzius > a)
            {
                Console.WriteLine("amzius didesnis nei pirmas skaicius");
            }
            else if (amzius < a)
            {
                Console.WriteLine("amzius mazesnis nei pirmas skaicius");
            }

            if (amzius > b)
            {
                Console.WriteLine("amzius didesnis nei antras skaicius");
            }
            else if (amzius < b)
            {
                Console.WriteLine("amzius mazesnis nei antras skaicius");
            }

        }
    }
}
