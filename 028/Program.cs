using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite keturis skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());

            
            if (a == b && a == c && a == d && b == c && b == d && c == d)
            {
                Console.WriteLine("Vienareiksme progresija");
            }
            else if (b - a == b - c && b - c == c - b)
            {
                Console.WriteLine("Didejanti progresija");
            }
        }
    }
}
