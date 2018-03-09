using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032
{
    class Program
    {
        static void Main(string[] args)
        {

            //parasyti programa dieju skaiciu sandaugai be * zenklo
            Console.WriteLine("Iveskite du sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var daugyba = 0;

            for (int i = 0; i < b; i++)
            {
                daugyba += a;
            }
            Console.WriteLine("Atsakymas: " + daugyba);
        }
    }
}
