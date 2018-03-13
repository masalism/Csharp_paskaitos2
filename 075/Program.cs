using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075
{
    class Program
    {
        static void Main(string[] args)
        {
            //ar taskai patenka i suvesto apskritmo koordinates, reikia vesti tris skaicius
            int[] x = { 2, 3, 4, 7, 4, 3, 7 };
            int[] y = { 2, -3, -4, 1, -2, 6, 1 };
            Console.WriteLine("Iveskite duomenis per tarpeli");
            string duomenys = Console.ReadLine();
            string[] poviena = duomenys.Split().ToArray();
            int a = Convert.ToInt32(poviena[0]);
            int b = Convert.ToInt32(poviena[1]);
            int r = Convert.ToInt32(poviena[2]);

            for (int i = 0; i < x.Length; i++)
            {
                double d = Math.Sqrt(Math.Pow(a - x[i], 2) + Math.Pow(b - y[i], 2));
                if (d <= r)
                {
                    Console.WriteLine("Taskas ({0} {1}) patenka i apskritima", x[i], y[i]);
                }
                else
                {
                    Console.WriteLine("Taskas ({0} {1}) nepatenka i apskritima", x[i], y[i]);
                }


            }
        }
    }
}
