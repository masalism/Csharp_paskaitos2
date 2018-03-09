using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmojo apskritimo spinduli");
            var r1 = Convert.ToInt32(Console.ReadLine());
            var p = 3.14;
            var S1 = 3.14 * Math.Pow(r1, 2);
            var r2 = r1 * 2;
            var r3 = r2 * 2;
            var S2 = 3.14 * Math.Pow(r2, 2);
            var S3 = 3.14 * Math.Pow(r3, 2);
            Console.WriteLine(S1 + ", " + ", " + S2 + ", " + S3);


        }
    }
}
