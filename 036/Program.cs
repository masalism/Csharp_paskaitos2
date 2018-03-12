using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kiek auksinu karalius turi?");
            var n = Convert.ToInt32(Console.ReadLine());

            var a = 1;
            var b = 1;
            var suma = 2;
            var kiekis = 2;
            var c = 0;

            while (n > suma)
            {
                c = a + b;
                suma += c;
                kiekis++;
                a = b;
                b = c;
            }
            Console.WriteLine("Po dienu " + kiekis);
        }
    }
}
