using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kambario ploti ir ilgi");
            var ilgis = Convert.ToInt32(Console.ReadLine());
            var plotis = Convert.ToInt32(Console.ReadLine());
            var kaina = 8;
            var plotas = ilgis * plotis;
            var kainaviso = plotas;
            var proc1 = (plotas * kaina) / 100;
            var ats = plotas * kaina + (proc1 * 5);

            Console.WriteLine("Viso reikes pinigu: " + ats);
        }
    }
}
