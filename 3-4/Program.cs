using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite be koki simboli");
            var simb = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("{0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}", simb);
        }
    }
}
