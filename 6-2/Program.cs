using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} >  {1}", a, b);
            }
            if (b > c)
            {
                Console.WriteLine("{0} >  {1}", b, c);
            }
            else if (c > a)
            {
                Console.WriteLine("{0} >  {1}", c, a);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} =  {1}", a, b);
            }
        }
    }
}
