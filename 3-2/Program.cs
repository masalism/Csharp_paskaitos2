using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite megstamiausios spalvos pirma raide");
            char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\niveskite du atsitiktinisu skaicius");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu varas {0}, pirma megstamiausios spalvos raide {1}, pasirinkti skaiciai {2} {3}",vardas, raide, a, b);
        }
    }
}
