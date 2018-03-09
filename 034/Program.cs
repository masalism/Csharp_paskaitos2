using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek suruko cigareciu per diena?");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek metu is viso ruko?");
            var metai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kokia viena cigaretes kaina?");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek padidejo norma po metu?");
            var c = Convert.ToInt32(Console.ReadLine());

            double suma = 0;
            
            for (int i = 0; i < metai; i++)
            {
                suma += a * b * 365;
                b += c;
            }

            Console.WriteLine(suma);
        }
    }
}
