using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ar_susidaro_trikampis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma trikampio krastine");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra trikampio krastine");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ilgiausia trikampio krastine");
            var c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("trikampis gaunasi");
            }
            else
            {
                Console.WriteLine("trikampis nesigauna");
            }
        }
    }
}
