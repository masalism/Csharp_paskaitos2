using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite penkiaziankli skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            int tukst10 = skaicius / 10000;
            int vnt = skaicius % 10;

            if (tukst10 == vnt)
            {
                Console.WriteLine("Skaicius polindromas");
            }
            else
            {
                Console.WriteLine("Skaicius ne polindromas");
            }

            
        
        }
    }
}
