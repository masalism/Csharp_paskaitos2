using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite sios dienos temperatura");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("ziauriai salta");
            }
            else if (a < 10)
            {
                Console.WriteLine("labai salta");
            }
            else if (a < 20)
            {
                Console.WriteLine("salta");
            }
            else if (a < 30)
            {
                Console.WriteLine("normali temperatura");
            }
            else if (a < 40)
            {
                Console.WriteLine("karsta");
            }
            else if (a >= 40)
            {
                Console.WriteLine("visiskai degina");
            }
        }
    }
}
