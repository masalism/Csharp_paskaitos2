using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055
{
    class Program
    {
        static void Main(string[] args)
        {
            //laiptai
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < (10-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            
        }
    }
}
