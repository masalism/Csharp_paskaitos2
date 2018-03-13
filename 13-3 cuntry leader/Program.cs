using System;
using System.IO; // kad galetu skaityti failus
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_cuntry_leader
{
    class Program
    {
        static void Main(string[] args)
        {
            //cuntry leader
            StreamReader reader = new StreamReader("input.txt"); //skaito failus
           // Console.WriteLine("Suveskite visus kandidatus atskiriant per tarpeli");
            string duomenys = reader.ReadLine().ToLower();//visas raides i mazasias
            reader.Close(); // uzdaryti
            string[] vardai = duomenys.Split(' ').ToArray(); //viska sumeta i masyva per tarpeli
            int indeksas = -1;
            int max_kiekis = 0;

            for (int i = 0; i < vardai.Length; i++)
            {
                char[] raides = vardai[i].ToCharArray(); //isskaido visas raides i char masyva
                if(max_kiekis <= Unikalios_raides(raides))
                {
                    max_kiekis = Unikalios_raides(raides);
                    indeksas = i;
                }
            }

            Console.WriteLine("Laimejo " + vardai[indeksas]);
        }

        static int Unikalios_raides(char[] raides)
        {
            int kiekis = 0;

            //pasiimam pirma raide
            for (int i = 0; i < raides.Length; i++)
            {
                int flag = 0;

                //pasiziurim ar nesutampa
                for (int j = i + 1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    kiekis++;
                }
            }
            return kiekis;

        }
    }
}
