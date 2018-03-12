using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_Ana_ziaurus
{
    class Program
    {
        static void Main(string[] args)
        {

            //uzdavinys su rekursija
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            while (!Ar_tvarkingas(sk))
            {
                sk--;
            }
            Console.WriteLine("Tvarkingas skaicius yra: " + sk);
        }

        static bool Ar_tvarkingas(int sk)
        {
            int sk1 = sk % 10;
            int sk2 = (sk % 100) / 10;
            bool check = false;
            if (sk1 >= sk2)
            {
                if (sk > 10)
                {
                    sk /= 10;
                    check = Ar_tvarkingas(sk);
                }
                else
                {
                    check = true;
                }
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
