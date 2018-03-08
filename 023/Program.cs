using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite metus");
            int metai = Convert.ToInt32(Console.ReadLine());
            var olimp1 = 1896;

            if (metai % 4 == 0 && olimp1 >= 1896)
            {
                int kurioszaidynes = (metai - olimp1) / 4;
                Console.WriteLine("Zaidynes buvo {0} buvo {1} zaidynes", metai, ++kurioszaidynes);
            }
            else
            {
                Console.WriteLine("Ne olimpiniai metai");
            }
        }
    }
}
