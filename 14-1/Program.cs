using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pazymius");
            string duomenis = Console.ReadLine();
            List<string> temp = duomenis.Split(' ').ToList();
            List<int> pazymiai = new List<int>();

            foreach (string item in temp)
            {
                pazymiai.Add(Convert.ToInt32(item));
            }

            Console.WriteLine("Didziausias " + pazymiai.Max());
            Console.WriteLine("Maziausias " + pazymiai.Min());
            Console.WriteLine("Vidurkis " + pazymiai.Average());
            Console.WriteLine("Pirmas " + pazymiai.First());
            Console.WriteLine("Paskutinis " + pazymiai.Last());

        }
    }
}
