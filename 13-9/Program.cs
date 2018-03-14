using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[5];
            Console.WriteLine("Iveskite penkis skaicius");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
