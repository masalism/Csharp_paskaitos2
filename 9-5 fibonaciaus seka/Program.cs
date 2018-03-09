using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_fibonaciaus_seka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite fibonaciaus skaiciu kieki");
            var n = Convert.ToInt32(Console.ReadLine());
            var a = 0;
            var b = 1;
            var c = 0;
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                

            }
            Console.WriteLine("------------------");
        }
    }
}
