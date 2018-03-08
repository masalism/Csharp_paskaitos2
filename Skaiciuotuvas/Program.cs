using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu?");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koki veiksma norite atlikti?");
            char z = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine(" ");
            Console.WriteLine("Iveskite antra skaiciu?");
            var b = Convert.ToInt32(Console.ReadLine());

            if (z == '+')
            {
                var c = a + b;
                Console.WriteLine(c);
            }
            else if (z == '-')
            {
                var c = a - b;
                Console.WriteLine(c);
            }
            else if (z == '*')
            {
                var c = a * b;
                Console.WriteLine(c);
            }
            else if (z == '/')
            {
                if (b != 0)
                {
                    Console.WriteLine((double)a / b);
                }
                else
                {
                    Console.WriteLine("dalyba is nulio negalima");
                }
            }
            else
            {
                Console.WriteLine("Netinkama salyga");
            }
        }
    }
}
