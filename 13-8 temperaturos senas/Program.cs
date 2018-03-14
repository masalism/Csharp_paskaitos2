using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_8_temperaturos_senas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 14.5, 18.5, 20.4, -20 };

            var zemiausia = temperaturos[0];

            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }
            }
            Console.WriteLine("zemiausia temperatura: " + zemiausia);

            var auksciausia = temperaturos[0];

            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auksciausia)
                {
                    auksciausia = temperatura;
                }
            }
            Console.WriteLine("auksciausia temperatura " + auksciausia);

            double suma = 0;

            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }

            var vidurkis = suma / temperaturos.Length;

            Console.WriteLine("Vidurkis " + vidurkis);

            var vidmin = 0;

            foreach (var temperatura in temperaturos)
            {
                if (vidurkis > temperatura)
                {
                    vidmin++;
                }
            }
            Console.WriteLine("zemesniu uz vidurki kiekis " + vidmin);

            var viddaug = 0;

            foreach (var temperatura in temperaturos)
            {
                if (vidurkis < temperatura)
                {
                    viddaug++;
                }
            }
            Console.WriteLine("auk uz vidurki kiekis " + viddaug);
        }
    }
}
