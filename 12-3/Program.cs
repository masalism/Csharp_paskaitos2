using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Suma(a,b));
            Console.WriteLine(Minusas(a,b));
            Console.WriteLine(Daugyba(a,b));
            Console.WriteLine(Dalyba(a,b));

        }
                

        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Minusas(int a, int b)
        {
            return a - b;
        }
        static int Daugyba(int a, int b)
        {
            return a * b;
        }
        static double Dalyba(double a, double b)
        {
            return (double)a / b;
        }
    }
}
