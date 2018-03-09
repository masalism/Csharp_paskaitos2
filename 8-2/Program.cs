using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite kokio gerimo norite");
            Console.WriteLine("1 - limonadas");
            Console.WriteLine("2 - arbata");
            Console.WriteLine("3 - kakava");
            Console.WriteLine("4 - kava");
            Console.WriteLine("5 - nieko");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote kakava");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 5:
                    Console.WriteLine("Jus nieko nenorite");
                    break;
                default:
                    Console.WriteLine("Netinkamas pasirinkimas");
                    break;
            }
        }
    }
}
