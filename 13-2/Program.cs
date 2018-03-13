using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //min max reikmes is masyvo
            int[] skaiciai = new int[5];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu:");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(skaiciai.Max());
            Console.WriteLine(skaiciai.Min());


            // anksciau taip ieskodavo max ir min value
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                if (skaiciai[i] > max)
                {
                    max = skaiciai[i];
                }
                if (skaiciai[i] < min)
                {
                    min = skaiciai[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
