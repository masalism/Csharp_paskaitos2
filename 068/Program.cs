using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _068
{
    class Program
    {
        static void Main(string[] args)
        { 


            for (int i = -5; i <= 5; i++)
            {
                var y = Math.Sqrt(Math.Pow(i, 2) + (3 * i) + 5);
                Console.WriteLine(y);
            }
            
        }
    }
}
