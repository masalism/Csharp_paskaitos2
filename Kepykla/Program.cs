using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iskepti kepalu per diena?");
            var kepalai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotoju turi kepykla?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kokia vieno kepalo savikaina");
            var savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("kokia kepalo pardavimo kaina?");
            var kaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kiek kepykla ta diena turi uzsakymu");
            var uzsakymai = Convert.ToInt32(Console.ReadLine());

            var valandos = 8;
            var viso_kep_perdiena = darbuotojai * kepalai * valandos;
            var visusavikaina = (double)viso_kep_perdiena * savikaina;
            var pajamosvisadiena = (double)viso_kep_perdiena * kaina;
            var pelnas = (double)pajamosvisadiena - visusavikaina;

            Console.WriteLine("Per diena kepykla kepalu iskeps: " + viso_kep_perdiena);
            Console.WriteLine("Visu kepalu savikaina: " + visusavikaina);
            Console.WriteLine("Pajamos per diena: " + pajamosvisadiena);
            Console.WriteLine("Pelnas tos dienos: " + pelnas);

            if (viso_kep_perdiena >= uzsakymai)
            {
                Console.WriteLine("Kepykla spes ivygdyti visus uzsakymus");
            }
            else if (viso_kep_perdiena < uzsakymai)
            {
                Console.WriteLine("Kepykla nespes iskepti visu dienos uzsakymu, jiems pritruks {0} kepalu", uzsakymai - viso_kep_perdiena);
            }
        }
    }
}
