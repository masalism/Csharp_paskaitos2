using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skaiciaus {0} kvadratas {1}", a, Math.Pow(a, 2));
        }
    }
}
