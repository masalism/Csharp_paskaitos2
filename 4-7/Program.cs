using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 69;
            var pirmas = a / 10; //6
            var antras = a % 10; //9
            Console.WriteLine(pirmas);
            Console.WriteLine(antras);
            Console.WriteLine(pirmas * antras);
        }
    }
}
