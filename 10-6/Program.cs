﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurkite string tipo kintamąjį. Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius. Tačiau jei vartotojas įrašytų “exit” - baigti ciklą. Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio vis buvo pridedami skirtingi žodžiai.

            var a = "";
            var zodis = "";
            while (a != "exit")
            {
                Console.WriteLine("Iveskite zodi arba exit");
                a = Console.ReadLine();

                if (a != "exit")
                {
                    zodis += a + " ";
                }
            }
            Console.WriteLine(zodis);
        }
    }
}
