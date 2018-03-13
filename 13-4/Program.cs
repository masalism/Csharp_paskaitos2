using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //nurodo kiek duomenu suvesti
            Console.WriteLine("Kiek duomenu norite suvesti");
            int kiek = Convert.ToInt32(Console.ReadLine());

            double[] temp = new double[kiek];

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine("Iveskite temperatura");
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Maksimali" + temp.Max());
            Console.WriteLine("Maziausia " + temp.Min());
            Console.WriteLine("Vidutine" + temp.Average());


            // uz maziau nei vidurki temp suma
            double suma = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < temp.Average())
                {
                    suma += temp[i];
                }
            }
            Console.WriteLine("Maziau uz vidurki " + suma);
        }
    }
}
