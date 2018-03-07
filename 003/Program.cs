using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek pinigu norite padeti i banka?");
            double pinigai = Convert.ToDouble(Console.ReadLine());
            double pometupalukanos = (pinigai / 100) * 2;
            double pometu = pinigai + pometupalukanos;
            double podviejupalukanos = (pometu / 100) * 2;
            double podvieju = podviejupalukanos + pometu;

            Console.WriteLine("Po metu turesite {0}, o po dvieju {1}, \nPalukanos metu bus {2}, o dvieju {3}", pometu, podvieju, pometupalukanos, podviejupalukanos);
        }
    }
}
