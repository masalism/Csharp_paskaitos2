﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0, taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0. Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais
            Console.WriteLine("Iveskite neigiama skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius <= 0)
            {
                Console.Write(skaicius + " ");
                skaicius++;
            }
        }
    }
}
