using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu prazia ir pabaiga");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(i + " " + Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("Blogai ivedete rezius");
            }
        }
    }
}
