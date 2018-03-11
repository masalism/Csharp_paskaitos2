using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu didesni uz 0");
            var a = Convert.ToInt32(Console.ReadLine());
            var suma = 0;
            while (a > 0)
            {

                Console.WriteLine(a);
                
                if (a % 2 == 0)
                {
                    suma += a;
                }
                a--;

            }
            Console.WriteLine(suma);
        }
    }
}
