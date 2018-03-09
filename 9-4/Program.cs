using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //pirminiu skaiciu suma uzdavinys!!!
            var suma = 2;
            for (int i = 3; i < 1000; i++)
            {
                int flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    suma += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(suma);
        }
    }
}
