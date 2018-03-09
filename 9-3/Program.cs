using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandauga = 1;
            for (int i = 7; i < 100; i++)
            {
                if ((i % 7) == 0)
                {
                    sandauga *= i;
                }
                
            }
            Console.WriteLine(sandauga);

        }
    }
}
