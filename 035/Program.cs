using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035
{
    class Program
    {
        static void Main(string[] args)
        {
            var jm = 0;
            var tg = 0.01;
            
            for (double i = 0; i <= 31; i++)
            {
                jm += 1000000;
                tg *= 2;
            }

            Console.WriteLine(jm);
            Console.WriteLine(tg);
        }
    }
}
