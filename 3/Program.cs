using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prekiu sarasas:");
            Console.WriteLine("1. Sviestas - 1,00 eur");
            Console.WriteLine("2. Pienas - 0,90 eur");
            Console.WriteLine("3. Batonas -  1,00 eur");
            Console.WriteLine("4. Duona - 1,50 eur");
            Console.WriteLine("5. Limondas - 1,40 eur");
            Console.WriteLine("6. Majonezas - 2,00");
            Console.WriteLine("7. Dešra - 3,20");
            Console.WriteLine("8. Apsipirkimas baigtas");

            Console.WriteLine("Issirinkite norimas prekes parase prekiu numerius. Kai baigsite, parasykite zodi Baigta.");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            float sum1 = 1.00f;
            float sum2 = 0.90f;
            float sum3 = 1.00f;
            float sum4 = 1.50f;
            float sum5 = 1.40f;
            float sum6 = 2.00f;
            float sum7 = 3.20f;
            float suma = 0;

            while (pasirinkimas != 8)
            {
                if (pasirinkimas == 1)
                {
                    suma += sum1;
                    Console.WriteLine("Sviestas");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 2)
                {
                    suma += sum2;
                    Console.WriteLine("Pienas");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 3)
                {
                    suma += sum3;
                    Console.WriteLine("Batonas");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 4)
                {
                    suma += sum4;
                    Console.WriteLine("Duona");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 5)
                {
                    suma += sum5;
                    Console.WriteLine("Limonadas");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 6)
                {
                    suma += sum6;
                    Console.WriteLine("Majonezas");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 7)
                {
                    suma += sum7;
                    Console.WriteLine("Dešra");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas < 1 || pasirinkimas > 7)
                {
                    Console.WriteLine("Tokio pasirinkimo nera");
                    pasirinkimas = Convert.ToInt32(Console.ReadLine());
                }
                else if (pasirinkimas == 8)
                {
                    Console.WriteLine(suma);
                }
            }
            Console.WriteLine("Jusu apsipirkimo suma: " + suma + " EUR");
        }
    }
}
