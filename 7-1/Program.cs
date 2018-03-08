using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite studento amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());
            var a = 17;
            var b = 25;
            if (amzius > b)
            {
                Console.WriteLine("Studentas pagyvenes");
            }
            else if (amzius > a)
            {
                Console.WriteLine("Studentas pilanmetis");
            }
            else
            {
                Console.WriteLine("Abu skaiciai mazesni");
            }
        }
    }
}
