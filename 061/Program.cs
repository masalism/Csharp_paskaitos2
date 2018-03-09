using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzduotis su keliamaisiais metais
            
            for (int i = 0; i <= 2018; i+=4)
            {

                if (i < 100)
                {
                    Console.WriteLine(i);
                }
                else if (i % 100 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
