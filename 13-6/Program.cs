using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //- Parašykite programą, kuri užpildytų masyvą nuo 1 iki žmogaus pasirinkto skaičiaus, tačiau skaičiai masyve turi eiti kas kart dvigubai didėjant.
            //-Pavydžiui, žmogus pasirenka 20.Tuomet masyvas yra užpildomas skaičiais: 1, 2, 4, 8, 16(32 nebepatenka, nes tai būtų daugiau nei žmogus pasirinko - 20).

                      Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int kiekis = 0;
            int skaiciuojamas = 1;

            while (skaiciuojamas < sk)
            {
                kiekis++;
                skaiciuojamas *= 2;
            }

            skaiciuojamas = 1;
            double[] masyvas = new double[kiekis];
            //masyvas[0] = 1;
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = Math.Pow(2,i);
                Console.WriteLine(masyvas[i]);
            }
            Console.WriteLine(skaiciuojamas);
        }
    }
}
