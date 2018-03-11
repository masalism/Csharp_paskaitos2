using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zaidimas kai speja kompiuteris koki skaiciu sugalvojau galvoje
            Console.WriteLine("Sugalvokite skaiciu tarp 1 ir 1000");
            var min = 1;
            var max = 1001;
            var spejimas = (min + max) / 2;
            string atsakyma = null;
            
            while (atsakyma != "Atspejai")
            {
                Console.WriteLine("Ar tai yra: " + spejimas);
                Console.WriteLine("Jei atspejau parasyk Atspejai, jei ne tai Daugiau ar Maziau");
                atsakyma = Console.ReadLine();

                if (atsakyma == "Daugiau")
                {
                    min = spejimas;
                    spejimas = (min + max) / 2;
                }
                else if (atsakyma == "Maziau")
                {
                    max = spejimas;
                    spejimas = (min + max) / 2;
                }
                
            }
            Console.WriteLine("Atspejau: " + spejimas);

       
        }
        
    }
}
