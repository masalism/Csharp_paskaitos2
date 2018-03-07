using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek valandu praejo po vidurnakcio");
            var h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek minuciu praejo po vidurnakcio");
            var m = Convert.ToInt32(Console.ReadLine());
            var minutes = h * 60;
            var sekundes = m * 60;
            Console.WriteLine("minutes {0}, sekundes {1}", minutes, sekundes);
        }
    }
}
