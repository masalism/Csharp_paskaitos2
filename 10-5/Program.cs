using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. Pvz.:5 + 4 = 95 - 4 = 1…
            var klausimas = "t";

            while (klausimas == "t")
            {
                Console.WriteLine("Iveskite du skaicius");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);

                Console.WriteLine();
                Console.WriteLine("Ar norite testi? t/n");
                klausimas = Console.ReadLine();
            }
            Console.WriteLine("Programos pabaiga");
        }
    }
}
