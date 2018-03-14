using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            Random random = new Random();

            var kieksugeneruoti = random.Next(0, 1001); // [1 - 1000]

            //sudedam norima kiek atsitiktiniu skaiciu
            for (int i = 0; i < kieksugeneruoti; i++)
            {
                // generuojam atsitiktini skaiciu ir ji dedam i sarasa
                skaiciai.Add(random.Next(1, 1001));
                Console.Write(skaiciai[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());
            Console.WriteLine("Kiekis skaiciu" + skaiciai.Count);

            var zemesniuuzvid = 0;

            var vidurkis = skaiciai.Average();
            Console.WriteLine("vidurkis skaicius: " + skaiciai.Average());

            foreach (var skaicius in skaiciai)
            {
                if (vidurkis > skaicius)
                {
                    zemesniuuzvid++;
                }
            }
            Console.WriteLine("zemensiu uz vid: " + zemesniuuzvid);

            int suma = 0;
            int kiekisnelyginiu = 0;

            foreach (int sumanelyginiu in skaiciai)
            {
                if (sumanelyginiu % 2 != 0)
                {
                    suma += sumanelyginiu;
                    kiekisnelyginiu++;
                }

            }
            Console.WriteLine("Nelyginiu skaiciu kiekis: " + kiekisnelyginiu);
            Console.WriteLine("suma lyginiu: " + suma);


        }
    }
}
