using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite su kuo norite iskepti greitpyragi 1-4");
            Console.WriteLine("1 - Obuoliai");
            Console.WriteLine("2 - Melynes");
            Console.WriteLine("3 - Juodieji serbentai");
            Console.WriteLine("4 - slyvos");
            var k = Convert.ToInt32(Console.ReadKey().KeyChar);

            switch (k)
            {
                case 1  :
                    Console.WriteLine("mamai ir dukrai");
                    break;
                case 2:
                    Console.WriteLine("mamai ir dukrai");
                    break;
                case 3:
                    Console.WriteLine("teciui ir sunui");
                    break;
                case 4:
                    Console.WriteLine("teciui ir sunui");
                    break;
                default:
                    Console.WriteLine("Nera tokio pasirinkimo");
                    break;
            }
        }
    }
}
