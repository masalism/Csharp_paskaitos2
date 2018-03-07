using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek vienas vidutiniskai per metus perskaito knygu?");
            var k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek is viso yra mokiniu mokykloje?");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is viso perskaitytu knygu skaicius: {0}", k * m);
        }
    }
}
