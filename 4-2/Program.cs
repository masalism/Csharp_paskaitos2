using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite trizenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int simt = sk / 100;
            int desim = (sk % 100) / 10;
            int vnt = sk % 10;
            int naujas = vnt * 100 + desim * 10 + simt;
            Console.WriteLine(naujas);


            /*
            is google: 
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("skaicius yra {0}", Reverse);
            Console.ReadLine();*/
        }
    }
}
