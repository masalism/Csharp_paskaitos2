using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defektuotas_kamuolys
{
    class Program
    {
        static void Main(string[] args)
        {
            var kam1 = 2;
            var kam2 = 2;
            var kam3 = 2;
            var kam4 = 1;
            var kam5 = 2;
            var kam6 = 2;
            var kam7 = 2;
            var kam8 = 2;

            if (kam1 + kam2 + kam3 == kam4 + kam5 + kam6)
            {
                Console.WriteLine("Cia defektuoto nera, ziureti 7 ir 8 kamuoliukus");
                if (kam7 > kam8)
                {
                    Console.WriteLine("defektuotas 8 kamuoliukas");
                }
                else
                {
                    Console.WriteLine("defektuotas 7 kamuoliukas");
                }
            }
            else if (kam1 + kam2 + kam3 < kam4 + kam5 + kam6)
            {
                if (kam4 == kam5)
                {
                    Console.WriteLine("defektuotas 6 kamuoliukas");
                }
                else if (kam4 > kam5)
                {
                    Console.WriteLine("defektuotas 5 kamuoliukas");
                }
                else
                {
                    Console.WriteLine("defektuotas 4 kamuoliukas");
                }
            }
            else if (kam1 + kam2 + kam3 > kam4 + kam5 + kam6)
            {
                if (kam1 == kam2)
                {
                    Console.WriteLine("defektuotas 3 kamuoliukas");
                }
                else if (kam1 > kam2)
                {
                    Console.WriteLine("defektuotas 2 kamuoliukas");
                }
                else
                {
                    Console.WriteLine("defektuotas 1 kamuoliukas");
                }
            }

        }
    }
}
