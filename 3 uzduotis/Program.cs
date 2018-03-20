using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            int[] skaiciai = { 5, 8, 6, 4, 3, 5, 7, 5, 6, 4, 3, 7, 8, 5, 3 };
            Console.WriteLine("Nelyginiu skaicius: " + programa.Kiek_Nelyginiu(skaiciai));
        }

        private int Kiek_Nelyginiu(int[] skaiciai)
        {
            int nelygsk = 0;
            foreach (int skaicius in skaiciai)
            {
                if (skaicius % 2 != 0)
                {
                    nelygsk++;
                }
            }
            return nelygsk;
        }
    }
}
