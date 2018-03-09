using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmojo tasko x koordinate");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirmojo tasko y koordinate");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antrojo tasko x koordinate");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antrojo tasko y koordinate");
            var y2 = Convert.ToInt32(Console.ReadLine());
                        
            var d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            var a = Math.Sqrt(Math.Pow(d, 2) - Math.Pow(x2 - x1, 2));
            var b = Math.Sqrt(Math.Pow(d, 2) - Math.Pow(y2 - y1, 2));

            Console.WriteLine(a + " " + b);

            Console.WriteLine("Plotas {0}: ", a * b);
            Console.WriteLine("Perimetras {0}: ", a + a + b + b);
        }
            
    }
}
