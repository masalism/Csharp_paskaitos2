using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Atsakymas " + suma);
        }
        
    }
}
