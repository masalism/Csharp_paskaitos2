using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gauta pazymi nuo 1 iki 10");
            var paz = Convert.ToInt32(Console.ReadLine());

            if (paz == 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (paz >= 8 && paz <= 9)
            {
                Console.WriteLine("Labai gerai");
            }
            else if (paz >= 5 && paz <= 7)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (paz >= 3 && paz <= 4)
            {
                Console.WriteLine("Prastai");
            }
            else if (paz >= 1 && paz <= 2)
            {
                Console.WriteLine("Blogai");
            }
        }
    }
}
