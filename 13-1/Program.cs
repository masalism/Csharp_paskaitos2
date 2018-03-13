using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //random masyva sukuriam
            int[] masyvas = new int[10];
            Random rng = new Random();
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = rng.Next();
            }
            
            
            Console.WriteLine("Pirma reiksme: {0}", masyvas[0]); //pirma reiksme
            Console.WriteLine("Paskutine reiksme {0}", masyvas[masyvas.Length-1]); // paskutine reiksme
            Console.WriteLine("Random reiksme {0}", masyvas[rng.Next(0, masyvas.Length)]); //random reiksme
        }
    }
}
