using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Mantas";
            string pavarde = "Masalis";
            int amzius = 28;
            double ugis = 1.78;
            double svoris = 88.1;
            string aukstoji_mokykla = "LSMU";
            int akademinis_kodas = 343;
            int kursas = 6;
            string pavadinimas = "Veterinarine medicina";
            int kreditu_skaicius = 243;

            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine(vardas + " " + pavarde + " amzius " + amzius);
            Console.WriteLine("Jo ugis yra " + ugis + ", o svoris " + svoris + " kg");
            Console.WriteLine("Jis mokosi " + aukstoji_mokykla);
            Console.WriteLine("Akademine grupe kuriai jis priklauso " + akademinis_kodas);
            Console.WriteLine("Jau yra baiges " + kursas + " kursus ir yra baiges studijas");
            Console.WriteLine("Per studiju laikotarpi atsiskaite " + kreditu_skaicius + " kreditus");
        }
    }
}
