using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_1
{
    class Automobilis
    {
        public string Marke { get; set; } 
        public string Modelis;
        private int GamybosMetai;
        public double Rida;

        public Automobilis(string marke, string modelis, int gamybosMetai, double rida)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;
        }

        public Automobilis(string marke)
        {
            Marke = marke;
            
        }

        public double Nuvaziavo_Per_Metus()
        {
            int praejometu = DateTime.Today.Year - GamybosMetai;
            double permetus = Rida / praejometu;
            return permetus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Audi", "A4", 2013, 50000);
            Automobilis auto1 = new Automobilis("BMW", "M5", 2016, 21300);
            Automobilis auto2 = new Automobilis("Mercedes", "AMG GT", 2015, 13000);
            Console.WriteLine("Nuvaziavo per metus {0} {1} km", auto.Marke, auto.Nuvaziavo_Per_Metus());
            Console.WriteLine("Nuvaziavo per metus {0} {1} km", auto1.Marke, auto1.Nuvaziavo_Per_Metus());
            Console.WriteLine("Nuvaziavo per metus {0} {1} km", auto2.Marke, auto2.Nuvaziavo_Per_Metus());
            //auto.Marke = "BMW";
            Automobilis auto3 = new Automobilis("Citroen");

        }
    }
}
