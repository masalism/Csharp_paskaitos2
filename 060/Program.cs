using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -10; i <= 10; i++)
            {
                var y = (7 * Math.Pow(i, 2)) + (5 * i) - 3;
                Console.WriteLine(y);
            }
        }
    }
}
