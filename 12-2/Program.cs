using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinti();
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite amaziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite savo hobi");
            string hobis = Console.ReadLine();
            Isvedimas(vardas, amzius, hobis);
        }

        public static void Pasisveikinti()
        {
            Console.WriteLine("Sveiki");
        }

        public static void Isvedimas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine("Jusu vardas {0}, amzius {1}, jusu hobis {2}", vardas, amzius, hobis);

        }

    }
}
