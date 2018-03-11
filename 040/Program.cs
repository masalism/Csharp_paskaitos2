using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040
{
    class Program
    {
        static void Main(string[] args)
        {

            // ar skaicius yra faktorialas
            Console.WriteLine("Iveskite teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            var i = 1;

            while (a > 1)
            {
                if (a % i == 0) 
                {
                    a /= i;
                    if (a == 1)
                    {
                        Console.WriteLine("Faktorialas " + i);
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Ne faktorialas");
                    break;
                }

            }
            

        }
    }
}
