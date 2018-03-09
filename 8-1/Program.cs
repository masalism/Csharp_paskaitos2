using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 3");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite du bet kokius skaicius");
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(a + b + c);
                    break;
                case 2:
                    Console.WriteLine(a - c);
                    break;
                case 3:
                    Console.WriteLine(b * c);
                    break;
            }
        }
    }
}
