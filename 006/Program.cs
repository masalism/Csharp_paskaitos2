using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek is viso yra keleiviu viename vagone?");
            var k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek ne i Vilniu keliauja viename vagone?");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek vagonu?");
            var m = Convert.ToInt32(Console.ReadLine());
            var ivln = k - n;
            var visoivln = ivln * m;

            Console.WriteLine("I Vilniu keliauja: " + visoivln);
        }
    }
}
