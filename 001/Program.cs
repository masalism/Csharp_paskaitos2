using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek klaseje yra mokiniu?");
            var mokiniai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek konspektas turi lapu?");
            var lapai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is viso lapu reikes: {0}", mokiniai * lapai);
        }
    }
}
