using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite trizenli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int simt = sk / 100;
            int desim = (sk % 100) / 10;
            int vnt = sk % 10;

            if (sk == Math.Pow(simt, 3) + Math.Pow(desim, 3) + Math.Pow(vnt, 3))
            {
                Console.WriteLine("Skaicius yra armmstrongo");
            }
            else
            {
                Console.WriteLine("Skaicius ne armstrongo");
            }
            
                
        }
    }
}
