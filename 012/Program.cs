using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek valandu laikrodis rode kai pradejo spresti uzdavinius");
            var h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek minuciu laikrodis rode kai pradejo spresti uzdavinius");
            var m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek valandu laikrodis rode kai baige spresti uzdavinius");
            var h2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek minuciu laikrodis rode kai baige spresti uzdavinius");
            var m2 = Convert.ToInt32(Console.ReadLine());

            

            if (h1 < h2)
            {
                int m3 = (h2 * 60 + m2) - (h1 * 60 + m1);
                int m4 = m3 % 60;
                double h4 = m3 / 60;
                Console.WriteLine("Mokinys namu darbus sprende {0:0} valandu ir {1} minuciu", h4, m4);
            }
            if (h1 > h2)
            {
                int m5 = ((h2 + 24) * 60 + m2) - (h1 * 60 + m1);
                int m6 = m5 % 60;
                double h5 = m5 / 60;
                Console.WriteLine("Mokinys namu darbus sprende {0:0} valandu ir {1} minuciu", h5, m6);
            }
            
        }
    }
}
