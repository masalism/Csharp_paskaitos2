using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite vardų masyvą, kuriame būtų keli iš karto įrašyti vardai.
            // Sukurkite atsitiktinio dydžio sąrašą į kurį sudėtumėte šiuos vardus, tačiau atsitiktinai parinktumėte kurį vardą į kurią sąrašo vietą įrašyti.
            //Pavyzdžiui: masyvas vardai = “Jonas”, “Petras”, “Inga”, “Gabrielė”sąrašas tarkim būtų dydžio 8, o jame duomenys atsitiktinai išsidėliotų tarkim tokia tvarka: Petras, Inga, Inga, Gabrielė, Jonas, Jonas, Petras, Gabrielė
            //Išvesti šio sąrašo duomenis toje pačioje eilutėje, vardus atskiriant kableliu

            string[] masyvas =
            {
                "Petras",
                "Mantas",
                "Gabriele",
                "Jonas",
                "Dominykas",
                "Indre",
                "Aurelija",
                "Faustas"
            };

            Random rng = new Random();
            int kiekis = rng.Next(0, 2000);
            List<string> sarasas = new List<string>();

            while (kiekis != 0)
            {
                sarasas.Add(masyvas[rng.Next(0, masyvas.Length)]);
                kiekis--;
            }

            foreach (string vard in sarasas)
            {
                Console.Write(vard + ", ");
            }

        }
    }
}
